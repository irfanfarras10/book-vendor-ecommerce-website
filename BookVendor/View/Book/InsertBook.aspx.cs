using BookVendor.Repository;
using BookVendor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookVendor.Controller;

namespace BookVendor.View
{
    public partial class InsertBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                DropDownList1.DataSource = GenreController.GetGenre();
                DropDownList1.DataBind();
            }
               
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value.ToString().Length < 10) args.IsValid = false;
        }

        protected void Insert_Click(object sender, EventArgs e)
        {
            string name = Name.Text;
            int genre = Int32.Parse(DropDownList1.SelectedValue);
            string description = Description.Text;
            int stock = Int32.Parse(Stock.Text);
            int price = Int32.Parse(Price.Text);
            if (Page.IsValid)
            {
                BookController.InsertBook(genre, name, description, stock, price);
                Name.Text = "";
                Description.Text = "";
                Stock.Text = "";
                Price.Text = "";
                Success.Text = "Insert Success";
            }
        }
    }
}