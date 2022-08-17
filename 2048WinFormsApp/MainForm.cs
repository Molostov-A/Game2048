using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using _2048.Common;
using _2048.Common.Models;

namespace _2048WinFormsApp
{
    public partial class MainForm : Form
    {
        private static ScaleStorage _scaleStorage = new();
        private static RecordsStorage _recordsStorage = new();
        private static MapSizeStorage _mapSizeStorage = new();
        private static Random random = new();

        private static int score;
        private static int mapSize = _mapSizeStorage.GetSize();
        private int lastRecords = _recordsStorage.GetLastRecords(mapSize);
        private static int scale = _scaleStorage.GetScale();
        private static int sizeCell = scale * 20;
        private static int helghMenu = scale * 10;
        private static int space = scale * 2;
        private static int sizeFormX = (space + sizeCell) * mapSize + space + 16;
        private static int sizeFormY = helghMenu + (space + sizeCell) * mapSize + space + 39;

        private Label[,] labelsMap;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            BackColor = ColorTranslator.FromHtml("#FAF3ED");
            Size = new Size(sizeFormX, sizeFormY);

            score_label.Font = new Font("Segoe UI Black", Convert.ToSingle(2 * scale), FontStyle.Bold, GraphicsUnit.Point);
            score_label.Location = new Point(sizeFormX - sizeCell * 2 - 20, scale * 2);
            score_label.Size = new Size(sizeCell * 2, scale * 6);

            records_label.Font = new Font("Segoe UI Black", Convert.ToSingle(2 * scale), FontStyle.Bold, GraphicsUnit.Point);
            records_label.Size = new Size(sizeCell, scale * 6);
            records_label.Location = new Point(sizeFormX / 2 - sizeCell / 2, scale * 2);
            records_label.Text = "Рекорд: " + lastRecords;

            menu_menuStrip.Size = new Size(sizeCell * 2, scale * 6);
            menu_menuStrip.Location = new Point(scale, scale);

            menu_menuStripMenuItem.Size = new Size(sizeCell * 2, scale * 6);
            menu_menuStripMenuItem.Font = new Font("Segoe UI Black", Convert.ToSingle(2 * scale), FontStyle.Bold, GraphicsUnit.Point);

            InitMap();
            GenerateNumber();
            ShowScore();
        }

        private void ShowScore()
        {
            score_label.Text = "Счёт: " + score;
        }

