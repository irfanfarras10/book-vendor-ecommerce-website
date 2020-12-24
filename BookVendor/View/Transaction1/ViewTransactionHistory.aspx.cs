using BookVendor.Controller;
using BookVendor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BookVendor.View.Transaction1
{
    public partial class ViewTransactionHistory : System.Web.UI.Page
    {
        public List<HeaderTransaction> trans;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            User user = (User)Session["user"];
            if (user.Role.RoleName == "Member")
            {
                trans = TransactionController.getUserTransaction(((User)Session["user"]).UserID);
            } 

        }

    }
}