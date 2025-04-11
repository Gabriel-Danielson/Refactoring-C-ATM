namespace Midterm
{
    partial class frmActions
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
            this.lbl_ActionsCustomerDisplay = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.lbl_ActionsAccountDisplay = new System.Windows.Forms.Label();
            this.lbl_UserPrompt = new System.Windows.Forms.Label();
            this.lbl_ActionsBalanceDisplay = new System.Windows.Forms.Label();
            this.txb_AmountMoving = new System.Windows.Forms.TextBox();
            this.btn_Confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ActionsCustomerDisplay
            // 
            this.lbl_ActionsCustomerDisplay.Location = new System.Drawing.Point(11, 9);
            this.lbl_ActionsCustomerDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ActionsCustomerDisplay.Name = "lbl_ActionsCustomerDisplay";
            this.lbl_ActionsCustomerDisplay.Size = new System.Drawing.Size(97, 18);
            this.lbl_ActionsCustomerDisplay.TabIndex = 12;
            this.lbl_ActionsCustomerDisplay.Text = "Customer #: _____";
            this.lbl_ActionsCustomerDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(210, 234);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(95, 23);
            this.btn_Cancel.TabIndex = 13;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // lbl_ActionsAccountDisplay
            // 
            this.lbl_ActionsAccountDisplay.Location = new System.Drawing.Point(11, 27);
            this.lbl_ActionsAccountDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ActionsAccountDisplay.Name = "lbl_ActionsAccountDisplay";
            this.lbl_ActionsAccountDisplay.Size = new System.Drawing.Size(97, 23);
            this.lbl_ActionsAccountDisplay.TabIndex = 14;
            this.lbl_ActionsAccountDisplay.Text = "Account #: _____";
            this.lbl_ActionsAccountDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_UserPrompt
            // 
            this.lbl_UserPrompt.Location = new System.Drawing.Point(3, 131);
            this.lbl_UserPrompt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_UserPrompt.Name = "lbl_UserPrompt";
            this.lbl_UserPrompt.Size = new System.Drawing.Size(484, 19);
            this.lbl_UserPrompt.TabIndex = 15;
            this.lbl_UserPrompt.Text = "How much do you want to _____ _____ _____?";
            this.lbl_UserPrompt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ActionsBalanceDisplay
            // 
            this.lbl_ActionsBalanceDisplay.Location = new System.Drawing.Point(11, 50);
            this.lbl_ActionsBalanceDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_ActionsBalanceDisplay.Name = "lbl_ActionsBalanceDisplay";
            this.lbl_ActionsBalanceDisplay.Size = new System.Drawing.Size(168, 20);
            this.lbl_ActionsBalanceDisplay.TabIndex = 16;
            this.lbl_ActionsBalanceDisplay.Text = "Balance: $_____";
            this.lbl_ActionsBalanceDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txb_AmountMoving
            // 
            this.txb_AmountMoving.Location = new System.Drawing.Point(174, 163);
            this.txb_AmountMoving.Name = "txb_AmountMoving";
            this.txb_AmountMoving.Size = new System.Drawing.Size(164, 20);
            this.txb_AmountMoving.TabIndex = 17;
            this.txb_AmountMoving.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Confirm
            // 
            this.btn_Confirm.Location = new System.Drawing.Point(210, 205);
            this.btn_Confirm.Name = "btn_Confirm";
            this.btn_Confirm.Size = new System.Drawing.Size(95, 23);
            this.btn_Confirm.TabIndex = 18;
            this.btn_Confirm.Text = "Confirm";
            this.btn_Confirm.UseVisualStyleBackColor = true;
            this.btn_Confirm.Click += new System.EventHandler(this.btn_Confirm_Click);
            // 
            // frmActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 343);
            this.Controls.Add(this.btn_Confirm);
            this.Controls.Add(this.txb_AmountMoving);
            this.Controls.Add(this.lbl_ActionsBalanceDisplay);
            this.Controls.Add(this.lbl_UserPrompt);
            this.Controls.Add(this.lbl_ActionsAccountDisplay);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.lbl_ActionsCustomerDisplay);
            this.Name = "frmActions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Actions";
            this.Shown += new System.EventHandler(this.frmActions_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ActionsCustomerDisplay;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label lbl_ActionsAccountDisplay;
        private System.Windows.Forms.Label lbl_UserPrompt;
        private System.Windows.Forms.Label lbl_ActionsBalanceDisplay;
        private System.Windows.Forms.TextBox txb_AmountMoving;
        private System.Windows.Forms.Button btn_Confirm;
    }
}