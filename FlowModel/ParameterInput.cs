using System.Windows.Forms;

namespace FlowModel
{
    public partial class ParameterInput : UserControl
    {
        public string MesuarmentUnit { get => unit_Label.Text; set => unit_Label.Text = value; }
        public string ParameterName { get => name_Label.Text; set => name_Label.Text = value; }
        public string Value { get => value_TextBox.Text; set => value_TextBox.Text = value; }

        public bool IsEnabled { get => value_TextBox.Enabled; set => value_TextBox.Enabled = value; }

        public ParameterInput()
        {
            InitializeComponent();
        }
    }
}