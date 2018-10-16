using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.DAL;


namespace ClassLibrary.BLL
{
    public class CustomerSubCategory
    {
        private igroup36_prodEntities db; // מביא לי את הדטה

        public CustomerSubCategory(igroup36_prodEntities _db)
        {
            db = _db;
        }

        public Customer_subCategory AddSubCategoriesForClient(Customer_subCategory e)
        {
            return db.Customer_subCategory.Add(e);
        }

        public void save()
        {
            db.SaveChanges();
        }
    }
}
