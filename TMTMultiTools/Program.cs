using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TMTMultiTools.Helper;

namespace TMTMultiTools
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //先处理下初始化的数据
            Helper.Themes.ThemesHelper.BindingThemesData();
            ConfigHelper.Read();

            Application.Run(new Launcher());
        }
    }
}
