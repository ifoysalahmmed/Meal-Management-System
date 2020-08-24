using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Meal_Management_System
{
    public partial class Meal_Description : System.Web.UI.Page
    {
        DataOperation op = new DataOperation();

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO [dbo].[Meal_Description]
                           ([date]
                           ,[prosenjit]
                           ,[limon]
                           ,[shila]
                            ,[abul])
                     VALUES('"+txtdate.Text+ "','"+txtprosen.Text+ "','"+txtlimon.Text+ "','"+txtshila.Text+ "','" + txtabul.Text + "')";

            if (op.executequery(query) == 1)
            {
                
            }

            Response.Redirect("Meal_Manager");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default");
        }
    }
}