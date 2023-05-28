namespace JustForWatchPaymentCsv.Forms
{
    partial class CsvColumnBindSelector
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.systemName_label = new System.Windows.Forms.Label();
            this.arrow_label = new System.Windows.Forms.Label();
            this.csvItems_comboBox = new System.Windows.Forms.ComboBox();
            this.errorMessage_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // systemName_label
            // 
            this.systemName_label.AutoSize = true;
            this.systemName_label.Location = new System.Drawing.Point(3, 9);
            this.systemName_label.Name = "systemName_label";
            this.systemName_label.Size = new System.Drawing.Size(79, 12);
            this.systemName_label.TabIndex = 2;
            this.systemName_label.Text = "システム内項目";
            // 
            // arrow_label
            // 
            this.arrow_label.AutoSize = true;
            this.arrow_label.Location = new System.Drawing.Point(142, 9);
            this.arrow_label.Name = "arrow_label";
            this.arrow_label.Size = new System.Drawing.Size(17, 12);
            this.arrow_label.TabIndex = 2;
            this.arrow_label.Text = "->";
            // 
            // csvItems_comboBox
            // 
            this.csvItems_comboBox.FormattingEnabled = true;
            this.csvItems_comboBox.Location = new System.Drawing.Point(187, 6);
            this.csvItems_comboBox.Name = "csvItems_comboBox";
            this.csvItems_comboBox.Size = new System.Drawing.Size(177, 20);
            this.csvItems_comboBox.TabIndex = 3;
            this.csvItems_comboBox.SelectedIndexChanged += new System.EventHandler(this.csvItems_comboBox_SelectedIndexChanged);
            // 
            // errorMessage_label
            // 
            this.errorMessage_label.AutoSize = true;
            this.errorMessage_label.ForeColor = System.Drawing.Color.Red;
            this.errorMessage_label.Location = new System.Drawing.Point(185, 29);
            this.errorMessage_label.Name = "errorMessage_label";
            this.errorMessage_label.Size = new System.Drawing.Size(229, 12);
            this.errorMessage_label.TabIndex = 2;
            this.errorMessage_label.Text = "必須項目のため、空欄にすることは出来ません。";
            this.errorMessage_label.Visible = false;
            // 
            // CsvColumnBindSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.csvItems_comboBox);
            this.Controls.Add(this.arrow_label);
            this.Controls.Add(this.errorMessage_label);
            this.Controls.Add(this.systemName_label);
            this.Name = "CsvColumnBindSelector";
            this.Size = new System.Drawing.Size(428, 51);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label systemName_label;
        private System.Windows.Forms.Label arrow_label;
        private System.Windows.Forms.ComboBox csvItems_comboBox;
        private System.Windows.Forms.Label errorMessage_label;
    }
}
