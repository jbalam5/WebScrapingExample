namespace WebScraping_Examples.Example1
{
    partial class Selenium_Search
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
            this.TextToSearchTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ReportDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TextToSearchTextBox
            // 
            this.TextToSearchTextBox.Location = new System.Drawing.Point(6, 13);
            this.TextToSearchTextBox.Name = "TextToSearchTextBox";
            this.TextToSearchTextBox.Size = new System.Drawing.Size(654, 22);
            this.TextToSearchTextBox.TabIndex = 0;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(667, 13);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(121, 23);
            this.SearchButton.TabIndex = 1;
            this.SearchButton.Text = "Buscar";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ReportDataGridView
            // 
            this.ReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReportDataGridView.Location = new System.Drawing.Point(6, 62);
            this.ReportDataGridView.Name = "ReportDataGridView";
            this.ReportDataGridView.RowHeadersWidth = 51;
            this.ReportDataGridView.RowTemplate.Height = 24;
            this.ReportDataGridView.Size = new System.Drawing.Size(782, 376);
            this.ReportDataGridView.TabIndex = 2;
            // 
            // Selenium_Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ReportDataGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.TextToSearchTextBox);
            this.Name = "Selenium_Search";
            this.Text = "Selenium_Busqueda";
            ((System.ComponentModel.ISupportInitialize)(this.ReportDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextToSearchTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView ReportDataGridView;
    }
}