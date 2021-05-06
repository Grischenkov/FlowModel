using System;
using System.Windows.Forms;
using FlowModel.Presenter.Views.AdministratorView;

namespace FlowModel
{
    public partial class AdministratorView : Form, IAdministratorView
    {
        private readonly ApplicationContext _context;
        
        public string MaterialId
        {
            get => materialId_TextBox.Text;
            set => materialId_TextBox.Text = value;
        }
        public string MaterialName
        {
            get => materialName_TextBox.Text;
            set => materialName_TextBox.Text = value;
        }
        public event Action AddMaterial;
        public event Action DeleteMaterial;


        public string MaterialParametersId
        {
            get => materialParametersId_TextBox.Text; 
            set => materialParametersId_TextBox.Text = value;
        }
        public string MaterialItem
        {
            get => material_ComboBox.SelectedItem.ToString();
            set => material_ComboBox.Items.Add(value);
        }
        public void MaterialItemsClear() {material_ComboBox.Items.Clear();}
        public string MaterialParametersMaterial
        {
            get => material_ComboBox.SelectedItem.ToString();
            set => material_ComboBox.SelectedItem = value;
        }
        public string ParameterItem
        {
            get => parameter_ComboBox.SelectedItem.ToString();
            set => parameter_ComboBox.Items.Add(value);
        }
        public void ParameterItemsClear() {parameter_ComboBox.Items.Clear();}
        public string MaterialParametersParameter
        {
            get => parameter_ComboBox.SelectedItem.ToString(); 
            set => parameter_ComboBox.SelectedItem = value;
        }
        public string ParameterValue
        {
            get => parameterValue_TextBox.Text; 
            set => parameterValue_TextBox.Text = value;
        }
        public event Action AddMaterialParameter;
        public event Action DeleteMaterialParameter;


        public string ParameterId
        {
            get => parameterId_TextBox.Text; 
            set => parameterId_TextBox.Text = value;
        }
        public string ParameterName
        {
            get => parameterName_TextBox.Text;
            set => parameterName_TextBox.Text = value;
        }
        public string TypeItem
        {
            get => parameterType_ComboBox.SelectedItem.ToString();
            set => parameterType_ComboBox.Items.Add(value);
        }
        public void TypeItemsClear() {parameter_ComboBox.Items.Clear();}
        public string ParameterType
        {
            get => parameterType_ComboBox.SelectedItem.ToString();
            set => parameterType_ComboBox.SelectedItem = value;
        }
        public string UnitItem
        {
            get => parameterUnit_ComboBox.SelectedItem.ToString();
            set => parameterUnit_ComboBox.Items.Add(value);
        }
        public void UnitItemsClear() {parameterUnit_ComboBox.Items.Clear();}
        public string ParameterUnit
        {
            get => parameterUnit_ComboBox.SelectedItem.ToString();
            set => parameterUnit_ComboBox.SelectedItem = value;
        }
        public event Action AddParameter;
        public event Action DeleteParameter;


        public string TypeId
        {
            get => typeId_TextBox.Text;
            set => typeId_TextBox.Text = value;
        }
        public string TypeName
        {
            get => typeName_TextBox.Text;
            set => typeName_TextBox.Text = value;
        }
        public event Action AddType;
        public event Action DeleteType;


