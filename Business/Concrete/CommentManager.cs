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
	public class CommentManager : ICommentService
	{
		ICommentDal _commentDal;

		public CommentManager(ICommentDal commentDal)
		{
			_commentDal = commentDal;
		}

        public void Add(Comment entity)
        {
            _commentDal.Add(entity);
        }

        public void Delete(Comment entity)
        {
            _commentDal.Delete(entity);
        }

        public List<Comment> GetAll(int id)
		{
            List<Comment> comments = _commentDal.GetAll(a=>a.Id==id);
            return comments;
		}

        public List<Comment> GetAll()
        {
            List<Comment> comments= _commentDal.GetAll();
            return comments;
        }

        public Comment GetById(int id)
        {
            Comment comment = _commentDal.GetById(id);
            return comment;
        }

        public void Update(Comment entity)
        {
            _commentDal.Update(entity);
        }
    }
}
