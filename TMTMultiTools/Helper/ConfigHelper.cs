using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMTMultiTools.Model;
using System.FishExtension;
using System.FishLib;
using System.IO;

namespace TMTMultiTools.Helper
{
    public static class ConfigHelper
    {
        public static void Save(GlobalConfigInfoModel config)
        {
            string path = ApplicationRunTimeContext.GetProcessMainModuleDirectory()+@"\config.ini";

            IOUtility.WriteAllText(path, config.ToJson());
        }

        public static void Save()
        {
            Save(StaticData.GlobalConfig);
        }

        public static void Read()
        { 
            string path = ApplicationRunTimeContext.GetProcessMainModuleDirectory() + @"\config.ini";
            if (File.Exists(path))
            {
                GlobalConfigInfoModel config = File.ReadAllText(path).ToInstance<GlobalConfigInfoModel>();
                if (config != null)
                {
                    StaticData.GlobalConfig = config;
                }
                else
                {
                    if (StaticData.GlobalConfig == null)
                        StaticData.GlobalConfig = new GlobalConfigInfoModel() { GlobalTheme = DevComponents.DotNetBar.eStyle.Office2007Blue };
                }
            }
            else
            {
                StaticData.GlobalConfig = new GlobalConfigInfoModel();
                Save();
            }
        }
    }
}
