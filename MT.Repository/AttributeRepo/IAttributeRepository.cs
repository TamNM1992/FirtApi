using MT.Data.Dtos;
using MT.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Repository.AttributeRepo
{
    public interface IAttributeRepository
    {
        public bool AddAttribute (AttributeDto attribute);
    }
}
