using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace FinalBanking
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
        }

        protected void login_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                string uname = username.Text.Trim();
                string pwd = password.Text.Trim();

                Session["UserName"] = null;

                if (FormsAuthentication.Authenticate(uname, pwd))
                {
                    Session["UserName"] = uname;

                    FormsAuthentication.RedirectFromLoginPage(uname, false);
                }
            }

        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {

        }
    }
}