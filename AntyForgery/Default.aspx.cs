using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AntyForgery
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblPostback.Text = $"IsPostBack:{IsPostBack}";
        }
        protected void Save_Click(object sender, EventArgs e)
        {
           // System.Web.Helpers.AntiForgery.Validate();

            Label1.Text = $"Saved {TextBox1.Text}";
        }
    }
}