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
    public partial class EditBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack && Request.QueryString["BookID"] != null)
            {
                int BookID = Int32.Parse(Request.QueryString["BookID"]);
                Book book = BookController.GetBook(BookID);

                InsertId.Text = book.BookID.ToString();
                Name.Text = book.Name;
                DropDownList1.Text = book.GenreID.ToString();
                Description.Text = book.Description;
                Stock.Text = book.Stock.ToString();
                Price.Text = book.Price.ToString();
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
            int bookid = Int32.Parse(InsertId.Text);
            string name = Name.Text;
            string desc = Description.Text;
            int genre = Int32.Parse(DropDownList1.SelectedValue);
            int stock = Int32.Parse(Stock.Text);
            int price = Int32.Parse(Price.Text);

            if (Page.IsValid)
            {
                BookRepository.UpdateBook(bookid, name,genre,desc,stock,price);
                Success.Text = "Update Success";
            }
        }
    }
}