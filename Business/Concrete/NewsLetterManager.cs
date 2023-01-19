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
	}
}
