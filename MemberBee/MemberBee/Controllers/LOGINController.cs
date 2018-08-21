using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClassLibrary.DAL;


namespace MemberBee.Controllers
{
    public class LOGINController : ApiController
    {
         
        [Route("api/LOGIN/{email}/{phone}")]
        // GET: api/Login
        public Customer Get(string email, int phone)
        {
               igroup36_prodEntities db   = new igroup36_prodEntities();

               Customer C = db.Customers.SingleOrDefault(x => x.MainMail == email);



            if (C != null && phone == C.PhoneNo)

                return true ;

            else return false;
        }
    }
}

