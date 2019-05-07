using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BO;
using BLL;
using Types;
namespace FinalBanking
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        Account_process ap = new Account_process();
        List<Account> alist = new List<Account>();

        protected void Page_Load(object sender, EventArgs e)
        { 
            try
            {
                int aid = int.Parse(Session["aid"].ToString());

                int cid = int.Parse(Session["cid"].ToString());

                if (aid == 0)
                {
                if (!IsPostBack)

                {
                    alist = ap.accid1(cid);
                    accid.DataSource = alist;
                    accid.DataTextField = "Account_id";
                    accid.DataValueField = "Account_id";
                    accid.DataBind();

                    accid.Items.Add(new ListItem("Select Account ID", "selid"));
                    accid.ClearSelection();
                    accid.Items.FindByValue("selid").Selected = true;
                }

                }
                else if (cid == 0)
                {
                    accid.Enabled= false;
                    alist = ap.viewadetails(cid, aid);
                    string accountid = (alist[0].Account_id).ToString();
                    accid.Items.Add(new ListItem(accountid, accountid));
                    custidTextBox1.Text = (alist[0].Customer_id).ToString();
                    acctypeTextBox1.Text = (alist[0].Account_type).ToString();
                    statusTextBox1.Text = (alist[0].Status).ToString();
                    lastupdatedTextBox1.Text = (alist[0].Created_date).ToString();
                    messageTextBox1.Text = (alist[0].Message).ToString();
                    depositamtTextBox1.Text = (alist[0].Deposit_amount).ToString();


                    if (acctypeTextBox1.Text == null)
                        Response.Write("<script type=\"text/javascript\">alert('Customer unavailable!');</script>");
                }
            }
            catch (Exception) { Response.Write("<script type=\"text/javascript\">alert('Customer unavailable!');</script>"); }
        }

        protected void accid_SelectedIndexChanged(object sender, EventArgs e)
        {
            int aid =int.Parse(accid.SelectedValue);
            int cid = 0;

            alist = ap.viewadetails(cid, aid);
            custidTextBox1.Text = (alist[0].Customer_id).ToString();
            acctypeTextBox1.Text = (alist[0].Account_type).ToString();
            statusTextBox1.Text = (alist[0].Status).ToString();
            lastupdatedTextBox1.Text = (alist[0].Created_date).ToString();
            messageTextBox1.Text = (alist[0].Message).ToString();
            depositamtTextBox1.Text = (alist[0].Deposit_amount).ToString();


            if (acctypeTextBox1.Text == null)
                Response.Write("<script type=\"text/javascript\">alert('Customer unavailable!');</script>");
        }
    }
}