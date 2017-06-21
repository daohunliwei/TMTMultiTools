using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace TMTMultiTools.DB
{
    public class BaseDBHelper
    {
        protected string ConnectionString = string.Empty;

        protected IDbConnection DbConnection;

        public virtual int? Insert<T>(T model) where T : class
        {
            return DbConnection.Insert(model);
        }
        public virtual int? Insert(string query,object anonymous)  
        {
            return DbConnection.Execute(query, anonymous);
        }
        public virtual int? InsertBulk<T>(string query,IEnumerable<T> model) where T : class
        {
            return DbConnection.Execute(query,model);
        } 

        public virtual int? Delete<T>(T model) where T : class
        {
            return DbConnection.Delete(model);
        }
        public virtual int? Delete(string query, object anonymous)
        {
            return DbConnection.Execute(query, anonymous);
        }

        public virtual IEnumerable<T> Get<T>() where T : class
        {
            return DbConnection.GetList<T>();
        }
        public virtual IEnumerable<T> Get<T>(object anonymous) where T : class
        {
            return DbConnection.GetList<T>(anonymous);
        }
        public virtual IEnumerable<T> Get<T>(string query) where T : class
        {
            return DbConnection.GetList<T>(query);
        }

        public virtual int? Update<T>(T model) where T : class
        {
            return DbConnection.Update(model);
        }
        public virtual int? Update(string query,object anonymous)  
        {
            return DbConnection.Execute(query,anonymous);
        }
    }
}
