using MT.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Service.AttributeServices
{
    public interface IAttributeService
    {
        public bool AddAttribute(AttributeDto attributeDto);
    }
}
