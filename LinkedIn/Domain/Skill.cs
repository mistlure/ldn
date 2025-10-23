using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedIn.Domain
{
    public class Skill
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }

    public class UserSkill
    {
        public Guid UserId { get; set; }
        public User User { get; set; }

        public Guid SkillId { get; set; }
        public Skill Skill { get; set; }
    }
}
