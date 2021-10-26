using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static Finalprog.WebForm1;

namespace Finalprog
{
    public partial class REsults : System.Web.UI.Page
    {
        public static UserDataClassesDataContext us = new UserDataClassesDataContext();
        int count = 0;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

            if (Session["searchTerm"] != null)
            {
                String searchText = Session["searchTerm"].ToString();
                Search(searchText);
            }
            if (eo != null)
            {
                if (role == "Admin")
                {
                    btnAdmin.Visible = true;
                }
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="searchText"></param>
        private void Search(string searchText)
        {
            UserDataClassesDataContext us = new UserDataClassesDataContext();
            var search = (from c in us.Classes
                          where (c.Id.ToString().Contains(searchText) ||
                          c.professorName.ToString().Contains(searchText) ||
                          c.description.ToString().Contains(searchText))
                          select c).ToList();

            foreach (var c in search)
            {
                String temp = ("Course: " + c.Id.ToString() + " " + c.description.ToString() + " " + c.professorName.ToString() + " ");
                lstResults.Items.Add(temp);
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        private bool searchCheck(string search)
        {
            if (search != null && !String.IsNullOrWhiteSpace(txtResultsSearch.Text))
            {
                return true;
            }
            else
            {
                lstResults.Text = "Value not Found";
                return false;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnResultsSearch_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();
            string searchText = txtResultsSearch.Text;
            bool check = searchCheck(searchText);

            if (check == true)
            {
                Search(searchText);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private void MultipleDisplay()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        private void SortResults()
        {

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
        protected void btnCourse_Click(object sender, EventArgs e)
        {
            String temp = lstResults.SelectedValue;
            if (!String.IsNullOrWhiteSpace(temp))
            {
                int course = Convert.ToInt32(temp.Substring(8, 4));

                CoursePage.course = course;
                Response.Redirect("~/Course Function/CoursePage.aspx");
            }
            else
            {
                lblSelect.Visible = true;
            }
        }
    }
}