using BookVendor.Repository;
using System;
using BookVendor.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookVendor.Controller;

namespace BookVendor.View
{
    public partial class InsertGenre : System.Web.UI.Page
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
            if (args.Value.ToString().Length < 10) args.IsValid = false;
        }

        protected void Insert_Click(object sender, EventArgs e)
        {
            string name = Name.Text;
            string description = Description.Text;
            if (Page.IsValid)
            {
                GenreController.InsertGenre(name, description);
                Name.Text = "";
                Description.Text = "";
                Success.Text = "Insert Success";
            }
        }
    }
}