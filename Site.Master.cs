using System;
using System.Web.UI;

namespace MCloud
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["LoginId"] != null && Session["Name"]!=null)
                {
                    btnAlogin.Visible = false;
                    lblName.Text = Session["Name"].ToString();
                }
                else
                {
                    Response.Redirect("~/SignUpAndSignIn.aspx");
                }
            }
        }

        protected void lnkLogout_Click(object sender, EventArgs e)
        {
            Session.RemoveAll();
            Session.Abandon();
            Response.Redirect("~/SignUpAndSignIn.aspx");
        }
    }
}