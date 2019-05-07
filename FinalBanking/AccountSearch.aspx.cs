using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalBanking
{
    public partial class AccountSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void viewButton1_Click(object sender, EventArgs e)
        {
            if (accidTextBox1.Text == "")
            {
                Session["cid"] = custidTextBox1.Text;
                Session["aid"] = 0;
                Response.Redirect("Accountdetails.aspx");
            }
            else if (custidTextBox1.Text == "")
            {
                Session["cid"] = 0;
                Session["aid"] = accidTextBox1.Text;
                Response.Redirect("Accountdetails.aspx");
            }
        }

        protected void accidTextBox1_TextChanged(object sender, EventArgs e)
        {
            custidTextBox1.ReadOnly = true;
        }

        protected void custidTextBox1_TextChanged(object sender, EventArgs e)
        {
            accidTextBox1.ReadOnly = true;
        }
    }
}