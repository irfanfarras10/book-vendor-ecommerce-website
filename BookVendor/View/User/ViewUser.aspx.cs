using BookVendor.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookVendor.Model;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookVendor.Controller;

namespace BookVendor.View
{
    public partial class ViewUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Grid1.DataSource = UserController.GetUser();
            Grid1.DataBind();
        }

        protected void CustomersGridView_RowCommand(Object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName == "Promote")
            {
                int userID = Int32.Parse(e.CommandArgument.ToString());

                UserController.Promote(userID);
                Grid1.DataSource = UserController.GetUser();
                Grid1.DataBind();
            }
            else if(e.CommandName == "Ban")
            {
                int userID = Int32.Parse(e.CommandArgument.ToString());
                UserController.Ban(userID);
                Grid1.DataSource = UserController.GetUser();
                Grid1.DataBind();
            }
            else if(e.CommandName == "DeleteUser")
            {
                int userID = Int32.Parse(e.CommandArgument.ToString());
                UserController.Delete(userID);
                Grid1.DataSource = UserController.GetUser();
                Grid1.DataBind();
            }
        }

        
    }
}