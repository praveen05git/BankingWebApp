using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using BO;

namespace FinalBanking
{
    public partial class DeleteAccount : System.Web.UI.Page
    {
        Account_process p = new Account_process();
        List<Account> alist = new List<Account>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                alist = p.accid();
                ddlid.DataSource = alist;
                ddlid.DataTextField = "Account_id";
                ddlid.DataValueField = "Account_id";
                ddlid.DataBind();

                ddlid.Items.Add(new ListItem("Select Account ID", "selid"));
                ddlid.ClearSelection();
                ddlid.Items.FindByValue("selid").Selected = true;
            }
        }

        protected void deleteButton1_Click(object sender, EventArgs e)
        {
            int accid = Convert.ToInt32(ddlid.SelectedValue);
            int res = p.deleteaccountprocess(accid);
            if (res == 1)
            {
                Response.Write("<script type=\"text/javascript\">alert('Account deleted Successfully!');</script>");
                ddlid.ClearSelection();
                acctypeTextBox1.Text = string.Empty;
            }
            else
                Response.Write("<script type=\"text/javascript\">alert('Process Failed! Please try again');</script>");
        }

        protected void acidDropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {try
            {
                int accid = Convert.ToInt32(ddlid.SelectedValue);
                alist = p.acctype(accid);
                acctypeTextBox1.Text = (alist[0].Account_type).ToString();
                float amt=float.Parse((alist[0].Deposit_amount).ToString());
            }
            catch (Exception) { Response.Write("<script type=\"text/javascript\">alert('Account unavailable!');</script>"); }

        }
    }
}