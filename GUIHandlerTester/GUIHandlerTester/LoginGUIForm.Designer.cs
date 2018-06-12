namespace GUIHandlerTester
{
    partial class LoginGUIForm
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
            this.uxLBL_Password = new System.Windows.Forms.Label();
            this.uxTB_Username = new System.Windows.Forms.TextBox();
            this.uxTB_Password = new System.Windows.Forms.TextBox();
            this.uxBtn_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxLBL_Username
            // 
            this.uxLBL_Username.AutoSize = true;
            this.uxLBL_Username.Location = new System.Drawing.Point(13, 48);
            this.uxLBL_Username.Name = "uxLBL_Username";
            this.uxLBL_Username.Size = new System.Drawing.Size(87, 20);
            this.uxLBL_Username.TabIndex = 0;
            this.uxLBL_Username.Text = "Username:";
            // 
            // uxLBL_Password
            // 
            this.uxLBL_Password.AutoSize = true;
            this.uxLBL_Password.Location = new System.Drawing.Point(17, 99);
            this.uxLBL_Password.Name = "uxLBL_Password";
            this.uxLBL_Password.Size = new System.Drawing.Size(82, 20);
            this.uxLBL_Password.TabIndex = 1;
            this.uxLBL_Password.Text = "Password:";
            // 
            // uxTB_Username
            // 
            this.uxTB_Username.Location = new System.Drawing.Point(106, 45);
            this.uxTB_Username.Name = "uxTB_Username";
            this.uxTB_Username.Size = new System.Drawing.Size(158, 26);
            this.uxTB_Username.TabIndex = 2;
            // 
            // uxTB_Password
            // 
            this.uxTB_Password.Location = new System.Drawing.Point(106, 96);
            this.uxTB_Password.Name = "uxTB_Password";
            this.uxTB_Password.Size = new System.Drawing.Size(158, 26);
            this.uxTB_Password.TabIndex = 3;
            this.uxTB_Password.UseSystemPasswordChar = true;
            // 
            // uxBtn_Login
            // 
            this.uxBtn_Login.Location = new System.Drawing.Point(106, 177);
            this.uxBtn_Login.Name = "uxBtn_Login";
            this.uxBtn_Login.Size = new System.Drawing.Size(97, 31);
            this.uxBtn_Login.TabIndex = 4;
            this.uxBtn_Login.Text = "Log In";
            this.uxBtn_Login.UseVisualStyleBackColor = true;
            this.uxBtn_Login.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // LoginGUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 248);
            this.Controls.Add(this.uxBtn_Login);
            this.Controls.Add(this.uxTB_Password);
            this.Controls.Add(this.uxTB_Username);
            this.Controls.Add(this.uxLBL_Password);
            this.Controls.Add(this.uxLBL_Username);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "LoginGUIForm";
            this.Text = "Login GUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CloseForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxLBL_Username;
        private System.Windows.Forms.Label uxLBL_Password;
        private System.Windows.Forms.TextBox uxTB_Username;
        private System.Windows.Forms.TextBox uxTB_Password;
        private System.Windows.Forms.Button uxBtn_Login;
    }
}