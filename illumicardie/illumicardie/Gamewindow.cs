using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace illumicardie
{
    public partial class Gamewindow : Form
    {
        // Tells it what players we will be using
        private WaveOutEvent backgroundPlayer;
        private WaveOutEvent soundEffectPlayer;
        private WaveOutEvent whispersPlayer;

        // Our deck
        private List<string> deck = new List<string>()
        {
            "ace_of_spades", "2_of_spades", "3_of_spades", "4_of_spades", "5_of_spades",
            "6_of_spades", "7_of_spades", "8_of_spades", "9_of_spades", "10_of_spades",
            "jack_of_spades", "queen_of_spades", "king_of_spades",
            "ace_of_hearts", "2_of_hearts", "3_of_hearts", "4_of_hearts", "5_of_hearts",
            "6_of_hearts", "7_of_hearts", "8_of_hearts", "9_of_hearts", "10_of_hearts",
            "jack_of_hearts", "queen_of_hearts", "king_of_hearts",
            "ace_of_diamonds", "2_of_diamonds", "3_of_diamonds", "4_of_diamonds", "5_of_diamonds",
            "6_of_diamonds", "7_of_diamonds", "8_of_diamonds", "9_of_diamonds", "10_of_diamonds",
            "jack_of_diamonds", "queen_of_diamonds", "king_of_diamonds",
            "ace_of_clubs", "2_of_clubs", "3_of_clubs", "4_of_clubs", "5_of_clubs",
            "6_of_clubs", "7_of_clubs", "8_of_clubs", "9_of_clubs", "10_of_clubs",
            "jack_of_clubs", "queen_of_clubs", "king_of_clubs"
        };

        // This is the total listed under the cards
        private int playerTotal = 0;
        private int dealerTotal = 0;

        public Gamewindow()
        {
            InitializeComponent();

            // Starts music
            backgroundPlayer = new WaveOutEvent();
            backgroundPlayer.Init(new AudioFileReader(AppDomain.CurrentDomain.BaseDirectory + @"Sound\Music.mp3"));
            backgroundPlayer.Volume = 0.1f;
            backgroundPlayer.Play();

            // Gets the sound effects ready
            soundEffectPlayer = new WaveOutEvent();
            whispersPlayer = new WaveOutEvent();

            // Sets Playerhand picture boxes invisible until dealt to
            Playerhand1.Visible = false;
            Playerhand2.Visible = false;
            Playerhand3.Visible = false;
            Playerhand4.Visible = false;
            Playerhand5.Visible = false;
            Playerhand6.Visible = false;

            // Sets the zoom so the cards show right this will need to be done on dealers to
            Playerhand1.SizeMode = PictureBoxSizeMode.Zoom;
            Playerhand2.SizeMode = PictureBoxSizeMode.Zoom;
            Playerhand3.SizeMode = PictureBoxSizeMode.Zoom;
            Playerhand4.SizeMode = PictureBoxSizeMode.Zoom;
            Playerhand5.SizeMode = PictureBoxSizeMode.Zoom;
            Playerhand6.SizeMode = PictureBoxSizeMode.Zoom;

            // makes it so they cant HIT until dealt to
            Hitbutton.Enabled = false;

            // linsk the method to the clicky
            Dealbutton.Click += Dealbutton_Click;

            // links the method to the clicky
            Hitbutton.Click += Hitbutton_Click;
        }

        // Method to load the cardsr
        private void LoadCardImage(PictureBox pictureBox, string card)
        {
            // Construct the file path for the card image
            string imagePath = @"Images\" + card + ".png";

            // Load the card image into the specified picture box
            pictureBox.Image = Image.FromFile(imagePath);

            // Make the picture box visible
            pictureBox.Visible = true;
        }

        // Method to deal the cards
        private string DealCard()
        {
            // Check if the deck is empty
            if (deck.Count == 0)
            {
                MessageBox.Show("The deck is empty!");
                return null;
            }

            // Generate a random index to select a card from the deck
            Random random = new Random();
            int index = random.Next(deck.Count);

            // Get the card at the selected index
            string card = deck[index];

            // Remove the dealt card from the deck
            deck.RemoveAt(index);

            return card;
        }

        // Method to update the player's total score
        private void UpdatePlayerTotal(string card)
        {
            // Extract the card value
            int value;
            if (int.TryParse(card.Split('_')[0], out value))
            {
                // Card is a number card (2, 3, ..., 10)
                playerTotal += value;
            }
            else
            {
                // Card is a face card or ace
                if (card.StartsWith("ace"))
                {
                    // Ace is worth 11
                    playerTotal += 11;
                }
                else
                {
                    // Face cards are worth 10
                    playerTotal += 10;
                }
            }

            // Update the Playertotal label
            Playertotal.Text = "Player Total: " + playerTotal.ToString();
        }

        //Dealbutton click event
        private void Dealbutton_Click(object sender, EventArgs e)
        {
            // Stop sounds
            soundEffectPlayer.Stop();
            whispersPlayer.Stop();

            // Play the sounds
            soundEffectPlayer.Init(new AudioFileReader(AppDomain.CurrentDomain.BaseDirectory + @"Sound\Gong.mp3"));
            soundEffectPlayer.Play();

            whispersPlayer.Init(new AudioFileReader(AppDomain.CurrentDomain.BaseDirectory + @"Sound\Whispers.mp3"));
            whispersPlayer.Play();

            // Deal a card to Playerhand1
            string card1 = DealCard();
            if (card1 != null)
            {
                LoadCardImage(Playerhand1, card1);
                UpdatePlayerTotal(card1);
            }

            // Deal a card to Playerhand2
            string card2 = DealCard();
            if (card2 != null)
            {
                LoadCardImage(Playerhand2, card2);
                UpdatePlayerTotal(card2);
            }

            // Disable the Deal button after the deal
            Dealbutton.Enabled = false;

            // Enable the Hit button after the deal
            Hitbutton.Enabled = true;
        }

        // Hitbutton click 
        private void Hitbutton_Click(object sender, EventArgs e)
        {
            // Find the first empty picture box from Playerhand3 to Playerhand6
            PictureBox emptyPictureBox = null;
            if (Playerhand3.Image == null)
            {
                emptyPictureBox = Playerhand3;
            }
            else if (Playerhand4.Image == null)
            {
                emptyPictureBox = Playerhand4;
            }
            else if (Playerhand5.Image == null)
            {
                emptyPictureBox = Playerhand5;
            }
            else if (Playerhand6.Image == null)
            {
                emptyPictureBox = Playerhand6;
            }

            // deal a card to it
            if (emptyPictureBox != null)
            {
                string card = DealCard();
                if (card != null)
                {
                    LoadCardImage(emptyPictureBox, card);

                    // picture box to the front
                    emptyPictureBox.BringToFront();

                    UpdatePlayerTotal(card);

                    //total exceeds 21 (BUST)
                    if (playerTotal > 21)
                    {
                        PlayCrowdLoseSound();
                        PlayGunshotSound();
                        PlayScreamSound();
                        whispersPlayer.Stop();
                        // BUST
                        MessageBox.Show("BUST! Your total exceeded 21.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Reset 
                        ResetGame();
                    }
                }
            }
        }

        // Method to reset the game
        private void ResetGame()
        {
            // Clear all picture boxes and set them back to invisible
            Playerhand1.Image = null;
            Playerhand1.Visible = false;
            Playerhand2.Image = null;
            Playerhand2.Visible = false;
            Playerhand3.Image = null;
            Playerhand3.Visible = false;
            Playerhand4.Image = null;
            Playerhand4.Visible = false;
            Playerhand5.Image = null;
            Playerhand5.Visible = false;
            Playerhand6.Image = null;
            Playerhand6.Visible = false;

            // Reset player total
            playerTotal = 0;

            // Update Playertotal label
            Playertotal.Text = "Player Total: " + playerTotal.ToString();

            // Enable the Deal button
            Dealbutton.Enabled = true;

            // Disable the Hit button
            Hitbutton.Enabled = false;
            

        }
        private void PlayCrowdLoseSound()
        {
            WaveOutEvent crowdLosePlayer = new WaveOutEvent();
            crowdLosePlayer.Init(new AudioFileReader(AppDomain.CurrentDomain.BaseDirectory + @"Sound\Crowdlose.mp3"));
            crowdLosePlayer.Play();
        }

        // Method to play Gunshot sound effect
        private void PlayGunshotSound()
        {
            WaveOutEvent gunshotPlayer = new WaveOutEvent();
            gunshotPlayer.Init(new AudioFileReader(AppDomain.CurrentDomain.BaseDirectory + @"Sound\Gunshot.mp3"));
            gunshotPlayer.Play();
        }
        private void PlayScreamSound()
        {
            WaveOutEvent screamPlayer = new WaveOutEvent();
            screamPlayer.Init(new AudioFileReader(AppDomain.CurrentDomain.BaseDirectory + @"Sound\Scream.mp3"));
            screamPlayer.Play();
        }

        private void Dealbutton_Click_1(object sender, EventArgs e)
        {

        }

        private void btnPlStay_Click(object sender, EventArgs e)
        {
            Hitbutton.Enabled = false;
            btnPlStay.Enabled = false;

            ProceedWithDealerTurn();
        }
        private void ProceedWithDealerTurn()
        {
            // Example logic for the dealer's turn
            while (dealerTotal < 17)
            {
                string card = DealCard();
                if (card == null) break; // Check if the deck is empty

                UpdateDealerTotal(card);
                // Optionally, simulate delay for drawing cards or show cards on UI (not covered here)
            }

            // Compare the totals and decide the outcome
            ComparePlayerAndDealerTotals();
        }

        private void UpdateDealerTotal(string card)
        {
            int value;
            if (int.TryParse(card.Split('_')[0], out value))
            {
                dealerTotal += value;
            }
            else
            {
                if (card.StartsWith("ace"))
                {
                    // Handle ace as 11 or 1 to avoid busting, if applicable
                    dealerTotal += (dealerTotal + 11 <= 21) ? 11 : 1;
                }
                else
                {
                    dealerTotal += 10;
                }
            }
        }

        private void ComparePlayerAndDealerTotals()
        {
            if (playerTotal > 21)
            {
                MessageBox.Show("Bust! You lose.");
            }
            else if (dealerTotal > 21 || playerTotal > dealerTotal)
            {
                MessageBox.Show("You win!");
            }
            else if (playerTotal == dealerTotal)
            {
                MessageBox.Show("It's a draw!");
            }
            else
            {
                MessageBox.Show("Dealer wins.");
            }

            // Reset the game for a new round
            ResetGame();
        }
    }
}
