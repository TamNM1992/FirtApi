using MT.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Repository.MonterRepo
{
    public interface IMonterRepository
    {
        public bool AddMonter(MonterDto monter);
    }
}
