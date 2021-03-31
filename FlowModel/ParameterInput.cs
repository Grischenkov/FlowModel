using System;
using System.Drawing;
using System.Text.RegularExpressions;
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

        private void DoubleInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.' && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }

        private void Validate(object sender, EventArgs e)
        {
            Value = Value.Replace('.', ',');
            var doubleRegular = new Regex(@"^-?[0-9]+(?:\,[0-9]*)?$");
            if (doubleRegular.IsMatch(Value)) return;
            value_TextBox.BackColor = Color.Red;
        }

        private void Clear(object sender, EventArgs e)
        {
            if (value_TextBox.Enabled)
            {
                value_TextBox.BackColor = Color.White;
            }
        }
    }
}