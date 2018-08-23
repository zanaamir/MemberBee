using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.DAL;

namespace ClassLibrary.BLL
{
   public class CustomerService
    {
        
        private igroup36_prodEntities db;
        //בנאי להבאת DB 
        public CustomerService(igroup36_prodEntities _db)
        {
            db = _db;
        }

        public Customer GetCustomer(string _email)
        {
            return db.Customers.SingleOrDefault(x => x.MainMail == _email);
        }
    }
}
// עמית הרמן 
