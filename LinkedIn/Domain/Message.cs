using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedIn.Domain
{
    public class Message
    {
        public Guid Id { get; set; }
        public string Content { get; set; }

        public DateTime SentAt { get; set; }
        public Guid SenderId { get; set; }
        public User Sender { get; set; }

        public Guid ReceiverId { get; set; }
        public User Receiver { get; set; }
    }
}
