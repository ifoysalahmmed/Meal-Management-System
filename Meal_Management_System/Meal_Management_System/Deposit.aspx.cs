using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Meal_Management_System
{
    public partial class Deposit : System.Web.UI.Page
    {
        DataOperation op = new DataOperation();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                depositloadgrid();
            }
        }
        public void depositloadgrid()
        {
            string query = @"SELECT [serial_no]
                                  ,[prosenjit]
                                  ,[limon]
                                  ,[shila]
                              FROM [dbo].[Deposit]";

            depositGridView.DataSource = op.getData(query);
            depositGridView.DataBind();
        }

        protected void depositGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            depositGridView.EditIndex = e.NewEditIndex;
            depositloadgrid();
        }

        protected void depositGridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label serial = (Label)depositGridView.Rows[e.RowIndex].FindControl("Label1");
            TextBox prosenjit = (TextBox)depositGridView.Rows[e.RowIndex].FindControl("TextBox2");
            TextBox limon = (TextBox)depositGridView.Rows[e.RowIndex].FindControl("TextBox3");
            TextBox shila = (TextBox)depositGridView.Rows[e.RowIndex].FindControl("TextBox4");

            string query = @"UPDATE [dbo].[Deposit]
            SET [prosenjit] ='" + prosenjit.Text + "',[limon] ='" + limon.Text + "',[shila] ='" + shila.Text + "' WHERE [serial_no] =" + serial.Text;

            if(op.executequery(query)==1)
            {
                depositGridView.EditIndex = -1;
                depositloadgrid();
            }
        }

        protected void depositGridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            depositGridView.EditIndex = -1;
            depositloadgrid();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default");
        }
    }
}