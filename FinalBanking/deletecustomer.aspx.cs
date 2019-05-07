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
    public partial class deletecustomer : System.Web.UI.Page
    {
        Process p = new Process();
        List<Customer> dlist = new List<Customer>();

        protected void Page_Load(object sender, EventArgs e)
        {
            
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

        protected void delteButton1_Click(object sender, EventArgs e)
        {try
            {
                int customerid = Convert.ToInt32(txtcustid.Text);
                int res = p.deletecustprocess(customerid);

                if (res == 1)
                {
                    Response.Write("<script type=\"text/javascript\">alert('Customer deleted Successfully!');</script>");
                    txtaddress.Text = string.Empty;
                    txtage.Text = string.Empty;
                    txtcustid.Text = string.Empty;
                    txtcustname.Text = string.Empty;
                    txtcustssnid.Text = string.Empty;
                    ddlid.ClearSelection();
                }
                else
                    Response.Write("<script type=\"text/javascript\">alert('Process Failed! Please try again');</script>");
            }
            catch (Exception) { Response.Write("<script type=\"text/javascript\">alert('Customer unavailable!');</script>"); }
        }

        protected void ddlid_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(ddlid.Text);

                dlist = p.viewcdetails1(id);

                txtcustssnid.Text = (dlist[0].Ssnid).ToString();
                txtcustid.Text = (dlist[0].Customer_id).ToString();
                txtcustname.Text = dlist[0].Customer_name;
                txtage.Text = (dlist[0].Age).ToString();
                txtaddress.Text = dlist[0].Address;
            }

            catch (Exception) { Response.Write("<script type=\"text/javascript\">alert('Customer unavailable!');</script>"); }
        }

        protected void cancelButton1_Click(object sender, EventArgs e)
        {
            txtaddress.Text = string.Empty;
            txtage.Text = string.Empty;
            txtcustid.Text = string.Empty;
            txtcustname.Text = string.Empty;
            txtcustssnid.Text = string.Empty;
            ddlid.ClearSelection();
        }
    }
}