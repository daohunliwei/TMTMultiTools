using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMTMultiTools.Helper.Themes
{
    public static class ThemesHelper
    {
        public static void BindingThemesData()
        {
            if (StaticData.ThemeDic == null)
                StaticData.ThemeDic = new Dictionary<string, eStyle>();
            else
                StaticData.ThemeDic.Clear();

            foreach (eStyle item in Enum.GetValues(typeof(eStyle)))
            {
                StaticData.ThemeDic.AddOrUpdate(item.ToString(), item);
            }
        }
    }
}
