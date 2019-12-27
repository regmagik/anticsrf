using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AntyForgery
{
    public partial class DefaultMP : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblPostback.Text = $"IsPostBack:{IsPostBack}";
        }
        protected void Save_Click(object sender, EventArgs e)
        {
            Label1.Text = $"Saved {TextBox1.Text}";
        }
    }
}