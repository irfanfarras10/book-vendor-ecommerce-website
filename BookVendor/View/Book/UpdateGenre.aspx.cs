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
    public partial class UpdateGenre : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Grid1.DataSource = GenreController.GetGenre();
            Grid1.DataBind();
        }

        protected void Grid1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = Int32.Parse(
                ((Label)Grid1.Rows[e.RowIndex].FindControl("GenreID")).Text
            );
            Book cekref = BookController.cekref(id);
            if (cekref != null)
            {
                cek1.Text = "Tidak bisa delete genre yang direferensikan";
            }
            else
            {
                cek1.Text = "";
                GenreController.DeleteGenre(id);
                Grid1.DataSource = GenreController.GetGenre();
                Grid1.DataBind();
            } 
        }

        protected void Grid1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if(e.CommandName=="Edit")
            {
                int genreID = Int32.Parse(e.CommandArgument.ToString());

                Response.Redirect("EditGenre.aspx?genreID=" +genreID);
            }
        }

        protected void AddGenre(object sender, EventArgs e)
        {
            Response.Redirect("InsertGenre.aspx");
        }
    }
}