using AutoMapper;
using MT.Data.Dtos;
using MT.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Repository.SkillRepo
{
    public class SkillRepository : ISkillRepository
    {
        private readonly MonterDataContext _context;
        private readonly IMapper _mapper;
        public SkillRepository(MonterDataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public bool AddSkill(SkillDto skillDto)
        {
            try
            {
                var skillEntity = _mapper.Map<SkillDto, Skill>(skillDto);

                _context.Skills.Add(skillEntity);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
