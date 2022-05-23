using AutoMapper;
using MT.Data.Dtos;
using MT.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Repository.BattleRepo
{
    public class BattleRepository : IBattleRepository
    {
        private readonly MonterDataContext _context;
        private readonly IMapper _mapper;
        public BattleRepository(MonterDataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public bool Solo(MonterDto m1, MonterDto m2)
        {

            return true;
        }
    }
}
