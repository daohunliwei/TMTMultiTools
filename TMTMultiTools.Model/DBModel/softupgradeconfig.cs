using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace TMTMultiTools.Model.DBModel
{
    //softupgradeconfig
    public class Softupgradeconfig
    {

        /// <summary>
        /// SoftCode
        /// </summary>		
        private string _softcode;
        public string SoftCode
        {
            get { return _softcode; }
            set { _softcode = value; }
        }
        /// <summary>
        /// SoftName
        /// </summary>		
        private string _softname;
        public string SoftName
        {
            get { return _softname; }
            set { _softname = value; }
        }
        /// <summary>
        /// LastVersion
        /// </summary>		
        private string _lastversion;
        public string LastVersion
        {
            get { return _lastversion; }
            set { _lastversion = value; }
        }
        /// <summary>
        /// UpdateNote
        /// </summary>		
        private byte[] _updatenote;
        public byte[] UpdateNote
        {
            get { return _updatenote; }
            set { _updatenote = value; }
        }
        /// <summary>
        /// on update CURRENT_TIMESTAMP
        /// </summary>		
        private DateTime _updatetime;
        public DateTime UpdateTime
        {
            get { return _updatetime; }
            set { _updatetime = value; }
        }
        /// <summary>
        /// UpdateURL
        /// </summary>		
        private string _updateurl;
        public string UpdateURL
        {
            get { return _updateurl; }
            set { _updateurl = value; }
        }

    }
}