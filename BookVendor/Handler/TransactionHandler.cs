using BookVendor.Factory;
using BookVendor.Model;
using BookVendor.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookVendor.Handler
{
    public class TransactionHandler
    {
        public static void Checkout(User user)
        {
            HeaderTransaction trans = TransactionFactory.CreateHeader(user.UserID);
            int id = TransactionRepository.insertHeader(trans).TransactionID;
            List<Cart> lcart = CartRepository.GetCart(user.UserID);
            foreach (var item in lcart)
            {
                DetailTransaction detail = TransactionFactory.CreateDetail(item.Book.BookID, id, item.Quantity);
                TransactionRepository.insertDetail(detail);
            }
        }

        public static List<HeaderTransaction> getUserTransaction(int userid)
        {
            return TransactionRepository.getUserTransaction(userid);
        }

        public static List<HeaderTransaction> getAllTransaction()
        {
            return TransactionRepository.getAllTransaction();
        }


    }
}