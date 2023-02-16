
namespace ATMApp
{
    partial class Home
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.closeBtn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.depositBtn = new System.Windows.Forms.Button();
            this.fastWithdrawBtn = new System.Windows.Forms.Button();
            this.changePinBtn = new System.Windows.Forms.Button();
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.balanceBtn = new System.Windows.Forms.Button();
            this.historyBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.closeBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
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
            this.label1.Location = new System.Drawing.Point(229, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "TRANSACTIONS";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 524);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 12);
            this.panel2.TabIndex = 1;
            // 
            // depositBtn
            // 
            this.depositBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.depositBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.depositBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.depositBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.depositBtn.ForeColor = System.Drawing.Color.Transparent;
            this.depositBtn.Location = new System.Drawing.Point(115, 180);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(186, 44);
            this.depositBtn.TabIndex = 2;
            this.depositBtn.Text = "DEPOSIT";
            this.depositBtn.UseVisualStyleBackColor = false;
            this.depositBtn.Click += new System.EventHandler(this.DepositBtn_Click);
            // 
            // fastWithdrawBtn
            // 
            this.fastWithdrawBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.fastWithdrawBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.fastWithdrawBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.fastWithdrawBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fastWithdrawBtn.ForeColor = System.Drawing.Color.Transparent;
            this.fastWithdrawBtn.Location = new System.Drawing.Point(115, 271);
            this.fastWithdrawBtn.Name = "fastWithdrawBtn";
            this.fastWithdrawBtn.Size = new System.Drawing.Size(186, 44);
            this.fastWithdrawBtn.TabIndex = 3;
            this.fastWithdrawBtn.Text = "FAST WITHDRAW";
            this.fastWithdrawBtn.UseVisualStyleBackColor = false;
            this.fastWithdrawBtn.Click += new System.EventHandler(this.FastWithdrawBtn_Click);
            // 
            // changePinBtn
            // 
            this.changePinBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.changePinBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.changePinBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changePinBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.changePinBtn.ForeColor = System.Drawing.Color.Transparent;
            this.changePinBtn.Location = new System.Drawing.Point(115, 376);
            this.changePinBtn.Name = "changePinBtn";
            this.changePinBtn.Size = new System.Drawing.Size(186, 44);
            this.changePinBtn.TabIndex = 4;
            this.changePinBtn.Text = "CHANGE PIN";
            this.changePinBtn.UseVisualStyleBackColor = false;
            this.changePinBtn.Click += new System.EventHandler(this.ChangePinBtn_Click);
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.withdrawBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.withdrawBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.withdrawBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.withdrawBtn.ForeColor = System.Drawing.Color.Transparent;
            this.withdrawBtn.Location = new System.Drawing.Point(498, 180);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(186, 44);
            this.withdrawBtn.TabIndex = 5;
            this.withdrawBtn.Text = "WITHDRAW";
            this.withdrawBtn.UseVisualStyleBackColor = false;
            this.withdrawBtn.Click += new System.EventHandler(this.WithdrawBtn_Click);
            // 
            // balanceBtn
            // 
            this.balanceBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.balanceBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.balanceBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.balanceBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.balanceBtn.ForeColor = System.Drawing.Color.Transparent;
            this.balanceBtn.Location = new System.Drawing.Point(498, 271);
            this.balanceBtn.Name = "balanceBtn";
            this.balanceBtn.Size = new System.Drawing.Size(186, 44);
            this.balanceBtn.TabIndex = 7;
            this.balanceBtn.Text = "BALANCE";
            this.balanceBtn.UseVisualStyleBackColor = false;
            this.balanceBtn.Click += new System.EventHandler(this.BalanceBtn_Click);
            // 
            // historyBtn
            // 
            this.historyBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.historyBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.historyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.historyBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.historyBtn.ForeColor = System.Drawing.Color.Transparent;
            this.historyBtn.Location = new System.Drawing.Point(498, 376);
            this.historyBtn.Name = "historyBtn";
            this.historyBtn.Size = new System.Drawing.Size(186, 44);
            this.historyBtn.TabIndex = 8;
            this.historyBtn.Text = "HISTORY";
            this.historyBtn.UseVisualStyleBackColor = false;
            this.historyBtn.Click += new System.EventHandler(this.HistoryBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 536);
            this.Controls.Add(this.historyBtn);
            this.Controls.Add(this.balanceBtn);
            this.Controls.Add(this.withdrawBtn);
            this.Controls.Add(this.changePinBtn);
            this.Controls.Add(this.fastWithdrawBtn);
            this.Controls.Add(this.depositBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button depositBtn;
        private System.Windows.Forms.Button fastWithdrawBtn;
        private System.Windows.Forms.Button changePinBtn;
        private System.Windows.Forms.Button withdrawBtn;
        private System.Windows.Forms.Button balanceBtn;
        private System.Windows.Forms.Label closeBtn;
        private System.Windows.Forms.Button historyBtn;
    }
}