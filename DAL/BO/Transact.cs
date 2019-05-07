using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BO
{
   public class Transact : ITransact
    {
        int account_id;
        int customer_id;
        int transaction_id;
        DateTime transaction_date;
        float amount;
        float balance;
        string description;

        public Transact(int transaction_id, DateTime transaction_date, float amount,float balance, string description)
        {
            this.transaction_id = transaction_id;
            this.transaction_date = transaction_date;
            this.amount = amount;
            this.balance = balance;
            this.description = description;
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

        public int Transaction_id
        {
            get
            {
                return transaction_id;
            }

            set
            {
                transaction_id = value;
            }
        }

        public DateTime Transaction_date
        {
            get
            {
                return transaction_date;
            }

            set
            {
                transaction_date = value;
            }
        }

        public float Amount
        {
            get
            {
                return amount;
            }

            set
            {
                amount = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public float Balance
        {
            get
            {
                return balance;
            }

            set
            {
                balance = value;
            }
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
    }
}
