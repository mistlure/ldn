using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedIn.Domain;
using LinkedIn.Infrastructure.Text;

namespace LinkedIn.Configuration
{
    public class TextConnector : IDataConnector
    {
        public IUserDao GetUserDao()
        {
            return new UserTextDao();
        }

        public IPostDao GetPostDao()
        {
            return new PostTextDao();
        }

        public IMessageDao GetMessageDao()
        {
            return new MessageTextDao();
        }

        public ISkillDao GetSkillDao()
        {
            return new SkillTextDao();
        }
    }

}
