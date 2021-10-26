using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Finalprog
{
    public partial class Quiz_Page : System.Web.UI.Page
    {
        public static UserDataClassesDataContext us = new UserDataClassesDataContext();
        public static Int32 course;
        private static int quizid;
        private Int32 score = 0;
        private static Int32 total = 5;
        private int[] correctanswers = new int[5];
        private int[] useranswers = new int[5];

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
            if (!Page.IsPostBack)
            {
                UserDataClassesDataContext us = new UserDataClassesDataContext();
                var quizidresult = us.quizzes.Where(a => a.courseid == course).Select(a => a.quizid).FirstOrDefault();
                quizid = quizidresult;


                var coursetitle = us.quizzes.Where(a => a.courseid == course).Select(a => a.quiztitle).FirstOrDefault();
                quizTitle.Text = coursetitle;


                //Load Questions
                var question = us.quizquestions.Where((a => a.quizid == quizid && a.qid == 1)).Select(a => a.question).FirstOrDefault();
                Question_1.Text = question;
                question = us.quizquestions.Where((a => a.quizid == quizid && a.qid == 2)).Select(a => a.question).FirstOrDefault();
                Question_2.Text = question;
                question = us.quizquestions.Where((a => a.quizid == quizid && a.qid == 3)).Select(a => a.question).FirstOrDefault();
                Question_3.Text = question;
                question = us.quizquestions.Where((a => a.quizid == quizid && a.qid == 4)).Select(a => a.question).FirstOrDefault();
                Question_4.Text = question;
                question = us.quizquestions.Where((a => a.quizid == quizid && a.qid == 5)).Select(a => a.question).FirstOrDefault();
                Question_5.Text = question;

                //        //Question 1 Load Answers
                RadioButtonList1.Items.Clear();
                var answer = us.quizanswers.Where((a => a.quizid == quizid && a.qqid == 1 && a.qcount == 1)).Select(a => a.answer).FirstOrDefault();
                RadioButtonList1.Items.Add(answer);
                answer = us.quizanswers.Where((a => a.quizid == quizid && a.qqid == 1 && a.qcount == 2)).Select(a => a.answer).FirstOrDefault();
                RadioButtonList1.Items.Add(answer);
                answer = us.quizanswers.Where((a => a.quizid == quizid && a.qqid == 1 && a.qcount == 3)).Select(a => a.answer).FirstOrDefault();
                RadioButtonList1.Items.Add(answer);
                answer = us.quizanswers.Where((a => a.quizid == quizid && a.qqid == 1 && a.qcount == 4)).Select(a => a.answer).FirstOrDefault();
                RadioButtonList1.Items.Add(answer);

                //Questions 2 Load Answers
                RadioButtonList2.Items.Clear();
                answer = us.quizanswers.Where((a => a.quizid == quizid && a.qqid == 2 && a.qcount == 5)).Select(a => a.answer).FirstOrDefault();
                RadioButtonList2.Items.Add(answer);
                answer = us.quizanswers.Where((a => a.quizid == quizid && a.qqid == 2 && a.qcount == 6)).Select(a => a.answer).FirstOrDefault();
                RadioButtonList2.Items.Add(answer);
                answer = us.quizanswers.Where((a => a.quizid == quizid && a.qqid == 2 && a.qcount == 7)).Select(a => a.answer).FirstOrDefault();
                RadioButtonList2.Items.Add(answer);
                answer = us.quizanswers.Where((a => a.quizid == quizid && a.qqid == 2 && a.qcount == 8)).Select(a => a.answer).FirstOrDefault();
                RadioButtonList2.Items.Add(answer);

                //Question 3 Load Answers
                RadioButtonList3.Items.Clear();
                answer = us.quizanswers.Where((a => a.quizid == quizid && a.qqid == 3 && a.qcount == 9)).Select(a => a.answer).FirstOrDefault();
                RadioButtonList3.Items.Add(answer);
                answer = us.quizanswers.Where((a => a.quizid == quizid && a.qqid == 3 && a.qcount == 10)).Select(a => a.answer).FirstOrDefault();
                RadioButtonList3.Items.Add(answer);
                answer = us.quizanswers.Where((a => a.quizid == quizid && a.qqid == 3 && a.qcount == 11)).Select(a => a.answer).FirstOrDefault();
                RadioButtonList3.Items.Add(answer);
                answer = us.quizanswers.Where((a => a.quizid == quizid && a.qqid == 3 && a.qcount == 12)).Select(a => a.answer).FirstOrDefault();
                RadioButtonList3.Items.Add(answer);

                //Question 4 Load Answers
                RadioButtonList4.Items.Clear();
                answer = us.quizanswers.Where((a => a.quizid == quizid && a.qqid == 4 && a.qcount == 13)).Select(a => a.answer).FirstOrDefault();
                RadioButtonList4.Items.Add(answer);
                answer = us.quizanswers.Where((a => a.quizid == quizid && a.qqid == 4 && a.qcount == 14)).Select(a => a.answer).FirstOrDefault();
                RadioButtonList4.Items.Add(answer);
                answer = us.quizanswers.Where((a => a.quizid == quizid && a.qqid == 4 && a.qcount == 15)).Select(a => a.answer).FirstOrDefault();
                RadioButtonList4.Items.Add(answer);
                answer = us.quizanswers.Where((a => a.quizid == quizid && a.qqid == 4 && a.qcount == 16)).Select(a => a.answer).FirstOrDefault();
                RadioButtonList4.Items.Add(answer);

                //Question 5 Load Answers
                RadioButtonList5.Items.Clear();
                answer = us.quizanswers.Where((a => a.quizid == quizid && a.qqid == 5 && a.qcount == 17)).Select(a => a.answer).FirstOrDefault();
                RadioButtonList5.Items.Add(answer);
                answer = us.quizanswers.Where((a => a.quizid == quizid && a.qqid == 5 && a.qcount == 18)).Select(a => a.answer).FirstOrDefault();
                RadioButtonList5.Items.Add(answer);
                answer = us.quizanswers.Where((a => a.quizid == quizid && a.qqid == 5 && a.qcount == 19)).Select(a => a.answer).FirstOrDefault();
                RadioButtonList5.Items.Add(answer);
                answer = us.quizanswers.Where((a => a.quizid == quizid && a.qqid == 5 && a.qcount == 20)).Select(a => a.answer).FirstOrDefault();
                RadioButtonList5.Items.Add(answer);
            }
            else
            {
                int index = 0;
                index = RadioButtonList1.SelectedIndex;
                RadioButtonList1.SelectedIndex = index;
                index = RadioButtonList2.SelectedIndex;
                RadioButtonList2.SelectedIndex = index;
                index = RadioButtonList3.SelectedIndex;
                RadioButtonList3.SelectedIndex = index;
                index = RadioButtonList4.SelectedIndex;
                RadioButtonList4.SelectedIndex = index;
                index = RadioButtonList5.SelectedIndex;
                RadioButtonList5.SelectedIndex = index;
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            UserDataClassesDataContext us = new UserDataClassesDataContext();

            //Gather Correct Answers
            int count = 0;
            for (int i = 1; i < 21; i++)
            {
                var correctanswer = us.quizanswers.Where((a => a.quizid == quizid && a.qcount == i)).Select(a => a.correctanswer).FirstOrDefault();
                if (correctanswer == true)
                {
                    var anum = us.quizanswers.Where((a => a.quizid == quizid && a.qcount == i)).Select(a => a.anum).FirstOrDefault();
                    correctanswers[count] = anum;
                    count++;
                }
            }

            //Gather user answers
            useranswers[0] = RadioButtonList1.SelectedIndex;
            useranswers[1] = RadioButtonList2.SelectedIndex;
            useranswers[2] = RadioButtonList3.SelectedIndex;
            useranswers[3] = RadioButtonList4.SelectedIndex;
            useranswers[4] = RadioButtonList5.SelectedIndex;

            //Compare Answers
            for (int i = 0; i < 5; i++)
            {
                if (useranswers[i] == correctanswers[i])
                {
                    score++;
                }
            }

            //Display Score
            scoreLabel.Visible = true;
            scoreLabel.Text = score + "/" + total;
            Button1.Enabled = false;
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