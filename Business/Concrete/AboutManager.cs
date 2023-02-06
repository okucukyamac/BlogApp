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
	public class AboutManager:IAboutService
	{
		IAboutDal _aboutDal;

		public AboutManager(IAboutDal aboutDal)
		{
			_aboutDal = aboutDal;
		}

        public void Add(About entity)
        {
            _aboutDal.Add(entity);
        }

        public void Delete(About entity)
        {
            _aboutDal.Delete(entity);
        }

        public List<About> GetAll()
        {
            List<About> abouts = _aboutDal.GetAll();
            return abouts;
        }

        public About GetById(int id)
        {
            About about = _aboutDal.GetById(id);
            return about;
        }

        public void Update(About entity)
        {
            _aboutDal.Update(entity);
        }
    }
}
