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
    public partial class DepositMoney : System.Web.UI.Page
    {
        Transaction_process p = new Transaction_process();
        Account_process ap = new Account_process();

        protected void Page_Load(object sender, EventArgs e)
        {
            Process p = new Process();
            List<Customer> dlist = new List<Customer>();

            if (!IsPostBack)
            {
                dlist = p.viewcid();
                ddlid.DataSource = p.viewcid();
                ddlid.DataTextField = "Customer_id";
                ddlid.DataValueField = "Customer_id";
                ddlid.DataBind();

                ddlid.Items.Add(new ListItem("Select Customer ID", "selid"));
                ddlid.ClearSelection();
                ddlid.Items.FindByValue("selid").Selected = true;
            }
        }

        protected void ddlid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id;
            id = int.Parse(ddlid.SelectedValue.ToString());

            List<Account> tlist = new List<Account>();
            
                tlist = ap.accid1(id);
                ddlaccid.DataSource = tlist;
                ddlaccid.DataTextField = "Account_id";
                ddlaccid.DataValueField = "Account_id";
                ddlaccid.DataBind();

                ddlaccid.Items.Add(new ListItem("Select Account ID", "selid"));
                ddlaccid.ClearSelection();
                ddlaccid.Items.FindByValue("selid").Selected = true;
           
        }

         protected void ButtonSub1_Click(object sender, EventArgs e)
         {
             int accid = Convert.ToInt32(ddlaccid.Text);
             float depositamt = float.Parse(TextBox1.Text);
             float amt = float.Parse(lblebalance.Text);
             float currentbal;

            if (lbleacctype.Text == "")
            {
                Response.Write("<script type=\"text/javascript\">alert('Inactive Account');</script>");
            }
            else if(lbleacctype.Text=="Savings"|lbleacctype.Text=="Current")
            {
                if (depositamt > 0)
                {
                    currentbal = depositamt + amt;

                    int res = p.depositprocess(accid, depositamt, currentbal);

                    if (res > 0)
                    {
                        Response.Write("<script type=\"text/javascript\">alert('Credited Successfully!');</script>");
                        ddlaccid.ClearSelection();
                        ddlaccid.Items.FindByValue("selid").Selected = true;
                        lbleacctype.Text = string.Empty;
                        lblebalance.Text = string.Empty;
                        ddlid.ClearSelection();
                        ddlid.Items.FindByValue("selid").Selected = true;
                        TextBox1.Text = string.Empty;
                    }
                    else
                        Response.Write("<script type=\"text/javascript\">alert('Process Failed! Please try again');</script>");
                }

                else
                    Response.Write("<script type=\"text/javascript\">alert('Process Failed! Please Enter valid amount');</script>");
            }
        }

        protected void accid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aid=int.Parse(ddlaccid.SelectedValue);

            List<Account> tlist = new List<Account>();
            tlist =p.viewfordep(aid);

            lbleacctype.Text = tlist[0].Account_type;
            lblebalance.Text = (tlist[0].Deposit_amount).ToString();
        }
    }
}