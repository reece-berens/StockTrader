namespace Client
{
    partial class LoginForm
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
            this.uxLBL_Username = new System.Windows.Forms.Label();
            this.uxTB_Username = new System.Windows.Forms.TextBox();
            this.uxLBL_Password = new System.Windows.Forms.Label();
            this.uxTB_Password = new System.Windows.Forms.TextBox();
            this.uxBtn_CreateAccount = new System.Windows.Forms.Button();
            this.uxBtn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxLBL_Username
            // 
            this.uxLBL_Username.AutoSize = true;
            this.uxLBL_Username.Location = new System.Drawing.Point(12, 50);
            this.uxLBL_Username.Name = "uxLBL_Username";
            this.uxLBL_Username.Size = new System.Drawing.Size(87, 20);
            this.uxLBL_Username.TabIndex = 0;
            this.uxLBL_Username.Text = "Username:";
            // 
            // uxTB_Username
            // 
            this.uxTB_Username.Location = new System.Drawing.Point(106, 49);
            this.uxTB_Username.Name = "uxTB_Username";
            this.uxTB_Username.Size = new System.Drawing.Size(148, 26);
            this.uxTB_Username.TabIndex = 1;
            // 
            // uxLBL_Password
            // 
            this.uxLBL_Password.AutoSize = true;
            this.uxLBL_Password.Location = new System.Drawing.Point(12, 99);
            this.uxLBL_Password.Name = "uxLBL_Password";
            this.uxLBL_Password.Size = new System.Drawing.Size(82, 20);
            this.uxLBL_Password.TabIndex = 2;
            this.uxLBL_Password.Text = "Password:";
            // 
            // uxTB_Password
            // 
            this.uxTB_Password.Location = new System.Drawing.Point(106, 99);
            this.uxTB_Password.Name = "uxTB_Password";
            this.uxTB_Password.Size = new System.Drawing.Size(148, 26);
            this.uxTB_Password.TabIndex = 3;
            this.uxTB_Password.UseSystemPasswordChar = true;
            // 
            // uxBtn_CreateAccount
            // 
            this.uxBtn_CreateAccount.Location = new System.Drawing.Point(16, 180);
            this.uxBtn_CreateAccount.Name = "uxBtn_CreateAccount";
            this.uxBtn_CreateAccount.Size = new System.Drawing.Size(131, 32);
            this.uxBtn_CreateAccount.TabIndex = 4;
            this.uxBtn_CreateAccount.Text = "Create Account";
            this.uxBtn_CreateAccount.UseVisualStyleBackColor = true;
            this.uxBtn_CreateAccount.Click += new System.EventHandler(this.BtnCreateAccount_Click);
            // 
            // uxBtn_Login
            // 
            this.uxBtn_Login.Location = new System.Drawing.Point(182, 180);
            this.uxBtn_Login.Name = "uxBtn_Login";
            this.uxBtn_Login.Size = new System.Drawing.Size(72, 32);
            this.uxBtn_Login.TabIndex = 5;
            this.uxBtn_Login.Text = "Login";
            this.uxBtn_Login.UseVisualStyleBackColor = true;
            this.uxBtn_Login.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 260);
            this.Controls.Add(this.uxBtn_Login);
            this.Controls.Add(this.uxBtn_CreateAccount);
            this.Controls.Add(this.uxTB_Password);
            this.Controls.Add(this.uxLBL_Password);
            this.Controls.Add(this.uxTB_Username);
            this.Controls.Add(this.uxLBL_Username);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoginForm_Closed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxLBL_Username;
        private System.Windows.Forms.TextBox uxTB_Username;
        private System.Windows.Forms.Label uxLBL_Password;
        private System.Windows.Forms.TextBox uxTB_Password;
        private System.Windows.Forms.Button uxBtn_CreateAccount;
        private System.Windows.Forms.Button uxBtn_Login;
    }
}