using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TMTMultiTools
{
    public partial class Launcher : Form
    {
        public Launcher()
        {
            InitializeComponent();
        }

        private void bt_autoupdate_Click(object sender, EventArgs e)
        {
            var updater = FSLib.App.SimpleUpdater.Updater.Instance;
            updater.Context.LogFile = "c:\\log.txt";
           // FSLib.App.SimpleUpdater.Updater.CheckUpdateSimple("", updateInfoFile);

            FSLib.App.SimpleUpdater.Updater.CheckUpdateSimple("C:\\发布程序\\update.xml");
        }
    }
}
