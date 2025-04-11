namespace Midterm
{
    partial class frmLogin
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
            this.lbl_CustomerNumber = new System.Windows.Forms.Label();
            this.lbl_PIN = new System.Windows.Forms.Label();
            this.txb_CustomerNumber = new System.Windows.Forms.TextBox();
            this.txb_PIN = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_CustomerNumber
            // 
            this.lbl_CustomerNumber.AutoSize = true;
            this.lbl_CustomerNumber.Location = new System.Drawing.Point(109, 75);
            this.lbl_CustomerNumber.Name = "lbl_CustomerNumber";
            this.lbl_CustomerNumber.Size = new System.Drawing.Size(91, 13);
            this.lbl_CustomerNumber.TabIndex = 0;
            this.lbl_CustomerNumber.Text = "Customer Number";
            // 
            // lbl_PIN
            // 
            this.lbl_PIN.AutoSize = true;
            this.lbl_PIN.Location = new System.Drawing.Point(175, 145);
            this.lbl_PIN.Name = "lbl_PIN";
            this.lbl_PIN.Size = new System.Drawing.Size(25, 13);
            this.lbl_PIN.TabIndex = 1;
            this.lbl_PIN.Text = "PIN";
            // 
            // txb_CustomerNumber
            // 
            this.txb_CustomerNumber.Location = new System.Drawing.Point(206, 72);
            this.txb_CustomerNumber.Name = "txb_CustomerNumber";
            this.txb_CustomerNumber.Size = new System.Drawing.Size(100, 20);
            this.txb_CustomerNumber.TabIndex = 2;
            // 
            // txb_PIN
            // 
            this.txb_PIN.Location = new System.Drawing.Point(206, 137);
            this.txb_PIN.Name = "txb_PIN";
            this.txb_PIN.Size = new System.Drawing.Size(100, 20);
            this.txb_PIN.TabIndex = 3;
            this.txb_PIN.UseSystemPasswordChar = true;
            // 
            // btn_Login
            // 
            this.btn_Login.Location = new System.Drawing.Point(179, 190);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(75, 23);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "Login";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 282);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txb_PIN);
            this.Controls.Add(this.txb_CustomerNumber);
            this.Controls.Add(this.lbl_PIN);
            this.Controls.Add(this.lbl_CustomerNumber);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Sign-In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_CustomerNumber;
        private System.Windows.Forms.Label lbl_PIN;
        private System.Windows.Forms.TextBox txb_CustomerNumber;
        public System.Windows.Forms.TextBox txb_PIN;
        private System.Windows.Forms.Button btn_Login;
    }
}

