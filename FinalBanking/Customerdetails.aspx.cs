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
    public partial class WebForm1 : System.Web.UI.Page
    {
        Process p = new Process();
        List<Customer> clist = new List<Customer>();

        protected void Page_Load(object sender, EventArgs e)
        {try
            {
                int sid = int.Parse(Session["sid"].ToString());
                int cid = int.Parse(Session["cus"].ToString());

                clist = p.viewcdetails(sid,cid);

                lbleiid.Text = (clist[0].Ssnid).ToString();
                lbleid.Text = (clist[0].Customer_id).ToString();
                lblename.Text = clist[0].Customer_name;
                lbleage.Text = (clist[0].Age).ToString();
                lbleadd.Text = clist[0].Address;

                if (lblename.Text == null)
                    Response.Write("<script type=\"text/javascript\">alert('Customer unavailable!');</script>");
            }
            catch (Exception) { Response.Write("<script type=\"text/javascript\">alert('Customer unavailable!');</script>"); }
        }
    }
}