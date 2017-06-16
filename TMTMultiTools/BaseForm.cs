using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using TMTMultiTools.Helper;
using System.Linq;

namespace TMTMultiTools
{
    public partial class BaseForm : MetroForm
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        protected void ChangeStyle(eStyle style)
        {
            StaticData.GlobalConfig.GlobalTheme = style;
            this.mainStyle.ManagerStyle = StaticData.GlobalConfig.GlobalTheme;
            ConfigHelper.Save();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            if (StaticData.GlobalConfig != null)
                ChangeStyle(StaticData.GlobalConfig.GlobalTheme);
        }
    }
}