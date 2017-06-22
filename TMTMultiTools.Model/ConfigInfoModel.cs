using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMTMultiTools.Model.User;

namespace TMTMultiTools.Model
{
    public class GlobalConfigInfoModel
    {
        public eStyle GlobalTheme { get; set; }

        public UserInfoModel UserInfo { get; set; }

        public List<string> RecentUserName { get; set; }
    }
}
