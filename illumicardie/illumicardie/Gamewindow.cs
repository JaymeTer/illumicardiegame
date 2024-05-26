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
                private WaveOutEvent backgroundPlayer;
        private WaveOutEvent soundEffectPlayer;
        private WaveOutEvent whispersPlayer;
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

        private int playerTotal = 0;
        private int dealerTotal = 0;

        public Gamewindow()
        {
            InitializeComponent();

            backgroundPlayer = new WaveOutEvent();
            backgroundPlayer.Init(new AudioFileReader(AppDomain.CurrentDomain.BaseDirectory + @"Sound\Music.mp3"));
            backgroundPlayer.Volume = 0.1f;
            backgroundPlayer.Play();

            soundEffectPlayer = new WaveOutEvent();
            whispersPlayer = new WaveOutEvent();

            Playerhand1.Visible = false;
            Playerhand2.Visible = false;
            Playerhand3.Visible = false;
            Playerhand4.Visible = false;
            Playerhand5.Visible = false;
            Playerhand6.Visible = false;

            Playerhand1.SizeMode = PictureBoxSizeMode.Zoom;
            Playerhand2.SizeMode = PictureBoxSizeMode.Zoom;
            Playerhand3.SizeMode = PictureBoxSizeMode.Zoom;
            Playerhand4.SizeMode = PictureBoxSizeMode.Zoom;
            Playerhand5.SizeMode = PictureBoxSizeMode.Zoom;
            Playerhand6.SizeMode = PictureBoxSizeMode.Zoom;

            Hitbutton.Enabled = false;
            Dealbutton.Click += Dealbutton_Click;
            Hitbutton.Click += Hitbutton_Click;

            btnPlStay.Enabled = false;
            Hitbutton.Enabled = true;
            btnPlStay.Enabled = true;
        }
        private void LoadCardImage(PictureBox pictureBox, string card)
        {
            if (card == null)
            {
                pictureBox.Visible = false; 
            }
            else
            {
                string imagePath = @"Images\" + card + ".png";
                try
                {
                    pictureBox.Image = Image.FromFile(imagePath);
                    pictureBox.Visible = true; 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Failed to load image at {imagePath}: {ex.Message}");
                    pictureBox.Visible = false; 
                }
            }
        }
        private string DealCard()
        {
            if (deck.Count == 0)
            {
                MessageBox.Show("The deck is empty!");
                return null;
            }

            Random random = new Random();
            int index = random.Next(deck.Count);
            string card = deck[index];
            deck.RemoveAt(index);

            return card;
        }

        private void UpdatePlayerTotal(string card)
        {
            int value;
            if (int.TryParse(card.Split('_')[0], out value))
            {
                playerTotal += value;
            }
            else
            {
                if (card.StartsWith("ace"))
                {
                    playerTotal += 11;
                }
                else
                {
                    playerTotal += 10;
                }
            }
            Playertotal.Text = "Player Total: " + playerTotal.ToString();
        }

        private void Dealbutton_Click(object sender, EventArgs e)
        {
            soundEffectPlayer.Stop();
            whispersPlayer.Stop();

            soundEffectPlayer.Init(new AudioFileReader(AppDomain.CurrentDomain.BaseDirectory + @"Sound\Gong.mp3"));
            soundEffectPlayer.Play();

            whispersPlayer.Init(new AudioFileReader(AppDomain.CurrentDomain.BaseDirectory + @"Sound\Whispers.mp3"));
            whispersPlayer.Play();

            string card1 = DealCard();
            if (card1 != null)
            {
                LoadCardImage(Playerhand1, card1);
                UpdatePlayerTotal(card1);
            }

            string card2 = DealCard();
            if (card2 != null)
            {
                LoadCardImage(Playerhand2, card2);
                UpdatePlayerTotal(card2);
            }

            Dealbutton.Enabled = false;
            Hitbutton.Enabled = true;
            btnPlStay.Enabled = true;
        }

        private void Hitbutton_Click(object sender, EventArgs e)
        {
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

            if (emptyPictureBox != null)
            {
                string card = DealCard();
                if (card != null)
                {
                    LoadCardImage(emptyPictureBox, card);
                    emptyPictureBox.BringToFront();
                    UpdatePlayerTotal(card);

                    if (playerTotal > 21)
                    {
                        PlayCrowdLoseSound();
                        PlayGunshotSound();
                        PlayScreamSound();
                        whispersPlayer.Stop();
                        MessageBox.Show("BUST! Your total exceeded 21.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
 
                        ResetGame();
                    }
                }
            }
        }

        private void ResetGame()
        {
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

            DealerHand1.Image = null;
            DealerHand1.Visible = false;
            DealerHand2.Image = null;
            DealerHand2.Visible = false;
            DealerHand3.Image = null;
            DealerHand3.Visible = false;
            DealerHand4.Image = null;
            DealerHand4.Visible = false;
            DealerHand5.Image = null;
            DealerHand5.Visible = false;

            playerTotal = 0;
            dealerTotal = 0;

            Playertotal.Text = "Player Total: 0";

            Dealbutton.Enabled = true;
            Hitbutton.Enabled = false;
            btnPlStay.Enabled = false;
        }
        private void PlayCrowdLoseSound()
        {
            WaveOutEvent crowdLosePlayer = new WaveOutEvent();
            crowdLosePlayer.Init(new AudioFileReader(AppDomain.CurrentDomain.BaseDirectory + @"Sound\Crowdlose.mp3"));
            crowdLosePlayer.Play();
        }

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
            while (dealerTotal < 17)
            {
                string dealerCard1 = DealCard();
                if (dealerCard1 != null)
                {
                    LoadCardImage(DealerHand1, dealerCard1);
                    UpdateDealerTotal(dealerCard1);
                    DealerHand1.Visible = true; 
                }

                string dealerCard2 = DealCard(); 
                if (dealerCard2 != null)
                {
                    LoadCardImage(DealerHand2, dealerCard2);
                    UpdateDealerTotal(dealerCard2);
                    DealerHand2.Visible = true; 
                }
                if (!DealerHand3.Visible)
                {
                    string card = DealCard();
                    if (card != null)
                    {
                        LoadCardImage(DealerHand3, card);
                        UpdateDealerTotal(card);
                        DealerHand3.Visible = true;
                    }
                }
                if (!DealerHand4.Visible)
                {
                    string card = DealCard();
                    if (card != null)
                    {
                        LoadCardImage(DealerHand4, card);
                        UpdateDealerTotal(card);
                        DealerHand3.Visible = true;
                    }
                }
                if (!DealerHand3.Visible)
                {
                    string card = DealCard();
                    if (card != null)
                    {
                        LoadCardImage(DealerHand3, card);
                        UpdateDealerTotal(card);
                        DealerHand3.Visible = true;
                    }
                }
            }
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
                    dealerTotal += (dealerTotal + 11 <= 21) ? 11 : 1;
                }
                else
                {
                    dealerTotal += 10;
                    DlrHandTotal.Text = $"Dealer Total: {dealerTotal}";
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
2            ResetGame();
        }

        private void DealerHand1_Click(object sender, EventArgs e)
        {

        }

        private void DealerHand2_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Playerhand2_Click(object sender, EventArgs e)
        {

        }

        private void DealerHand3_Click(object sender, EventArgs e)
        {

        }

        private void DealerHand4_Click(object sender, EventArgs e)
        {

        }

        private void DealerHand5_Click(object sender, EventArgs e)
        {

        }

        private void DlrHandTotal_Click(object sender, EventArgs e)
        {
        
        }
    }
}
