using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using Finalprog;

namespace Finalprog
{

    public partial class CoursePage : Page
    {
        public static UserDataClassesDataContext us = new UserDataClassesDataContext();
        public static Int32 course;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(Login.currentUser))
            {
                Response.Redirect("Login.aspx");
            }
            user eo = (from f in us.users
                       where f.username == Login.currentUser
                       select f).SingleOrDefault();
            var role = us.Roles.Where(a => a.Id == eo.RoleID).Select(a => a.Description).FirstOrDefault();

            if (eo != null)
            {
                if (role == "Admin")
                {
                    btnAdmin.Visible = true;
                }
            }
            if (!us.quizzes.Where(a => a.courseid == course).Any())
            {
                testButton.Visible = false;
            }

            //--------------------------------------------------------------
            var video_id = us.Classes.Where(a => a.Id == course).Select(a => a.videourl).FirstOrDefault();

            // Gets the video url from the database
            var videoframe = new Literal();
            video_id = video_id.Split('=')[1];
            video_id = "https://www.youtube.com/embed/" + video_id;
            videoframe.Text = String.Format(@"<iframe width=""628"" height=""374"" src=""{0}"" frameborder=""0"" allowfullscreen></iframe>", video_id);
            test.Controls.Add(videoframe);


            var currentclass = us.Classes.Where(a => a.Id == course).FirstOrDefault();

            lblCourse.Text = currentclass.Id + " " + currentclass.courseTitle;

            var zoom = us.Classes.Where(a => a.Id == course).Select(a => a.zoomLink).FirstOrDefault();
            var descrip = us.Classes.Where(a => a.Id == course).Select(a => a.description).FirstOrDefault();
            var announcemessage = us.Classes.Where(a => a.Id == course).Select(a => a.announcementMessage).FirstOrDefault();
            var teacher = us.Classes.Where(a => a.Id == course).Select(a => a.professorName).FirstOrDefault();

            if (!String.IsNullOrWhiteSpace(announcemessage))
            {
                announceLabel.Text = announcemessage;

            }
            else
            {

                announceLabel.Text = "There is no announcement for this course.";
            }
            descriptionLabel.Text = descrip;
            if (zoom == null)
            {
                zoomLabel.Text = "This course does not have a Zoom meeting scheduled. Check back later";
            }
            else
            {
                zoomLabel.Text = zoom;
            }
            teachLabel.Text = "Teacher: " + teacher;

            //--------------------------------------------------------------

        }
        public void updateCourse(Int32 courseId)
        {

        }

        protected void testButton_Click(object sender, EventArgs e)
        {

            Quiz_Page.course = course;
            Response.Redirect("Quiz_Page.aspx", false);

        }
        protected void btnAdmin_Click(object sender, EventArgs e)
        {

            Response.Redirect("~/User Function/Admin.aspx");

        }
        protected void btnUser_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/User Function/UserPage.aspx");
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
    }
}