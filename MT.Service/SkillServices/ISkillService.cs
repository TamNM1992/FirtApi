using MT.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Service.SkillServices
{
    public interface ISkillService
    {
        public bool AddSkill(SkillDto skillDto);
    }
}
