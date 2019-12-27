using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AntyForgery
{
    public partial class DefaultAF : Page
    {

        bool oneClickAttackDetected = false;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
               DetectOneClickAttack();
            }
            lblPostback.Text = $"IsPostBack:{IsPostBack}";
        }

        private void DetectOneClickAttack()
        {
            if (Request.QueryString["__VIEWSTATE"] != null)
            {
                oneClickAttackDetected = true;
                return; // or throw to prevent any further processing; alert security team...
            }
        }

        protected void Save_Click(object sender, EventArgs e)
        {
            System.Web.Helpers.AntiForgery.Validate();

            if (oneClickAttackDetected)
            {
                Label1.Text = $"One Click Attack Detected with  {TextBox1.Text}";
                return;
            }
            Label1.Text = $"Saved {TextBox1.Text}";
        }
    }
}