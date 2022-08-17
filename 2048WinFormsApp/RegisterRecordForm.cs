using System;
using System.Windows.Forms;

namespace _2048WinFormsApp
{
    public partial class RegisterRecordForm : Form
    {
        public RegisterRecordForm()
        {
            InitializeComponent();
        }

        private void enterName_button_Click(object sender, EventArgs e)
        {
            
            if (name_textBox.Text == "")
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Пожалуйста, введите своё имя", "Неверный ввод", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult = DialogResult.OK;
            }
        }
    }
}
