using System;
using System.Windows.Forms;
using FlowModel.Presenter.Views.HistoryView;

namespace FlowModel
{
    public partial class HistoryView : Form, IHistoryView
    {
        public string ReportId { get; set; }
        public string ReportDate { get; set; }
        public string ReportName { get; set; }
        
        public event Action SelectReport;
        
        public HistoryView()
        {
            //reports_DataGridView.CellDoubleClick += (sender, args) => Action(SelectReport);
            InitializeComponent();
        }
        
        public new void Show()
        {
            ShowDialog();
        }

        public void ShowError(string errorMessage)
        {
            MessageBox.Show(errorMessage, @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ShowWarning(string warningMessage)
        {
            MessageBox.Show(warningMessage, @"Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void ShowSuccess(string successMessage)
        {
            MessageBox.Show(successMessage, @"Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void ReportsRecordSelect(object sender, DataGridViewCellEventArgs e)
        {
            if (reports_DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) return;
            ReportId = reports_DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            ReportDate = reports_DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            ReportName = reports_DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            Action(SelectReport);
        }
        public void FillReportsRecords(string[][] records)
        {
            reports_DataGridView.RowCount = 0;
            reports_DataGridView.RowCount = records.Length + 1;
            if (records.Length == 0) return;
            for (var i = 0; i < records.Length; i++)
            {
                reports_DataGridView.Rows[i].Cells[0].Value = records[i][0];
                reports_DataGridView.Rows[i].Cells[1].Value = records[i][1];
                reports_DataGridView.Rows[i].Cells[2].Value = records[i][2];
            }
        }
        
        private void Action(Action action)
        {
            try
            {
                action?.Invoke();
            }
            catch (Exception e)
            {
                ShowError(e.Message);
            }
        }
    }
}