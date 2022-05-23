using MT.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Service.MonterServices
{
    public interface IMonterService
    {
        public bool AddMonter(MonterDto monter);
    }
}
