using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public interface IAccount
    {
        int Account_id { get; set; }
        string Account_type { get; set; }
        DateTime Created_date { get; set; }
        int Customer_id { get; set; }
        float Deposit_amount { get; set; }
        string Message { get; set; }
        float Sbalance { get; set; }
        string Status { get; set; }
        float Tbalance { get; set; }
    }
}
