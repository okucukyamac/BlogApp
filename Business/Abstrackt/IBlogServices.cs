using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstrackt
{
    public interface IBlogServices:IGenericService<Blog>
    {
        
        List<Blog> GetBlogListWithCategory();
        List<Blog> GetBlogListWithBlogCategory();
        List<Blog> GetBlogListByWriter(int id);

    }
}
