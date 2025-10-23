using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedIn.Domain
{
    public interface ISkillDao
    {
        IEnumerable<Skill> GetAllSkills();
        void AddSkillToUser(Guid userId, Skill skill);
        void RemoveSkillFromUser(Guid userId, Guid skillId);
    }
}
