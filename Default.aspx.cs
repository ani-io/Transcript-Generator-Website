using MCloud.App_Code;
using System;
using System.IO;
using System.Linq;
using System.Web;

namespace MCloud
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["LoginId"]==null)
                {
                    Response.Redirect("~/User/UserLogin.aspx");

                }
            }
        }
    }
}