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
	public class WriterManager : IWriterService
	{
		IWriterDal _writerDal;

		public WriterManager(IWriterDal writerDal)
		{
			_writerDal = writerDal;
		}

		public void Add(Writer writer)
		{
			_writerDal.Add(writer);
		}

        public void Delete(Writer writer)
        {
            _writerDal.Delete(writer);
        }

        public List<Writer> GetAll()
        {
           List<Writer> writers= _writerDal.GetAll();
            return writers;
        }

        public Writer GetById(int id)
        {
            Writer writer = _writerDal.GetById(id);
            return writer;
        }

        public void Update(Writer entity)
        {
            _writerDal.Update(entity);
        }
    }
}
