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
    public class BlogManager : IBlogServices
    {
        IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }

        public void Add(Blog blog)
        {
            throw new NotImplementedException();
        }

        public void Delete(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetAll()
        {
            return _blogDal.GetAll();
        }

        public List<Blog> GetBlogListWithBlogCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public List<Blog> GetBlogListWithCategory()
        {
            return _blogDal.GetListWithCategory();
        }

        public Blog GetById(int id)
        {
            return _blogDal.GetById(id);
        }

        public void Update(Blog blog)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogById(int id)
        {
            return _blogDal.GetAll(x=>x.Id == id);
        }
    }
}
