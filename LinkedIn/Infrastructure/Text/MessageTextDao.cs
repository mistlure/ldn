    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedIn.Domain;

namespace LinkedIn.Infrastructure.Text
{
    public class MessageTextDao : IMessageDao
    {
        public IEnumerable<Message> GetMessagesBetween(Guid userAId, Guid userBId)
        {
            throw new NotImplementedException();
        }

        public void SendMessage(Message message)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid messageId)
        {
            throw new NotImplementedException();
        }
    }

}
