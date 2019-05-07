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
    public partial class Updatecustomer : System.Web.UI.Page
    {
        Process p = new Process();
        List<Customer> clist = new List<Customer>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                clist=p.viewcid();
                ddlid.DataSource = p.viewcid();
                ddlid.DataTextField = "Customer_id";
                ddlid.DataValueField = "Customer_id";
                ddlid.DataBind();

                ddlid.Items.Add(new ListItem("Select Customer ID", "selid"));
                ddlid.ClearSelection();
                ddlid.Items.FindByValue("selid").Selected = true;
            }
        }

        protected void updateButton1_Click(object sender, EventArgs e)
        {
            int res;
            int custid = Convert.ToInt32(lbleid.Text);
            string msg = "Updated Successfully";
            string oldcustname = lblename.Text;
            int oldage = int.Parse(lbleage.Text);
            string oldadd = lbleaddress.Text;


            if (newcustnameTextBox1.Text == "" & newageTextBox1.Text == "" & newaddressTextBox1.Text == "")
            {
                Response.Write("<script type=\"text/javascript\">alert('Enter values for updating');</script>");
            }

            else if (newcustnameTextBox1.Text == "" & newageTextBox1.Text == "")
            {
                string newadd = newaddressTextBox1.Text;

                res = p.updatecustprocess(custid, oldcustname, newadd, oldage, msg);
                if (res == 1)
                {
                    Response.Write("<script type=\"text/javascript\">alert('Updated Successfully!');</script>");
                    
                    newcustnameTextBox1.Text = string.Empty;
                    newaddressTextBox1.Text = string.Empty;
                    newageTextBox1.Text = string.Empty;
                }
                else
                    Response.Write("<script type=\"text/javascript\">alert('Process Failed! Please try again');</script>");
            }

            else if (newageTextBox1.Text == "" & newaddressTextBox1.Text == "")
            {
                string newcustname = newcustnameTextBox1.Text;
                
                res = p.updatecustprocess(custid, newcustname, oldadd, oldage, msg);
                if (res == 1)
                {
                    Response.Write("<script type=\"text/javascript\">alert('Updated Successfully!');</script>");
                    
                    newcustnameTextBox1.Text = string.Empty;
                    newaddressTextBox1.Text = string.Empty;
                    newageTextBox1.Text = string.Empty;
                }
                else
                    Response.Write("<script type=\"text/javascript\">alert('Process Failed! Please try again');</script>");
            }

            else if (newcustnameTextBox1.Text == "" & newaddressTextBox1.Text == "")
            {
                int newage = Convert.ToInt32(newageTextBox1.Text);
                
                res = p.updatecustprocess(custid, oldcustname, oldadd, newage, msg);
                if (res == 1)
                {
                    Response.Write("<script type=\"text/javascript\">alert('Updated Successfully!');</script>");
                    
                    newcustnameTextBox1.Text = string.Empty;
                    newaddressTextBox1.Text = string.Empty;
                    newageTextBox1.Text = string.Empty;
                }
                else
                    Response.Write("<script type=\"text/javascript\">alert('Process Failed! Please try again');</script>");
            }

            else if(newcustnameTextBox1.Text!=""& newaddressTextBox1.Text!=""& newageTextBox1.Text!="")
            {
                string newcustname = newcustnameTextBox1.Text;
                string newadd = newaddressTextBox1.Text;
                int newage = Convert.ToInt32(newageTextBox1.Text);

                res = p.updatecustprocess(custid, newcustname, newadd, newage, msg);
                if (res == 1)
                {
                    Response.Write("<script type=\"text/javascript\">alert('Updated Successfully!');</script>");
                    
                    newcustnameTextBox1.Text = string.Empty;
                    newaddressTextBox1.Text = string.Empty;
                    newageTextBox1.Text = string.Empty;
                }
                else
                    Response.Write("<script type=\"text/javascript\">alert('Process Failed! Please try again');</script>");
            }
            
            else if(newcustnameTextBox1.Text=="")
            {
                string newadd = newaddressTextBox1.Text;
                int newage = Convert.ToInt32(newageTextBox1.Text);

                res = p.updatecustprocess(custid, oldcustname, newadd, newage, msg);
                if (res == 1)
                {
                    Response.Write("<script type=\"text/javascript\">alert('Updated Successfully!');</script>");
                    
                    newcustnameTextBox1.Text = string.Empty;
                    newaddressTextBox1.Text = string.Empty;
                    newageTextBox1.Text = string.Empty;
                }
                else
                    Response.Write("<script type=\"text/javascript\">alert('Process Failed! Please try again');</script>");
            }
            else if(newaddressTextBox1.Text=="")
            {
                string newcustname = newcustnameTextBox1.Text;
                int newage = Convert.ToInt32(newageTextBox1.Text);

                res = p.updatecustprocess(custid, newcustname, oldadd, newage, msg);
                if (res == 1)
                {
                    Response.Write("<script type=\"text/javascript\">alert('Updated Successfully!');</script>");
                    
                    newcustnameTextBox1.Text = string.Empty;
                    newaddressTextBox1.Text = string.Empty;
                    newageTextBox1.Text = string.Empty;
                }
                else
                    Response.Write("<script type=\"text/javascript\">alert('Process Failed! Please try again');</script>");
            }
            else if (newageTextBox1.Text == "")
            {
                string newcustname = newcustnameTextBox1.Text;
                string newadd = newaddressTextBox1.Text;

                res = p.updatecustprocess(custid, newcustname, newadd, oldage, msg);
                if (res == 1)
                {
                    Response.Write("<script type=\"text/javascript\">alert('Updated Successfully!');</script>");
                    
                    newcustnameTextBox1.Text = string.Empty;
                    newaddressTextBox1.Text = string.Empty;
                    newageTextBox1.Text = string.Empty;
                }
                else
                    Response.Write("<script type=\"text/javascript\">alert('Process Failed! Please try again');</script>");
            }

        }

        protected void ddlid_SelectedIndexChanged(object sender, EventArgs e)
        {try
            {
                int id = int.Parse(ddlid.Text);

                clist = p.viewcdetails1(id);

                lblessnid.Text = (clist[0].Ssnid).ToString();
                lbleid.Text = (clist[0].Customer_id).ToString();
                lblename.Text = clist[0].Customer_name;
                lbleage.Text = (clist[0].Age).ToString();
                lbleaddress.Text = clist[0].Address;
            }
            catch (Exception) { Response.Write("<script type=\"text/javascript\">alert('Customer unavailable!');</script>"); }
        }
    }
}