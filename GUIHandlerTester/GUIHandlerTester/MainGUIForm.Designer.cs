namespace GUIHandlerTester
{
    partial class MainGUIForm
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
            this.uxBtn_AddStock = new System.Windows.Forms.Button();
            this.uxTB_SymbolToAdd = new System.Windows.Forms.TextBox();
            this.uxLB_StockList = new System.Windows.Forms.ListBox();
            this.uxBtn_Detail = new System.Windows.Forms.Button();
            this.uxBtn_Logout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxBtn_AddStock
            // 
            this.uxBtn_AddStock.Location = new System.Drawing.Point(13, 332);
            this.uxBtn_AddStock.Name = "uxBtn_AddStock";
            this.uxBtn_AddStock.Size = new System.Drawing.Size(110, 31);
            this.uxBtn_AddStock.TabIndex = 0;
            this.uxBtn_AddStock.Text = "Add Stock";
            this.uxBtn_AddStock.UseVisualStyleBackColor = true;
            this.uxBtn_AddStock.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // uxTB_SymbolToAdd
            // 
            this.uxTB_SymbolToAdd.Location = new System.Drawing.Point(12, 300);
            this.uxTB_SymbolToAdd.Name = "uxTB_SymbolToAdd";
            this.uxTB_SymbolToAdd.Size = new System.Drawing.Size(111, 26);
            this.uxTB_SymbolToAdd.TabIndex = 1;
            // 
            // uxLB_StockList
            // 
            this.uxLB_StockList.FormattingEnabled = true;
            this.uxLB_StockList.ItemHeight = 20;
            this.uxLB_StockList.Location = new System.Drawing.Point(12, 13);
            this.uxLB_StockList.Name = "uxLB_StockList";
            this.uxLB_StockList.Size = new System.Drawing.Size(176, 264);
            this.uxLB_StockList.TabIndex = 2;
            // 
            // uxBtn_Detail
            // 
            this.uxBtn_Detail.Location = new System.Drawing.Point(204, 13);
            this.uxBtn_Detail.Name = "uxBtn_Detail";
            this.uxBtn_Detail.Size = new System.Drawing.Size(108, 35);
            this.uxBtn_Detail.TabIndex = 3;
            this.uxBtn_Detail.Text = "Details";
            this.uxBtn_Detail.UseVisualStyleBackColor = true;
            this.uxBtn_Detail.Click += new System.EventHandler(this.BtnDetails_Click);
            // 
            // uxBtn_Logout
            // 
            this.uxBtn_Logout.Location = new System.Drawing.Point(204, 332);
            this.uxBtn_Logout.Name = "uxBtn_Logout";
            this.uxBtn_Logout.Size = new System.Drawing.Size(108, 31);
            this.uxBtn_Logout.TabIndex = 4;
            this.uxBtn_Logout.Text = "Logout";
            this.uxBtn_Logout.UseVisualStyleBackColor = true;
            this.uxBtn_Logout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // MainGUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 384);
            this.Controls.Add(this.uxBtn_Logout);
            this.Controls.Add(this.uxBtn_Detail);
            this.Controls.Add(this.uxLB_StockList);
            this.Controls.Add(this.uxTB_SymbolToAdd);
            this.Controls.Add(this.uxBtn_AddStock);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainGUIForm";
            this.Text = "Main GUI Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxBtn_AddStock;
        private System.Windows.Forms.TextBox uxTB_SymbolToAdd;
        private System.Windows.Forms.ListBox uxLB_StockList;
        private System.Windows.Forms.Button uxBtn_Detail;
        private System.Windows.Forms.Button uxBtn_Logout;
    }
}

