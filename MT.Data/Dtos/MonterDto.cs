using MT.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Data.Dtos
{
    public class MonterDto
    {
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Level { get; set; }
        //public TypeDto Type { get; set; }
        public string Type { get; set; }
        //public AttributeDto Attribute { get; set; }
        public string Attribute { get; set; }
        [Key]
        public string Name { get; set; }
        //public int ManaRegent { get; set; }
        //public int ManaMax { get; set; }
        public int ManaCurrent { get; set; }
        //public int HealMax { get; set; }
        public int HealCurrent { get; set; }
        public int ShieldCurrent { get; set; }
        //public int AtkCurrent { get; set; }
        //public int DefCurrent { get; set; }


        public SkillDto Qskill { get; set; }/* type index mana waiting_time  countdowntype index mana waiting_time  countdown*/
        public SkillDto Wskill { get; set; }
        public SkillDto Eskill { get; set; }
        public SkillDto Ultimate { get; set; }


    }
}
