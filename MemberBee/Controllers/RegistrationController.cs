﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ClassLibrary.DAL;
using ClassLibrary.BLL;


namespace MemberBee.Controllers
{
    public class RegistrationController : ApiController
    {
        Registration new_Client;
        CustomerSubCategory category_for_client;

        public RegistrationController()
        {
            igroup36_prodEntities db = new igroup36_prodEntities();

            new_Client = new Registration(db);
        }

        [Route("api/Registration")]
        [HttpPost]
        public void PostNewClient(Customer e, Customer_subCategory d)
        {


            category_for_client.AddSubCategoriesForClient(d);
            category_for_client.save();
            new_Client.AddCustomer(e);
            new_Client.save();

        }

       
    }
}