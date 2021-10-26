using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Finalprog.User_Function
{
    public partial class Admin : System.Web.UI.Page
    {
        public static UserDataClassesDataContext us = new UserDataClassesDataContext();
        public static int count = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Login.currentUser))
            {
                Response.Redirect("Login.aspx");
            }
            if (count == 0)
            {
                foreach (GridViewRow gridRow in GridView1.Rows)
                {
                    gridRow.Cells[8].Text = us.Roles.Where(a => a.Id == Int32.Parse(gridRow.Cells[8].Text)).Select(a => a.Description).FirstOrDefault();
                } 
            }
            count++;
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            user eo = (from f in us.users
                       where f.username == Login.currentUser
                       select f).SingleOrDefault();

            us.SubmitChanges();
            Login.currentUser = "";
            Response.Redirect("~/User Function/Login.aspx");
        }

        protected void btnCourse_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Search Function/SearchPage.aspx");
        }


        protected void btnUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User Function/UserPage.aspx");
        }
    }
}