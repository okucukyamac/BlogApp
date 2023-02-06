using Business.Abstrackt;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryServices
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void Add(Category category)
        {
            _categoryDal.Add(category);
        }

        public void Delete(Category category)
        {
            _categoryDal.Delete(category);
        }

        public List<Category> GetAll()
        {
            List<Category> categories = _categoryDal.GetAll();
            return categories;
        }

        public Category GetById(int id)
        {
            Category category= _categoryDal.GetById(id);
            return category;
        }

        public void Update(Category category)
        {
            _categoryDal.Update(category);
        }
    }
}
