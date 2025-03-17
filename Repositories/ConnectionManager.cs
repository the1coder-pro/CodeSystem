using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeSystem.Models;

namespace CodeSystem.Repositories
{
    public class ConnectionManager
    {
        private static ConnectionManager instance = null;
        private OleDbConnection conn;

        private ConnectionManager()
        {
            conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + CodeSystem.Models.ThisPCDataModel.GetThisPCDataPath() + ";Persist Security Info=False;Jet OLEDB:Database Password=3250";
        }

        public int ExecuteSingle(string sql, bool openConn = true)
        {
            OleDbCommand comm = new OleDbCommand();
            if (openConn)
            {
                OpenConnection();
            }
            int numberOfRowsAffected;
            try
            {
                comm.CommandText = sql;
                comm.Connection = conn;
                numberOfRowsAffected = comm.ExecuteNonQuery();
                return numberOfRowsAffected;
            }
            catch (Exception ex)
            {
                if (ex.HResult.ToString() == "-2147467259")
                {
                    Console.WriteLine("قيمة تم إدخالها من قبل");
                }
                else
                {
                    Console.WriteLine($"{ex.ToString()}, {ex.HResult}");
                }
                return -2;
            }
        }

        private OleDbConnection conn1;

        public void OpenConnection()
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
        }

        public void CloseConnection()
        {
            if (conn.State != ConnectionState.Closed)
            {
                conn.Close();
            }
        }

        public DataTable ReadData(string sql)
        {
            DataSet ds = new DataSet();
            try
            {
                OleDbCommand cm = new OleDbCommand
                {
                    CommandText = sql,
                    Connection = conn
                };
                OleDbDataAdapter da = new OleDbDataAdapter(cm);
                da.Fill(ds);
                if (ds.Tables.Count > 0)
                {
                    return ds.Tables[0];
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public static ConnectionManager DefaultInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ConnectionManager();
                }
                return instance;
            }
        }

        public void SetPrintingFilterInvoiceID(string strInvoiceID, int intUserID)
        {
            string appPath = AppDomain.CurrentDomain.BaseDirectory;
            Console.WriteLine(appPath);
            conn1 = new OleDbConnection();
            conn1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + appPath + "\\Report.accde;Persist Security Info=False";
            conn1.Open();
            OleDbCommand comm = new OleDbCommand();
            OleDbTransaction trx = conn1.BeginTransaction();
            try
            {
                comm.Transaction = trx;
                comm.CommandText = $"Update tblPrintingFilter Set tblPrintingFilter.[InvoiceID]='{strInvoiceID}' , tblPrintingFilter.[UserID]={intUserID}";
                comm.Connection = conn1;
                comm.ExecuteNonQuery();
                trx.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                trx.Rollback();
            }
            finally
            {
                conn1.Close();
            }
        }

        public void SetPrintingFilterItemID(long lngBarcodeReportTypeID, int lngItemID, int intUserID, long lngBarcodeCopyCount, DateTime dtMadeDate, DateTime dtExpireDate)
        {
            string appPath = AppDomain.CurrentDomain.BaseDirectory;
            conn1 = new OleDbConnection();
            conn1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + appPath + "\\Report.accde;Persist Security Info=False";
            conn1.Open();
            OleDbCommand comm = new OleDbCommand();
            OleDbTransaction trx = conn1.BeginTransaction();
            try
            {
                comm.Transaction = trx;
                comm.CommandText = $"Update tblPrintingFilter Set tblPrintingFilter.[ItemID]={lngItemID}, tblPrintingFilter.[UserID]={intUserID}, tblPrintingFilter.[BarcodeReportTypeID]={lngBarcodeReportTypeID}, tblPrintingFilter.[BarcodeCopyCount]={lngBarcodeCopyCount}, tblPrintingFilter.[MadeDate]=#{dtMadeDate}#, tblPrintingFilter.[ExpireDate]=#{dtExpireDate}#";
                comm.Connection = conn1;
                comm.ExecuteNonQuery();
                trx.Commit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                trx.Rollback();
            }
            finally
            {
                conn1.Close();
            }
        }
    }
}
