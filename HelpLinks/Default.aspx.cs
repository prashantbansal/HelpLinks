using System;

namespace HelpLinks
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Response.Redirect("HLPages/Links.aspx", true);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}