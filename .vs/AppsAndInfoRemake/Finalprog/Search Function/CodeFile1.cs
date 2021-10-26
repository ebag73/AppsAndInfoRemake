using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Finalprog
{
    public partial class SearchFunctionProcessing
    {
        private void Search()
        {
            UserDataClassesDataContext us = new UserDataClassesDataContext();
            string searchText = txtSearch.Text;
            var search = (from c in us.Classes where (c.Id.ToString().StartsWith(searchText) ||
                c.professorName.ToString().StartsWith(searchText) || c.description.ToString().StartsWith(searchText)) select c).FirstOrDefault();

            if (search != null && !String.IsNullOrWhiteSpace(txtSearch.Text))
            {
                var result = search.Id + " " + search.description;
                btnNav.Visible = true;
                CoursePage.course = search.Id;
                lblResults.Text = result;
                lblSearch.Visible = false;
            }
            else
            {
                lblSearch.Visible = true;
                lblSearch.Text = "Value not Found";
            }
        }
    }
}