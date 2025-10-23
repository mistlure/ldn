using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedIn.Domain
{
    public interface IUserDao
    {
        User GetById(Guid id);
        IEnumerable<User> GetAll();
        void Save(User user);
        void Delete(Guid id);
    }
}
