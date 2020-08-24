using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Meal_Management_System
{
    public partial class Meal_Manager : System.Web.UI.Page
    {
        DataOperation op = new DataOperation();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                mealloadgrid();
            }
        }
        public void mealloadgrid()
        {
            string query = @"SELECT [serial_no]
                                  ,[date]
                                  ,[prosenjit]
                                  ,[limon]
                                  ,[shila]
                                  ,[abul]
                              FROM [dbo].[Meal_Description]";

            mealGridView.DataSource = op.getData(query);
            mealGridView.DataBind();
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            string query = @"SELECT * FROM [dbo].[Meal_Description] WHERE [serial_no]='"+txtsearch.Text+"'";

            searchGridView.DataSource = op.getData(query);
            searchGridView.DataBind();
        }

        protected void searchGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            searchGridView.PageIndex = e.NewPageIndex;
            mealloadgrid();
        }

        protected void searchGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            searchGridView.EditIndex = e.NewEditIndex;
            mealloadgrid();
        }

        protected void searchGridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label serial = (Label)searchGridView.Rows[e.RowIndex].FindControl("Label1");
            TextBox date = (TextBox)searchGridView.Rows[e.RowIndex].FindControl("TextBox2");
            TextBox prosen = (TextBox)searchGridView.Rows[e.RowIndex].FindControl("TextBox3");
            TextBox limon = (TextBox)searchGridView.Rows[e.RowIndex].FindControl("TextBox4");
            TextBox shila = (TextBox)searchGridView.Rows[e.RowIndex].FindControl("TextBox5");

            string query = @"UPDATE [dbo].[Meal_Description]
                            SET [date] ='" + date.Text + "' ,[prosenjit] ='" + prosen.Text + "' ,[limon] ='" + limon.Text + "' ,[shila] ='" + shila.Text + "' WHERE [serial_no]=" + serial.Text;

            if (op.executequery(query) == 1)
            {
                searchGridView.EditIndex = -1;
                mealloadgrid();
                message.Text = "Data Updated Successfully";
            }
            else
            {
                message.Text = "Failed to Update";
            }
        }

        protected void searchGridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            searchGridView.EditIndex = -1;
            mealloadgrid();
        }

        protected void searchGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label serial = (Label)searchGridView.Rows[e.RowIndex].FindControl("Label1");

            string query = @"DELETE FROM [dbo].[Meal_Description] WHERE [serial_no]="+serial.Text;

            if (op.executequery(query) == 1)
            {
                mealloadgrid();                
            }            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default");
        }

        
    }
}
