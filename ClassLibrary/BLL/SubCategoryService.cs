using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary.DAL;

namespace ClassLibrary.BLL
{
    public class SubCategoryService
    {
        private igroup36_prodEntities db; // מביא לי את הדטה

        public SubCategoryService(igroup36_prodEntities _db)
        {
            db = _db;
        }

        //public Category AddCategory(Category e)
        //{

        //    return db.Categories.Add(e);

        //}

        public subCategory AddSubCategory(subCategory e)
        {

            return db.subCategories.Add(e);

        }

        public List<subCategory> GetSubCategory()
        {
            return db.subCategories.ToList();
            //return db.CategoryChoices.Select(x => new CategoryChoice()
            //{
            //    CategoryChoiceNo = x.CategoryChoiceNo,
            //    CategoryChoiceName = x.CategoryChoiceName,


            //}).ToList();
        }

        public void save()
        {
            db.SaveChanges();
        }
    }
}

