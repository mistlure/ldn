using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedIn.Domain;

namespace LinkedIn.Infrastructure.Text
{
    public class SkillTextDao : ISkillDao
    {
        public IEnumerable<Skill> GetAllSkills()
        {
            throw new NotImplementedException();
        }

        public void AddSkillToUser(Guid userId, Skill skill)
        {
            throw new NotImplementedException();
        }

        public void RemoveSkillFromUser(Guid userId, Guid skillId)
        {
            throw new NotImplementedException();
        }
    }

}
