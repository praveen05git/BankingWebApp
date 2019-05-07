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
    public partial class Viewbynooftransaction : System.Web.UI.Page
    {
        Transaction_process p = new Transaction_process();
        List<Transact> tlist = new List<Transact>();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                if (selection.SelectedValue == "1")
                {
                    int accid = Convert.ToInt32(TextAccId.Text);
                    int count = Convert.ToInt32(DDLTransaction.Text);

                    tlist = p.viewbycount(accid, count);
                    Grid.DataSource = tlist;
                    Grid.DataBind();
                }
                else if (selection.SelectedValue == "2")
                {
                    Session["accid"] = TextAccId.Text;
                    Response.Redirect("viewbystartandenddate.aspx");
                }
            }
        }

        protected void Grid_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}