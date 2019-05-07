using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BO
{
   public class Account : IAccount
    {
        int customer_id;
        int account_id;
        float sbalance;
        float tbalance;
        string account_type;
        float deposit_amount;
        string status;
        DateTime created_date;
        string message;

        public Account(int account_id)
        {
            this.account_id = account_id;
        }

       

        public Account(int account_id, int customer_id, string account_type, string status, DateTime created_date, string message, float deposit_amount)
        {
            this.account_id = account_id;
            this.customer_id = customer_id;
            this.account_type = account_type;
            this.status = status;
            this.created_date = created_date;
            this.message = message;
            this.deposit_amount = deposit_amount;
        }

        public Account(int account_id, int customer_id, string account_type, string status, DateTime created_date, string message)
        {
            this.account_id = account_id;
            this.customer_id = customer_id;
            this.account_type = account_type;
            this.status = status;
            this.created_date = created_date;
            this.message = message;
        }

        public Account(int account_id, string account_type, float deposit_amount)
        {
            this.account_id = account_id;
            this.account_type = account_type;
            this.deposit_amount = deposit_amount;
        }

        public Account(float deposit_amount)
        {
            this.deposit_amount = deposit_amount;
        }

        public Account(string account_type, float deposit_amount)
        {
            this.account_type = account_type;
            this.deposit_amount = deposit_amount;
        }

        public int Account_id
        {
            get
            {
                return account_id;
            }

            set
            {
                account_id = value;
            }
        }

        public int Customer_id
        {
            get
            {
                return customer_id;
            }

            set
            {
                customer_id = value;
            }
        }

        public string Account_type
        {
            get
            {
                return account_type;
            }

            set
            {
                account_type = value;
            }
        }

        public float Deposit_amount
        {
            get
            {
                return deposit_amount;
            }

            set
            {
                deposit_amount = value;
            }
        }

        public DateTime Created_date
        {
            get
            {
                return created_date;
            }

            set
            {
                created_date = value;
            }
        }

        public string Message
        {
            get
            {
                return message;
            }

            set
            {
                message = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public float Sbalance
        {
            get
            {
                return sbalance;
            }

            set
            {
                sbalance = value;
            }
        }

        public float Tbalance
        {
            get
            {
                return tbalance;
            }

            set
            {
                tbalance = value;
            }
        }
    }
}
