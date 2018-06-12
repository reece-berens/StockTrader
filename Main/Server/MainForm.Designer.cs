namespace Server
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
            this.uxLBL_OnlineUsers = new System.Windows.Forms.Label();
            this.uxLB_StockList = new System.Windows.Forms.ListBox();
            this.uxLBL_StockList = new System.Windows.Forms.Label();
            this.uxLB_UserList = new System.Windows.Forms.ListBox();
            this.uxLBL_UserList = new System.Windows.Forms.Label();
            this.uxLBL_ServerIP = new System.Windows.Forms.Label();
            this.uxLB_Transactions = new System.Windows.Forms.ListBox();
            this.uxLBL_TransactionList = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxLBL_OnlineUsers
            // 
            this.uxLBL_OnlineUsers.AutoSize = true;
            this.uxLBL_OnlineUsers.Location = new System.Drawing.Point(13, 13);
            this.uxLBL_OnlineUsers.Name = "uxLBL_OnlineUsers";
            this.uxLBL_OnlineUsers.Size = new System.Drawing.Size(108, 20);
            this.uxLBL_OnlineUsers.TabIndex = 0;
            this.uxLBL_OnlineUsers.Text = "Users Online: ";
            // 
            // uxLB_StockList
            // 
            this.uxLB_StockList.FormattingEnabled = true;
            this.uxLB_StockList.ItemHeight = 20;
            this.uxLB_StockList.Location = new System.Drawing.Point(13, 89);
            this.uxLB_StockList.Name = "uxLB_StockList";
            this.uxLB_StockList.Size = new System.Drawing.Size(229, 384);
            this.uxLB_StockList.TabIndex = 1;
            // 
            // uxLBL_StockList
            // 
            this.uxLBL_StockList.AutoSize = true;
            this.uxLBL_StockList.Location = new System.Drawing.Point(9, 66);
            this.uxLBL_StockList.Name = "uxLBL_StockList";
            this.uxLBL_StockList.Size = new System.Drawing.Size(83, 20);
            this.uxLBL_StockList.TabIndex = 2;
            this.uxLBL_StockList.Text = "Stock List:";
            // 
            // uxLB_UserList
            // 
            this.uxLB_UserList.FormattingEnabled = true;
            this.uxLB_UserList.ItemHeight = 20;
            this.uxLB_UserList.Location = new System.Drawing.Point(283, 89);
            this.uxLB_UserList.Name = "uxLB_UserList";
            this.uxLB_UserList.Size = new System.Drawing.Size(229, 384);
            this.uxLB_UserList.TabIndex = 3;
            // 
            // uxLBL_UserList
            // 
            this.uxLBL_UserList.AutoSize = true;
            this.uxLBL_UserList.Location = new System.Drawing.Point(279, 66);
            this.uxLBL_UserList.Name = "uxLBL_UserList";
            this.uxLBL_UserList.Size = new System.Drawing.Size(76, 20);
            this.uxLBL_UserList.TabIndex = 4;
            this.uxLBL_UserList.Text = "User List:";
            // 
            // uxLBL_ServerIP
            // 
            this.uxLBL_ServerIP.AutoSize = true;
            this.uxLBL_ServerIP.Location = new System.Drawing.Point(283, 13);
            this.uxLBL_ServerIP.Name = "uxLBL_ServerIP";
            this.uxLBL_ServerIP.Size = new System.Drawing.Size(82, 20);
            this.uxLBL_ServerIP.TabIndex = 5;
            this.uxLBL_ServerIP.Text = "Server IP: ";
            // 
            // uxLB_Transactions
            // 
            this.uxLB_Transactions.FormattingEnabled = true;
            this.uxLB_Transactions.ItemHeight = 20;
            this.uxLB_Transactions.Location = new System.Drawing.Point(553, 89);
            this.uxLB_Transactions.Name = "uxLB_Transactions";
            this.uxLB_Transactions.Size = new System.Drawing.Size(227, 384);
            this.uxLB_Transactions.TabIndex = 6;
            // 
            // uxLBL_TransactionList
            // 
            this.uxLBL_TransactionList.AutoSize = true;
            this.uxLBL_TransactionList.Location = new System.Drawing.Point(549, 66);
            this.uxLBL_TransactionList.Name = "uxLBL_TransactionList";
            this.uxLBL_TransactionList.Size = new System.Drawing.Size(160, 20);
            this.uxLBL_TransactionList.TabIndex = 7;
            this.uxLBL_TransactionList.Text = "Recent Transactions:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 516);
            this.Controls.Add(this.uxLBL_TransactionList);
            this.Controls.Add(this.uxLB_Transactions);
            this.Controls.Add(this.uxLBL_ServerIP);
            this.Controls.Add(this.uxLBL_UserList);
            this.Controls.Add(this.uxLB_UserList);
            this.Controls.Add(this.uxLBL_StockList);
            this.Controls.Add(this.uxLB_StockList);
            this.Controls.Add(this.uxLBL_OnlineUsers);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Server Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxLBL_OnlineUsers;
        private System.Windows.Forms.ListBox uxLB_StockList;
        private System.Windows.Forms.Label uxLBL_StockList;
        private System.Windows.Forms.ListBox uxLB_UserList;
        private System.Windows.Forms.Label uxLBL_UserList;
        private System.Windows.Forms.Label uxLBL_ServerIP;
        private System.Windows.Forms.ListBox uxLB_Transactions;
        private System.Windows.Forms.Label uxLBL_TransactionList;
    }
}

