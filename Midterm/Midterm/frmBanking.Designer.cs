namespace Midterm
{
    partial class frmBanking
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
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_SavingsAccountLabel = new System.Windows.Forms.Label();
            this.lbl_CheckingsAccountLabel = new System.Windows.Forms.Label();
            this.lbl_SavingsBalanceDisplay = new System.Windows.Forms.Label();
            this.lbl_CheckingsBalanceDisplay = new System.Windows.Forms.Label();
            this.btn_TransferFromSavings = new System.Windows.Forms.Button();
            this.btn_TransferFromCheckings = new System.Windows.Forms.Button();
            this.btn_DepositIntoSavings = new System.Windows.Forms.Button();
            this.btn_DepositIntoCheckings = new System.Windows.Forms.Button();
            this.btn_WithdrawFromSavings = new System.Windows.Forms.Button();
            this.btn_WithdrawFromCheckings = new System.Windows.Forms.Button();
            this.lbl_CustomerDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Logout
            // 
            this.btn_Logout.Location = new System.Drawing.Point(402, 7);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(75, 23);
            this.btn_Logout.TabIndex = 0;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = true;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_SavingsAccountLabel
            // 
            this.lbl_SavingsAccountLabel.Location = new System.Drawing.Point(268, 72);
            this.lbl_SavingsAccountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SavingsAccountLabel.Name = "lbl_SavingsAccountLabel";
            this.lbl_SavingsAccountLabel.Size = new System.Drawing.Size(109, 13);
            this.lbl_SavingsAccountLabel.TabIndex = 1;
            this.lbl_SavingsAccountLabel.Text = "Savings Account (#x)";
            this.lbl_SavingsAccountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CheckingsAccountLabel
            // 
            this.lbl_CheckingsAccountLabel.Location = new System.Drawing.Point(95, 72);
            this.lbl_CheckingsAccountLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CheckingsAccountLabel.Name = "lbl_CheckingsAccountLabel";
            this.lbl_CheckingsAccountLabel.Size = new System.Drawing.Size(121, 13);
            this.lbl_CheckingsAccountLabel.TabIndex = 2;
            this.lbl_CheckingsAccountLabel.Text = "Checkings Account (#x)";
            this.lbl_CheckingsAccountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_SavingsBalanceDisplay
            // 
            this.lbl_SavingsBalanceDisplay.Location = new System.Drawing.Point(245, 96);
            this.lbl_SavingsBalanceDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_SavingsBalanceDisplay.Name = "lbl_SavingsBalanceDisplay";
            this.lbl_SavingsBalanceDisplay.Size = new System.Drawing.Size(162, 18);
            this.lbl_SavingsBalanceDisplay.TabIndex = 3;
            this.lbl_SavingsBalanceDisplay.Text = "Balance: $__________";
            this.lbl_SavingsBalanceDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_CheckingsBalanceDisplay
            // 
            this.lbl_CheckingsBalanceDisplay.Location = new System.Drawing.Point(69, 96);
            this.lbl_CheckingsBalanceDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CheckingsBalanceDisplay.Name = "lbl_CheckingsBalanceDisplay";
            this.lbl_CheckingsBalanceDisplay.Size = new System.Drawing.Size(173, 18);
            this.lbl_CheckingsBalanceDisplay.TabIndex = 4;
            this.lbl_CheckingsBalanceDisplay.Text = "Balance: $__________";
            this.lbl_CheckingsBalanceDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_TransferFromSavings
            // 
            this.btn_TransferFromSavings.Location = new System.Drawing.Point(262, 248);
            this.btn_TransferFromSavings.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TransferFromSavings.Name = "btn_TransferFromSavings";
            this.btn_TransferFromSavings.Size = new System.Drawing.Size(124, 40);
            this.btn_TransferFromSavings.TabIndex = 5;
            this.btn_TransferFromSavings.Text = "Transfer Savings";
            this.btn_TransferFromSavings.UseVisualStyleBackColor = true;
            this.btn_TransferFromSavings.Click += new System.EventHandler(this.btn_SavingsTransfer_Click);
            // 
            // btn_TransferFromCheckings
            // 
            this.btn_TransferFromCheckings.Location = new System.Drawing.Point(91, 248);
            this.btn_TransferFromCheckings.Margin = new System.Windows.Forms.Padding(2);
            this.btn_TransferFromCheckings.Name = "btn_TransferFromCheckings";
            this.btn_TransferFromCheckings.Size = new System.Drawing.Size(124, 40);
            this.btn_TransferFromCheckings.TabIndex = 6;
            this.btn_TransferFromCheckings.Text = "Transfer Checkings";
            this.btn_TransferFromCheckings.UseVisualStyleBackColor = true;
            this.btn_TransferFromCheckings.Click += new System.EventHandler(this.btn_CheckingsTransfer_Click);
            // 
            // btn_DepositIntoSavings
            // 
            this.btn_DepositIntoSavings.Location = new System.Drawing.Point(262, 128);
            this.btn_DepositIntoSavings.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DepositIntoSavings.Name = "btn_DepositIntoSavings";
            this.btn_DepositIntoSavings.Size = new System.Drawing.Size(124, 40);
            this.btn_DepositIntoSavings.TabIndex = 7;
            this.btn_DepositIntoSavings.Text = "Deposit Savings";
            this.btn_DepositIntoSavings.UseVisualStyleBackColor = true;
            this.btn_DepositIntoSavings.Click += new System.EventHandler(this.btn_SavingsDeposit_Click);
            // 
            // btn_DepositIntoCheckings
            // 
            this.btn_DepositIntoCheckings.Location = new System.Drawing.Point(91, 128);
            this.btn_DepositIntoCheckings.Margin = new System.Windows.Forms.Padding(2);
            this.btn_DepositIntoCheckings.Name = "btn_DepositIntoCheckings";
            this.btn_DepositIntoCheckings.Size = new System.Drawing.Size(124, 40);
            this.btn_DepositIntoCheckings.TabIndex = 8;
            this.btn_DepositIntoCheckings.Text = "Deposit Checkings";
            this.btn_DepositIntoCheckings.UseVisualStyleBackColor = true;
            this.btn_DepositIntoCheckings.Click += new System.EventHandler(this.btn_CheckingsDeposit_Click);
            // 
            // btn_WithdrawFromSavings
            // 
            this.btn_WithdrawFromSavings.Location = new System.Drawing.Point(262, 187);
            this.btn_WithdrawFromSavings.Margin = new System.Windows.Forms.Padding(2);
            this.btn_WithdrawFromSavings.Name = "btn_WithdrawFromSavings";
            this.btn_WithdrawFromSavings.Size = new System.Drawing.Size(124, 40);
            this.btn_WithdrawFromSavings.TabIndex = 9;
            this.btn_WithdrawFromSavings.Text = "Withdraw Savings";
            this.btn_WithdrawFromSavings.UseVisualStyleBackColor = true;
            this.btn_WithdrawFromSavings.Click += new System.EventHandler(this.btn_SavingsWithdraw_Click);
            // 
            // btn_WithdrawFromCheckings
            // 
            this.btn_WithdrawFromCheckings.Location = new System.Drawing.Point(91, 187);
            this.btn_WithdrawFromCheckings.Margin = new System.Windows.Forms.Padding(2);
            this.btn_WithdrawFromCheckings.Name = "btn_WithdrawFromCheckings";
            this.btn_WithdrawFromCheckings.Size = new System.Drawing.Size(124, 40);
            this.btn_WithdrawFromCheckings.TabIndex = 10;
            this.btn_WithdrawFromCheckings.Text = "Withdraw Checkings";
            this.btn_WithdrawFromCheckings.UseVisualStyleBackColor = true;
            this.btn_WithdrawFromCheckings.Click += new System.EventHandler(this.btn_CheckingsWithdraw_Click);
            // 
            // lbl_CustomerDisplay
            // 
            this.lbl_CustomerDisplay.Location = new System.Drawing.Point(9, 7);
            this.lbl_CustomerDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CustomerDisplay.Name = "lbl_CustomerDisplay";
            this.lbl_CustomerDisplay.Size = new System.Drawing.Size(99, 23);
            this.lbl_CustomerDisplay.TabIndex = 11;
            this.lbl_CustomerDisplay.Text = "Customer #: _____";
            this.lbl_CustomerDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmBanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 343);
            this.Controls.Add(this.lbl_CustomerDisplay);
            this.Controls.Add(this.btn_WithdrawFromCheckings);
            this.Controls.Add(this.btn_WithdrawFromSavings);
            this.Controls.Add(this.btn_DepositIntoCheckings);
            this.Controls.Add(this.btn_DepositIntoSavings);
            this.Controls.Add(this.btn_TransferFromCheckings);
            this.Controls.Add(this.btn_TransferFromSavings);
            this.Controls.Add(this.lbl_CheckingsBalanceDisplay);
            this.Controls.Add(this.lbl_SavingsBalanceDisplay);
            this.Controls.Add(this.lbl_CheckingsAccountLabel);
            this.Controls.Add(this.lbl_SavingsAccountLabel);
            this.Controls.Add(this.btn_Logout);
            this.Name = "frmBanking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form ATM";
            this.Shown += new System.EventHandler(this.frmBanking_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Label lbl_SavingsAccountLabel;
        private System.Windows.Forms.Label lbl_CheckingsAccountLabel;
        private System.Windows.Forms.Label lbl_SavingsBalanceDisplay;
        private System.Windows.Forms.Label lbl_CheckingsBalanceDisplay;
        private System.Windows.Forms.Button btn_TransferFromSavings;
        private System.Windows.Forms.Button btn_TransferFromCheckings;
        private System.Windows.Forms.Button btn_DepositIntoSavings;
        private System.Windows.Forms.Button btn_DepositIntoCheckings;
        private System.Windows.Forms.Button btn_WithdrawFromSavings;
        private System.Windows.Forms.Button btn_WithdrawFromCheckings;
        private System.Windows.Forms.Label lbl_CustomerDisplay;
    }
}