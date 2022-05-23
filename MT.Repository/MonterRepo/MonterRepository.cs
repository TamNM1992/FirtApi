using AutoMapper;
using MT.Data.Dtos;
using MT.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Repository.MonterRepo
{
    public class MonterRepository : IMonterRepository
    {
        private readonly MonterDataContext _context;
        private readonly IMapper _mapper;
        public MonterRepository(MonterDataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public bool AddMonter(MonterDto monter)
        {
            try
            {
                var type = _context.Types.Find(monter.Type);
                var attribute = _context.Attributes.Find(monter.Attribute);

                if (type == null)
                    return false;

                if (attribute == null)
                    return false;
                var monterEntity = _mapper.Map<MonterDto, Monter>(monter);

                _context.Monters.Add(monterEntity);
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
