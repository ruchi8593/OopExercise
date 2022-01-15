using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Session_cookies
{
    public partial class ViewState : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void login_Click(object sender, EventArgs e)
        {


            if (tbpassword.Text == "abc123")
            {
                // Storing email to Session variable  
                ViewState["email"] = tbemail.Text;
                ViewState["pwd"] = tbpassword.Text;


            }
            // Checking Session variable is not empty  
            if (ViewState["email"] != null)
            {
                // Displaying stored email  
                Label3.Text = "This email is stored to the session.";
                Label4.Text = ViewState["email"].ToString();

            }
        }
    }
}