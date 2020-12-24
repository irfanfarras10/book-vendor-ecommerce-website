using BookVendor.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using BookVendor.Model;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookVendor.Controller;

namespace BookVendor.View
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value.ToString().Length < 3) args.IsValid = false;
        }

        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value.ToString().Length < 8) args.IsValid = false;
        }

        protected void CustomValidator3_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (!args.Value.ToString().Contains("Street") && !args.Value.ToString().Contains("street")) args.IsValid = false;
        }

        protected void RegisterButton1_Click(object sender, EventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;
            string name = Name.Text;
            string gender = Gender.Text;
            string pnumber = PhoneNumber.Text;
            string adress = Adress.Text;
            User cek = UserController.check(Username.Text);
            if (cek != null)
            {
                cekuser.IsValid = false;
                ceklbl.Text = "Username sudah dipakai";
            }
            else
            {
                cekuser.IsValid = true;
                ceklbl.Text = "";
            }

            if (Page.IsValid)
            {
                UserController.RegisterUser(2, username, name, password, gender, pnumber, adress, 0);
                Success.Text = "Register Success";
                Username.Text = "";
                Password.Text = "";
                Name.Text = "";
                Gender.Text = "";
                PhoneNumber.Text = "";
                Adress.Text = "";
            }
            else
            {
                Success.Text = "";
            }
        }
    }
}