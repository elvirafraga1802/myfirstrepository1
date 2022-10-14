using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using efragalaureano.dotnet.Dtos;
using efragalaureano.dotnet.Dtos.Character;
using efragalaureano.dotnet.Dtos.Fight;
using efragalaureano.dotnet.Dtos.Skill;
using efragalaureano.dotnet.Dtos.Weapon;

namespace efragalaureano.dotnet
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
            CreateMap<Weapon, GetWeaponDto>();
            CreateMap<Skill, GetSkillDto>();
             CreateMap<Character, HighScoreDto>();
        }
    }
}