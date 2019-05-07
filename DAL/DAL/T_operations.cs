using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BO;

namespace DAL
{
    public class T_operations
    {
        public List<Account> account_search(int acc_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_depsearch";

            cmd.Parameters.AddWithValue("@account_id", acc_id);

            SqlDataReader reader = cmd.ExecuteReader();

            List<Account> alist = new List<Account>();

            int aid;
            string atype;
            float amount;

            while (reader.Read())
            {
                aid = int.Parse(reader["account_id"].ToString());
                amount = float.Parse(reader["deposit_amount"].ToString());
                atype = reader["account_type"].ToString();
                alist.Add(new Account(aid,atype,amount));
            }
            conn.Close();
            return alist;
        }

        public int deposit(int accid,float depositamt,float balance)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_deposit";

            cmd.Parameters.AddWithValue("@account_id", accid);
            cmd.Parameters.AddWithValue("@deposit_amount", depositamt);
            cmd.Parameters.AddWithValue("@balance", @balance);

            int rows = cmd.ExecuteNonQuery();
            conn.Close();

            return rows;

        }

        public int deposit1(int accid, float depositamt, float balance)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_wd";

            cmd.Parameters.AddWithValue("@account_id", accid);
            cmd.Parameters.AddWithValue("@deposit_amount", depositamt);
            cmd.Parameters.AddWithValue("@balance", @balance);

            int rows = cmd.ExecuteNonQuery();
            conn.Close();

            return rows;

        }
        public int transfer(int sid,int tid,float amt,float sb,float tgb)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_transfer";

            cmd.Parameters.AddWithValue("@account_id", sid);
            cmd.Parameters.AddWithValue("@target_id", tid);
            cmd.Parameters.AddWithValue("@transfer_amount", amt);
            cmd.Parameters.AddWithValue("@sourcebalance", sb);
            cmd.Parameters.AddWithValue("@targetbalance", tgb);

            int rows = cmd.ExecuteNonQuery();
            conn.Close();

            return rows;
        }
        public List<Account> viewamt(int sid)
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_amtview";

            cmd.Parameters.AddWithValue("@id", sid);

            SqlDataReader reader = cmd.ExecuteReader();

            float samt;
            List<Account> alist = new List<Account>();

            while(reader.Read())
            {
                samt = int.Parse(reader["sbal"].ToString());
                alist.Add(new Account(samt));
            }

            conn.Close();
            
            return alist;
         }

        public List<Transact>viewtransact(int id,DateTime sdate,DateTime edate)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_viewtransaction";

            cmd.Parameters.AddWithValue("@accountid", id);
            cmd.Parameters.AddWithValue("@startdate", sdate);
            cmd.Parameters.AddWithValue("@enddate", edate);

            SqlDataReader reader = cmd.ExecuteReader();

            int tid;
            DateTime tdate;
            string description;
            float amt;
            float balance;
            List<Transact> tlist = new List<Transact>();

            while (reader.Read())
            {
                tid = int.Parse(reader["transaction_id"].ToString());
                tdate =DateTime.Parse(reader["transaction_date"].ToString());
                description = (reader["description"].ToString());
                amt = float.Parse(reader["amount"].ToString());
                balance = float.Parse(reader["balance"].ToString());
                tlist.Add(new Transact(tid,tdate,amt,balance,description));
            }

            conn.Close();

            return tlist;
        }

        public List<Transact> viewtransact1(int id,int count)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_viewtransaction1";

            cmd.Parameters.AddWithValue("@accountid", id);
            cmd.Parameters.AddWithValue("@count", count);

            SqlDataReader reader = cmd.ExecuteReader();

            int tid;
            DateTime tdate;
            string description;
            float amt;
            float balance;
            List<Transact> tlist = new List<Transact>();

            while (reader.Read())
            {
                tid = int.Parse(reader["transaction_id"].ToString());
                tdate = DateTime.Parse(reader["transaction_date"].ToString());
                description = (reader["description"].ToString());
                amt = float.Parse(reader["amount"].ToString());
                balance = float.Parse(reader["balance"].ToString());
                tlist.Add(new Transact(tid, tdate, amt, balance, description));
            }

            conn.Close();

            return tlist;
        }
    }
}
