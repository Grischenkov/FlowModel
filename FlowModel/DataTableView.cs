﻿using System.Windows.Forms;
using FlowModel.Presenter.Views.AddDataTable;

namespace FlowModel
{
    public partial class DataTableView : Form, IDataTableView
    {
        public DataTableView()
        {
            InitializeComponent();
        }
        
        public void DrawTable(double[,] table)
        {
            for (int i = 0, j = 0; i < table.Length; i++)
            {
                dataGridView.RowCount = j + 1;
                dataGridView.Rows[j].Cells[0].Value = table[i,0].ToString();
                dataGridView.Rows[j].Cells[1].Value = table[i,1].ToString();
                dataGridView.Rows[j].Cells[1].Value = table[i,2].ToString();
                j++;
            }
        }
        
        public new void Show()
        {
            ShowDialog();
        }

        public void ShowError(string errorMessage)
        {
            throw new System.NotImplementedException();
        }

        public void ShowWarning(string warningMessage)
        {
            throw new System.NotImplementedException();
        }

        public void ShowSuccess(string successMessage)
        {
            throw new System.NotImplementedException();
        }
    }
    
}