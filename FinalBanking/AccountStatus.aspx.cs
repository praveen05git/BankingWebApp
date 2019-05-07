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
    public partial class AccountStatus : System.Web.UI.Page
    {
        Account_process p = new Account_process();
        List<Account> slist = new List<Account>();

        protected void Page_Load(object sender, EventArgs e)
        {
            slist = p.bindData();
            Grid.DataSource = slist;
            Grid.DataBind();
        }

        protected void refreshLinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("AccountStatus.aspx");
        }
    }
}