        private void InitMap()
        {
            labelsMap = new Label[mapSize, mapSize];
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLabel = CreateLabel(i, j);
                    Controls.Add(newLabel);
                    labelsMap[i, j] = newLabel;
                }
            }
        }

        private void GenerateNumber()
        {
            List<int> numbers = new List<int>();
            for (int i = 0; i < mapSize * mapSize; i++)
            {
                numbers.Add(i);
            }

            while (numbers.Count > 0)
            {
                var randomNumberLabel = random.Next(numbers.Count);
                var indexRow = numbers[randomNumberLabel] / mapSize;
                var indexColomn = numbers[randomNumberLabel] % mapSize;
                if (labelsMap[indexRow, indexColomn].Text == string.Empty)
                {
                    var cellLabel = labelsMap[indexRow, indexColomn];
                    var randomSwitch = random.Next(4);
                    int numberNewCells;
                    if (randomSwitch == 0)
                        numberNewCells = 4;
                    else numberNewCells = 2;
                    cellLabel.Text = numberNewCells.ToString();
                    cellLabel.BackColor = GetColor(numberNewCells);
                    break;
                }
                numbers.RemoveAt(randomNumberLabel);
            }
            if (numbers.Count == 0)
            {
                Hide();
                if (lastRecords < score)
                {
                    NewRecordMessege();
                }
                GameOverMessege();
            }
        }

        private void NewRecordMessege()
        {
            var result = MessageBox.Show(
                "Вы поставили новый рекорд! \nЖелаете зарегестрировать результат?",
                "Окончание игры",
                MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                var registerRecord = new RegisterRecordForm();
                result = registerRecord.ShowDialog();

                if (result == DialogResult.OK)
                {
                    var newRecord = new Result(registerRecord.name_textBox.Text, mapSize, score);
                    _recordsStorage.Add(newRecord);
                    registerRecord.Close();
                    GameOverMessege();
                }
            }

            if (result == DialogResult.No)
            {
                GameOverMessege();
            }
        }

        private void GameOverMessege()
        {
            var result = MessageBox.Show("Игра окончена!\nЖелаете повторить?",
                "Окончание игры", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Restart();
            }
            if (result == DialogResult.No)
            {
                Application.Exit();
            }
        }

        private Label CreateLabel(int indexRow, int indexColumn)
        {
            var label = new Label();
            label.BackColor = GetColor();
            label.Font = new Font("Segoe UI Black", Convert.ToSingle(4 * scale), FontStyle.Bold, GraphicsUnit.Point);
            label.Name = "cell_label";
            label.Size = new Size(sizeCell, sizeCell);
            label.TabIndex = 0;

            label.TextAlign = ContentAlignment.MiddleCenter;
            var x = space * (indexColumn + 1) + sizeCell * indexColumn;
            var y = helghMenu + space * (indexRow + 1) + sizeCell * indexRow;
            label.Location = new Point(x, y);
            return label;
        }

        private Color GetColor(int number = 0)
        {
            switch (number)
            {
                case 0: return ColorTranslator.FromHtml("#D5CFCA");

                case 2: return ColorTranslator.FromHtml("#9ACCED");
                case 4: return ColorTranslator.FromHtml("#66BFFB");
                case 8: return ColorTranslator.FromHtml("#4386DD");
                case 16: return ColorTranslator.FromHtml("#2946A4");

                case 32: return ColorTranslator.FromHtml("#EDD396");
                case 64: return ColorTranslator.FromHtml("#FFB562");
                case 128: return ColorTranslator.FromHtml("#DB974E");
                case 256: return ColorTranslator.FromHtml("#CF743F");

                case 512: return ColorTranslator.FromHtml("#6ED632");
                case 1024: return ColorTranslator.FromHtml("#00BC33");
                case 2048: return ColorTranslator.FromHtml("#008F00");
                case 4096: return ColorTranslator.FromHtml("#005900");

                case 8192: return ColorTranslator.FromHtml("#FF81B6");
                case 16384: return ColorTranslator.FromHtml("#FF5B70");
                case 32768: return ColorTranslator.FromHtml("#CF3237");
                case 65536: return ColorTranslator.FromHtml("#940205");

                default: return ColorTranslator.FromHtml("#4D6355");
            }
        }


        #region KeyAction

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                CollapseRight();
                MoveRight();
                GenerateNumber();
            }

            if (e.KeyCode == Keys.Left)
            {
                CollapseLeft();
                MoveLeft();
                GenerateNumber();
            }

            if (e.KeyCode == Keys.Up)
            {
                CollapseUp();
                MoveUp();
                GenerateNumber();
            }

            if (e.KeyCode == Keys.Down)
            {
                CollapseDown();
                MoveDown();
                GenerateNumber();
            }
            ShowScore();
        }

        private void MoveRight()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text == string.Empty) //если первая найденная ячейка Пустая, то:
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty) //первая НЕ Пустая найденная ячейка в ряду
                            {
                                var number = int.Parse(labelsMap[i, k].Text);
                                labelsMap[i, j].BackColor = GetColor(number);
                                labelsMap[i, k].BackColor = GetColor();

                                labelsMap[i, j].Text = labelsMap[i, k].Text; // перезаписываем содержимое
                                labelsMap[i, k].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void CollapseRight()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text != string.Empty)  //если первая найденная ячейка НЕ Пустая, то:
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = 2 * int.Parse(labelsMap[i, j].Text);
                                    labelsMap[i, j].BackColor = GetColor(number);
                                    labelsMap[i, k].BackColor = GetColor();

                                    labelsMap[i, j].Text = (number).ToString();
                                    score += number;
                                    labelsMap[i, k].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveLeft()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty) //если первая найденная ячейка Пустая, то:
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty) //первая НЕ Пустая найденная ячейка в ряду
                            {
                                var number = int.Parse(labelsMap[i, k].Text);
                                labelsMap[i, j].BackColor = GetColor(number);
                                labelsMap[i, k].BackColor = GetColor();

                                labelsMap[i, j].Text = labelsMap[i, k].Text; // перезаписываем содержимое
                                labelsMap[i, k].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void CollapseLeft()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text != string.Empty)  //если первая найденная ячейка НЕ Пустая, то:
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)//
                            {
                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)//
                                {
                                    var number = 2 * int.Parse(labelsMap[i, j].Text);
                                    labelsMap[i, j].BackColor = GetColor(number);
                                    labelsMap[i, k].BackColor = GetColor();

                                    labelsMap[i, j].Text = (number).ToString();//
                                    score += number;
                                    labelsMap[i, k].Text = string.Empty;//
                                }
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveUp()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text == string.Empty) //если первая найденная ячейка Пустая, то:
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty) //первая НЕ Пустая найденная ячейка в ряду
                            {
                                var number = int.Parse(labelsMap[k, j].Text);
                                labelsMap[i, j].BackColor = GetColor(number);
                                labelsMap[k, j].BackColor = GetColor();

                                labelsMap[i, j].Text = labelsMap[k, j].Text; // перезаписываем содержимое
                                labelsMap[k, j].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }
        private void CollapseUp()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text != string.Empty) //если первая найденная ячейка НЕ Пустая, то:
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = 2 * int.Parse(labelsMap[i, j].Text);
                                    labelsMap[i, j].BackColor = GetColor(number);
                                    labelsMap[k, j].BackColor = GetColor();

                                    labelsMap[i, j].Text = (number).ToString();
                                    score += number;
                                    labelsMap[k, j].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void MoveDown()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text == string.Empty) //если первая найденная ячейка Пустая, то:
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty) //первая НЕ Пустая найденная ячейка в ряду
                            {
                                var number = int.Parse(labelsMap[k, j].Text);
                                labelsMap[i, j].BackColor = GetColor(number);
                                labelsMap[k, j].BackColor = GetColor();

                                labelsMap[i, j].Text = labelsMap[k, j].Text; // перезаписываем содержимое
                                labelsMap[k, j].Text = string.Empty;
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void CollapseDown()
        {
            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text != string.Empty) //если первая найденная ячейка НЕ Пустая, то:
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = 2 * int.Parse(labelsMap[i, j].Text);
                                    labelsMap[i, j].BackColor = GetColor(number);
                                    labelsMap[k, j].BackColor = GetColor();

                                    labelsMap[i, j].Text = (number).ToString();
                                    score += number;
                                    labelsMap[k, j].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }
                }
            }
        }

        #endregion

        #region Menu

        private void reset_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            if (lastRecords < score)
            {
                NewRecordMessege();
            }
            Application.Restart();
        }

        private void rules_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string text = "1. В каждом раунде появляется плитка номинала 2 (с вероятностью 75 %) " +
                          "или 4(с вероятностью 25 %)\n" +
                          "2. Нажатием стрелки игрок может скинуть все плитки игрового поля в одну" +
                          " из 4 сторон. Если при сбрасывании две плитки одного номинала «налетают» " +
                          "одна на другую, то они превращаются в одну, номинал которой равен сумме " +
                          "соединившихся плиток. После каждого хода на свободной секции поля " +
                          "появляется новая плитка номиналом «2» или «4».\n" +
                          "3. Если в одной строчке или в одном столбце находится более двух плиток " +
                          "одного номинала, то при сбрасывании они начинают соединяться с той стороны, " +
                          "в которую были направлены. \n" +
                          "Например, находящиеся в одной строке плитки (4, 4, 4) после хода влево " +
                          "превратятся в (8, 4), а после хода вправо — в (4, 8). Данная обработка " +
                          "неоднозначности позволяет более точно формировать стратегию игры.\n" +
                          "4. За каждое соединение игровые очки увеличиваются на номинал " +
                          "получившейся плитки.\n" +
                          "5. Игра заканчивается поражением, если после очередного хода невозможно " +
                          "совершить действие.\n";
            MessageBox.Show(text, "Правила игры 2048");
        }

        private void tableRecords_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ResultsTesting = new ResultsTestingForm();
            ResultsTesting.ShowDialog();
        }

        private void exit_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            if (lastRecords < score)
            {
                NewRecordMessege();
            }
            Application.Exit();
        }

        private void scale40_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            _scaleStorage.SetScale(2);
            Application.Restart();
        }
        private void scale60_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            _scaleStorage.SetScale(3);
            Application.Restart();
        }

        private void scale80_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            _scaleStorage.SetScale(4);
            Application.Restart();
        }

        private void scale100_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            _scaleStorage.SetScale(5);
            Application.Restart();
        }

        private void scale120_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            _scaleStorage.SetScale(6);
            Application.Restart();
        }

        private void scale140_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            _scaleStorage.SetScale(7);
            Application.Restart();
        }

        private void scale160_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            _scaleStorage.SetScale(8);
            Application.Restart();
        }

        private void scale180_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            _scaleStorage.SetScale(9);
            Application.Restart();
        }

        private void scale200_toolStripMenuItem_Click(object sender, EventArgs e)
        {
            _scaleStorage.SetScale(10);
            Application.Restart();
        }

        private void sizeField_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            var setMapSizeForm = new SetMapSizeForm();
            var result = setMapSizeForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                var mapSizeNew = int.Parse(setMapSizeForm.inputMapSize_textBox.Text);
                _mapSizeStorage.SetSize(mapSizeNew);
                Application.Restart();
            }
        }

        #endregion
    }
}
