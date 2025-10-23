using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedIn.Domain
{
    public interface IMessageDao
    {
        IEnumerable<Message> GetMessagesBetween(Guid userAId, Guid userBId);
        void SendMessage(Message message);
        void Delete(Guid messageId);
    }
}
