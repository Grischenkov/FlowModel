using System.ComponentModel;

namespace FlowModel
{
    partial class HistoryView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.reports_DataGridView = new System.Windows.Forms.DataGridView();
            this.reportId_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportDate_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportName_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.reports_DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.reports_DataGridView, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 461F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(634, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // reports_DataGridView
            // 
            this.reports_DataGridView.AllowUserToAddRows = false;
            this.reports_DataGridView.AllowUserToDeleteRows = false;
            this.reports_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reports_DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {this.reportId_Column, this.reportDate_Column, this.reportName_Column});
            this.reports_DataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reports_DataGridView.Location = new System.Drawing.Point(3, 3);
            this.reports_DataGridView.Name = "reports_DataGridView";
            this.reports_DataGridView.ReadOnly = true;
            this.reports_DataGridView.Size = new System.Drawing.Size(628, 455);
            this.reports_DataGridView.TabIndex = 4;
            this.reports_DataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ReportsRecordSelect);
            // 
            // reportId_Column
            // 
            this.reportId_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reportId_Column.HeaderText = "Id";
            this.reportId_Column.Name = "reportId_Column";
            this.reportId_Column.ReadOnly = true;
            // 
            // reportDate_Column
            // 
            this.reportDate_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reportDate_Column.HeaderText = "Дата";
            this.reportDate_Column.Name = "reportDate_Column";
            this.reportDate_Column.ReadOnly = true;
            // 
            // reportName_Column
            // 
            this.reportName_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reportName_Column.HeaderText = "Имя";
            this.reportName_Column.Name = "reportName_Column";
            this.reportName_Column.ReadOnly = true;
            // 
            // HistoryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HistoryView";
            this.Text = "История отчетов";
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.reports_DataGridView)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView reports_DataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportId_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportDate_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportName_Column;
    }
}