using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MT.Data.Models
{
    public class Attribute
    {
        [Key]
        public string Name { get; set; }
        public int AtkBase { get; set; }
        public int DefBase { get; set; }
        public int SpeedBase { get; set; }
        public int StrengBase { get; set; }

        //public static int[] Light = { 600, 400, 750, 250 };
        //public static int[] Dark = { 500, 500, 700, 300 };
        //public static int[] Water = { 250, 750, 850, 150 };
        //public static int[] Fire = { 700, 300, 800, 200 };
        //public static int[] Earth = { 100, 900, 200, 800 };
        //public static int[] Wind = { 550, 450, 900, 100 };
        //public static int[] Divine = { 1000, 1000, 1000, 1000 };
    };
}
