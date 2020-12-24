using BookVendor.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using BookVendor.Model;
using System.Web.UI.WebControls;
using BookVendor.Controller;

namespace BookVendor.View
{
    public partial class ViewProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = UserController.GetProfile(
                ((User)Session["user"]).UserID
            );
            Username.Text = user.Username;
            Name.Text = user.Name;
            Gender.Text = user.Gender;
            Pnumber.Text = user.PhoneNumber;
            Adress.Text = user.Adress;
        }

        protected void Update_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateProfile.aspx");
        }

        protected void Change_Click(object sender, EventArgs e)
        {
            Response.Redirect("ChangePassword.aspx");
        }
    }
}