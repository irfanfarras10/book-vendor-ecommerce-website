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
    public partial class EditGenre : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack && Request.QueryString["genreID"] != null)
            {
                int genreID = Int32.Parse(Request.QueryString["genreID"]);
                Genre genre = GenreController.GetGenre(genreID);

                InsertId.Text = genre.GenreID.ToString();
                Name.Text = genre.GenreName;
                Description.Text = genre.Description;
            }
        }

        protected void UpdateGenre1_Click(object sender, EventArgs e)
        {
            int genreID = Int32.Parse(InsertId.Text);
            string genreName = Name.Text;
            string genreDescription = Description.Text;

            if (Page.IsValid)
            {
                GenreController.UpdateGenre(genreID, genreName, Description.Text);
                Success.Text = "Update Success";
            }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value.ToString().Length < 3) args.IsValid = false;
        }

        protected void CustomValidator2_ServerValidate(object source, ServerValidateEventArgs args)
        {
            if (args.Value.ToString().Length < 10) args.IsValid = false;
        }
    }
}