using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Data.Models
{
    public class AuthorityDto
    {
        public Guid ID { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }

        public virtual ICollection<User> Users { get; set; }

    }
}
