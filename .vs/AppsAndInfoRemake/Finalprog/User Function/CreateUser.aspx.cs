using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Finalprog
{
    public partial class CreateUser : System.Web.UI.Page
    { //make email unique
        public static int key = 5635;
        public static bool con;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void dropRole_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropRole.SelectedIndex == 1)
            {
                txtAdminConfirm.Visible = true;
                btnAdminConfrim.Visible = true;
                lblAdmin.Visible = true;
                con = false;
            }
            else
            {
                txtAdminConfirm.Visible = false;
                btnAdminConfrim.Visible = false;
                lblAdmin.Visible = false;
                con = true;
            }
                
        }

        protected void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnAdminConfrim_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(txtAdminConfirm.Text) == key)
            {
                con = true;
                lblAdminConfirm.Visible = true;
                lblAdminConfirm.Text = "Access Granted";
                lblAdminConfirm.ForeColor = System.Drawing.Color.Green;
            }
            else if (Int32.Parse(txtAdminConfirm.Text) != key)
            {
                con = false;
                lblAdminConfirm.Visible = true;
                lblAdminConfirm.Text = "Access Denied, Incorrect Passcode";
                lblAdminConfirm.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            UserDataClassesDataContext us = new UserDataClassesDataContext();
            Security sec = new Security();
            string enc = sec.EncryptString(txtPassword.Text);
            if(!us.users.Any(x => x.username == txtUsername.Text))
            {
                if (con == true)
                {

                    user u = new user
                    {
                        username = txtUsername.Text,
                        password = enc,
                        first_name = txtFirstname.Text,
                        last_name = txtLastname.Text,
                        phone_number = txtPhone.Text,
                        role = dropRole.SelectedValue,
                        organization = DropDownList3.SelectedValue,
                        degree = DropDownList2.SelectedValue,
                        email = txtEmail.Text,
                        RoleID = us.Roles.Where(a => a.Description == dropRole.SelectedValue).Select(a => a.Id).FirstOrDefault(),
                    };

                    us.users.InsertOnSubmit(u);
                    us.SubmitChanges();
                    Response.Redirect("Login.aspx");
                }
                else if (con == false)
                {
                    lblFail.Visible = true;
                }
            }
            else if(us.users.Any(x => x.username == txtUsername.Text))
            {
                lblUnique.Visible = true;
                lblUnique.Text = "Username Already Taken";
                lblUnique.ForeColor = System.Drawing.Color.Red;
            }
        }
    }
}