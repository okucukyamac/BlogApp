using DataAccess.Abstract;
using DataAccess.Respositories;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCommentRepository:GenericRepository<Comment>,ICommentDal
    {
    }
}
