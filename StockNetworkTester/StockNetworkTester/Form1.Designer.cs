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
            this.uxGBDataType = new System.Windows.Forms.GroupBox();
            this.uxRBIntraday = new System.Windows.Forms.RadioButton();
            this.uxRBDaily = new System.Windows.Forms.RadioButton();
            this.uxRBWeekly = new System.Windows.Forms.RadioButton();
            this.uxRBBatch = new System.Windows.Forms.RadioButton();
            this.uxGBDataType.SuspendLayout();
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
            this.uxBtnAddStock.Click += new System.EventHandler(this.AddStock_Click);
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
            // uxGBDataType
            // 
            this.uxGBDataType.Controls.Add(this.uxRBBatch);
            this.uxGBDataType.Controls.Add(this.uxRBWeekly);
            this.uxGBDataType.Controls.Add(this.uxRBDaily);
            this.uxGBDataType.Controls.Add(this.uxRBIntraday);
            this.uxGBDataType.Location = new System.Drawing.Point(232, 24);
            this.uxGBDataType.Name = "uxGBDataType";
            this.uxGBDataType.Size = new System.Drawing.Size(200, 192);
            this.uxGBDataType.TabIndex = 4;
            this.uxGBDataType.TabStop = false;
            this.uxGBDataType.Text = "Data Type";
            // 
            // uxRBIntraday
            // 
            this.uxRBIntraday.AutoSize = true;
            this.uxRBIntraday.Location = new System.Drawing.Point(7, 29);
            this.uxRBIntraday.Name = "uxRBIntraday";
            this.uxRBIntraday.Size = new System.Drawing.Size(100, 28);
            this.uxRBIntraday.TabIndex = 0;
            this.uxRBIntraday.TabStop = true;
            this.uxRBIntraday.Text = "Intra Day";
            this.uxRBIntraday.UseVisualStyleBackColor = true;
            // 
            // uxRBDaily
            // 
            this.uxRBDaily.AutoSize = true;
            this.uxRBDaily.Location = new System.Drawing.Point(7, 64);
            this.uxRBDaily.Name = "uxRBDaily";
            this.uxRBDaily.Size = new System.Drawing.Size(68, 28);
            this.uxRBDaily.TabIndex = 1;
            this.uxRBDaily.TabStop = true;
            this.uxRBDaily.Text = "Daily";
            this.uxRBDaily.UseVisualStyleBackColor = true;
            // 
            // uxRBWeekly
            // 
            this.uxRBWeekly.AutoSize = true;
            this.uxRBWeekly.Enabled = false;
            this.uxRBWeekly.Location = new System.Drawing.Point(7, 99);
            this.uxRBWeekly.Name = "uxRBWeekly";
            this.uxRBWeekly.Size = new System.Drawing.Size(90, 28);
            this.uxRBWeekly.TabIndex = 2;
            this.uxRBWeekly.TabStop = true;
            this.uxRBWeekly.Text = "Weekly";
            this.uxRBWeekly.UseVisualStyleBackColor = true;
            // 
            // uxRBBatch
            // 
            this.uxRBBatch.AutoSize = true;
            this.uxRBBatch.Location = new System.Drawing.Point(7, 134);
            this.uxRBBatch.Name = "uxRBBatch";
            this.uxRBBatch.Size = new System.Drawing.Size(75, 28);
            this.uxRBBatch.TabIndex = 3;
            this.uxRBBatch.TabStop = true;
            this.uxRBBatch.Text = "Batch";
            this.uxRBBatch.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 398);
            this.Controls.Add(this.uxGBDataType);
            this.Controls.Add(this.uxLBStocks);
            this.Controls.Add(this.uxTBAddStock);
            this.Controls.Add(this.uxBtnAddStock);
            this.Controls.Add(this.uxBtnGetPrices);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Stock Network Tester";
            this.uxGBDataType.ResumeLayout(false);
            this.uxGBDataType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uxBtnGetPrices;
        private System.Windows.Forms.Button uxBtnAddStock;
        private System.Windows.Forms.TextBox uxTBAddStock;
        private System.Windows.Forms.ListBox uxLBStocks;
        private System.Windows.Forms.GroupBox uxGBDataType;
        private System.Windows.Forms.RadioButton uxRBBatch;
        private System.Windows.Forms.RadioButton uxRBWeekly;
        private System.Windows.Forms.RadioButton uxRBDaily;
        private System.Windows.Forms.RadioButton uxRBIntraday;
    }
}

