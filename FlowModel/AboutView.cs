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
                "Copyright © 2021 Grishchenkov Nikita" + Environment.NewLine + Environment.NewLine +
                "Данная лицензия разрешает лицам, получившим копию данного программного" + Environment.NewLine +
                "обеспечения и сопутствующей документации (в дальнейшем именуемыми «Программное" + Environment.NewLine +
                "Обеспечение»), безвозмездно использовать Программное Обеспечение без ограничений," + Environment.NewLine +
                "включая неограниченное право на использование, копирование, изменение, слияние," + Environment.NewLine +
                "публикацию, распространение, сублицензирование и/или продажу копий Программного" + Environment.NewLine +
                "Обеспечения, а также лицам, которым предоставляется данное Программное Обеспечение," + Environment.NewLine +
                "при соблюдении следующих условий:" + Environment.NewLine + Environment.NewLine +
                "Указанное выше уведомление об авторском праве и данные условия должны быть" + Environment.NewLine +
                "включены во все копии или значимые части данного Программного Обеспечения." + Environment.NewLine + Environment.NewLine +
                "ДАННОЕ ПРОГРАММНОЕ ОБЕСПЕЧЕНИЕ ПРЕДОСТАВЛЯЕТСЯ «КАК ЕСТЬ»," + Environment.NewLine +
                "БЕЗ КАКИХ-ЛИБО ГАРАНТИЙ, ЯВНО ВЫРАЖЕННЫХ ИЛИ ПОДРАЗУМЕВАЕМЫХ," + Environment.NewLine +
                "ВКЛЮЧАЯ ГАРАНТИИ ТОВАРНОЙ ПРИГОДНОСТИ, СООТВЕТСТВИЯ ПО ЕГО" + Environment.NewLine +
                "КОНКРЕТНОМУ НАЗНАЧЕНИЮ И ОТСУТСТВИЯ НАРУШЕНИЙ, НО НЕ ОГРАНИЧИВАЯСЬ" + Environment.NewLine +
                "ИМИ. НИ В КАКОМ СЛУЧАЕ АВТОРЫ ИЛИ ПРАВООБЛАДАТЕЛИ НЕ НЕСУТ" + Environment.NewLine +
                "ОТВЕТСТВЕННОСТИ ПО КАКИМ-ЛИБО ИСКАМ, ЗА УЩЕРБ ИЛИ ПО ИНЫМ" + Environment.NewLine +
                "ТРЕБОВАНИЯМ, В ТОМ ЧИСЛЕ, ПРИ ДЕЙСТВИИ КОНТРАКТА, ДЕЛИКТЕ" + Environment.NewLine +
                "ИЛИ ИНОЙ СИТУАЦИИ, ВОЗНИКШИМ ИЗ-ЗА ИСПОЛЬЗОВАНИЯ ПРОГРАММНОГО" + Environment.NewLine +
                "ОБЕСПЕЧЕНИЯ ИЛИ ИНЫХ ДЕЙСТВИЙ С ПРОГРАММНЫМ ОБЕСПЕЧЕНИЕМ.";
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