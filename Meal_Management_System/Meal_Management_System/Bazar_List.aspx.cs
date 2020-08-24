using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Meal_Management_System
{
    public partial class Bazar_List : System.Web.UI.Page
    {
        DataOperation op = new DataOperation();

        protected void Page_Load(object sender, EventArgs e)
        {
            if(!Page.IsPostBack)
            {
                bazarloadgrid();
            }
        }
        public void bazarloadgrid()
        {
            string query = @"SELECT [serial_no]
                                  ,[date]
                                  ,[name]
                                  ,[amount]
                              FROM [dbo].[Bazar_List]";

            bazarGridView.DataSource = op.getData(query);
            bazarGridView.DataBind();
        }

        protected void btnsave_Click(object sender, EventArgs e)
        {
            string query = @"INSERT INTO[dbo].[Bazar_List]
                               ([date]
                               ,[name]
                               ,[amount])
                         VALUES('" + txtdate.Text + "','" + txtname.Text + "','" + txtamount.Text + "')";

            if (op.executequery(query) == 1)
            {
                bazarloadgrid();
            }
        }

        protected void bazarGridView_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            bazarGridView.PageIndex = e.NewPageIndex;
            bazarloadgrid();
        }

        protected void bazarGridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            bazarGridView.EditIndex = e.NewEditIndex;
            bazarloadgrid();
        }

        protected void bazarGridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Label serial = (Label)bazarGridView.Rows[e.RowIndex].FindControl("Label1");
            TextBox date = (TextBox)bazarGridView.Rows[e.RowIndex].FindControl("TextBox2");
            TextBox name = (TextBox)bazarGridView.Rows[e.RowIndex].FindControl("TextBox3");
            TextBox amount = (TextBox)bazarGridView.Rows[e.RowIndex].FindControl("TextBox4");

            string query = @"UPDATE [dbo].[Bazar_List]
            SET [date] ='" + date.Text + "',[name] ='" + name.Text + "',[amount] ='" + amount.Text + "' WHERE [serial_no]=" + serial.Text;

            if(op.executequery(query)==1)
            {
                bazarGridView.EditIndex = -1;
                bazarloadgrid();
            }
        }

        protected void bazarGridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            bazarGridView.EditIndex = -1;
            bazarloadgrid();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default");
        }
    }
}