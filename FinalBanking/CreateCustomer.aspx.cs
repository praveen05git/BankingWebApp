using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;

namespace FinalBanking
{
    public partial class CreateCustomer : System.Web.UI.Page
    {
        Process p = new Process();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submitButton1_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                int ssnid = Convert.ToInt32(custssnidTextBox1.Text);
                string name = custnameTextBox1.Text;
                int age = Convert.ToInt32(ageTextBox1.Text);
                string add = addresTextBox1.Text;
                string state = ddlstate.SelectedValue.ToString();
                string city = ddlcity.SelectedValue.ToString();
                string status = "Active", message = "Created Successfully";
                DateTime lastupdated = DateTime.Now;

                int result = p.addcustprocess(ssnid, name, age, add, state, city, status, message, lastupdated);

                if (result == 1)
                {
                    Response.Write("<script type=\"text/javascript\">alert('Customer added Successfully!');</script>");
                    addresTextBox1.Text = string.Empty;
                    ageTextBox1.Text = string.Empty;
                    custnameTextBox1.Text = string.Empty;
                    custssnidTextBox1.Text = string.Empty;
                    ddlcity.ClearSelection();
                    ddlstate.ClearSelection();
                }
                else
                    Response.Write("<script type=\"text/javascript\">alert('Process Failed! Please try again');</script>");
            }

        }

        protected void stateDropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ddlstate.SelectedValue == "Kerala")
            {
                ddlcity.Items.Clear();
                ddlcity.Items.Add(new ListItem("Select", "Select"));
                ddlcity.Items.Add(new ListItem("Cochin", "Cochin"));
                ddlcity.Items.Add(new ListItem("Trivandram", "Trivandram"));

            }

            else if (ddlstate.SelectedValue == "TamilNadu")
            {
                ddlcity.Items.Clear();
                ddlcity.Items.Add(new ListItem("Select", "Select"));
                ddlcity.Items.Add(new ListItem("Thanjavur", "Thanjavur"));
                ddlcity.Items.Add(new ListItem("Trichy", "Trichy"));
            }
        }

        protected void resetButton1_Click(object sender, EventArgs e)
        {
            addresTextBox1.Text = string.Empty;
            ageTextBox1.Text = string.Empty;
            custnameTextBox1.Text = string.Empty;
            custssnidTextBox1.Text = string.Empty;
            ddlcity.ClearSelection();
            ddlstate.ClearSelection();
        }
    }
}