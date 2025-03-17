using CodeSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSystem
{

    public class User
    {
        private int _ID;
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        private string _NameArabic;
        public string NameArabic
        {
            get { return _NameArabic; }
            set { _NameArabic = value; }
        }

        private string _NameEnglish;
        public string NameEnglish
        {
            get { return _NameEnglish; }
            set { _NameEnglish = value; }
        }

        private string _Username;
        public string Username
        {
            get { return _Username; }
            set { _Username = value; }
        }

        private string _Password;
        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }

        private DateTime _FirstEntry;
        public DateTime FirstEntry
        {
            get { return _FirstEntry; }
            set { _FirstEntry = value; }
        }

        private DateTime _LastEntry;
        public DateTime LastEntry
        {
            get { return _LastEntry; }
            set { _LastEntry = value; }
        }

        private byte _UserGroupID;
        public byte UserGroupID
        {
            get { return _UserGroupID; }
            set { _UserGroupID = value; }
        }

        private int _CurrentStatusID;
        public int CurrentStatusID
        {
            get { return _CurrentStatusID; }
            set { _CurrentStatusID = value; }
        }

        private bool _Stopped;
        public bool Stopped
        {
            get { return _Stopped; }
            set { _Stopped = value; }
        }

        public User(int intID, string strNamear, string strNameEn, string strUserName, string strPassword, DateTime datFirstEntry, DateTime datLastEntry, byte bytUserGroupID, int intCurrentStatusID, bool bolStopped)
        {
            this.ID = intID;
            this.NameArabic = strNamear;
            this.NameEnglish = strNameEn;
            this.Username = strUserName;
            this.Password = strPassword;
            this.FirstEntry = datFirstEntry;
            this.LastEntry = datLastEntry;
            this.UserGroupID = bytUserGroupID;
            this.CurrentStatusID = intCurrentStatusID;
            this.Stopped = bolStopped;
        }

        public static DataTable UserList()
        {
            var conMgr = ConnectionManager.DefaultInstance;
            return conMgr.ReadData("select * from [tblUser]");
        }

        public void Add()
        {
            var conMgr = ConnectionManager.DefaultInstance;
            int newId = 1 + int.Parse(conMgr.ReadData("select max(id) from [tblUser]").Rows[0][0].ToString());
            this.ID = newId;

            string SQL = $"Insert into [tblUser] ([ID],[Namear],[NameEn],[UserName],[Password],[FirstEntry],[LastEntry],[UserGroupID],[CurrentStatusID],[Stopped]) " +
                         $"Values({this.ID},'{this.NameArabic}','{this.NameEnglish}','{this.Username}','{this.Password}',#{this.FirstEntry}#,#{this.LastEntry}#,{this.UserGroupID},{this.CurrentStatusID},{this.Stopped})";
            conMgr.ExecuteSingle(SQL);
        }

        public static byte BytCurrentUserGroupID { get; set; }
        public static int IntCurrentUserID { get; set; }

        public static byte GetUserGroupID(int intID)
        {
            var conMgr = ConnectionManager.DefaultInstance;
            var dt = conMgr.ReadData($"select First(UserGroupID) from [tblUser] where [ID]={intID}");
            byte result = byte.Parse(dt.Rows[0][0].ToString());
            BytCurrentUserGroupID = result;
            IntCurrentUserID = intID;
            return result;
        }

        public static DataTable CurrentUserDetail(int intID)
        {
            var conMgr = ConnectionManager.DefaultInstance;
            return conMgr.ReadData($"select * FROM tblUser Where [ID]= {intID}");
        }

        public bool Authenticate()
        {
            var conMgr = ConnectionManager.DefaultInstance;
            var dt = conMgr.ReadData($"select count(*) as cnt from [tblUser] where [username]='{this.Username}' and [password]='{this.Password}'");
            return dt.Rows[0][0].ToString() != "0";
        }

        public void AddThenUpdateFullName()
        {
            var conMgr = ConnectionManager.DefaultInstance;
            int newId = 1 + int.Parse(conMgr.ReadData("select max(id) from [tblUser]").Rows[0][0].ToString());

            string sql = $"insert into [tblUser] ([id],[username],[password],[UserGroupID]) values ({newId},'{this.Username}','{this.Password}',1)";
            conMgr.ExecuteSingle(sql);

            sql = $"update [tblUser] set [fullname]='{this.Username}' where [username]='{this.Username}'";
            conMgr.ExecuteSingle(sql);
        }

        public static DataTable UsernameList()
        {
            var conMgr = ConnectionManager.DefaultInstance;
            return conMgr.ReadData("select ID,UserName,Namear,NameEn from [tblUser] Where [Stopped]=0");
        }

        public bool AvailableUserName()
        {
            var conMgr = ConnectionManager.DefaultInstance;
            var dt = conMgr.ReadData($"select count(*) as cnt from [tblUser] where [username]='{this.Username}'");
            return dt.Rows[0][0].ToString() == "0";
        }

        public static string StMatchingPassword(string stNewPassword, string stReNewPassword)
        {
            if (string.IsNullOrEmpty(stNewPassword) || string.IsNullOrEmpty(stReNewPassword))
            {
                return "لم يتم تكرار كلمة المرور";
            }
            return stNewPassword != stReNewPassword ? "كلمة المرور غير مطابقة" : "مطابق";
        }

        public User(string stNamear, string stNameEn, string stUserName, string stPassword, byte bytUserGroupID)
        {
            this.NameArabic = stNamear;
            this.NameEnglish = stNameEn;
            this.Username = stUserName;
            this.Password = stPassword;
            this.UserGroupID = bytUserGroupID;
        }

        public User(string stUserName, string stPassword)
        {
            this.Username = stUserName;
            this.Password = stPassword;
        }

        public User(string stUserName)
        {
            this.Username = stUserName;
        }
    }
}

