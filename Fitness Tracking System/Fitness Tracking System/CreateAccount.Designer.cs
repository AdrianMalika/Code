
namespace Fitness_Tracking_System
{
    partial class CreateAccount
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
            this.lblGoLogin = new System.Windows.Forms.LinkLabel();
            this.lblAlreadyAcc = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblCreateAcc = new System.Windows.Forms.Label();
            this.cmdCreateAccount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGoLogin
            // 
            this.lblGoLogin.AutoSize = true;
            this.lblGoLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoLogin.Location = new System.Drawing.Point(153, 408);
            this.lblGoLogin.Name = "lblGoLogin";
            this.lblGoLogin.Size = new System.Drawing.Size(50, 20);
            this.lblGoLogin.TabIndex = 18;
            this.lblGoLogin.TabStop = true;
            this.lblGoLogin.Text = "Login";
            this.lblGoLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGoLogin_LinkClicked);
            // 
            // lblAlreadyAcc
            // 
            this.lblAlreadyAcc.AutoSize = true;
            this.lblAlreadyAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlreadyAcc.Location = new System.Drawing.Point(73, 378);
            this.lblAlreadyAcc.Name = "lblAlreadyAcc";
            this.lblAlreadyAcc.Size = new System.Drawing.Size(203, 20);
            this.lblAlreadyAcc.TabIndex = 17;
            this.lblAlreadyAcc.Text = "Already have an Account?";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.Location = new System.Drawing.Point(35, 101);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(94, 20);
            this.lblUserName.TabIndex = 16;
            this.lblUserName.Text = "User Name";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(35, 192);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(83, 20);
            this.lblPassword.TabIndex = 15;
            this.lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Linen;
            this.txtPassword.Location = new System.Drawing.Point(39, 215);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(257, 30);
            this.txtPassword.TabIndex = 14;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.Linen;
            this.txtUserName.Location = new System.Drawing.Point(39, 124);
            this.txtUserName.Multiline = true;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(257, 30);
            this.txtUserName.TabIndex = 12;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // lblCreateAcc
            // 
            this.lblCreateAcc.AutoSize = true;
            this.lblCreateAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateAcc.Location = new System.Drawing.Point(46, 29);
            this.lblCreateAcc.Name = "lblCreateAcc";
            this.lblCreateAcc.Size = new System.Drawing.Size(234, 36);
            this.lblCreateAcc.TabIndex = 11;
            this.lblCreateAcc.Text = "Create Account";
            // 
            // cmdCreateAccount
            // 
            this.cmdCreateAccount.BackColor = System.Drawing.Color.Linen;
            this.cmdCreateAccount.Location = new System.Drawing.Point(39, 297);
            this.cmdCreateAccount.Name = "cmdCreateAccount";
            this.cmdCreateAccount.Size = new System.Drawing.Size(257, 41);
            this.cmdCreateAccount.TabIndex = 19;
            this.cmdCreateAccount.Text = "Create Account";
            this.cmdCreateAccount.UseVisualStyleBackColor = false;
            this.cmdCreateAccount.Click += new System.EventHandler(this.cmdCreateAccount_Click);
            // 
            // CreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(352, 450);
            this.Controls.Add(this.cmdCreateAccount);
            this.Controls.Add(this.lblGoLogin);
            this.Controls.Add(this.lblAlreadyAcc);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.lblCreateAcc);
            this.Name = "CreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CreateAccount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblGoLogin;
        private System.Windows.Forms.Label lblAlreadyAcc;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblCreateAcc;
        private System.Windows.Forms.Button cmdCreateAccount;
    }
}