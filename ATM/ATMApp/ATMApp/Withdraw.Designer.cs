
namespace ATMApp
{
    partial class Withdraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Withdraw));
            this.withdrawBox = new System.Windows.Forms.Button();
            this.amountBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // withdrawBox
            // 
            this.withdrawBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.withdrawBox.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.withdrawBox.Location = new System.Drawing.Point(314, 416);
            this.withdrawBox.Name = "withdrawBox";
            this.withdrawBox.Size = new System.Drawing.Size(185, 48);
            this.withdrawBox.TabIndex = 20;
            this.withdrawBox.Text = "WITHDRAW";
            this.withdrawBox.UseVisualStyleBackColor = true;
            this.withdrawBox.Click += new System.EventHandler(this.WithdrawBox_Click);
            // 
            // amountBox
            // 
            this.amountBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.amountBox.Location = new System.Drawing.Point(416, 251);
            this.amountBox.Name = "amountBox";
            this.amountBox.Size = new System.Drawing.Size(185, 45);
            this.amountBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(216, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 38);
            this.label3.TabIndex = 18;
            this.label3.Text = "AMOUNT";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 21;
            // 
            // backBtn
            // 
            this.backBtn.Image = ((System.Drawing.Image)(resources.GetObject("backBtn.Image")));
            this.backBtn.Location = new System.Drawing.Point(12, 12);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(32, 32);
            this.backBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.backBtn.TabIndex = 9;
            this.backBtn.TabStop = false;
            this.backBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.AutoSize = true;
            this.closeBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.closeBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.closeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.closeBtn.Location = new System.Drawing.Point(750, 9);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(38, 40);
            this.closeBtn.TabIndex = 8;
            this.closeBtn.Text = "X";
            this.closeBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(314, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "WITHDRAW";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 524);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 12);
            this.panel2.TabIndex = 22;
            // 
            // Withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.withdrawBox);
            this.Controls.Add(this.amountBox);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Withdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Withdraw";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button withdrawBox;
        private System.Windows.Forms.TextBox amountBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox backBtn;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
    }
}