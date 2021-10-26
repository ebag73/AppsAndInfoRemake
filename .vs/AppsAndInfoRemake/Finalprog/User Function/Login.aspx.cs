using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Finalprog
{
    public partial class Login : System.Web.UI.Page
    {
        public static string currentUser;
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void btnLogin_Click(object sender, EventArgs e)
        {
            Security sec = new Security();
            //string enc = sec.EncryptString(txtpass.Text);
            UserDataClassesDataContext us = new UserDataClassesDataContext();
            if (us.users.Any(x => x.username == txtuser.Text))// && us.users.Any(xy => xy.password == enc)))
            {
                user ev = us.users.FirstOrDefault(x => x.username == (txtuser.Text));
                if(sec.DecryptString(ev.password) == txtpass.Text)
                {
                    currentUser = txtuser.Text;
                    Response.Redirect("UserPage.aspx");
                }
                else if (sec.DecryptString(ev.password) != txtpass.Text)
                {
                    Label1.Visible = true;
                    Label1.Text = "Invalid Username or Password";
                }
                
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Invalid Username or Password";
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateUser.aspx");
        }
    }
}