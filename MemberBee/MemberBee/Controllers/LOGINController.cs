using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClassLibrary.DAL;
using ClassLibrary.BLL;


namespace MemberBee.Controllers
{
    public class LOGINController : ApiController
    {

        static igroup36_prodEntities db = new igroup36_prodEntities();
        CustomerService cCustomer = new CustomerService(db);
        ClubService cClub = new ClubService(db);

        [Route("api/LOGIN/{email}/{phone}")]
        // GET: api/Login
        public Customer GET(string email, int phone)
        {

            Customer C = db.Customers.SingleOrDefault(x => x.MainMail == email);

            if (C != null )
            {
                if(phone == C.PhoneNo)
                {
                      return C;
                }
            }
        }
    }
}

