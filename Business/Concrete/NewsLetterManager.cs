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
	public class NewsLetterManager : INewsLetterService
	{
		INewsLetterDal _newsLetterDal;

		public NewsLetterManager(INewsLetterDal newsLetterDal)
		{
			_newsLetterDal = newsLetterDal;
		}

		public void Add(NewsLetter newsLetter)
		{
			_newsLetterDal.Add(newsLetter);
		}

        public void Delete(NewsLetter entity)
        {
            _newsLetterDal.Delete(entity);
        }

        public List<NewsLetter> GetAll()
        {
            List<NewsLetter> newsLetters=_newsLetterDal.GetAll();
            return newsLetters;
        }

        public NewsLetter GetById(int id)
        {
            NewsLetter newsLetter = _newsLetterDal.GetById(id);
            return newsLetter;
        }

        public void Update(NewsLetter entity)
        {
            _newsLetterDal.Update(entity);  
        }
    }
}
