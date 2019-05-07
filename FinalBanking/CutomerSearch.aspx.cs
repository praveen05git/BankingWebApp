using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FinalBanking
{
    public partial class CutomerSearch : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void viewButton1_Click(object sender, EventArgs e)
        {
            if (ssnidTextBox1.Text == "")
            {
                Session["cus"] = custidTextBox1.Text;
                Session["sid"] = 0;
                Response.Redirect("Customerdetails.aspx");
            }
            else if (custidTextBox1.Text == "")
            {
                Session["cus"] = 0;
                Session["sid"] = ssnidTextBox1.Text;
                Response.Redirect("Customerdetails.aspx");
            }
        }

        protected void ssnidTextBox1_TextChanged(object sender, EventArgs e)
        {
            custidTextBox1.ReadOnly = true;
        }

        protected void custidTextBox1_TextChanged(object sender, EventArgs e)
        {
            ssnidTextBox1.ReadOnly = true;
        }
    }
}