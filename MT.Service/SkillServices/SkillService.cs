using AutoMapper;
using MT.Data.Dtos;
using MT.Repository.SkillRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Service.SkillServices
{
    public class SkillService : ISkillService
    {
        private ISkillRepository _repo;
        private IMapper _mapper;

        public SkillService(ISkillRepository skill, IMapper mapper)
        {
            _repo = skill;
            _mapper = mapper;
        }
        public bool AddSkill(SkillDto skillDto)
        {
            var temp = _repo.AddSkill(skillDto);
            return temp;
        }
    }
}
