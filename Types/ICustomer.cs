using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
        public interface ICustomer
        {
            string Address { get; set; }
            int Age { get; set; }
            string City { get; set; }
            int Customer_id { get; set; }
            string Customer_name { get; set; }
            DateTime Lastupdated { get; set; }
            string Message { get; set; }
            int Ssnid { get; set; }
            string State { get; set; }
            string Status { get; set; }
        }
}
