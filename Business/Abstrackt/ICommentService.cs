using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstrackt
{
	public interface ICommentService
	{
		void Add(Comment comment);
		//void Update(Category category);
		//void Delete(Category category);
		List<Comment> GetAll(int id);
		//Category GetById(int id);
	}
}
