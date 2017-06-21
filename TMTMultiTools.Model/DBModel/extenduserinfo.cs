using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace TMTMultiTools.Model.DBModel
{
    //extenduserinfo
    public class Extenduserinfo
    {

        /// <summary>
        /// UserID
        /// </summary>		
        private int _userid;
        public int UserID
        {
            get { return _userid; }
            set { _userid = value; }
        }
        /// <summary>
        /// ExtendType
        /// </summary>		
        private int _extendtype;
        public int ExtendType
        {
            get { return _extendtype; }
            set { _extendtype = value; }
        }
        /// <summary>
        /// ExtendID
        /// </summary>		
        private string _extendid;
        public string ExtendID
        {
            get { return _extendid; }
            set { _extendid = value; }
        }
        /// <summary>
        /// on update CURRENT_TIMESTAMP
        /// </summary>		
        private DateTime _extendexpiretime;
        public DateTime ExtendExpireTime
        {
            get { return _extendexpiretime; }
            set { _extendexpiretime = value; }
        }

    }
}

