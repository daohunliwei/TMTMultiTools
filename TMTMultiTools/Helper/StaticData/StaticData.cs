using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMTMultiTools.Model;

namespace TMTMultiTools.Helper
{
    public static class StaticData
    {
        /// <summary>
        /// 主题的名录
        /// </summary>
        public static Dictionary<string, eStyle> ThemeDic { get; set; }

        /// <summary>
        /// 全局配置
        /// </summary>
        public static ConfigInfoModel GlobalConfig { get; set; }
    }
}
