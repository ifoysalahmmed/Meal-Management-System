using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Meal_Management_System
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Meal_Description");
        }
        
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Meal_Manager");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Deposit");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("Bazar_List");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            var select = this.DropDownList1.SelectedValue;
            if(select=="Prosenjit")
            {
                Response.Redirect("Prosenjit");
            }
            else if(select=="Limon")
            {
                Response.Redirect("Limon");
            }
            else
            {
                Response.Redirect("Shila");
            }
        }
    }
}