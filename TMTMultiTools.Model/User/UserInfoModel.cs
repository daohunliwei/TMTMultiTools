using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMTMultiTools.Model.User
{
    public class UserInfoModel
    {
        public int UserId { get; set; }
        public string NickName { get; set; }
        public string MachineKey { get; set; }
        public DateTime RegisterTime { get; set; }
    }
}
