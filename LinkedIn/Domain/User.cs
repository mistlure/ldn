using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedIn.Domain
{
    public class User
    {
        public Guid Id { get; set; }
        public string FullName { get; set; }
        public string Nickname { get; set; }
        public string Location { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ProfilePictureUrl { get; set; }

        public ICollection<Post> Posts { get; set; }
        public ICollection<Message> SentMessages { get; set; }
        public ICollection<Message> ReceivedMessages { get; set; }
    }
}
