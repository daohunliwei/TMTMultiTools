using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMTMultiTools.Model.DBModel;
using TMTMultiTools.Model.User;

namespace TMTMultiTools.Common.Providers
{
    public class UserProvider
    { 
        #region Singleton
        private static readonly UserProvider instance = new UserProvider();
        public static UserProvider Instance
        {
            get
            {
                return instance;
            }
        }

        private UserProvider()
        {

        }
        #endregion

        public UserInfoModel GetLocalUserInfo()
        {
            var userInfo = StaticData.GlobalConfig.UserInfo; 
            return userInfo;
        }

        public UserInfoModel Login(string username, string password)
        {
            var userinfo=DB.MySqlHelper.Instance.Get<Userinfo>(new { UserName = username, Password = password }).FirstOrDefault();
            if (userinfo != null)
            {
                return new UserInfoModel() { NickName = userinfo.Nickname, RegisterTime = userinfo.RegisterTime, UserId = userinfo.UserID };
            }
            return null;
        }
    }
}
