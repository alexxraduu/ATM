
namespace ATMApp
{
    partial class Welcome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.label1 = new System.Windows.Forms.Label();
            this.welcomeImg = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.welcomeImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(285, 52);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(244, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "ATM SYSTEM";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // welcomeImg
            // 
            this.welcomeImg.Image = ((System.Drawing.Image)(resources.GetObject("welcomeImg.Image")));
            this.welcomeImg.Location = new System.Drawing.Point(313, 192);
            this.welcomeImg.Name = "welcomeImg";
            this.welcomeImg.Size = new System.Drawing.Size(195, 193);
            this.welcomeImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.welcomeImg.TabIndex = 1;
            this.welcomeImg.TabStop = false;
            this.welcomeImg.Click += new System.EventHandler(this.WelcomeImg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(313, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 14);
            this.label2.TabIndex = 2;
            this.label2.Text = "Click on the image to get started.";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.welcomeImg);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.welcomeImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox welcomeImg;
        private System.Windows.Forms.Label label2;
    }
}

