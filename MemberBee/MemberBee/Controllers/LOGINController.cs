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
         
        [Route("api/Login/{phone}/{id}")]
        // GET: api/Login
        public bool Get(int phone, int id)
        {
               igroup36_prodEntities db   = new igroup36_prodEntities();

            Customer C = db.Customers.SingleOrDefault(x => x.IdNumber == id);



            if (C != null && phone == C.PhoneNo)

                return true ;

            else return false;
        }
    }
}

