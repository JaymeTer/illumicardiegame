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
            this.Playerhand3 = new System.Windows.Forms.PictureBox();
            this.Playerhand4 = new System.Windows.Forms.PictureBox();
            this.Playerhand5 = new System.Windows.Forms.PictureBox();
            this.Playerhand6 = new System.Windows.Forms.PictureBox();
            this.Dealbutton = new System.Windows.Forms.Button();
            this.Playertotal = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.Hitbutton = new System.Windows.Forms.Button();
            this.btnPlStay = new System.Windows.Forms.Button();
            this.DealerHand1 = new System.Windows.Forms.PictureBox();
            this.DealerHand2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Playerhand1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playerhand2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playerhand3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playerhand4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playerhand5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playerhand6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerHand1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerHand2)).BeginInit();
            this.SuspendLayout();
            // 
            // Playerhand1
            // 
            this.Playerhand1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Playerhand1.Location = new System.Drawing.Point(143, 507);
            this.Playerhand1.Name = "Playerhand1";
            this.Playerhand1.Size = new System.Drawing.Size(104, 129);
            this.Playerhand1.TabIndex = 0;
            this.Playerhand1.TabStop = false;
            // 
            // Playerhand2
            // 
            this.Playerhand2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Playerhand2.Location = new System.Drawing.Point(178, 507);
            this.Playerhand2.Name = "Playerhand2";
            this.Playerhand2.Size = new System.Drawing.Size(104, 129);
            this.Playerhand2.TabIndex = 1;
            this.Playerhand2.TabStop = false;
            this.Playerhand2.Click += new System.EventHandler(this.Playerhand2_Click);
            // 
            // Playerhand3
            // 
            this.Playerhand3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Playerhand3.Location = new System.Drawing.Point(214, 507);
            this.Playerhand3.Name = "Playerhand3";
            this.Playerhand3.Size = new System.Drawing.Size(104, 129);
            this.Playerhand3.TabIndex = 3;
            this.Playerhand3.TabStop = false;
            // 
            // Playerhand4
            // 
            this.Playerhand4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Playerhand4.Location = new System.Drawing.Point(247, 507);
            this.Playerhand4.Name = "Playerhand4";
            this.Playerhand4.Size = new System.Drawing.Size(104, 129);
            this.Playerhand4.TabIndex = 4;
            this.Playerhand4.TabStop = false;
            // 
            // Playerhand5
            // 
            this.Playerhand5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Playerhand5.Location = new System.Drawing.Point(288, 507);
            this.Playerhand5.Name = "Playerhand5";
            this.Playerhand5.Size = new System.Drawing.Size(104, 129);
            this.Playerhand5.TabIndex = 5;
            this.Playerhand5.TabStop = false;
            // 
            // Playerhand6
            // 
            this.Playerhand6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Playerhand6.Location = new System.Drawing.Point(324, 507);
            this.Playerhand6.Name = "Playerhand6";
            this.Playerhand6.Size = new System.Drawing.Size(104, 129);
            this.Playerhand6.TabIndex = 6;
            this.Playerhand6.TabStop = false;
            // 
            // Dealbutton
            // 
            this.Dealbutton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Dealbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Dealbutton.BackgroundImage")));
            this.Dealbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Dealbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Dealbutton.Location = new System.Drawing.Point(79, 722);
            this.Dealbutton.Name = "Dealbutton";
            this.Dealbutton.Size = new System.Drawing.Size(132, 49);
            this.Dealbutton.TabIndex = 7;
            this.Dealbutton.Text = "Deal";
            this.Dealbutton.UseVisualStyleBackColor = true;
            this.Dealbutton.Click += new System.EventHandler(this.Dealbutton_Click_1);
            // 
            // Playertotal
            // 
            this.Playertotal.AutoSize = true;
            this.Playertotal.Location = new System.Drawing.Point(214, 639);
            this.Playertotal.Name = "Playertotal";
            this.Playertotal.Size = new System.Drawing.Size(0, 13);
            this.Playertotal.TabIndex = 8;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // Hitbutton
            // 
            this.Hitbutton.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Hitbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Hitbutton.BackgroundImage")));
            this.Hitbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Hitbutton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Hitbutton.Location = new System.Drawing.Point(231, 722);
            this.Hitbutton.Name = "Hitbutton";
            this.Hitbutton.Size = new System.Drawing.Size(132, 49);
            this.Hitbutton.TabIndex = 9;
            this.Hitbutton.Text = "Hit";
            this.Hitbutton.UseVisualStyleBackColor = true;
            // 
            // btnPlStay
            // 
            this.btnPlStay.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnPlStay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlStay.BackgroundImage")));
            this.btnPlStay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlStay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPlStay.Location = new System.Drawing.Point(383, 722);
            this.btnPlStay.Name = "btnPlStay";
            this.btnPlStay.Size = new System.Drawing.Size(132, 49);
            this.btnPlStay.TabIndex = 10;
            this.btnPlStay.Text = "Stay";
            this.btnPlStay.UseVisualStyleBackColor = true;
            this.btnPlStay.Click += new System.EventHandler(this.btnPlStay_Click);
            // 
            // DealerHand1
            // 
            this.DealerHand1.Location = new System.Drawing.Point(231, 128);
            this.DealerHand1.Name = "DealerHand1";
            this.DealerHand1.Size = new System.Drawing.Size(107, 139);
            this.DealerHand1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerHand1.TabIndex = 11;
            this.DealerHand1.TabStop = false;
            this.DealerHand1.Click += new System.EventHandler(this.DealerHand1_Click);
            // 
            // DealerHand2
            // 
            this.DealerHand2.Location = new System.Drawing.Point(272, 128);
            this.DealerHand2.Name = "DealerHand2";
            this.DealerHand2.Size = new System.Drawing.Size(104, 139);
            this.DealerHand2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerHand2.TabIndex = 12;
            this.DealerHand2.TabStop = false;
            this.DealerHand2.Click += new System.EventHandler(this.DealerHand2_Click);
            // 
            // Gamewindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(585, 842);
            this.Controls.Add(this.DealerHand2);
            this.Controls.Add(this.DealerHand1);
            this.Controls.Add(this.btnPlStay);
            this.Controls.Add(this.Hitbutton);
            this.Controls.Add(this.Playertotal);
            this.Controls.Add(this.Dealbutton);
            this.Controls.Add(this.Playerhand6);
            this.Controls.Add(this.Playerhand5);
            this.Controls.Add(this.Playerhand4);
            this.Controls.Add(this.Playerhand3);
            this.Controls.Add(this.Playerhand2);
            this.Controls.Add(this.Playerhand1);
            this.DoubleBuffered = true;
            this.Name = "Gamewindow";
            this.Text = "Illumicardie Table";
            ((System.ComponentModel.ISupportInitialize)(this.Playerhand1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playerhand2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playerhand3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playerhand4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playerhand5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playerhand6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerHand1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerHand2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Playerhand1;
        private System.Windows.Forms.PictureBox Playerhand2;
        private System.Windows.Forms.PictureBox Playerhand3;
        private System.Windows.Forms.PictureBox Playerhand4;
        private System.Windows.Forms.PictureBox Playerhand5;
        private System.Windows.Forms.PictureBox Playerhand6;
        private System.Windows.Forms.Button Dealbutton;
        private System.Windows.Forms.Label Playertotal;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button Hitbutton;
        private System.Windows.Forms.Button btnPlStay;
        private System.Windows.Forms.PictureBox DealerHand1;
        private System.Windows.Forms.PictureBox DealerHand2;
    }
}

