namespace _2048WinFormsApp
{
    partial class SetMapSizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetMapSizeForm));
            this.enter_button = new System.Windows.Forms.Button();
            this.text_label = new System.Windows.Forms.Label();
            this.inputMapSize_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enter_button
            // 
            this.enter_button.BackColor = System.Drawing.SystemColors.Highlight;
            this.enter_button.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enter_button.Location = new System.Drawing.Point(46, 98);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(124, 37);
            this.enter_button.TabIndex = 0;
            this.enter_button.Text = "ОК";
            this.enter_button.UseVisualStyleBackColor = false;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // text_label
            // 
            this.text_label.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.text_label.Location = new System.Drawing.Point(12, 9);
            this.text_label.Name = "text_label";
            this.text_label.Size = new System.Drawing.Size(199, 48);
            this.text_label.TabIndex = 1;
            this.text_label.Text = "Введите размер поля (от 2 до 20)";
            this.text_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inputMapSize_textBox
            // 
            this.inputMapSize_textBox.Location = new System.Drawing.Point(46, 69);
            this.inputMapSize_textBox.Name = "inputMapSize_textBox";
            this.inputMapSize_textBox.Size = new System.Drawing.Size(124, 23);
            this.inputMapSize_textBox.TabIndex = 2;
            this.inputMapSize_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SetMapSizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(224, 141);
            this.Controls.Add(this.inputMapSize_textBox);
            this.Controls.Add(this.text_label);
            this.Controls.Add(this.enter_button);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SetMapSizeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SetMapSizeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.Label text_label;
        public System.Windows.Forms.TextBox inputMapSize_textBox;
    }
}