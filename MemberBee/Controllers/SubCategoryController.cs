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
    public class SubCategoryController : ApiController
    {
        SubCategoryService newSubCategory;

        public SubCategoryController()
        {
            igroup36_prodEntities db = new igroup36_prodEntities();

            newSubCategory = new SubCategoryService(db);
        }

        [HttpGet]
        [Route("api/SubCategory")]
        public List<subCategory> GetSubCategoria()
        {

            return newSubCategory.GetSubCategory().ToList(); 


        }
    }
}