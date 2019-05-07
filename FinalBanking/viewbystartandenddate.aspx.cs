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
    public partial class viewbystartandenddate : System.Web.UI.Page
    {
        Transaction_process p = new Transaction_process();
        List<Transact> tlist = new List<Transact>();

        protected void Page_Load(object sender, EventArgs e)
        {
            txtaccid.Text = Session["accid"].ToString();
        }

        protected void submitButton1_Click(object sender, EventArgs e)
        {
            int accid = Convert.ToInt32(txtaccid.Text);
            DateTime stdate = Convert.ToDateTime(startdateTextBox1.Text);
            DateTime enddate = Convert.ToDateTime(enddateTextBox1.Text);

            tlist = p.viewtransactprocess(accid, stdate, enddate);
            Grid.DataSource = tlist;
            Grid.DataBind();
        }
    }
}