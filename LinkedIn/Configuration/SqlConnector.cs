using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedIn.Domain;
using LinkedIn.Infrastructure.Sql;

namespace LinkedIn.Configuration
{
    public class SqlConnector : IDataConnector
    {
        public IUserDao GetUserDao()
        {
            return new UserSqlDao();
        }

        public IPostDao GetPostDao()
        {
            return new PostSqlDao();
        }

        public IMessageDao GetMessageDao()
        {
            return new MessageSqlDao();
        }

        public ISkillDao GetSkillDao()
        {
            return new SkillSqlDao();
        }
    }

}
