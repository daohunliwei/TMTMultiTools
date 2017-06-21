using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace TMTMultiTools.Model.DBModel
{
    //softuseinfo
    public class Softuseinfo
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
        /// SoftCode
        /// </summary>		
        private string _softcode;
        public string SoftCode
        {
            get { return _softcode; }
            set { _softcode = value; }
        }
        /// <summary>
        /// MachineKey
        /// </summary>		
        private string _machinekey;
        public string MachineKey
        {
            get { return _machinekey; }
            set { _machinekey = value; }
        }
        /// <summary>
        /// CurrentVersion
        /// </summary>		
        private string _currentversion;
        public string CurrentVersion
        {
            get { return _currentversion; }
            set { _currentversion = value; }
        }
        /// <summary>
        /// on update CURRENT_TIMESTAMP
        /// </summary>		
        private DateTime _firstrecordtime;
        public DateTime FirstRecordTime
        {
            get { return _firstrecordtime; }
            set { _firstrecordtime = value; }
        }
        /// <summary>
        /// on update CURRENT_TIMESTAMP
        /// </summary>		
        private DateTime _lastrecordtime;
        public DateTime LastRecordTime
        {
            get { return _lastrecordtime; }
            set { _lastrecordtime = value; }
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
        /// Note
        /// </summary>		
        private string _note;
        public string Note
        {
            get { return _note; }
            set { _note = value; }
        }

    }
}

