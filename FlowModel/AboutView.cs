using System;
using System.Windows.Forms;
using FlowModel.Presenter.Views.AboutView;

namespace FlowModel
{
    public partial class AboutView : Form, IAboutView
    {
        public AboutView()
        {
            InitializeComponent();
            license_TextBox.Text =
                "Copyright � 2021 Grishchenkov Nikita" + Environment.NewLine + Environment.NewLine +
                "������ �������� ��������� �����, ���������� ����� ������� ������������" + Environment.NewLine +
                "����������� � ������������� ������������ (� ���������� ���������� ������������" + Environment.NewLine +
                "�����������), ������������ ������������ ����������� ����������� ��� �����������," + Environment.NewLine +
                "������� �������������� ����� �� �������������, �����������, ���������, �������," + Environment.NewLine +
                "����������, ���������������, ����������������� �/��� ������� ����� ������������" + Environment.NewLine +
                "�����������, � ����� �����, ������� ��������������� ������ ����������� �����������," + Environment.NewLine +
                "��� ���������� ��������� �������:" + Environment.NewLine + Environment.NewLine +
                "��������� ���� ����������� �� ��������� ����� � ������ ������� ������ ����" + Environment.NewLine +
                "�������� �� ��� ����� ��� �������� ����� ������� ������������ �����������." + Environment.NewLine + Environment.NewLine +
                "������ ����������� ����������� ��������������� ���� ���ܻ," + Environment.NewLine +
                "��� �����-���� ��������, ���� ���������� ��� ���������������," + Environment.NewLine +
                "������� �������� �������� �����������, ������������ �� ���" + Environment.NewLine +
                "����������� ���������� � ���������� ���������, �� �� �������������" + Environment.NewLine +
                "���. �� � ����� ������ ������ ��� ��������������� �� �����" + Environment.NewLine +
                "��������������� �� �����-���� �����, �� ����� ��� �� ����" + Environment.NewLine +
                "�����������, � ��� �����, ��� �������� ���������, �������" + Environment.NewLine +
                "��� ���� ��������, ��������� ��-�� ������������� ������������" + Environment.NewLine +
                "����������� ��� ���� �������� � ����������� ������������.";
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