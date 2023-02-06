using Business.Abstrackt;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BlogManager :IBlogServices
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public List<Blog> GetBlogListWithBlogCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public List<Blog> GetBlogById(int id)
        {
            return _blogDal.GetAll(x=>x.Id == id);
        }

        public List<Blog> GetBlogListByWriter(int id)
        {
            return _blogDal.GetAll(b => b.WriterId == id);
        }

        public List<Blog> GetLastBlog(int count)
        {
            return _blogDal.GetAll().TakeLast(count).ToList();
        }

        public void Add(Blog entity)
        {
            _blogDal.Add(entity);
        }

        public void Update(Blog entity)
        {
            _blogDal.Update(entity);
        }

        public void Delete(Blog entity)
        {
            _blogDal.Delete(entity);
        }

        public List<Blog> GetAll()
        {
            List<Blog> blogs = _blogDal.GetAll();
            return blogs;
        }

        public Blog GetById(int id)
        {
            Blog blog = _blogDal.GetById(id);
            return blog;
        }
    }
}
