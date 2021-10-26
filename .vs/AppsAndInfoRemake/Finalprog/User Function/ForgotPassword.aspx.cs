using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;

namespace Finalprog
{
    public partial class ForgotPassword : System.Web.UI.Page
    {
        static public int recov;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            Random yuh = new Random();
            UserDataClassesDataContext us = new UserDataClassesDataContext();
            if (us.users.Any(x => x.email == txtEmail.Text))
            {
                Random y = new Random();
                recov = yuh.Next(10000, 99999);
                string email = txtEmail.Text;
                try
                {
                    using (MailMessage mail = new MailMessage())
                    {
                        mail.From = new MailAddress("recovacc1234@gmail.com");
                        mail.To.Add(email);
                        mail.Subject = "Password Recovery";
                        mail.Body = "<h1>Your Recovery number is: " + recov + "</h1>";
                        mail.IsBodyHtml = true;
                        using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                        {
                            //SmtpClient.UseDefaultCredentials = false;
                            smtp.Credentials = new System.Net.NetworkCredential("recovacc1234@gmail.com", "testing123!");
                            smtp.EnableSsl = true;
                            smtp.Send(mail);
                            Label1.Visible = true;
                            Label1.ForeColor = System.Drawing.Color.Green;
                            Label1.Text = "Recovery # Sent";
                            lblConfirm.Visible = true;
                            txtConfirm.Visible = true;
                            btnComfirm.Visible = true;
                            Label1.Visible = false;
                        }
                    }

                }
                catch (Exception ex)
                {
                    Label1.Text = ex.Message;
                }
            }
            else
            {
                Label1.Visible = true;
                Label1.Text = "Email Incorrect";
            }

        }

        protected void btnComfirm_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(txtConfirm.Text) == recov)
            {
                lblNew.Visible = true;
                lblNewConfirm.Visible = true;
                txtNew.Visible = true;
                txtNewConfirm.Visible = true;
                lblFalse.Visible = false;
                btnConfirmNew.Visible = true;
            }
            else
            {
                lblFalse.Visible = true;
                lblFalse.ForeColor = System.Drawing.Color.Red;
            }
        }

        protected void btnConfirmNew_Click(object sender, EventArgs e)
        {
            UserDataClassesDataContext us = new UserDataClassesDataContext();
            Security sec = new Security();
            //user ev = us.users.FirstOrDefault(x => x.email == (txtEmail.Text));
            //ev.password = sec.EncryptString(txtNewConfirm.Text);
            ////us.users.InsertOnSubmit(ev);
            //us.SubmitChanges();



            (from f in us.users
             where f.email.Equals(txtEmail.Text)
             select f).FirstOrDefault().password = sec.EncryptString(txtNewConfirm.Text);

            us.SubmitChanges();

            //(from f in us.users
            //where f.email.Equals(txtEmail.Text)
            //select f)
            //       .FirstOrDefault().password = sec.EncryptString(txtNewConfirm.Text);

            //us.SubmitChanges();


            lblChanged.Visible = true;
        }

        protected void btnReturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
        }
    }
}