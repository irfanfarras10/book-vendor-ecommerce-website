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
    public partial class UpdateBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Grid1.DataSource = BookController.GetAll();
                Grid1.DataBind();
            }
            Clearbtn.Enabled = false;
        }

        protected void Grid1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Int32.Parse(
                ((Label)Grid1.Rows[e.RowIndex].FindControl("BookID")).Text
            );
            BookController.DeleteBook(id);
            Grid1.DataSource = BookController.GetAll();
            Grid1.DataBind();
        }

        protected void Grid1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Edit")
            {
                int BookID = Int32.Parse(e.CommandArgument.ToString());

                Response.Redirect("EditBook.aspx?BookID=" + BookID);
            }
        }

        protected void AddBook(object sender, EventArgs e)
        {
            Response.Redirect("InsertBook.aspx");
        }

        protected void Searchbtn_Click(object sender, EventArgs e)
        {
            string name = Search.Text;
            if (BookController.getSearch(name) != null)
            {
                Grid1.DataSource = BookController.getSearch(name);
                Grid1.DataBind();
                empty.Text = "";
                Clearbtn.Enabled = true;
            }
            else
            {
                Grid1.DataSource = BookController.GetAll();
                Grid1.DataBind();
                empty.Text = "Buku tidak ditemukan";
            }
        }

        protected void Clearbtn_Click(object sender, EventArgs e)
        {
            Grid1.DataSource = BookController.GetAll();
            Grid1.DataBind();
            empty.Text = "";
            Clearbtn.Enabled = false;
            Search.Text = "";
        }

    }
}