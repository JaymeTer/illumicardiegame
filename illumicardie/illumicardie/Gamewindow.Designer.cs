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
            this.DealerHand3 = new System.Windows.Forms.PictureBox();
            this.DealerHand4 = new System.Windows.Forms.PictureBox();
            this.DealerHand5 = new System.Windows.Forms.PictureBox();
            this.DlrHandTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Playerhand1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playerhand2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playerhand3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playerhand4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playerhand5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Playerhand6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerHand1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerHand2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerHand3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerHand4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerHand5)).BeginInit();
            this.SuspendLayout();
            // 
            // Playerhand1
            // 
            this.Playerhand1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Playerhand1.Location = new System.Drawing.Point(160, 487);
            this.Playerhand1.Name = "Playerhand1";
            this.Playerhand1.Size = new System.Drawing.Size(104, 129);
            this.Playerhand1.TabIndex = 0;
            this.Playerhand1.TabStop = false;
            // 
            // Playerhand2
            // 
            this.Playerhand2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Playerhand2.Location = new System.Drawing.Point(195, 487);
            this.Playerhand2.Name = "Playerhand2";
            this.Playerhand2.Size = new System.Drawing.Size(104, 129);
            this.Playerhand2.TabIndex = 1;
            this.Playerhand2.TabStop = false;
            this.Playerhand2.Click += new System.EventHandler(this.Playerhand2_Click);
            // 
            // Playerhand3
            // 
            this.Playerhand3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Playerhand3.Location = new System.Drawing.Point(231, 487);
            this.Playerhand3.Name = "Playerhand3";
            this.Playerhand3.Size = new System.Drawing.Size(104, 129);
            this.Playerhand3.TabIndex = 3;
            this.Playerhand3.TabStop = false;
            // 
            // Playerhand4
            // 
            this.Playerhand4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Playerhand4.Location = new System.Drawing.Point(264, 487);
            this.Playerhand4.Name = "Playerhand4";
            this.Playerhand4.Size = new System.Drawing.Size(104, 129);
            this.Playerhand4.TabIndex = 4;
            this.Playerhand4.TabStop = false;
            // 
            // Playerhand5
            // 
            this.Playerhand5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Playerhand5.Location = new System.Drawing.Point(305, 487);
            this.Playerhand5.Name = "Playerhand5";
            this.Playerhand5.Size = new System.Drawing.Size(104, 129);
            this.Playerhand5.TabIndex = 5;
            this.Playerhand5.TabStop = false;
            // 
            // Playerhand6
            // 
            this.Playerhand6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Playerhand6.Location = new System.Drawing.Point(341, 487);
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
            this.Playertotal.Location = new System.Drawing.Point(231, 619);
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
            this.DealerHand1.Location = new System.Drawing.Point(217, 128);
            this.DealerHand1.Name = "DealerHand1";
            this.DealerHand1.Size = new System.Drawing.Size(107, 139);
            this.DealerHand1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerHand1.TabIndex = 11;
            this.DealerHand1.TabStop = false;
            this.DealerHand1.Visible = false;
            this.DealerHand1.Click += new System.EventHandler(this.DealerHand1_Click);
            // 
            // DealerHand2
            // 
            this.DealerHand2.Location = new System.Drawing.Point(247, 128);
            this.DealerHand2.Name = "DealerHand2";
            this.DealerHand2.Size = new System.Drawing.Size(104, 139);
            this.DealerHand2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerHand2.TabIndex = 12;
            this.DealerHand2.TabStop = false;
            this.DealerHand2.Visible = false;
            this.DealerHand2.Click += new System.EventHandler(this.DealerHand2_Click);
            // 
            // DealerHand3
            // 
            this.DealerHand3.Location = new System.Drawing.Point(284, 128);
            this.DealerHand3.Name = "DealerHand3";
            this.DealerHand3.Size = new System.Drawing.Size(107, 139);
            this.DealerHand3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerHand3.TabIndex = 13;
            this.DealerHand3.TabStop = false;
            this.DealerHand3.Visible = false;
            this.DealerHand3.Click += new System.EventHandler(this.DealerHand3_Click);
            // 
            // DealerHand4
            // 
            this.DealerHand4.Location = new System.Drawing.Point(321, 128);
            this.DealerHand4.Name = "DealerHand4";
            this.DealerHand4.Size = new System.Drawing.Size(107, 139);
            this.DealerHand4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerHand4.TabIndex = 14;
            this.DealerHand4.TabStop = false;
            this.DealerHand4.Visible = false;
            this.DealerHand4.Click += new System.EventHandler(this.DealerHand4_Click);
            // 
            // DealerHand5
            // 
            this.DealerHand5.Location = new System.Drawing.Point(357, 128);
            this.DealerHand5.Name = "DealerHand5";
            this.DealerHand5.Size = new System.Drawing.Size(107, 139);
            this.DealerHand5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DealerHand5.TabIndex = 15;
            this.DealerHand5.TabStop = false;
            this.DealerHand5.Visible = false;
            this.DealerHand5.Click += new System.EventHandler(this.DealerHand5_Click);
            // 
            // DlrHandTotal
            // 
            this.DlrHandTotal.AutoSize = true;
            this.DlrHandTotal.Location = new System.Drawing.Point(215, 287);
            this.DlrHandTotal.Name = "DlrHandTotal";
            this.DlrHandTotal.Size = new System.Drawing.Size(68, 13);
            this.DlrHandTotal.TabIndex = 16;
            this.DlrHandTotal.Text = "Dealer Total:\r\n";
            this.DlrHandTotal.Click += new System.EventHandler(this.DlrHandTotal_Click);
            // 
            // Gamewindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(585, 842);
            this.Controls.Add(this.DlrHandTotal);
            this.Controls.Add(this.DealerHand5);
            this.Controls.Add(this.DealerHand4);
            this.Controls.Add(this.DealerHand3);
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
            ((System.ComponentModel.ISupportInitialize)(this.DealerHand3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerHand4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DealerHand5)).EndInit();
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
        private System.Windows.Forms.PictureBox DealerHand3;
        private System.Windows.Forms.PictureBox DealerHand4;
        private System.Windows.Forms.PictureBox DealerHand5;
        private System.Windows.Forms.Label DlrHandTotal;
    }
}

