using System;
using System.Windows.Forms;
using _2048.Common;

namespace _2048WinFormsApp
{
    public partial class ResultsTestingForm : Form
    {
        private RecordsStorage _recordsStorage = new();
        public ResultsTestingForm()
        {
            InitializeComponent();
        }

        private void Results_Load(object sender, EventArgs e)
        {
            var results = _recordsStorage.GetRecords();
            foreach (var result in results)
            {
                resultsDataGridView.Rows.Add(result.Name,result.MapSize, result.Score, result.Data.ToLocalTime());
            }
        }
    }
}
