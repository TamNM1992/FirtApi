using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Data.Dtos
{
    public class SkillDto
    {
        //type index mana waiting_time  countdown
        public string TypeSkill { get; set; }
        [Key]
        public string SkillName { get; set; }
        public int Value { get; set; }
        public int ManaConsume { get; set; }
        public int EffectiveTime { get; set; }
        public int CoolDownTime  { get; set; }
    }
}
