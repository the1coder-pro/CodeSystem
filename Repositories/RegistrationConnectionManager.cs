using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Configuration;

namespace CodeSystem.Repositories
{
    public class RegistrationConnectionManager
    {
        private static RegistrationConnectionManager instance = null;
        private OleDbConnection conn;

        private RegistrationConnectionManager()
        {
            string appPath = AppDomain.CurrentDomain.BaseDirectory; // Equivalent to VB.NET's My.Application.Info.DirectoryPath
            conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Codes\\Codes101\\Registration.accde;Persist Security Info=False;Jet OLEDB:Database Password=8176966";
            // conn.Open();
        }

        public OleDbTransaction GetNewTransaction()
        {
            return conn.BeginTransaction();
        }

        public OleDbTransaction ExecuteMutliple(OleDbTransaction trx, string sql)
        {
            OleDbCommand comm = new OleDbCommand
            {
                Transaction = trx,
                CommandText = sql,
                Connection = conn
            };
            comm.ExecuteNonQuery();
            return trx;
        }

        public void ExecuteSingle(string sql)
        {
            conn.Open();
            OleDbCommand comm = new OleDbCommand();
            OleDbTransaction trx = conn.BeginTransaction();
            try
            {
                comm.Transaction = trx;
                comm.CommandText = sql;
                comm.Connection = conn;
                comm.ExecuteNonQuery();
                trx.Commit();
            }
            catch (Exception ex)
            {
                // Store error anywhere
                Console.WriteLine(ex.ToString());
                trx.Rollback();
            }
            finally
            {
                conn.Close();
            }
        }

        private OleDbConnection conn1;

        public DataTable ReadData(string sql)
        {
            DataTable dt = new DataTable();
            OleDbCommand cm = new OleDbCommand
            {
                CommandText = sql,
                Connection = conn
            };
            OleDbDataAdapter da = new OleDbDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }

        public DataTable ReadData(string sql, OleDbTransaction tx)
        {
            DataTable dt = new DataTable();
            OleDbCommand cm = new OleDbCommand
            {
                Transaction = tx,
                CommandText = sql,
                Connection = conn
            };
            OleDbDataAdapter da = new OleDbDataAdapter(cm);
            da.Fill(dt);
            return dt;
        }

        public static RegistrationConnectionManager DefaultInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RegistrationConnectionManager();
                }
                return instance;
            }
        }
    }
}
