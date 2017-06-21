using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace TMTMultiTools.Model.DBModel
{
    //extendinfo
    public class Extendinfo
    {

        /// <summary>
        /// ExtendID
        /// </summary>		
        private int _extendid;
        public int ExtendID
        {
            get { return _extendid; }
            set { _extendid = value; }
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
        /// ExtendNickName
        /// </summary>		
        private string _extendnickname;
        public string ExtendNickName
        {
            get { return _extendnickname; }
            set { _extendnickname = value; }
        }
        /// <summary>
        /// ExtendAllInfoJson
        /// </summary>		
        private string _extendallinfojson;
        public string ExtendAllInfoJson
        {
            get { return _extendallinfojson; }
            set { _extendallinfojson = value; }
        }

    }
}

