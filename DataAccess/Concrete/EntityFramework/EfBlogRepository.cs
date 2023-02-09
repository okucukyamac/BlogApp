using DataAccess.Abstract;
using DataAccess.Respositories;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBlogRepository : GenericRepository<Blog>, IBlogDal
    {
        public List<Blog> GetListWithCategory()
        {
            using (var db = new Context())
            {
                return db.Blogs.Include(a => a.Category).ToList();
            }
        }

        public List<Blog> GetListWithCategoryByWriter(int id)
        {
            using (var db = new Context())
            {
                var blogs = db.Blogs.Include(x => x.Category).Where(a => a.WriterId == id).ToList();
                return blogs;
            }
        }
    }
}
