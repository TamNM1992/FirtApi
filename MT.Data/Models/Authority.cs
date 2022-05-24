using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Data.Models
{
    public class Authority
    {
        public Guid ID { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public Authority()
        {
            this.Users = new HashSet<User>();
        }
        public virtual ICollection<User> Users { get; set; }

    }
}
