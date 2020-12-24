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
    public partial class UpdateProfile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = ((User)Session["user"]);
            if (!Page.IsPostBack)
            {               
                Name.Text = user.Name;
                Gender.Text = user.Gender;
                PhoneNumber.Text = user.PhoneNumber;
                Adress.Text = user.Adress;
            }
           
        }

        protected void CustomValidator3_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (!args.Value.ToString().Contains("Street") && !args.Value.ToString().Contains("street")) args.IsValid = false;
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            int id = ((User)Session["user"]).UserID;
            string name = Name.Text;
            string gender = Gender.Text;
            string phone = PhoneNumber.Text;
            string adress = Adress.Text;  
            if (Page.IsValid)
            {
                UserController.UpdateUser(id,name, gender, phone, adress);
                Name.Text = "";
                Gender.Text = "";
                PhoneNumber.Text = "";
                Adress.Text = "";
                Success.Visible = true;
            }
            else
            {
                Success.Visible = false;
            }
        }
    }
}