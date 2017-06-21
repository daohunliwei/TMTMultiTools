using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
using Dapper;

namespace TMTMultiTools.Model.DBModel
{
    //extendconfig
    public class Extendconfig
    {

        /// <summary>
        /// ExtendType
        /// </summary>		
        private int _extendtype;
        [Key]
        public int ExtendType
        {
            get { return _extendtype; }
            set { _extendtype = value; }
        }
        /// <summary>
        /// ExtendName
        /// </summary>		
        private string _extendname;
        public string ExtendName
        {
            get { return _extendname; }
            set { _extendname = value; }
        }
        /// <summary>
        /// ExtendConfigJson
        /// </summary>		
        private string _extendconfigjson;
        public string ExtendConfigJson
        {
            get { return _extendconfigjson; }
            set { _extendconfigjson = value; }
        }

    }
}