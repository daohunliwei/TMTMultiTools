using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TMTMultiTools.Model
{
    public class QuickSearchReturnModel
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("data")]
        public WeiboUserData UserData { get; set; }
    }
    public class WeiboUserData
    {
        [JsonProperty("user")]
        public IEnumerable<WeiboUserInfo> UserList { get; set; }
    }
    public class WeiboUserInfo
    {
        [JsonProperty("u_id")]
        public int UID { get; set; }

        [JsonProperty("u_pic")]
        public string Avatar { get; set; }

        [JsonProperty("u_name")]
        public string NickName { get; set; }

        [JsonProperty("sex")]
        public string Sex { get; set; }

        [JsonProperty("is_v")]
        public bool IsV { get; set; }

        [JsonProperty("fans_n")]
        public int FansNum { get; set; }
    }
}
