namespace FlowModel
{
    sealed partial class ReportView
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Coordinate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Viscosity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.viscosity_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.temperature_Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.memoryOutput_GroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.memory_Label = new System.Windows.Forms.Label();
            this.viscosityOutput_GroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.viscosity_Label = new System.Windows.Forms.Label();
            this.temperatureOutput_GroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.temperature_Label = new System.Windows.Forms.Label();
            this.performanceOutput_GroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.performance_Label = new System.Windows.Forms.Label();
            this.timeOutput_GroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.time_Label = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viscosity_Chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperature_Chart)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.memoryOutput_GroupBox.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            this.viscosityOutput_GroupBox.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.temperatureOutput_GroupBox.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.performanceOutput_GroupBox.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.timeOutput_GroupBox.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1134, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 95);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1128, 363);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Coordinate,
            this.Temperature,
            this.Viscosity});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 3);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.Size = new System.Drawing.Size(445, 357);
            this.dataGridView.TabIndex = 1;
            // 
            // Coordinate
            // 
            this.Coordinate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Coordinate.HeaderText = "Координата, м";
            this.Coordinate.Name = "Coordinate";
            this.Coordinate.ReadOnly = true;
            // 
            // Temperature
            // 
            this.Temperature.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Temperature.HeaderText = "Температура, °C";
            this.Temperature.Name = "Temperature";
            this.Temperature.ReadOnly = true;
            // 
            // Viscosity
            // 
            this.Viscosity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Viscosity.HeaderText = "Вязкость, Па*с";
            this.Viscosity.Name = "Viscosity";
            this.Viscosity.ReadOnly = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.viscosity_Chart, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.temperature_Chart, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(454, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(671, 357);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // viscosity_Chart
            // 
            chartArea3.Name = "ChartArea1";
            this.viscosity_Chart.ChartAreas.Add(chartArea3);
            this.viscosity_Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.viscosity_Chart.Legends.Add(legend3);
            this.viscosity_Chart.Location = new System.Drawing.Point(3, 181);
            this.viscosity_Chart.Name = "viscosity_Chart";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.viscosity_Chart.Series.Add(series3);
            this.viscosity_Chart.Size = new System.Drawing.Size(665, 173);
            this.viscosity_Chart.TabIndex = 2;
            this.viscosity_Chart.Text = "chart1";
            // 
            // temperature_Chart
            // 
            chartArea4.Name = "ChartArea1";
            this.temperature_Chart.ChartAreas.Add(chartArea4);
            this.temperature_Chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend4.Name = "Legend1";
            this.temperature_Chart.Legends.Add(legend4);
            this.temperature_Chart.Location = new System.Drawing.Point(3, 3);
            this.temperature_Chart.Name = "temperature_Chart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.temperature_Chart.Series.Add(series4);
            this.temperature_Chart.Size = new System.Drawing.Size(665, 172);
            this.temperature_Chart.TabIndex = 1;
            this.temperature_Chart.Text = "chart";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.memoryOutput_GroupBox, 4, 0);
            this.tableLayoutPanel4.Controls.Add(this.viscosityOutput_GroupBox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.temperatureOutput_GroupBox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.performanceOutput_GroupBox, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.timeOutput_GroupBox, 3, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1128, 86);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // memoryOutput_GroupBox
            // 
            this.memoryOutput_GroupBox.Controls.Add(this.tableLayoutPanel18);
            this.memoryOutput_GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoryOutput_GroupBox.Location = new System.Drawing.Point(903, 3);
            this.memoryOutput_GroupBox.Name = "memoryOutput_GroupBox";
            this.memoryOutput_GroupBox.Size = new System.Drawing.Size(222, 80);
            this.memoryOutput_GroupBox.TabIndex = 5;
            this.memoryOutput_GroupBox.TabStop = false;
            this.memoryOutput_GroupBox.Text = "Оперативная память [Кб]";
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.ColumnCount = 1;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel18.Controls.Add(this.memory_Label, 0, 0);
            this.tableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel18.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 1;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(216, 61);
            this.tableLayoutPanel18.TabIndex = 0;
            // 
            // memory_Label
            // 
            this.memory_Label.AutoSize = true;
            this.memory_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memory_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.memory_Label.Location = new System.Drawing.Point(3, 0);
            this.memory_Label.Name = "memory_Label";
            this.memory_Label.Size = new System.Drawing.Size(210, 61);
            this.memory_Label.TabIndex = 0;
            this.memory_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // viscosityOutput_GroupBox
            // 
            this.viscosityOutput_GroupBox.Controls.Add(this.tableLayoutPanel13);
            this.viscosityOutput_GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viscosityOutput_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viscosityOutput_GroupBox.Location = new System.Drawing.Point(228, 3);
            this.viscosityOutput_GroupBox.Name = "viscosityOutput_GroupBox";
            this.viscosityOutput_GroupBox.Size = new System.Drawing.Size(219, 80);
            this.viscosityOutput_GroupBox.TabIndex = 3;
            this.viscosityOutput_GroupBox.TabStop = false;
            this.viscosityOutput_GroupBox.Text = "Вязкость [Па⋅с]";
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel13.Controls.Add(this.viscosity_Label, 0, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 1;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(213, 61);
            this.tableLayoutPanel13.TabIndex = 0;
            // 
            // viscosity_Label
            // 
            this.viscosity_Label.AutoSize = true;
            this.viscosity_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viscosity_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.viscosity_Label.Location = new System.Drawing.Point(3, 0);
            this.viscosity_Label.Name = "viscosity_Label";
            this.viscosity_Label.Size = new System.Drawing.Size(207, 61);
            this.viscosity_Label.TabIndex = 0;
            this.viscosity_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // temperatureOutput_GroupBox
            // 
            this.temperatureOutput_GroupBox.Controls.Add(this.tableLayoutPanel14);
            this.temperatureOutput_GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temperatureOutput_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.temperatureOutput_GroupBox.Location = new System.Drawing.Point(453, 3);
            this.temperatureOutput_GroupBox.Name = "temperatureOutput_GroupBox";
            this.temperatureOutput_GroupBox.Size = new System.Drawing.Size(219, 80);
            this.temperatureOutput_GroupBox.TabIndex = 2;
            this.temperatureOutput_GroupBox.TabStop = false;
            this.temperatureOutput_GroupBox.Text = "Температура [°C]";
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 1;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel14.Controls.Add(this.temperature_Label, 0, 0);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 1;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(213, 61);
            this.tableLayoutPanel14.TabIndex = 0;
            // 
            // temperature_Label
            // 
            this.temperature_Label.AutoSize = true;
            this.temperature_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.temperature_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.temperature_Label.Location = new System.Drawing.Point(3, 0);
            this.temperature_Label.Name = "temperature_Label";
            this.temperature_Label.Size = new System.Drawing.Size(207, 61);
            this.temperature_Label.TabIndex = 0;
            this.temperature_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // performanceOutput_GroupBox
            // 
            this.performanceOutput_GroupBox.Controls.Add(this.tableLayoutPanel15);
            this.performanceOutput_GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.performanceOutput_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.performanceOutput_GroupBox.Location = new System.Drawing.Point(3, 3);
            this.performanceOutput_GroupBox.Name = "performanceOutput_GroupBox";
            this.performanceOutput_GroupBox.Size = new System.Drawing.Size(219, 80);
            this.performanceOutput_GroupBox.TabIndex = 1;
            this.performanceOutput_GroupBox.TabStop = false;
            this.performanceOutput_GroupBox.Text = "Производительность [кг/ч]";
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 1;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel15.Controls.Add(this.performance_Label, 0, 0);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 1;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(213, 61);
            this.tableLayoutPanel15.TabIndex = 0;
            // 
            // performance_Label
            // 
            this.performance_Label.AutoSize = true;
            this.performance_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.performance_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.performance_Label.Location = new System.Drawing.Point(3, 0);
            this.performance_Label.Name = "performance_Label";
            this.performance_Label.Size = new System.Drawing.Size(207, 61);
            this.performance_Label.TabIndex = 0;
            this.performance_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeOutput_GroupBox
            // 
            this.timeOutput_GroupBox.Controls.Add(this.tableLayoutPanel17);
            this.timeOutput_GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timeOutput_GroupBox.Location = new System.Drawing.Point(678, 3);
            this.timeOutput_GroupBox.Name = "timeOutput_GroupBox";
            this.timeOutput_GroupBox.Size = new System.Drawing.Size(219, 80);
            this.timeOutput_GroupBox.TabIndex = 4;
            this.timeOutput_GroupBox.TabStop = false;
            this.timeOutput_GroupBox.Text = "Время работы [мс]";
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.ColumnCount = 1;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel17.Controls.Add(this.time_Label, 0, 0);
            this.tableLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel17.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 1;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(213, 61);
            this.tableLayoutPanel17.TabIndex = 0;
            // 
            // time_Label
            // 
            this.time_Label.AutoSize = true;
            this.time_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.time_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.time_Label.Location = new System.Drawing.Point(3, 0);
            this.time_Label.Name = "time_Label";
            this.time_Label.Size = new System.Drawing.Size(207, 61);
            this.time_Label.TabIndex = 0;
            this.time_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(1150, 500);
            this.Name = "ReportView";
            this.Text = "ReportView";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.viscosity_Chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.temperature_Chart)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.memoryOutput_GroupBox.ResumeLayout(false);
            this.tableLayoutPanel18.ResumeLayout(false);
            this.tableLayoutPanel18.PerformLayout();
            this.viscosityOutput_GroupBox.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.temperatureOutput_GroupBox.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.tableLayoutPanel14.PerformLayout();
            this.performanceOutput_GroupBox.ResumeLayout(false);
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel15.PerformLayout();
            this.timeOutput_GroupBox.ResumeLayout(false);
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel17.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.GroupBox performanceOutput_GroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.Label performance_Label;
        private System.Windows.Forms.GroupBox temperatureOutput_GroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.Label temperature_Label;
        private System.Windows.Forms.GroupBox viscosityOutput_GroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.Label viscosity_Label;
        private System.Windows.Forms.GroupBox timeOutput_GroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.Label time_Label;
        private System.Windows.Forms.GroupBox memoryOutput_GroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel18;
        private System.Windows.Forms.Label memory_Label;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coordinate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Temperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn Viscosity;
        private System.Windows.Forms.DataVisualization.Charting.Chart viscosity_Chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart temperature_Chart;
    }
}