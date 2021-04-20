using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlowModel.Presenter;
using FlowModel.Presenter.Views.ResearcherView;

namespace FlowModel
{
    public partial class ResearcherView : Form, IResearcherView
    {
        private readonly ApplicationContext _context;
        
        public bool IsProcessing
        {
            set
            {
                progressBar.Visible = value;
                progressBar.MarqueeAnimationSpeed = value ? 1 : 0;
            }
        }

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

        public new IParameterInput Width => width_ParameterInput;
        public IParameterInput Depth => depth_ParameterInput;
        public IParameterInput Length => length_ParameterInput;

        public IParameterInput Density
        {
            get => density_ParameterInput;
            set => density_ParameterInput.Value = value.Value;
        }

        public IParameterInput HeatCapacity
        {
            get => heatCapacity_ParameterInput;
            set => heatCapacity_ParameterInput.Value = value.Value;
        }

        public IParameterInput MeltingTemperature
        {
            get => meltingTemperature_ParameterInput;
            set => meltingTemperature_ParameterInput.Value = value.Value;
        }

        public IParameterInput LidSpeed => lidSpeed_ParameterInput;
        public IParameterInput LidTemperature => lidTemperature_ParameterInput;

        public IParameterInput Step
        {
            get => step_ParameterInput;
            set => step_ParameterInput.Value = value.Value;
        }

        public IParameterInput FlowIndex
        {
            get => flowIndex_ParameterInput;
            set => flowIndex_ParameterInput.Value = value.Value;
        }

        public IParameterInput ViscosityIndex
        {
            get => viscosityIndex_ParameterInput;
            set => viscosityIndex_ParameterInput.Value = value.Value;
        }

        public IParameterInput ConsistencyIndex
        {
            get => consistencyIndex_ParameterInput;
            set => consistencyIndex_ParameterInput.Value = value.Value;
        }

        public IParameterInput HeatTransferIndex
        {
            get => heatTransferIndex_ParameterInput;
            set => heatTransferIndex_ParameterInput.Value = value.Value;
        }

        public IParameterInput ReferenceTemperature
        {
            get => referenceTemperature_ParameterInput;
            set => referenceTemperature_ParameterInput.Value = value.Value;
        }

        public ResearcherView(ApplicationContext context)
        {
            _context = context;
            
            InitializeComponent();

            progressBar.Style = ProgressBarStyle.Marquee;
            progressBar.MarqueeAnimationSpeed = 0;
            progressBar.Visible = false;

            open_ToolStrip.Click += (sender, args) => Action(Open);
            save_ToolStrip.Click += (sender, args) => Action(Save);
            exit_ToolStrip.Click += (sender, args) => Action(Exit);
            export_ToolStrip.Click += (sender, args) => Action(Export);

            help_ToolStrip.Click += (sender, args) => Action(Help);
            about_ToolStrip.Click += (sender, args) => Action(About);
            setting_ToolStrip.Click += (sender, args) => Action(Settings);

            material_ComboBox.SelectedIndexChanged += (sender, args) => Action(SelectMaterial);

            calculate_Button.Click += (sender, args) => Action(Calculate);
        }

        public new void Show()
        {
            _context.MainForm = this;
            base.Show();
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

        public event Action SelectMaterial;

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