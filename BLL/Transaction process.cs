using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
using DAL;

namespace BLL
{
    public class Transaction_process
    {
        T_operations ob = new T_operations();

        public List<Account> viewfordep(int id)
        {
            return ob.account_search(id);
        }

        public int depositprocess(int accid, float depositamt, float balance)
        {
            return ob.deposit(accid, depositamt, balance);
        }

        public int depositprocess1(int accid, float depositamt, float balance)
        {
            return ob.deposit1(accid, depositamt, balance);
        }
        public int transferprocess(int sid, int tid, float amt, float sb, float tgb)
        {
            return ob.transfer(sid, tid, amt, sb, tgb);
        }
        public List<Account> viewamtprocess(int sid)
        {
            return ob.viewamt(sid);
        }
        public List<Transact>viewtransactprocess(int id, DateTime sdate, DateTime edate)
        {
            List<Transact> tlist = new List<Transact>();
            return ob.viewtransact(id, sdate, edate);
        }
        public List<Transact> viewbycount(int id,int count)
        {
            List<Transact> tlist = new List<Transact>();
            return ob.viewtransact1(id, count);
        }
    }
}
