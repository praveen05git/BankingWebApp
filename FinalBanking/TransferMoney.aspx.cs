using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BO;
using BLL;

namespace FinalBanking
{
    public partial class TransferMoney : System.Web.UI.Page
    {
        Transaction_process t = new Transaction_process();
        List<Account> tlist = new List<Account>();

        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void ButtonTransfer_Click(object sender, EventArgs e)
        {
            int sid=int.Parse(txtsid.Text);
            int tid=int.Parse(txttid.Text);
            float amt=float.Parse(txtamt.Text);

            List<Account> s = new List<Account>();
            s = t.viewamtprocess(sid);
            float source = (s[0].Deposit_amount)-amt;

            List <Account>d = new List<Account>();
            d = t.viewamtprocess(tid);
            float dest = (d[0].Deposit_amount)+amt;

            if (source==-1|dest==-1)
            {
                Response.Write("<script type=\"text/javascript\">alert('Inactive Account');</script>");
            }
            else if (dest > 0)
            {
                if (source < amt)
                {
                    Response.Write("<script type=\"text/javascript\">alert('Insufficient Balance');</script>");
                }
                else if (source > amt)
                { 
                    int res = t.transferprocess(sid, tid, amt, source, dest);

                    if (res > 0)
                    {
                        Response.Write("<script type=\"text/javascript\">alert('Tranferred');</script>");
                        txtamt.Text = string.Empty;
                        txtsid.Text = string.Empty;
                        txttid.Text = string.Empty;
                        ddltype.Text = string.Empty;
                    }
                    else
                        Response.Write("<script type=\"text/javascript\">alert('Process Failed');</script>");
                }
            }
        }
    }
}