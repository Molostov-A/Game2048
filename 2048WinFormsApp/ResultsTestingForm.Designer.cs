namespace _2048WinFormsApp
{
    partial class ResultsTestingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultsTestingForm));
            this.resultsDataGridView = new System.Windows.Forms.DataGridView();
            this.textAppeal_Label = new System.Windows.Forms.Label();
            this.UserNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ScoresColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // resultsDataGridView
            // 
            this.resultsDataGridView.BackgroundColor = System.Drawing.Color.OldLace;
            this.resultsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserNameColumn,
            this.SizeColumn,
            this.ScoresColumn,
            this.DataColumn});
            this.resultsDataGridView.Location = new System.Drawing.Point(12, 56);
            this.resultsDataGridView.Name = "resultsDataGridView";
            this.resultsDataGridView.RowTemplate.Height = 25;
            this.resultsDataGridView.Size = new System.Drawing.Size(541, 409);
            this.resultsDataGridView.TabIndex = 0;
            // 
            // textAppeal_Label
            // 
            this.textAppeal_Label.AutoSize = true;
            this.textAppeal_Label.BackColor = System.Drawing.Color.Transparent;
            this.textAppeal_Label.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.textAppeal_Label.Location = new System.Drawing.Point(207, 19);
            this.textAppeal_Label.Name = "textAppeal_Label";
            this.textAppeal_Label.Size = new System.Drawing.Size(143, 21);
            this.textAppeal_Label.TabIndex = 6;
            this.textAppeal_Label.Text = "Результаты игры";
            // 
            // UserNameColumn
            // 
            this.UserNameColumn.HeaderText = "Имя";
            this.UserNameColumn.Name = "UserNameColumn";
            // 
            // SizeColumn
            // 
            this.SizeColumn.HeaderText = "Размер поля";
            this.SizeColumn.Name = "SizeColumn";
            // 
            // ScoresColumn
            // 
            this.ScoresColumn.HeaderText = "Счёт";
            this.ScoresColumn.Name = "ScoresColumn";
            // 
            // DataColumn
            // 
            this.DataColumn.HeaderText = "Дата";
            this.DataColumn.Name = "DataColumn";
            this.DataColumn.Width = 200;
            // 
            // ResultsTestingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(565, 476);
            this.Controls.Add(this.textAppeal_Label);
            this.Controls.Add(this.resultsDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResultsTestingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "2048";
            this.Load += new System.EventHandler(this.Results_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView resultsDataGridView;
        private System.Windows.Forms.Label textAppeal_Label;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SizeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ScoresColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataColumn;
    }
}