        public string UnitId
        {
            get => unitId_TextBox.Text; 
            set => unitId_TextBox.Text = value;
        }
        public string UnitName
        {
            get => unitName_TextBox.Text;
            set => unitName_TextBox.Text = value;
        }
        public event Action AddUnit;
        public event Action DeleteUnit;

        
        public string UserId
        {
            get => userId_TextBox.Text;
            set => userId_TextBox.Text = value;
        }
        public string UserLogin
        {
            get => userLogin_TextBox.Text; 
            set => userLogin_TextBox.Text = value;
        }
        public string UserPassword
        {
            get => userPassword_TextBox.Text;
            set => userPassword_TextBox.Text = value;
        }
        public bool UserStatus
        {
            get => userStatus_CheckBox.Checked;
            set => userStatus_CheckBox.Checked = value;
        }
        public event Action AddUser;
        public event Action DeleteUser;

        
        public string ReportId
        {
            get => reportId_TextBox.Text;
            set => reportId_TextBox.Text = value;
        }
        public string ReportDate
        {
            get => reportDate_TextBox.Text;
            set => reportDate_TextBox.Text = value;
        }
        public string ReportName
        {
            get => reportName_TextBox.Text;
            set => reportName_TextBox.Text = value;
        }
        public event Action DeleteReport;
        
        
        public event Action Open;
        public event Action Save;
        public event Action Export;
        public event Action Logout;
        public event Action Exit;

        
        public event Action Help;
        public event Action About;
        public event Action Settings;
        
        
        public AdministratorView(ApplicationContext context)
        {
            _context = context;
            
            InitializeComponent();

            addMaterial_Button.Click += (sender, args) => Action(AddMaterial);
            deleteMaterial_Button.Click += (sender, args) => Action(DeleteMaterial);
            
            addMaterialParameter_Button.Click += (sender, args) => Action(AddMaterialParameter);
            deleteMaterialParameter_Button.Click += (sender, args) => Action(DeleteMaterialParameter);
            
            addParameter_Button.Click += (sender, args) => Action(AddParameter);
            deleteParameter_Button.Click += (sender, args) => Action(DeleteParameter);
            
            addType_Button.Click += (sender, args) => Action(AddType);
            deleteType_Button.Click += (sender, args) => Action(DeleteType);
            
            addUnit_Button.Click += (sender, args) => Action(AddUnit);
            deleteUnit_Button.Click += (sender, args) => Action(DeleteUnit);
            
            addUser_Button.Click += (sender, args) => Action(AddUser);
            deleteUser_Button.Click += (sender, args) => Action(DeleteUser);
            
            deleteReport_Button.Click += (sender, args) => Action(DeleteReport);
            
            open_ToolStrip.Click += (sender, args) => Action(Open);
            save_ToolStrip.Click += (sender, args) => Action(Save);
            exit_ToolStrip.Click += (sender, args) => Action(Exit);
            logout_ToolStrip.Click += (sender, args) => Action(Logout);
            export_ToolStrip.Click += (sender, args) => Action(Export);

            help_ToolStrip.Click += (sender, args) => Action(Help);
            about_ToolStrip.Click += (sender, args) => Action(About);
            setting_ToolStrip.Click += (sender, args) => Action(Settings);
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

        private void ReportsRecordSelect(object sender, DataGridViewCellEventArgs e)
        {
            if (reports_DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) return;
            ReportId = reports_DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            ReportDate = reports_DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            ReportName = reports_DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
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
        
        private void UsersRecordSelect(object sender, DataGridViewCellEventArgs e)
        {
            if (users_DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) return;
            UserId = users_DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            UserLogin = users_DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            UserPassword = users_DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            UserStatus = users_DataGridView.Rows[e.RowIndex].Cells[3].Value.ToString() == "True";
        }
        public void FillUsersRecords(string[][] records)
        {
            users_DataGridView.RowCount = 0;
            users_DataGridView.RowCount = records.Length + 1;
            if (records.Length == 0) return;
            for (var i = 0; i < records.Length; i++)
            {
                users_DataGridView.Rows[i].Cells[0].Value = records[i][0];
                users_DataGridView.Rows[i].Cells[1].Value = records[i][1];
                users_DataGridView.Rows[i].Cells[2].Value = records[i][2];
                users_DataGridView.Rows[i].Cells[3].Value = records[i][3];
            }
        }

        private void UnitsRecordSelect(object sender, DataGridViewCellEventArgs e)
        {
            if (units_DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) return;
            UnitId = units_DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            UnitName = units_DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        public void FillUnitsRecords(string[][] records)
        {
            units_DataGridView.RowCount = 0;
            units_DataGridView.RowCount = records.Length + 1;
            if (records.Length == 0) return;
            for (var i = 0; i < records.Length; i++)
            {
                units_DataGridView.Rows[i].Cells[0].Value = records[i][0];
                units_DataGridView.Rows[i].Cells[1].Value = records[i][1];
            }
        }

        private void TypesRecordSelect(object sender, DataGridViewCellEventArgs e)
        {
            if (types_DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) return;
            TypeId = types_DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            TypeName = types_DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        public void FillTypesRecords(string[][] records)
        {
            types_DataGridView.RowCount = 0;
            types_DataGridView.RowCount = records.Length + 1;
            if (records.Length == 0) return;
            for (var i = 0; i < records.Length; i++)
            {
                types_DataGridView.Rows[i].Cells[0].Value = records[i][0];
                types_DataGridView.Rows[i].Cells[1].Value = records[i][1];
            }
        }
        
        private void ParametersRecordSelect(object sender, DataGridViewCellEventArgs e)
        {
            if (parameters_DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) return;
            ParameterId = parameters_DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            ParameterName = parameters_DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            ParameterType = parameters_DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            ParameterUnit = parameters_DataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        public void FillParametersRecords(string[][] records)
        {
            parameters_DataGridView.RowCount = 0;
            parameters_DataGridView.RowCount = records.Length + 1;
            if (records.Length == 0) return;
            for (var i = 0; i < records.Length; i++)
            {
                parameters_DataGridView.Rows[i].Cells[0].Value = records[i][0];
                parameters_DataGridView.Rows[i].Cells[1].Value = records[i][1];
                parameters_DataGridView.Rows[i].Cells[2].Value = records[i][2];
                parameters_DataGridView.Rows[i].Cells[3].Value = records[i][3];
            }
        }

        private void MaterialParametersRecordSelect(object sender, DataGridViewCellEventArgs e)
        {
            if (materialParameters_DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) return;
            MaterialParametersId = materialParameters_DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            MaterialParametersMaterial = materialParameters_DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            MaterialParametersParameter = materialParameters_DataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            ParameterValue = materialParameters_DataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        public void FillMaterialParametersRecords(string[][] records)
        {
            materialParameters_DataGridView.RowCount = 0;
            materialParameters_DataGridView.RowCount = records.Length + 1;
            if (records.Length == 0) return;
            for (var i = 0; i < records.Length; i++)
            {
                materialParameters_DataGridView.Rows[i].Cells[0].Value = records[i][0];
                materialParameters_DataGridView.Rows[i].Cells[1].Value = records[i][1];
                materialParameters_DataGridView.Rows[i].Cells[2].Value = records[i][2];
                materialParameters_DataGridView.Rows[i].Cells[3].Value = records[i][3];
            }
        }

        private void MaterialsRecordSelect(object sender, DataGridViewCellEventArgs e)
        {
            if (materials_DataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == null) return;
            MaterialId = materials_DataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            MaterialName = materials_DataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        public void FillMaterialsRecords(string[][] records)
        {
            materials_DataGridView.RowCount = 0;
            materials_DataGridView.RowCount = records.Length + 1;
            if (records.Length == 0) return;
            for (var i = 0; i < records.Length; i++)
            {
                materials_DataGridView.Rows[i].Cells[0].Value = records[i][0];
                materials_DataGridView.Rows[i].Cells[1].Value = records[i][1];
            }
        }
    }
}
