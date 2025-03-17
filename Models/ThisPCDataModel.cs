using CodeSystem.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSystem.Models
{
    public class ThisPCDataModel
    {
        private int _PCID;
        public int PCID
        {
            get { return _PCID; }
            set { _PCID = value; }
        }

        private string _DataPath;
        public string DataPath
        {
            get { return _DataPath; }
            set { _DataPath = value; }
        }

        public ThisPCDataModel(int intPCID, string stDataPath)
        {
            this.PCID = intPCID;
            this.DataPath = stDataPath;
        }

        public static string GetThisPCDataPath()
        {
            var conMgr = RegistrationConnectionManager.DefaultInstance;
            return conMgr.ReadData("SELECT PCID, DataPath FROM [tblThisPCData]").Rows[0]["DataPath"].ToString();
        }

        public static int GetThisPCID()
        {
            var conMgr = RegistrationConnectionManager.DefaultInstance;
            return Convert.ToInt32(conMgr.ReadData("SELECT PCID, DataPath FROM [tblThisPCData]").Rows[0]["PCID"]);
        }

        public static int intThisPCID;

        public void Add()
        {
            var conMgr = RegistrationConnectionManager.DefaultInstance;
            string sql = $"INSERT INTO [tblThisPCData] ([PCID], [DataPath]) VALUES({this.PCID}, '{this.DataPath}')";
            conMgr.ExecuteSingle(sql);
        }
    }

}
