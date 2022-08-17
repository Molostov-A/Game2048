namespace _2048WinFormsApp
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.records_label = new System.Windows.Forms.Label();
            this.score_label = new System.Windows.Forms.Label();
            this.menu_menuStrip = new System.Windows.Forms.MenuStrip();
            this.menu_menuStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reset_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rules_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableRecords_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeField_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scale_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scale40_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scale60_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scale80_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scale100_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scale120_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scale140_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scale160_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scale180_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scale200_toolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exit_ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // records_label
            // 
            this.records_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.records_label.BackColor = System.Drawing.Color.Transparent;
            this.records_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.records_label.Location = new System.Drawing.Point(80, 9);
            this.records_label.Name = "records_label";
            this.records_label.Size = new System.Drawing.Size(107, 20);
            this.records_label.TabIndex = 0;
            this.records_label.Text = "Рекорд: 0";
            this.records_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // score_label
            // 
            this.score_label.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.score_label.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.score_label.Location = new System.Drawing.Point(211, 9);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(56, 20);
            this.score_label.TabIndex = 0;
            this.score_label.Text = "Счет: 0";
            this.score_label.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // menu_menuStrip
            // 
            this.menu_menuStrip.AutoSize = false;
            this.menu_menuStrip.BackColor = System.Drawing.Color.Transparent;
            this.menu_menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_menuStripMenuItem});
            this.menu_menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menu_menuStrip.Name = "menu_menuStrip";
            this.menu_menuStrip.Size = new System.Drawing.Size(267, 29);
            this.menu_menuStrip.TabIndex = 1;
            this.menu_menuStrip.Text = "menuStrip1";
            // 
            // menu_menuStripMenuItem
            // 
            this.menu_menuStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reset_ToolStripMenuItem,
            this.rules_ToolStripMenuItem,
            this.tableRecords_ToolStripMenuItem,
            this.sizeField_ToolStripMenuItem,
            this.scale_ToolStripMenuItem,
            this.exit_ToolStripMenuItem});
            this.menu_menuStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menu_menuStripMenuItem.Name = "menu_menuStripMenuItem";
            this.menu_menuStripMenuItem.Size = new System.Drawing.Size(53, 25);
            this.menu_menuStripMenuItem.Text = "Меню";
            this.menu_menuStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // reset_ToolStripMenuItem
            // 
            this.reset_ToolStripMenuItem.AutoToolTip = true;
            this.reset_ToolStripMenuItem.Name = "reset_ToolStripMenuItem";
            this.reset_ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.reset_ToolStripMenuItem.Text = "Перезапуск";
            this.reset_ToolStripMenuItem.Click += new System.EventHandler(this.reset_ToolStripMenuItem_Click);
            // 
            // rules_ToolStripMenuItem
            // 
            this.rules_ToolStripMenuItem.Name = "rules_ToolStripMenuItem";
            this.rules_ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.rules_ToolStripMenuItem.Text = "Правила игры";
            this.rules_ToolStripMenuItem.Click += new System.EventHandler(this.rules_ToolStripMenuItem_Click);
            // 
            // tableRecords_ToolStripMenuItem
            // 
            this.tableRecords_ToolStripMenuItem.Name = "tableRecords_ToolStripMenuItem";
            this.tableRecords_ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.tableRecords_ToolStripMenuItem.Text = "Таблица рекордов";
            this.tableRecords_ToolStripMenuItem.Click += new System.EventHandler(this.tableRecords_ToolStripMenuItem_Click);
            // 
            // sizeField_ToolStripMenuItem
            // 
            this.sizeField_ToolStripMenuItem.Name = "sizeField_ToolStripMenuItem";
            this.sizeField_ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.sizeField_ToolStripMenuItem.Text = "Выбор размера поля";
            this.sizeField_ToolStripMenuItem.Click += new System.EventHandler(this.sizeField_ToolStripMenuItem_Click);
            // 
            // scale_ToolStripMenuItem
            // 
            this.scale_ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scale40_toolStripMenuItem,
            this.scale60_toolStripMenuItem,
            this.scale80_toolStripMenuItem,
            this.scale100_toolStripMenuItem,
            this.scale120_toolStripMenuItem,
            this.scale140_toolStripMenuItem,
            this.scale160_toolStripMenuItem,
            this.scale180_toolStripMenuItem,
            this.scale200_toolStripMenuItem});
            this.scale_ToolStripMenuItem.Name = "scale_ToolStripMenuItem";
            this.scale_ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.scale_ToolStripMenuItem.Text = "Маштаб";
            // 
            // scale40_toolStripMenuItem
            // 
            this.scale40_toolStripMenuItem.Name = "scale40_toolStripMenuItem";
            this.scale40_toolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.scale40_toolStripMenuItem.Text = "40%";
            this.scale40_toolStripMenuItem.Click += new System.EventHandler(this.scale40_toolStripMenuItem_Click);
            // 
            // scale60_toolStripMenuItem
            // 
            this.scale60_toolStripMenuItem.Name = "scale60_toolStripMenuItem";
            this.scale60_toolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.scale60_toolStripMenuItem.Text = "60%";
            this.scale60_toolStripMenuItem.Click += new System.EventHandler(this.scale60_toolStripMenuItem_Click);
            // 
            // scale80_toolStripMenuItem
            // 
            this.scale80_toolStripMenuItem.Name = "scale80_toolStripMenuItem";
            this.scale80_toolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.scale80_toolStripMenuItem.Text = "80%";
            this.scale80_toolStripMenuItem.Click += new System.EventHandler(this.scale80_toolStripMenuItem_Click);
            // 
            // scale100_toolStripMenuItem
            // 
            this.scale100_toolStripMenuItem.Name = "scale100_toolStripMenuItem";
            this.scale100_toolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.scale100_toolStripMenuItem.Text = "100%";
            this.scale100_toolStripMenuItem.Click += new System.EventHandler(this.scale100_toolStripMenuItem_Click);
            // 
            // scale120_toolStripMenuItem
            // 
            this.scale120_toolStripMenuItem.Name = "scale120_toolStripMenuItem";
            this.scale120_toolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.scale120_toolStripMenuItem.Text = "120%";
            this.scale120_toolStripMenuItem.Click += new System.EventHandler(this.scale120_toolStripMenuItem_Click);
            // 
            // scale140_toolStripMenuItem
            // 
            this.scale140_toolStripMenuItem.Name = "scale140_toolStripMenuItem";
            this.scale140_toolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.scale140_toolStripMenuItem.Text = "140%";
            this.scale140_toolStripMenuItem.Click += new System.EventHandler(this.scale140_toolStripMenuItem_Click);
            // 
            // scale160_toolStripMenuItem
            // 
            this.scale160_toolStripMenuItem.Name = "scale160_toolStripMenuItem";
            this.scale160_toolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.scale160_toolStripMenuItem.Text = "160%";
            this.scale160_toolStripMenuItem.Click += new System.EventHandler(this.scale160_toolStripMenuItem_Click);
            // 
            // scale180_toolStripMenuItem
            // 
            this.scale180_toolStripMenuItem.Name = "scale180_toolStripMenuItem";
            this.scale180_toolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.scale180_toolStripMenuItem.Text = "180%";
            this.scale180_toolStripMenuItem.Click += new System.EventHandler(this.scale180_toolStripMenuItem_Click);
            // 
            // scale200_toolStripMenuItem
            // 
            this.scale200_toolStripMenuItem.Name = "scale200_toolStripMenuItem";
            this.scale200_toolStripMenuItem.Size = new System.Drawing.Size(102, 22);
            this.scale200_toolStripMenuItem.Text = "200%";
            this.scale200_toolStripMenuItem.Click += new System.EventHandler(this.scale200_toolStripMenuItem_Click);
            // 
            // exit_ToolStripMenuItem
            // 
            this.exit_ToolStripMenuItem.Name = "exit_ToolStripMenuItem";
            this.exit_ToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.exit_ToolStripMenuItem.Text = "Выход";
            this.exit_ToolStripMenuItem.Click += new System.EventHandler(this.exit_ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(267, 203);
            this.Controls.Add(this.records_label);
            this.Controls.Add(this.score_label);
            this.Controls.Add(this.menu_menuStrip);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu_menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2048";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.menu_menuStrip.ResumeLayout(false);
            this.menu_menuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.MenuStrip menu_menuStrip;
        private System.Windows.Forms.ToolStripMenuItem menu_menuStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reset_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rules_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tableRecords_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeField_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scale_ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scale40_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scale60_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scale80_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scale100_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scale120_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scale140_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scale160_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scale180_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scale200_toolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exit_ToolStripMenuItem;
        private System.Windows.Forms.Label records_label;

        #endregion

        //private System.Windows.Forms.Label cell_label;
    }
}
