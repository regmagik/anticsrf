using System;
using System.Web.Helpers;
using System.Web.UI;

namespace AntyForgery
{
    public class B : Page
    {
        protected void Page_Init(object sender, EventArgs e)
        {
            var antiForgeryToken = new LiteralControl(AntiForgery.GetHtml().ToHtmlString());
            Form.Controls.Add(antiForgeryToken);

            if(IsPostBack) AntiForgery.Validate();
        }
    }
    public partial class DefaultB : B
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