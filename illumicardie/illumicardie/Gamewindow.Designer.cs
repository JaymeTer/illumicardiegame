namespace illumicardie
{
    partial class Gamewindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Gamewindow));
            this.Playerhand1 = new System.Windows.Forms.PictureBox();
            this.Playerhand2 = new System.Windows.Forms.PictureBox();
            this.Deck = new System.Windows.Forms.PictureBox();
            this.Playerhand3 = new System.Windows.Forms.PictureBox();
            this.Playerhand4 = new System.Windows.Forms.PictureBox();
            this.Playerhand5 = new System.Windows.Forms.PictureBox();
            this.Playerhand6 = new System.Windows.Forms.PictureBox();
            this.Dealbutton = new System.Windows.Forms.Button();
            this.Playertotal = new System.Windows.Forms.Label();
            this.Hitbutton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.Playerhand1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playerhand2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Deck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playerhand3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playerhand4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playerhand5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playerhand6)).BeginInit();
            this.SuspendLayout();
            // 
            // Playerhand1
            // 
            this.Playerhand1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Playerhand1.Location = new System.Drawing.Point(146, 533);
            this.Playerhand1.Name = "Playerhand1";
            this.Playerhand1.Size = new System.Drawing.Size(65, 86);
            this.Playerhand1.TabIndex = 0;
            this.Playerhand1.TabStop = false;
            // 
            // Playerhand2
            // 
            this.Playerhand2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Playerhand2.Location = new System.Drawing.Point(182, 533);
            this.Playerhand2.Name = "Playerhand2";
            this.Playerhand2.Size = new System.Drawing.Size(65, 86);
            this.Playerhand2.TabIndex = 1;
            this.Playerhand2.TabStop = false;
            // 
            // Deck
            // 
            this.Deck.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Deck.BackgroundImage")));
            this.Deck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Deck.Location = new System.Drawing.Point(76, 300);
            this.Deck.Name = "Deck";
            this.Deck.Size = new System.Drawing.Size(65, 86);
            this.Deck.TabIndex = 2;
            this.Deck.TabStop = false;
            // 
            // Playerhand3
            // 
            this.Playerhand3.Location = new System.Drawing.Point(217, 533);
            this.Playerhand3.Name = "Playerhand3";
            this.Playerhand3.Size = new System.Drawing.Size(65, 86);
            this.Playerhand3.TabIndex = 3;
            this.Playerhand3.TabStop = false;
            // 
            // Playerhand4
            // 
            this.Playerhand4.Location = new System.Drawing.Point(253, 533);
            this.Playerhand4.Name = "Playerhand4";
            this.Playerhand4.Size = new System.Drawing.Size(65, 86);
            this.Playerhand4.TabIndex = 4;
            this.Playerhand4.TabStop = false;
            // 
            // Playerhand5
            // 
            this.Playerhand5.Location = new System.Drawing.Point(288, 533);
            this.Playerhand5.Name = "Playerhand5";
            this.Playerhand5.Size = new System.Drawing.Size(65, 86);
            this.Playerhand5.TabIndex = 5;
            this.Playerhand5.TabStop = false;
            // 
            // Playerhand6
            // 
            this.Playerhand6.Location = new System.Drawing.Point(324, 533);
            this.Playerhand6.Name = "Playerhand6";
            this.Playerhand6.Size = new System.Drawing.Size(65, 86);
            this.Playerhand6.TabIndex = 6;
            this.Playerhand6.TabStop = false;
            // 
            // Dealbutton
            // 
            this.Dealbutton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Dealbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Dealbutton.BackgroundImage")));
            this.Dealbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Dealbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Dealbutton.Location = new System.Drawing.Point(432, 320);
            this.Dealbutton.Name = "Dealbutton";
            this.Dealbutton.Size = new System.Drawing.Size(84, 48);
            this.Dealbutton.TabIndex = 7;
            this.Dealbutton.Text = "Deal";
            this.Dealbutton.UseVisualStyleBackColor = true;
            // 
            // Playertotal
            // 
            this.Playertotal.AutoSize = true;
            this.Playertotal.Location = new System.Drawing.Point(214, 639);
            this.Playertotal.Name = "Playertotal";
            this.Playertotal.Size = new System.Drawing.Size(0, 13);
            this.Playertotal.TabIndex = 8;
            // 
            // Hitbutton
            // 
            this.Hitbutton.Location = new System.Drawing.Point(253, 488);
            this.Hitbutton.Name = "Hitbutton";
            this.Hitbutton.Size = new System.Drawing.Size(75, 23);
            this.Hitbutton.TabIndex = 9;
            this.Hitbutton.Text = "Hit";
            this.Hitbutton.UseVisualStyleBackColor = true;
            // 
            // Gamewindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(585, 842);
            this.Controls.Add(this.Hitbutton);
            this.Controls.Add(this.Playertotal);
            this.Controls.Add(this.Dealbutton);
            this.Controls.Add(this.Playerhand6);
            this.Controls.Add(this.Playerhand5);
            this.Controls.Add(this.Playerhand4);
            this.Controls.Add(this.Playerhand3);
            this.Controls.Add(this.Deck);
            this.Controls.Add(this.Playerhand2);
            this.Controls.Add(this.Playerhand1);
            this.Name = "Gamewindow";
            this.Text = "Illumicardie Table";
            ((System.ComponentModel.ISupportInitialize)(this.Playerhand1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playerhand2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Deck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playerhand3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playerhand4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playerhand5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playerhand6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Playerhand1;
        private System.Windows.Forms.PictureBox Playerhand2;
        private System.Windows.Forms.PictureBox Deck;
        private System.Windows.Forms.PictureBox Playerhand3;
        private System.Windows.Forms.PictureBox Playerhand4;
        private System.Windows.Forms.PictureBox Playerhand5;
        private System.Windows.Forms.PictureBox Playerhand6;
        private System.Windows.Forms.Button Dealbutton;
        private System.Windows.Forms.Label Playertotal;
        private System.Windows.Forms.Button Hitbutton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

