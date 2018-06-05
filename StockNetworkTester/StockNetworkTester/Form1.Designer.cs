namespace StockNetworkTester
{
    partial class Form1
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
            this.uxBtnGetPrices = new System.Windows.Forms.Button();
            this.uxBtnAddStock = new System.Windows.Forms.Button();
            this.uxTBAddStock = new System.Windows.Forms.TextBox();
            this.uxLBStocks = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // uxBtnGetPrices
            // 
            this.uxBtnGetPrices.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uxBtnGetPrices.Location = new System.Drawing.Point(258, 309);
            this.uxBtnGetPrices.Name = "uxBtnGetPrices";
            this.uxBtnGetPrices.Size = new System.Drawing.Size(119, 49);
            this.uxBtnGetPrices.TabIndex = 0;
            this.uxBtnGetPrices.Text = "Get Prices";
            this.uxBtnGetPrices.UseVisualStyleBackColor = true;
            this.uxBtnGetPrices.Click += new System.EventHandler(this.GetPrices_Click);
            // 
            // uxBtnAddStock
            // 
            this.uxBtnAddStock.Location = new System.Drawing.Point(26, 309);
            this.uxBtnAddStock.Name = "uxBtnAddStock";
            this.uxBtnAddStock.Size = new System.Drawing.Size(116, 49);
            this.uxBtnAddStock.TabIndex = 1;
            this.uxBtnAddStock.Text = "Add Stock";
            this.uxBtnAddStock.UseVisualStyleBackColor = true;
            // 
            // uxTBAddStock
            // 
            this.uxTBAddStock.Location = new System.Drawing.Point(26, 258);
            this.uxTBAddStock.Name = "uxTBAddStock";
            this.uxTBAddStock.Size = new System.Drawing.Size(154, 29);
            this.uxTBAddStock.TabIndex = 2;
            // 
            // uxLBStocks
            // 
            this.uxLBStocks.FormattingEnabled = true;
            this.uxLBStocks.ItemHeight = 24;
            this.uxLBStocks.Location = new System.Drawing.Point(26, 13);
            this.uxLBStocks.Name = "uxLBStocks";
            this.uxLBStocks.Size = new System.Drawing.Size(154, 196);
            this.uxLBStocks.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 398);
            this.Controls.Add(this.uxLBStocks);
            this.Controls.Add(this.uxTBAddStock);
            this.Controls.Add(this.uxBtnAddStock);
            this.Controls.Add(this.uxBtnGetPrices);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Stock Network Tester";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxBtnGetPrices;
        private System.Windows.Forms.Button uxBtnAddStock;
        private System.Windows.Forms.TextBox uxTBAddStock;
        private System.Windows.Forms.ListBox uxLBStocks;
    }
}

