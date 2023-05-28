namespace JustForWatchPaymentCsv.Forms
{
    partial class MappingCsvForm
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
            this.targetFile_label = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // targetFile_label
            // 
            this.targetFile_label.AutoSize = true;
            this.targetFile_label.Location = new System.Drawing.Point(178, 9);
            this.targetFile_label.Name = "targetFile_label";
            this.targetFile_label.Size = new System.Drawing.Size(89, 12);
            this.targetFile_label.TabIndex = 1;
            this.targetFile_label.Text = "#target#の紐づけ";
            this.targetFile_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(435, 234);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // MappingCsvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 284);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.targetFile_label);
            this.Name = "MappingCsvForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "項目の紐づけ設定";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label targetFile_label;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}