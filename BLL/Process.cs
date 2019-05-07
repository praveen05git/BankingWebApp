using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BO;

namespace BLL
{
    public class Process
    {
        c_operations ob = new c_operations();
        List<Customer> clist = new List<Customer>();
        int res;

        public int addcustprocess(int ssnid,string custname,int age,string address,string state,string city,string sts,string msg,DateTime updated)
        {
            res=ob.addcustomer(ssnid,custname,age,address,state,city,sts,msg,updated);
            return res;
        }
       public int deletecustprocess(int custid)
        {
            res = ob.deletecustomer(custid);
            return res;
        }
        public List<Customer> viewcid()
        {
            clist=ob.idviewer();
            return clist;
        }
        public List<Customer> viewcdetails(int sid,int cid)
        {
            return ob.customer_details(sid,cid);
        }
        public List<Customer> viewcdetails1( int cid)
        {
            return ob.customer_details1(cid);
        }
        public int updatecustprocess(int custid,string newcustname,string newaddress,int newage,string msg)
        {
            res = ob.updatecustomer(custid, newcustname, newaddress, newage,msg);
            return res;
        }

        public List<Customer> bindData()
        {
            clist = ob.cstatus();
            return clist;

        }
        
        
            }
}
