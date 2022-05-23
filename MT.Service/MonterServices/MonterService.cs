using AutoMapper;
using MT.Data.Dtos;
using MT.Repository.MonterRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Service.MonterServices
{
    public class MonterService : IMonterService
    {
        private IMonterRepository _repo;
        private IMapper _mapper;

        public MonterService(IMonterRepository monter, IMapper mapper)
        {
            _repo = monter;
            _mapper = mapper;
        }
        public bool AddMonter(MonterDto monterDto)
        {
            var temp = _repo.AddMonter(monterDto);
            return temp;
        }
    }
}
