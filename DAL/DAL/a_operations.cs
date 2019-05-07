using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BO;
using Types;

namespace DAL
{
    public class a_operations
    {

        public int addaccount(int customer_id, string account_type, float deposit_amount)
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            conn.Open();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_addaccount";



            cmd.Parameters.AddWithValue("@customer_id", customer_id);
            cmd.Parameters.AddWithValue("@account_type", account_type);
            cmd.Parameters.AddWithValue("@deposit_amount", deposit_amount);

            int rows = cmd.ExecuteNonQuery();
            conn.Close();

            return rows;

        }

        public int deleteaccount(int account_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_deleteaccount";

            cmd.Parameters.AddWithValue("@account_id", account_id);

            int rows = cmd.ExecuteNonQuery();
            conn.Close();

            return rows;
        }


        public List<Account> account_search(int custid,int account_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            conn.Open();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_asearch";

            cmd.Parameters.AddWithValue("@customer_id", custid);
            cmd.Parameters.AddWithValue("@account_id", account_id);


            SqlDataReader reader = cmd.ExecuteReader();

            List<Account> alist = new List<Account>();

            int aid;
            int cid;
            string astatus;
            string amessage;
            DateTime acreateddate;
            string atype;
            float amount;

            while (reader.Read())
            {
                aid = int.Parse(reader["account_id"].ToString());
                amount = float.Parse(reader["deposit_amount"].ToString());
                cid = int.Parse(reader["customer_id"].ToString());
                astatus = (reader["status"].ToString());
                amessage = (reader["message"].ToString());
                acreateddate = DateTime.Parse(reader["created_date"].ToString());
                atype = reader["account_type"].ToString();
                alist.Add(new Account(aid,cid,atype,astatus,acreateddate,amessage,amount));
            }
            conn.Close();
            return alist;
        }

        public List<Account> displayaccid()
        {
            List<Account> accidlist = new List<Account>();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            conn.Open();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_displayaccid";

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int accid = Convert.ToInt32(reader["account_id"]);
                accidlist.Add(new Account(accid));
            }
            conn.Close();
            return accidlist;
        }

        public List<Account> displayaccid1(int custid)
        {
            List<Account> accidlist = new List<Account>();
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            conn.Open();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_displayaccid1";

            cmd.Parameters.AddWithValue("@custid", custid);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                int accid = Convert.ToInt32(reader["account_id"]);
                accidlist.Add(new Account(accid));
            }
            conn.Close();
            return accidlist;
        }
        public List<Account> displayacctype(int accid)
        {
            List<Account> acctypelist = new List<Account>();

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_displayacctype";

            cmd.Parameters.AddWithValue("account_id", accid);

            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string acctype = (reader["account_type"]).ToString();
                float depoamt = float.Parse((reader["deposit_amount"]).ToString());
                acctypelist.Add(new Account(acctype,depoamt));
            }
            conn.Close();
            return acctypelist;
        }
        public List<Account> astatus()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_viewastatus";

            SqlDataReader reader = cmd.ExecuteReader();

            int custid;
            int accid;
            string accstat;
            string message;
            string acctype;
            DateTime lastupdated;
            List<Account> alist = new List<Account>();

            while (reader.Read())
            {
                custid = Convert.ToInt32(reader["customer_id"]);
                accid = Convert.ToInt32(reader["account_id"]);
                accstat = (reader["status"]).ToString();
                acctype = (reader["account_type"]).ToString();
                message = (reader["message"]).ToString();
                lastupdated = Convert.ToDateTime(reader["created_date"]);
                alist.Add(new Account(accid, custid,acctype,accstat, lastupdated, message));
            }
            conn.Close();
            return alist;
        }
    }
}
