namespace FlowModel
{
    partial class ResearcherView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResearcherView));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.open_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.save_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.export_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.logout_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.exit_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setting_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.help_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.about_ToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.input_GroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.modeInput_GroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.lidSpeed_ParameterInput = new FlowModel.ParameterInput();
            this.lidTemperature_ParameterInput = new FlowModel.ParameterInput();
            this.methodInput_GroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.step_ParameterInput = new FlowModel.ParameterInput();
            this.geometryInput_GroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.length_ParameterInput = new FlowModel.ParameterInput();
            this.depth_ParameterInput = new FlowModel.ParameterInput();
            this.width_ParameterInput = new FlowModel.ParameterInput();
            this.materialInput_GroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.meltingTemperature_ParameterInput = new FlowModel.ParameterInput();
            this.materialCombo_GroupBox = new System.Windows.Forms.GroupBox();
            this.material_ComboBox = new System.Windows.Forms.ComboBox();
            this.heatCapacity_ParameterInput = new FlowModel.ParameterInput();
            this.density_ParameterInput = new FlowModel.ParameterInput();
            this.coefficientInput_GroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.consistencyIndex_ParameterInput = new FlowModel.ParameterInput();
            this.viscosityIndex_ParameterInput = new FlowModel.ParameterInput();
            this.referenceTemperature_ParameterInput = new FlowModel.ParameterInput();
            this.flowIndex_ParameterInput = new FlowModel.ParameterInput();
            this.heatTransferIndex_ParameterInput = new FlowModel.ParameterInput();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.calculate_Button = new System.Windows.Forms.Button();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.menuStrip.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.input_GroupBox.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.modeInput_GroupBox.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.methodInput_GroupBox.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.geometryInput_GroupBox.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.materialInput_GroupBox.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.materialCombo_GroupBox.SuspendLayout();
            this.coefficientInput_GroupBox.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1434, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.open_ToolStrip,
            this.save_ToolStrip,
            this.export_ToolStrip,
            this.logout_ToolStrip,
            this.toolStripMenuItem2,
            this.exit_ToolStrip});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // open_ToolStrip
            // 
            this.open_ToolStrip.Name = "open_ToolStrip";
            this.open_ToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.open_ToolStrip.Size = new System.Drawing.Size(262, 22);
            this.open_ToolStrip.Text = "Открыть историю отчетов";
            // 
            // save_ToolStrip
            // 
            this.save_ToolStrip.Enabled = false;
            this.save_ToolStrip.Name = "save_ToolStrip";
            this.save_ToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.save_ToolStrip.Size = new System.Drawing.Size(262, 22);
            this.save_ToolStrip.Text = "Сохранить";
            this.save_ToolStrip.Visible = false;
            // 
            // export_ToolStrip
            // 
            this.export_ToolStrip.Enabled = false;
            this.export_ToolStrip.Name = "export_ToolStrip";
            this.export_ToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.export_ToolStrip.Size = new System.Drawing.Size(262, 22);
            this.export_ToolStrip.Text = "Экспорт";
            this.export_ToolStrip.Visible = false;
            // 
            // logout_ToolStrip
            // 
            this.logout_ToolStrip.Name = "logout_ToolStrip";
            this.logout_ToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.logout_ToolStrip.Size = new System.Drawing.Size(262, 22);
            this.logout_ToolStrip.Text = "Сменить пользователя";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(259, 6);
            // 
            // exit_ToolStrip
            // 
            this.exit_ToolStrip.Name = "exit_ToolStrip";
            this.exit_ToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exit_ToolStrip.Size = new System.Drawing.Size(262, 22);
            this.exit_ToolStrip.Text = "Выход";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setting_ToolStrip,
            this.helpToolStripMenuItem1,
            this.help_ToolStrip,
            this.about_ToolStrip});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.helpToolStripMenuItem.Text = "Помощь";
            // 
            // setting_ToolStrip
            // 
            this.setting_ToolStrip.Enabled = false;
            this.setting_ToolStrip.Name = "setting_ToolStrip";
            this.setting_ToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.setting_ToolStrip.Size = new System.Drawing.Size(206, 22);
            this.setting_ToolStrip.Text = "Настройки";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(203, 6);
            // 
            // help_ToolStrip
            // 
            this.help_ToolStrip.Enabled = false;
            this.help_ToolStrip.Name = "help_ToolStrip";
            this.help_ToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.help_ToolStrip.Size = new System.Drawing.Size(206, 22);
            this.help_ToolStrip.Text = "Помощь";
            // 
            // about_ToolStrip
            // 
            this.about_ToolStrip.Name = "about_ToolStrip";
            this.about_ToolStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.about_ToolStrip.Size = new System.Drawing.Size(206, 22);
            this.about_ToolStrip.Text = "О программе";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.input_GroupBox, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1434, 487);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // input_GroupBox
            // 
            this.input_GroupBox.Controls.Add(this.tableLayoutPanel2);
            this.input_GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.input_GroupBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.input_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.input_GroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.input_GroupBox.Location = new System.Drawing.Point(3, 3);
            this.input_GroupBox.Name = "input_GroupBox";
            this.input_GroupBox.Size = new System.Drawing.Size(1428, 432);
            this.input_GroupBox.TabIndex = 0;
            this.input_GroupBox.TabStop = false;
            this.input_GroupBox.Text = "Входные параметры процесса";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.geometryInput_GroupBox, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.materialInput_GroupBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.coefficientInput_GroupBox, 3, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 413F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1422, 413);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.modeInput_GroupBox, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.methodInput_GroupBox, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(713, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(349, 407);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // modeInput_GroupBox
            // 
            this.modeInput_GroupBox.Controls.Add(this.tableLayoutPanel8);
            this.modeInput_GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.modeInput_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modeInput_GroupBox.Location = new System.Drawing.Point(3, 3);
            this.modeInput_GroupBox.Name = "modeInput_GroupBox";
            this.modeInput_GroupBox.Size = new System.Drawing.Size(343, 238);
            this.modeInput_GroupBox.TabIndex = 0;
            this.modeInput_GroupBox.TabStop = false;
            this.modeInput_GroupBox.Text = "Режимные параметры процесса";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel8.Controls.Add(this.lidSpeed_ParameterInput, 0, 0);
            this.tableLayoutPanel8.Controls.Add(this.lidTemperature_ParameterInput, 0, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(337, 219);
            this.tableLayoutPanel8.TabIndex = 0;
            // 
            // lidSpeed_ParameterInput
            // 
            this.lidSpeed_ParameterInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lidSpeed_ParameterInput.IsEnabled = true;
            this.lidSpeed_ParameterInput.Location = new System.Drawing.Point(3, 3);
            this.lidSpeed_ParameterInput.MeasurementUnit = "м/с";
            this.lidSpeed_ParameterInput.Name = "lidSpeed_ParameterInput";
            this.lidSpeed_ParameterInput.ParameterName = "Скорость крышки";
            this.lidSpeed_ParameterInput.Size = new System.Drawing.Size(331, 103);
            this.lidSpeed_ParameterInput.TabIndex = 0;
            this.lidSpeed_ParameterInput.TabStop = false;
            this.lidSpeed_ParameterInput.Value = "1,2";
            // 
            // lidTemperature_ParameterInput
            // 
            this.lidTemperature_ParameterInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lidTemperature_ParameterInput.IsEnabled = true;
            this.lidTemperature_ParameterInput.Location = new System.Drawing.Point(3, 112);
            this.lidTemperature_ParameterInput.MeasurementUnit = "°C";
            this.lidTemperature_ParameterInput.Name = "lidTemperature_ParameterInput";
            this.lidTemperature_ParameterInput.ParameterName = "Температура крышки";
            this.lidTemperature_ParameterInput.Size = new System.Drawing.Size(331, 104);
            this.lidTemperature_ParameterInput.TabIndex = 1;
            this.lidTemperature_ParameterInput.TabStop = false;
            this.lidTemperature_ParameterInput.Value = "150";
            // 
            // methodInput_GroupBox
            // 
            this.methodInput_GroupBox.Controls.Add(this.tableLayoutPanel12);
            this.methodInput_GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.methodInput_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.methodInput_GroupBox.Location = new System.Drawing.Point(3, 247);
            this.methodInput_GroupBox.Name = "methodInput_GroupBox";
            this.methodInput_GroupBox.Size = new System.Drawing.Size(343, 157);
            this.methodInput_GroupBox.TabIndex = 1;
            this.methodInput_GroupBox.TabStop = false;
            this.methodInput_GroupBox.Text = "Параметры метода решения";
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel12.Controls.Add(this.step_ParameterInput, 0, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 138F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(337, 138);
            this.tableLayoutPanel12.TabIndex = 0;
            // 
            // step_ParameterInput
            // 
            this.step_ParameterInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.step_ParameterInput.IsEnabled = true;
            this.step_ParameterInput.Location = new System.Drawing.Point(3, 3);
            this.step_ParameterInput.MeasurementUnit = "м";
            this.step_ParameterInput.Name = "step_ParameterInput";
            this.step_ParameterInput.ParameterName = "Шаг расчета по длине канала";
            this.step_ParameterInput.Size = new System.Drawing.Size(331, 132);
            this.step_ParameterInput.TabIndex = 0;
            this.step_ParameterInput.TabStop = false;
            this.step_ParameterInput.Value = "0,1";
            // 
            // geometryInput_GroupBox
            // 
            this.geometryInput_GroupBox.Controls.Add(this.tableLayoutPanel10);
            this.geometryInput_GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.geometryInput_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.geometryInput_GroupBox.Location = new System.Drawing.Point(3, 3);
            this.geometryInput_GroupBox.Name = "geometryInput_GroupBox";
            this.geometryInput_GroupBox.Size = new System.Drawing.Size(349, 407);
            this.geometryInput_GroupBox.TabIndex = 1;
            this.geometryInput_GroupBox.TabStop = false;
            this.geometryInput_GroupBox.Text = "Геометрические параметры канала";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.Controls.Add(this.length_ParameterInput, 0, 2);
            this.tableLayoutPanel10.Controls.Add(this.depth_ParameterInput, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.width_ParameterInput, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 3;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(343, 388);
            this.tableLayoutPanel10.TabIndex = 0;
            // 
            // length_ParameterInput
            // 
            this.length_ParameterInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.length_ParameterInput.IsEnabled = true;
            this.length_ParameterInput.Location = new System.Drawing.Point(3, 261);
            this.length_ParameterInput.MeasurementUnit = "м";
            this.length_ParameterInput.Name = "length_ParameterInput";
            this.length_ParameterInput.ParameterName = "Длина";
            this.length_ParameterInput.Size = new System.Drawing.Size(337, 124);
            this.length_ParameterInput.TabIndex = 1;
            this.length_ParameterInput.TabStop = false;
            this.length_ParameterInput.Value = "4";
            // 
            // depth_ParameterInput
            // 
            this.depth_ParameterInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.depth_ParameterInput.IsEnabled = true;
            this.depth_ParameterInput.Location = new System.Drawing.Point(3, 132);
            this.depth_ParameterInput.MeasurementUnit = "м";
            this.depth_ParameterInput.Name = "depth_ParameterInput";
            this.depth_ParameterInput.ParameterName = "Глубина";
            this.depth_ParameterInput.Size = new System.Drawing.Size(337, 123);
            this.depth_ParameterInput.TabIndex = 2;
            this.depth_ParameterInput.TabStop = false;
            this.depth_ParameterInput.Value = "0,005";
            // 
            // width_ParameterInput
            // 
            this.width_ParameterInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.width_ParameterInput.IsEnabled = true;
            this.width_ParameterInput.Location = new System.Drawing.Point(3, 3);
            this.width_ParameterInput.MeasurementUnit = "м";
            this.width_ParameterInput.Name = "width_ParameterInput";
            this.width_ParameterInput.ParameterName = "Ширина";
            this.width_ParameterInput.Size = new System.Drawing.Size(337, 123);
            this.width_ParameterInput.TabIndex = 3;
            this.width_ParameterInput.TabStop = false;
            this.width_ParameterInput.Value = "0,2";
            // 
            // materialInput_GroupBox
            // 
            this.materialInput_GroupBox.Controls.Add(this.tableLayoutPanel9);
            this.materialInput_GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialInput_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.materialInput_GroupBox.Location = new System.Drawing.Point(358, 3);
            this.materialInput_GroupBox.Name = "materialInput_GroupBox";
            this.materialInput_GroupBox.Size = new System.Drawing.Size(349, 407);
            this.materialInput_GroupBox.TabIndex = 2;
            this.materialInput_GroupBox.TabStop = false;
            this.materialInput_GroupBox.Text = "Параметры свойств материала";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.Controls.Add(this.meltingTemperature_ParameterInput, 0, 3);
            this.tableLayoutPanel9.Controls.Add(this.materialCombo_GroupBox, 0, 0);
            this.tableLayoutPanel9.Controls.Add(this.heatCapacity_ParameterInput, 0, 2);
            this.tableLayoutPanel9.Controls.Add(this.density_ParameterInput, 0, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 4;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.66667F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.66667F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.66667F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(343, 388);
            this.tableLayoutPanel9.TabIndex = 0;
            // 
            // meltingTemperature_ParameterInput
            // 
            this.meltingTemperature_ParameterInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.meltingTemperature_ParameterInput.IsEnabled = false;
            this.meltingTemperature_ParameterInput.Location = new System.Drawing.Point(3, 286);
            this.meltingTemperature_ParameterInput.MeasurementUnit = "°C";
            this.meltingTemperature_ParameterInput.Name = "meltingTemperature_ParameterInput";
            this.meltingTemperature_ParameterInput.ParameterName = "Температура плавления";
            this.meltingTemperature_ParameterInput.Size = new System.Drawing.Size(337, 99);
            this.meltingTemperature_ParameterInput.TabIndex = 2;
            this.meltingTemperature_ParameterInput.TabStop = false;
            this.meltingTemperature_ParameterInput.Value = "";
            // 
            // materialCombo_GroupBox
            // 
            this.materialCombo_GroupBox.Controls.Add(this.material_ComboBox);
            this.materialCombo_GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialCombo_GroupBox.Location = new System.Drawing.Point(3, 3);
            this.materialCombo_GroupBox.Name = "materialCombo_GroupBox";
            this.materialCombo_GroupBox.Size = new System.Drawing.Size(337, 71);
            this.materialCombo_GroupBox.TabIndex = 1;
            this.materialCombo_GroupBox.TabStop = false;
            this.materialCombo_GroupBox.Text = "Выбор материала";
            // 
            // material_ComboBox
            // 
            this.material_ComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.material_ComboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.material_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.material_ComboBox.FormattingEnabled = true;
            this.material_ComboBox.Location = new System.Drawing.Point(3, 16);
            this.material_ComboBox.Name = "material_ComboBox";
            this.material_ComboBox.Size = new System.Drawing.Size(331, 21);
            this.material_ComboBox.TabIndex = 0;
            this.material_ComboBox.TabStop = false;
            // 
            // heatCapacity_ParameterInput
            // 
            this.heatCapacity_ParameterInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heatCapacity_ParameterInput.IsEnabled = false;
            this.heatCapacity_ParameterInput.Location = new System.Drawing.Point(3, 183);
            this.heatCapacity_ParameterInput.MeasurementUnit = "Дж/(кг⋅°C)";
            this.heatCapacity_ParameterInput.Name = "heatCapacity_ParameterInput";
            this.heatCapacity_ParameterInput.ParameterName = "Удельная теплоемкость";
            this.heatCapacity_ParameterInput.Size = new System.Drawing.Size(337, 97);
            this.heatCapacity_ParameterInput.TabIndex = 1;
            this.heatCapacity_ParameterInput.TabStop = false;
            this.heatCapacity_ParameterInput.Value = "";
            // 
            // density_ParameterInput
            // 
            this.density_ParameterInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.density_ParameterInput.IsEnabled = false;
            this.density_ParameterInput.Location = new System.Drawing.Point(3, 80);
            this.density_ParameterInput.MeasurementUnit = "кг/м^3";
            this.density_ParameterInput.Name = "density_ParameterInput";
            this.density_ParameterInput.ParameterName = "Плотность";
            this.density_ParameterInput.Size = new System.Drawing.Size(337, 97);
            this.density_ParameterInput.TabIndex = 0;
            this.density_ParameterInput.TabStop = false;
            this.density_ParameterInput.Value = "";
            // 
            // coefficientInput_GroupBox
            // 
            this.coefficientInput_GroupBox.Controls.Add(this.tableLayoutPanel11);
            this.coefficientInput_GroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.coefficientInput_GroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.coefficientInput_GroupBox.Location = new System.Drawing.Point(1068, 3);
            this.coefficientInput_GroupBox.Name = "coefficientInput_GroupBox";
            this.coefficientInput_GroupBox.Size = new System.Drawing.Size(351, 407);
            this.coefficientInput_GroupBox.TabIndex = 3;
            this.coefficientInput_GroupBox.TabStop = false;
            this.coefficientInput_GroupBox.Text = "Эмпирические коэффициенты математической модели";
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel11.Controls.Add(this.consistencyIndex_ParameterInput, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.viscosityIndex_ParameterInput, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.referenceTemperature_ParameterInput, 0, 2);
            this.tableLayoutPanel11.Controls.Add(this.flowIndex_ParameterInput, 0, 3);
            this.tableLayoutPanel11.Controls.Add(this.heatTransferIndex_ParameterInput, 0, 4);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 5;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(345, 388);
            this.tableLayoutPanel11.TabIndex = 0;
            // 
            // consistencyIndex_ParameterInput
            // 
            this.consistencyIndex_ParameterInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.consistencyIndex_ParameterInput.IsEnabled = true;
            this.consistencyIndex_ParameterInput.Location = new System.Drawing.Point(3, 3);
            this.consistencyIndex_ParameterInput.MeasurementUnit = "Па⋅с^n";
            this.consistencyIndex_ParameterInput.Name = "consistencyIndex_ParameterInput";
            this.consistencyIndex_ParameterInput.ParameterName = "Коэффициент консистенции при температуре приведения";
            this.consistencyIndex_ParameterInput.Size = new System.Drawing.Size(339, 71);
            this.consistencyIndex_ParameterInput.TabIndex = 0;
            this.consistencyIndex_ParameterInput.TabStop = false;
            this.consistencyIndex_ParameterInput.Value = "";
            // 
            // viscosityIndex_ParameterInput
            // 
            this.viscosityIndex_ParameterInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viscosityIndex_ParameterInput.IsEnabled = true;
            this.viscosityIndex_ParameterInput.Location = new System.Drawing.Point(3, 80);
            this.viscosityIndex_ParameterInput.MeasurementUnit = "1/°C";
            this.viscosityIndex_ParameterInput.Name = "viscosityIndex_ParameterInput";
            this.viscosityIndex_ParameterInput.ParameterName = "Температурный коэффициент вязкости";
            this.viscosityIndex_ParameterInput.Size = new System.Drawing.Size(339, 71);
            this.viscosityIndex_ParameterInput.TabIndex = 1;
            this.viscosityIndex_ParameterInput.TabStop = false;
            this.viscosityIndex_ParameterInput.Value = "";
            // 
            // referenceTemperature_ParameterInput
            // 
            this.referenceTemperature_ParameterInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.referenceTemperature_ParameterInput.IsEnabled = true;
            this.referenceTemperature_ParameterInput.Location = new System.Drawing.Point(3, 157);
            this.referenceTemperature_ParameterInput.MeasurementUnit = "°C";
            this.referenceTemperature_ParameterInput.Name = "referenceTemperature_ParameterInput";
            this.referenceTemperature_ParameterInput.ParameterName = "Температура приведения";
            this.referenceTemperature_ParameterInput.Size = new System.Drawing.Size(339, 71);
            this.referenceTemperature_ParameterInput.TabIndex = 2;
            this.referenceTemperature_ParameterInput.TabStop = false;
            this.referenceTemperature_ParameterInput.Value = "";
            // 
            // flowIndex_ParameterInput
            // 
            this.flowIndex_ParameterInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowIndex_ParameterInput.IsEnabled = true;
            this.flowIndex_ParameterInput.Location = new System.Drawing.Point(3, 234);
            this.flowIndex_ParameterInput.MeasurementUnit = "";
            this.flowIndex_ParameterInput.Name = "flowIndex_ParameterInput";
            this.flowIndex_ParameterInput.ParameterName = "Индекс течения";
            this.flowIndex_ParameterInput.Size = new System.Drawing.Size(339, 71);
            this.flowIndex_ParameterInput.TabIndex = 3;
            this.flowIndex_ParameterInput.TabStop = false;
            this.flowIndex_ParameterInput.Value = "";
            // 
            // heatTransferIndex_ParameterInput
            // 
            this.heatTransferIndex_ParameterInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.heatTransferIndex_ParameterInput.IsEnabled = true;
            this.heatTransferIndex_ParameterInput.Location = new System.Drawing.Point(3, 311);
            this.heatTransferIndex_ParameterInput.MeasurementUnit = "Вт/(м^2⋅°C)";
            this.heatTransferIndex_ParameterInput.Name = "heatTransferIndex_ParameterInput";
            this.heatTransferIndex_ParameterInput.ParameterName = "Коэффициент теплоотдачи от крышки канала к материалу";
            this.heatTransferIndex_ParameterInput.Size = new System.Drawing.Size(339, 74);
            this.heatTransferIndex_ParameterInput.TabIndex = 4;
            this.heatTransferIndex_ParameterInput.TabStop = false;
            this.heatTransferIndex_ParameterInput.Value = "";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel4.Controls.Add(this.calculate_Button, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.progressBar, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 441);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1428, 43);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // calculate_Button
            // 
            this.calculate_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calculate_Button.Location = new System.Drawing.Point(3, 3);
            this.calculate_Button.Name = "calculate_Button";
            this.calculate_Button.Size = new System.Drawing.Size(136, 37);
            this.calculate_Button.TabIndex = 0;
            this.calculate_Button.Text = "Рассчитать";
            this.calculate_Button.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar.Location = new System.Drawing.Point(145, 3);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1280, 37);
            this.progressBar.TabIndex = 1;
            // 
            // ResearcherView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 511);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1450, 550);
            this.Name = "ResearcherView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Исследователь";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.input_GroupBox.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.modeInput_GroupBox.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.methodInput_GroupBox.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.geometryInput_GroupBox.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.materialInput_GroupBox.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.materialCombo_GroupBox.ResumeLayout(false);
            this.coefficientInput_GroupBox.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem open_ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem save_ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem export_ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem exit_ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setting_ToolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem help_ToolStrip;
        private System.Windows.Forms.ToolStripMenuItem about_ToolStrip;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox input_GroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox modeInput_GroupBox;
        private System.Windows.Forms.GroupBox methodInput_GroupBox;
        private System.Windows.Forms.GroupBox geometryInput_GroupBox;
        private System.Windows.Forms.GroupBox materialInput_GroupBox;
        private System.Windows.Forms.GroupBox coefficientInput_GroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private ParameterInput lidSpeed_ParameterInput;
        private ParameterInput lidTemperature_ParameterInput;
        private ParameterInput consistencyIndex_ParameterInput;
        private ParameterInput viscosityIndex_ParameterInput;
        private ParameterInput referenceTemperature_ParameterInput;
        private ParameterInput flowIndex_ParameterInput;
        private ParameterInput heatTransferIndex_ParameterInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private ParameterInput length_ParameterInput;
        private ParameterInput depth_ParameterInput;
        private ParameterInput width_ParameterInput;
        private ParameterInput density_ParameterInput;
        private ParameterInput heatCapacity_ParameterInput;
        private ParameterInput meltingTemperature_ParameterInput;
        private ParameterInput step_ParameterInput;
        private System.Windows.Forms.GroupBox materialCombo_GroupBox;
        private System.Windows.Forms.ComboBox material_ComboBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button calculate_Button;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.ToolStripMenuItem logout_ToolStrip;
    }
}

