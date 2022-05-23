using MT.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Service.TypeServices
{
    public interface ITypeService
    {
        public bool AddType(TypeDto typeDto);
    }
}
