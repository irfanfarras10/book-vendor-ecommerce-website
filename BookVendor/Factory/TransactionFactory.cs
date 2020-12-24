using System;
using BookVendor.Model;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookVendor.Factory
{
    public class TransactionFactory
    {
        public static HeaderTransaction CreateHeader(int userid)
        {
            HeaderTransaction trans = new HeaderTransaction();
            trans.UserID = userid;
            trans.Date = DateTime.Now;
            return trans;
        }

        public static DetailTransaction CreateDetail(int bookid, int transid, int qty)
        {
            DetailTransaction transdet = new DetailTransaction();
            transdet.BookID = bookid;
            transdet.TransactionID = transid;
            transdet.Quantity = qty;
            return transdet;
        }
    }
}