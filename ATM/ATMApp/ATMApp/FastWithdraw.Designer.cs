
namespace ATMApp
{
    partial class FastWithdraw
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FastWithdraw));
            this.panel1 = new System.Windows.Forms.Panel();
            this.backBtn = new System.Windows.Forms.PictureBox();
            this.closeBtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.withdraw2000 = new System.Windows.Forms.Button();
            this.withdraw1000 = new System.Windows.Forms.Button();
            this.withdraw50 = new System.Windows.Forms.Button();
            this.withdraw500 = new System.Windows.Forms.Button();
            this.withdraw200 = new System.Windows.Forms.Button();
            this.withdraw100 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 22;
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
            this.label1.Location = new System.Drawing.Point(247, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "FAST WITHDRAW";
            // 
            // withdraw2000
            // 
            this.withdraw2000.BackColor = System.Drawing.Color.DarkSlateGray;
            this.withdraw2000.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.withdraw2000.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.withdraw2000.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.withdraw2000.ForeColor = System.Drawing.Color.Transparent;
            this.withdraw2000.Location = new System.Drawing.Point(497, 389);
            this.withdraw2000.Name = "withdraw2000";
            this.withdraw2000.Size = new System.Drawing.Size(186, 44);
            this.withdraw2000.TabIndex = 28;
            this.withdraw2000.Text = "2000 Lei";
            this.withdraw2000.UseVisualStyleBackColor = false;
            this.withdraw2000.Click += new System.EventHandler(this.Withdraw2000_Click);
            // 
            // withdraw1000
            // 
            this.withdraw1000.BackColor = System.Drawing.Color.DarkSlateGray;
            this.withdraw1000.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.withdraw1000.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.withdraw1000.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.withdraw1000.ForeColor = System.Drawing.Color.Transparent;
            this.withdraw1000.Location = new System.Drawing.Point(497, 284);
            this.withdraw1000.Name = "withdraw1000";
            this.withdraw1000.Size = new System.Drawing.Size(186, 44);
            this.withdraw1000.TabIndex = 27;
            this.withdraw1000.Text = "1000 Lei";
            this.withdraw1000.UseVisualStyleBackColor = false;
            this.withdraw1000.Click += new System.EventHandler(this.Withdraw1000_Click);
            // 
            // withdraw50
            // 
            this.withdraw50.BackColor = System.Drawing.Color.DarkSlateGray;
            this.withdraw50.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.withdraw50.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.withdraw50.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.withdraw50.ForeColor = System.Drawing.Color.Transparent;
            this.withdraw50.Location = new System.Drawing.Point(497, 193);
            this.withdraw50.Name = "withdraw50";
            this.withdraw50.Size = new System.Drawing.Size(186, 44);
            this.withdraw50.TabIndex = 26;
            this.withdraw50.Text = "50 Lei";
            this.withdraw50.UseVisualStyleBackColor = false;
            this.withdraw50.Click += new System.EventHandler(this.Withdraw50_Click);
            // 
            // withdraw500
            // 
            this.withdraw500.BackColor = System.Drawing.Color.DarkSlateGray;
            this.withdraw500.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.withdraw500.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.withdraw500.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.withdraw500.ForeColor = System.Drawing.Color.Transparent;
            this.withdraw500.Location = new System.Drawing.Point(114, 389);
            this.withdraw500.Name = "withdraw500";
            this.withdraw500.Size = new System.Drawing.Size(186, 44);
            this.withdraw500.TabIndex = 25;
            this.withdraw500.Text = "500 Lei";
            this.withdraw500.UseVisualStyleBackColor = false;
            this.withdraw500.Click += new System.EventHandler(this.Withdraw500_Click);
            // 
            // withdraw200
            // 
            this.withdraw200.BackColor = System.Drawing.Color.DarkSlateGray;
            this.withdraw200.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.withdraw200.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.withdraw200.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.withdraw200.ForeColor = System.Drawing.Color.Transparent;
            this.withdraw200.Location = new System.Drawing.Point(114, 284);
            this.withdraw200.Name = "withdraw200";
            this.withdraw200.Size = new System.Drawing.Size(186, 44);
            this.withdraw200.TabIndex = 24;
            this.withdraw200.Text = "200 Lei";
            this.withdraw200.UseVisualStyleBackColor = false;
            this.withdraw200.Click += new System.EventHandler(this.Withdraw200_Click);
            // 
            // withdraw100
            // 
            this.withdraw100.BackColor = System.Drawing.Color.DarkSlateGray;
            this.withdraw100.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.withdraw100.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.withdraw100.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.withdraw100.ForeColor = System.Drawing.Color.Transparent;
            this.withdraw100.Location = new System.Drawing.Point(114, 193);
            this.withdraw100.Name = "withdraw100";
            this.withdraw100.Size = new System.Drawing.Size(186, 44);
            this.withdraw100.TabIndex = 23;
            this.withdraw100.Text = "100 Lei";
            this.withdraw100.UseVisualStyleBackColor = false;
            this.withdraw100.Click += new System.EventHandler(this.Withdraw100_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 524);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 12);
            this.panel2.TabIndex = 29;
            // 
            // FastWithdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.withdraw2000);
            this.Controls.Add(this.withdraw1000);
            this.Controls.Add(this.withdraw50);
            this.Controls.Add(this.withdraw500);
            this.Controls.Add(this.withdraw200);
            this.Controls.Add(this.withdraw100);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FastWithdraw";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FastWithdraw";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox backBtn;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button withdraw2000;
        private System.Windows.Forms.Button withdraw1000;
        private System.Windows.Forms.Button withdraw50;
        private System.Windows.Forms.Button withdraw500;
        private System.Windows.Forms.Button withdraw200;
        private System.Windows.Forms.Button withdraw100;
        private System.Windows.Forms.Panel panel2;
    }
}