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
            using (var c= new Context())
            {
                return c.Blogs.Include(a=>a.Category).ToList();
            }
        }

       
    }
}
