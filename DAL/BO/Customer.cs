using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Types;

namespace BO
{
    public class Customer : ICustomer
    {
        string customer_name;
        int age;
        string address;
        string state;
        string city;
        int ssnid;
        int customer_id;
        string status;
        string message;
        DateTime lastupdated;

        public Customer(int customer_id)
        {
            this.customer_id = customer_id;
        }


        public Customer(int ssnid, int customer_id, string customer_name, int age, string address)
        {
            this.ssnid = ssnid;
            this.customer_id = customer_id;
            this.customer_name = customer_name;
            this.age = age;
            this.address = address;
        }

        public Customer(int ssnid, int customer_id, string status, string message, DateTime lastupdated)
        {
            this.ssnid = ssnid;
            this.customer_id = customer_id;
            this.status = status;
            this.message = message;
            this.lastupdated = lastupdated;
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

        public string Customer_name
        {
            get
            {
                return customer_name;
            }

            set
            {
                customer_name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public string State
        {
            get
            {
                return state;
            }

            set
            {
                state = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
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

        public DateTime Lastupdated
        {
            get
            {
                return lastupdated;
            }

            set
            {
                lastupdated = value;
            }
        }

        public int Ssnid
        {
            get
            {
                return ssnid;
            }

            set
            {
                ssnid = value;
            }
        }
    }
}
