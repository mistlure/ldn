using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedIn.Domain;

namespace LinkedIn.Configuration
{
    public interface IDataConnector
    {
        IUserDao GetUserDao();
        IPostDao GetPostDao();
        IMessageDao GetMessageDao();
        ISkillDao GetSkillDao();
    }
}
