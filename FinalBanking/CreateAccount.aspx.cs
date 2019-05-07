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
    public partial class CreateAccount : System.Web.UI.Page
    {
        Account_process p = new Account_process();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton1_Click(object sender, EventArgs e)
        {
            int custid = Convert.ToInt32(custidTextBox1.Text);
            string acctype = acctypeDropDownList1.SelectedValue.ToString();
            int depositamt = Convert.ToInt32(depositTextBox1.Text);

            int res=p.addaccprocess(custid, acctype, depositamt);

            if (res == 1)
                Response.Write("<script type=\"text/javascript\">alert('Account created Successfully!');</script>");
            else
                Response.Write("<script type=\"text/javascript\">alert('Process Failed! Please try again');</script>");
        }
    }
}