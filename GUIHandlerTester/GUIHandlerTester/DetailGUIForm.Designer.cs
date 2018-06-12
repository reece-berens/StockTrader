namespace GUIHandlerTester
{
    partial class DetailGUIForm
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
            this.uxTB_DetailBox = new System.Windows.Forms.TextBox();
            this.uxBtn_Return = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxTB_DetailBox
            // 
            this.uxTB_DetailBox.Location = new System.Drawing.Point(79, 33);
            this.uxTB_DetailBox.Multiline = true;
            this.uxTB_DetailBox.Name = "uxTB_DetailBox";
            this.uxTB_DetailBox.ReadOnly = true;
            this.uxTB_DetailBox.Size = new System.Drawing.Size(238, 163);
            this.uxTB_DetailBox.TabIndex = 0;
            // 
            // uxBtn_Return
            // 
            this.uxBtn_Return.Location = new System.Drawing.Point(137, 244);
            this.uxBtn_Return.Name = "uxBtn_Return";
            this.uxBtn_Return.Size = new System.Drawing.Size(106, 38);
            this.uxBtn_Return.TabIndex = 1;
            this.uxBtn_Return.Text = "Return";
            this.uxBtn_Return.UseVisualStyleBackColor = true;
            // 
            // DetailGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 312);
            this.Controls.Add(this.uxBtn_Return);
            this.Controls.Add(this.uxTB_DetailBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "DetailGUI";
            this.Text = "Detail GUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uxTB_DetailBox;
        private System.Windows.Forms.Button uxBtn_Return;
    }
}