using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedIn.Domain
{
    public interface IPostDao
    {
        Post GetById(Guid id);
        IEnumerable<Post> GetAllByUser(Guid userId);
        void Save(Post post);
        void Delete(Guid id);
    }
}
