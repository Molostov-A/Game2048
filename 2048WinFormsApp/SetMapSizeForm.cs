using System;
using System.Windows.Forms;

namespace _2048WinFormsApp
{
    public partial class SetMapSizeForm : Form
    {
        public SetMapSizeForm()
        {
            InitializeComponent();
        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            if (inputMapSize_textBox.Text == "")
            {
                DialogResult = DialogResult.None;
                MessageBox.Show("Пожалуйста, введите размер поля", "Неверный ввод", MessageBoxButtons.OK);
            }
            else
            {
                var textMapSize = inputMapSize_textBox.Text;
                int mapSize;
                if (int.TryParse(textMapSize, out mapSize))
                {
                    mapSize = int.Parse(textMapSize);
                    if (mapSize >= 2 && mapSize <= 20)
                    {
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Пожалуйста, ведите целое число от 2 до 20", "Неверный ввод", MessageBoxButtons.OK);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Пожалуйста, целое число", "Неверный ввод", MessageBoxButtons.OK);
                }
            }
        }
    }
}
