namespace Client
{
    partial class MainForm
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
            this.uxBtn_Logout = new System.Windows.Forms.Button();
            this.uxLB_Stocks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // uxBtn_Logout
            // 
            this.uxBtn_Logout.Location = new System.Drawing.Point(12, 293);
            this.uxBtn_Logout.Name = "uxBtn_Logout";
            this.uxBtn_Logout.Size = new System.Drawing.Size(93, 32);
            this.uxBtn_Logout.TabIndex = 0;
            this.uxBtn_Logout.Text = "Logout";
            this.uxBtn_Logout.UseVisualStyleBackColor = true;
            this.uxBtn_Logout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // uxLB_Stocks
            // 
            this.uxLB_Stocks.FormattingEnabled = true;
            this.uxLB_Stocks.ItemHeight = 20;
            this.uxLB_Stocks.Location = new System.Drawing.Point(13, 13);
            this.uxLB_Stocks.Name = "uxLB_Stocks";
            this.uxLB_Stocks.Size = new System.Drawing.Size(178, 224);
            this.uxLB_Stocks.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 337);
            this.Controls.Add(this.uxLB_Stocks);
            this.Controls.Add(this.uxBtn_Logout);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_Closed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxBtn_Logout;
        private System.Windows.Forms.ListBox uxLB_Stocks;
    }
}