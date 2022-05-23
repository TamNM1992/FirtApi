using AutoMapper;
using MT.Data.Dtos;
using MT.Data.Models;
using System;

namespace MT.Common
{
    public static class InforExtension
    {

        public static int ManaMax(this MonterDto monterDto)
        {
            return (monterDto.Atk + monterDto.Def) * monterDto.Level;


        }

        public static int ManaRegent(this MonterDto monterDto,  TypeDto typDto, AttributeDto attribute)
        {
            return ((monterDto.Def + typDto.SpeedBase + attribute.SpeedBase) * monterDto.Level / 40)
                    * (100 + (1000 + typDto.SpeedBase + attribute.SpeedBase) / 200) / 100;
        }

            public static int HealMax(this MonterDto monterDto, TypeDto typDto, AttributeDto attribute)
            {
                return ((monterDto.Atk + monterDto.Def) * monterDto.Level + (monterDto.Atk + monterDto.Def) * monterDto.Level * 
                       (typDto.DefBase + attribute.DefBase + typDto.StrengBase + attribute.StrengBase) / 1000)
                    * (10 + monterDto.Level) / 10;

            }

            public static int HealRegent(this MonterDto monterDto, TypeDto typDto, AttributeDto attribute)
            {
                return ((monterDto.Def + typDto.DefBase + attribute.DefBase + typDto.StrengBase + attribute.StrengBase) * monterDto.Level / 50)
                    * (100 + (1000 + typDto.DefBase + attribute.DefBase + typDto.StrengBase + attribute.StrengBase) / 100) / 100;
            }

            public static int AtkCurrent(this  MonterDto monterDto, TypeDto typDto, AttributeDto attribute)
            {
                return ((typDto.AtkBase + attribute.AtkBase + typDto.SpeedBase + attribute.SpeedBase) + 
                            (monterDto.Atk + monterDto.Atk * (typDto.AtkBase + attribute.AtkBase) / 1000)
                             * ((100 + (1000 + typDto.SpeedBase + attribute.SpeedBase) / 200)) / 100) * (10 + monterDto.Level) / 10;
            }

            public static int DefCurrent(this  MonterDto monterDto, TypeDto typDto, AttributeDto attribute)
            {
                return ((typDto.DefBase + attribute.DefBase + typDto.StrengBase + attribute.StrengBase) + (monterDto.Def + monterDto.Def * (typDto.DefBase + attribute.DefBase) / 1000)
                       * ((100 + (1000 + typDto.StrengBase + attribute.StrengBase) / 100)) / 100) * (10 + monterDto.Level) / 10;
            }

            public static int SpeedAtk(this MonterDto monterDto, TypeDto typDto, AttributeDto attribute)
            {
                return (1000 + typDto.SpeedBase + attribute.SpeedBase) / 200;
            }

            public static int Agi(this MonterDto monterDto, TypeDto typDto, AttributeDto attribute)
            {
                return (typDto.SpeedBase + attribute.SpeedBase) / 100;
            }

            public static int Crit(this MonterDto monterDto, TypeDto typDto, AttributeDto attribute)
            {
                return (typDto.AtkBase + attribute.AtkBase + typDto.SpeedBase + attribute.SpeedBase) * monterDto.Level * monterDto.Level / 10000;
            }

            public static int Block(this MonterDto monterDto, TypeDto typDto, AttributeDto attribute)
            {
                return (monterDto.Def - monterDto.Atk + typDto.DefBase + attribute.DefBase + typDto.StrengBase + attribute.StrengBase)
                            * monterDto.Level * monterDto.Level / 10000;
            }

            public static int Tenacious(this MonterDto monterDto, TypeDto typDto, AttributeDto attribute)
            {
                return (2 * monterDto.Def - monterDto.Atk + typDto.DefBase + attribute.DefBase + typDto.StrengBase + attribute.StrengBase) 
                            * monterDto.Level * monterDto.Level / 10000;
            }
        
    }
}
