using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Data;
using System.Data.SqlClient;
using Dapper;
using MySql.Data.MySqlClient;

namespace TMTMultiTools.DB
{
    public class MySqlHelper:BaseDBHelper
    {
        #region Singleton
        private static readonly MySqlHelper instance = new MySqlHelper();
        public static MySqlHelper Instance
        {
            get
            {
                return instance;
            }
        }

        private MySqlHelper()
        {
            ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["default"].ConnectionString;
            DbConnection = new MySqlConnection(ConnectionString);
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.MySQL);
        }
        #endregion
        public MySqlHelper(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new Exception("传入参数不得为空");
            ConnectionString = connectionString;
            DbConnection = new MySqlConnection(ConnectionString);
            SimpleCRUD.SetDialect(SimpleCRUD.Dialect.MySQL);
        }
         
    }
}
