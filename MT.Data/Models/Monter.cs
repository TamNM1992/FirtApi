using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Data.Models
{
    public class Monter
    {
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Level { get; set; }
        //public Type Type { get; set; }
        public string Type { get; set; }
        //public Attribute Attribute { get; set; }
        public string Attribute { get; set; }
        [Key]
        public string Name { get; set; }
        //public int ManaRegent { get; set; }
        //public int ManaMax { get; set; }
        public int ManaCurrent = 0;
        //public int HealMax { get; set; }
        public int HealCurrent = 0;

        public int ShieldCurrent = 0;
        //public int AtkCurrent { get; set; }
        //public int DefCurrent { get; set; }


        public Skill Qskill { get; set; }/* type index mana waiting_time  countdowntype index mana waiting_time  countdown*/
        public Skill Wskill { get; set; }
        public Skill Eskill { get; set; }
        public Skill Ultimate { get; set; }

    }
}
