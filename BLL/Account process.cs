using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;
using Types;

namespace BLL
{
    public class Account_process
    {
        a_operations ob = new a_operations();
        List<Account> alist = new List<Account>();

        public List<Account> accid()
        {
            alist = ob.displayaccid();
            return alist;
        }

        public List<Account> accid1(int custid)
        {
            alist = ob.displayaccid1(custid);
            return alist;
        }

        public int deleteaccountprocess(int accid)
        {
            int res = ob.deleteaccount(accid);
            return res;
        }

        public List<Account> acctype(int accid)
        {
            alist = ob.displayacctype(accid);
            return alist;
        }

        public List<Account> viewadetails(int cid,int aid)
        {
            return ob.account_search(cid,aid);
        }
        public List<Account> bindData()
        {
            alist = ob.astatus();
            return alist;
        }
        public int addaccprocess(int id,string acctype,float amt)
        {
            return ob.addaccount(id, acctype, amt);
        }
    }
}
