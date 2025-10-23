using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedIn.Domain;

namespace LinkedIn.Infrastructure.Sql
{
    public class PostSqlDao : IPostDao
    {
        public Post GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAllByUser(Guid userId)
        {
            throw new NotImplementedException();
        }

        public void Save(Post post)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }
    }

}
