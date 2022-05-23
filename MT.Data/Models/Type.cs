using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Data.Models
{
        public class Type
        {/*                                atk----def----speed--streng*/
            [Key]
            public string Name { get; set; }

            public int AtkBase { get; set; }
            public int DefBase { get; set; }
            public int SpeedBase { get; set; }
            public int StrengBase { get; set; }

        }

}
