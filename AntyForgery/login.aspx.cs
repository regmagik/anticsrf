using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AntyForgery
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }
        protected void Admin_Click(object sender, EventArgs e)
        {
            FormsAuthentication.RedirectFromLoginPage("admin", true);
        }
        protected void Guest_Click(object sender, EventArgs e)
        {
            FormsAuthentication.RedirectFromLoginPage("guest", true);
        }
    }
}