namespace _2048WinFormsApp
{
    partial class RegisterRecordForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterRecordForm));
            this.text_label = new System.Windows.Forms.Label();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.enterName_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_label
            // 
            this.text_label.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.text_label.Location = new System.Drawing.Point(12, 22);
            this.text_label.Name = "text_label";
            this.text_label.Size = new System.Drawing.Size(315, 58);
            this.text_label.TabIndex = 0;
            this.text_label.Text = "Для регистрации нового рекорда необходимо ввести Ваше имя";
            this.text_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // name_textBox
            // 
            this.name_textBox.Location = new System.Drawing.Point(12, 93);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(315, 23);
            this.name_textBox.TabIndex = 1;
            this.name_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // enterName_button
            // 
            this.enterName_button.BackColor = System.Drawing.Color.RoyalBlue;
            this.enterName_button.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.enterName_button.Location = new System.Drawing.Point(79, 131);
            this.enterName_button.Name = "enterName_button";
            this.enterName_button.Size = new System.Drawing.Size(167, 49);
            this.enterName_button.TabIndex = 2;
            this.enterName_button.Text = "OK";
            this.enterName_button.UseVisualStyleBackColor = false;
            this.enterName_button.Click += new System.EventHandler(this.enterName_button_Click);
            // 
            // RegisterRecordForm
            // 
            this.AcceptButton = this.enterName_button;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(341, 201);
            this.Controls.Add(this.enterName_button);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.text_label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterRecordForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "2048";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text_label;
        public System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.Button enterName_button;
    }
}