using BookVendor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookVendor.Repository
{
    public class TransactionRepository
    {
        public static HeaderTransaction insertHeader(HeaderTransaction trans)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            db.HeaderTransactions.Add(trans);
            db.SaveChanges();
            return trans;
        }

        public static DetailTransaction insertDetail(DetailTransaction detail)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            db.DetailTransactions.Add(detail);
            db.SaveChanges();
            int id = (int)detail.BookID;
            BookRepository.decreaseStock(id, detail.Quantity);
            return detail;
        }

        public static List<HeaderTransaction> getUserTransaction(int userid)
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            List<HeaderTransaction> det = new List<HeaderTransaction>();
            det = db.HeaderTransactions.Where(z => z.UserID == userid).ToList();
            return det;
        }

        public static List<HeaderTransaction> getAllTransaction()
        {
            DatabaseEntities2 db = new DatabaseEntities2();
            List<HeaderTransaction> det = new List<HeaderTransaction>();
            det = db.HeaderTransactions.ToList();
            return det;
        }




    }
}