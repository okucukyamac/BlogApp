using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstrackt
{
    public interface IBlogServices
    {
        void Add(Blog blog);
        void Update(Blog blog);
        void Delete(Blog blog);
        List<Blog> GetAll();
        Blog GetById(int id);
        List<Blog> GetBlogListWithCategory();
        List<Blog> GetBlogListWithBlogCategory();
        List<Blog> GetBlogListByWriter(int id);

    }
}
