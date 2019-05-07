using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using BO;

namespace DAL
{
    public class c_operations
    {
        public int addcustomer(int ssn_id, string name, int age, string address, string state, string city,string status,string message,DateTime lastupdated)
        {try
            {

                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_addcustomer";

                cmd.Parameters.AddWithValue("@ssn_id", ssn_id);
                cmd.Parameters.AddWithValue("@customer_name", name);
                cmd.Parameters.AddWithValue("@age", age);
                cmd.Parameters.AddWithValue("@address", address);
                cmd.Parameters.AddWithValue("@state", state);
                cmd.Parameters.AddWithValue("@city", city);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@message", message);
                cmd.Parameters.AddWithValue("lastupdated", lastupdated);

                int rows = cmd.ExecuteNonQuery();
                conn.Close();

                return rows;
            }
            catch (Exception) { return 0; }

        }       


        public int deletecustomer(int customer_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_deletecustomer";

            cmd.Parameters.AddWithValue("@customer_id", customer_id);

            int rows = cmd.ExecuteNonQuery();
            conn.Close();

            return rows;
        }

        public int updatecustomer( int customer_id,string customer_name,string new_address,int new_age,string new_message)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_updatecustomer";

            cmd.Parameters.AddWithValue("@customer_id", customer_id);
            cmd.Parameters.AddWithValue("@new_customer_name", customer_name);
            cmd.Parameters.AddWithValue("@new_address", new_address);
            cmd.Parameters.AddWithValue("@new_age", new_age);
            cmd.Parameters.AddWithValue("@new_msg", new_message);

            int rows = cmd.ExecuteNonQuery();
            conn.Close();

            return rows;

         }


        public List<Customer> customer_search(int customer_id)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_csearch";

            cmd.Parameters.AddWithValue("@customer_id", customer_id);

            SqlDataReader reader = cmd.ExecuteReader();

            List<Customer> clist = new List<Customer>();
            
            int cid;
            string cname;
            int cage;
            string caddress;
            string cstate;
            string ccity;
            string cstatus;
            string cmessage;
            DateTime clastupdated;

            while (reader.Read())
            {
                cid = int.Parse(reader["customer_id"].ToString());
                cname =(reader["customer_name"].ToString());
                cage = int.Parse(reader["age"].ToString());
                caddress = (reader["address"].ToString());
                cstate = (reader["state"].ToString());
                ccity = (reader["city"].ToString());
                cstatus = (reader["status"].ToString());
                cmessage =(reader["message"].ToString());
                clastupdated = DateTime.Parse(reader["lastupdated"].ToString());
               /* clist.Add(new Customer(cid, cstatus, cmessage, clastupdated));*/
            }

            conn.Close();

            return clist;
        }

        public List<Customer> customer_details(int ssn_id,int cid)
        {try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
                conn.Open();


                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_csearch";

                cmd.Parameters.AddWithValue("@customer_id", cid);
                cmd.Parameters.AddWithValue("@ssn_id", ssn_id);

                SqlDataReader reader = cmd.ExecuteReader();

                int ssnid;
                string cname;
                int cage;
                string caddress;
                int custid;
                List<Customer> clist = new List<Customer>();

                while (reader.Read())
                {
                    custid = int.Parse(reader["customer_id"].ToString());
                    ssnid = int.Parse(reader["ssn_id"].ToString());
                    cname = (reader["customer_name"].ToString());
                    cage = int.Parse(reader["age"].ToString());
                    caddress = (reader["address"].ToString());
                    clist.Add(new Customer(ssnid, custid, cname, cage, caddress));
                }

                conn.Close();

                return clist;
            }
            catch (Exception) { List<Customer> clist = new List<Customer>(); return clist; }
        }
        public List<Customer> customer_details1(int custid)
        {
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "sp_csearch1";

                cmd.Parameters.AddWithValue("@customer_id", custid);

                SqlDataReader reader = cmd.ExecuteReader();

                int ssnid;
                string cname;
                int cage;
                string caddress;
                List<Customer> clist = new List<Customer>();

                while (reader.Read())
                {
                    ssnid = int.Parse(reader["ssn_id"].ToString());
                    cname = (reader["customer_name"].ToString());
                    cage = int.Parse(reader["age"].ToString());
                    caddress = (reader["address"].ToString());
                    clist.Add(new Customer(ssnid, custid, cname, cage, caddress));
                }

                conn.Close();

                return clist;
            }
            catch (Exception) { List<Customer> clist = new List<Customer>(); return clist; }
        }

        public List<Customer>idviewer()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_viewallcust";

            SqlDataReader reader = cmd.ExecuteReader();

            List<Customer> clist = new List<Customer>();

            int cid;

            while (reader.Read())
            {
                cid = int.Parse(reader["customer_id"].ToString());
                clist.Add(new Customer(cid));
            }

            conn.Close();

            return clist;
        }

        public List<Customer>cstatus()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=.\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";
            conn.Open();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "sp_viewcstatus";

            SqlDataReader reader = cmd.ExecuteReader();

            int ssnid;
            int cid;
            string status;
            string msg;
            DateTime lastupdated;
            List<Customer> clist = new List<Customer>();

            while (reader.Read())
            {
                ssnid = int.Parse(reader["ssn_id"].ToString());
                cid = int.Parse(reader["customer_id"].ToString());
                status = (reader["status"].ToString());
                msg = (reader["message"].ToString());
                lastupdated = DateTime.Parse(reader["lastupdated"].ToString());
                clist.Add(new Customer(ssnid, cid, status, msg, lastupdated));
            }

            conn.Close();

            return clist;
        }


    }
}
