using System; 
using System.Text;
using System.Collections.Generic; 
using System.Data;
namespace TMTMultiTools.Model.DBModel{
	 	//userinfo
		public class Userinfo
	{
   		     
      	/// <summary>
		/// UserID
        /// </summary>		
		private int _userid;
        public int UserID
        {
            get{ return _userid; }
            set{ _userid = value; }
        }        
		/// <summary>
		/// UserName
        /// </summary>		
		private string _username;
        public string UserName
        {
            get{ return _username; }
            set{ _username = value; }
        }        
		/// <summary>
		/// Password
        /// </summary>		
		private string _password;
        public string Password
        {
            get{ return _password; }
            set{ _password = value; }
        }        
		/// <summary>
		/// Nickname
        /// </summary>		
		private string _nickname;
        public string Nickname
        {
            get{ return _nickname; }
            set{ _nickname = value; }
        }        
		/// <summary>
		/// on update CURRENT_TIMESTAMP
        /// </summary>		
		private DateTime _registertime;
        public DateTime RegisterTime
        {
            get{ return _registertime; }
            set{ _registertime = value; }
        }        
		   
	}
}

