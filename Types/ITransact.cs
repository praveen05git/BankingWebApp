using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    public interface ITransact
    {
        int Account_id { get; set; }
        float Amount { get; set; }
        float Balance { get; set; }
        int Customer_id { get; set; }
        string Description { get; set; }
        DateTime Transaction_date { get; set; }
        int Transaction_id { get; set; }
    }
}
