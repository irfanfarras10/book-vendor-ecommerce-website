using BookVendor.Controller;
using BookVendor.Model;
using BookVendor.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookVendor.View
{
    public partial class ChangePassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value.ToString().Length < 5) args.IsValid = false;
        }

        protected void ChangeButton_Click(object sender, EventArgs e)
        {
            int id = ((User)Session["user"]).UserID;
            string password = Password.Text;
            string oldpass = OldPassword.Text;
            User check = UserController.ChangePassword(id, password, oldpass);
            if (check == null) RequiredFieldValidator1.IsValid = false;
            if (Page.IsValid)
            {
                Response.Cookies["Password"].Value = Password.Text;
                OldPassword.Text = "";
                Password.Text = "";
                ConfirmPassword.Text = "";
                Success.Visible = true;
            }
            else
            {
                Success.Visible = false;
            }
        }
    }
}