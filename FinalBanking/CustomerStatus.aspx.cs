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
    public partial class CustomerStatus : System.Web.UI.Page
    {
        List<Customer> slist = new List<Customer>();
        Process p = new Process();

        protected void Page_Load(object sender, EventArgs e)
        {
            slist=p.bindData();
            Grid.DataSource = slist;
            Grid.DataBind();
        }

        protected void viewdetails_Click(object sender, EventArgs e)
        {
            
        }

        protected void refresh_Click(object sender, EventArgs e)
        {
            Response.Redirect("CustomerStatus.aspx");
        }

    }
}