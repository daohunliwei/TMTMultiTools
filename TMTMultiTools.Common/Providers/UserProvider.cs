using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    }
}
