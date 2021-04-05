using System;
using System.Windows.Forms;
using FlowModel.Presenter.Views.ResearcherView;

namespace FlowModel
{
    public partial class ResearcherView : Form, IResearcherView
    {
        public string MaterialItem
        {
            get => material_ComboBox.SelectedItem.ToString(); 
            set => material_ComboBox.Items.Add(value);
        }
        public string MaterialSelectedItem 
        {
            get => material_ComboBox.SelectedItem == null ? "" : material_ComboBox.SelectedItem.ToString();
            set => material_ComboBox.SelectedItem = value;
        }

        public new string Width => width_ParameterInput.Value;
        public string Depth => depth_ParameterInput.Value;
        public string Length => length_ParameterInput.Value;

        public string Density
        {
            get => density_ParameterInput.Value; 
            set => density_ParameterInput.Value = value;
        }
        public string HeatCapacity
        {
            get => heatCapacity_ParameterInput.Value; 
            set => heatCapacity_ParameterInput.Value = value;
        }
        public string MeltingTemperature
        {
            get => meltingTemperature_ParameterInput.Value; 
            set => meltingTemperature_ParameterInput.Value = value;
        }

        public string LidSpeed => lidSpeed_ParameterInput.Value;
        public string LidTemperature => lidTemperature_ParameterInput.Value;

        public string Step => step_ParameterInput.Value;

        public string FlowIndex { get; set; }
        public string ViscosityIndex { get; set; }
        public string ConsistencyIndex { get; set; }
        public string HeatTransferIndex { get; set; }
        public string ReferenceTemperature { get; set; }

        public string Viscosity
        {
            set => viscosity_Label.Text = value;
        }
        public string Temperature
        {
            set => temperature_Label.Text = value;
        }
        public string Performance
        {
            set => performance_Label.Text = value;
        }

        public string Time
        {
            set => time_Label.Text = value;
        }
        public string Memory
        {
            set => memory_Label.Text = value;
        }
        
        public ResearcherView()
        {
            InitializeComponent();

            open_ToolStrip.Click += (sender, args) => Action(Open);
            save_ToolStrip.Click += (sender, args) => Action(Save);
            exit_ToolStrip.Click += (sender, args) => Action(Exit);
            export_ToolStrip.Click += (sender, args) => Action(Export);

            help_ToolStrip.Click += (sender, args) => Action(Help);
            about_ToolStrip.Click += (sender, args) => Action(About);
            setting_ToolStrip.Click += (sender, args) => Action(Settings);

            calculate_Button.Click += (sender, args) => Action(Calculate);

            showValueTable_Button.Click += (sender, args) => Action(ShowValueTable);
            showViscosityChart_Button.Click += (sender, args) => Action(ShowViscosityChart);
            showTemperatureChart_Button.Click += (sender, args) => Action(ShowTemperatureChart);
        }
        
        public new void Show()
        {
            Application.Run(this);
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
        
        public event Action Open;
        public event Action Save;
        public event Action Export;
        public event Action Exit;
        
        public event Action Help;
        public event Action About;
        public event Action Settings;
        
        public event Action Calculate;
        
        public event Action ShowValueTable;
        public event Action ShowViscosityChart;
        public event Action ShowTemperatureChart;

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
