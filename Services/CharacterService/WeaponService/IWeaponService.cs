using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efragalaureano.dotnet.Dtos.Character;
using efragalaureano.dotnet.Dtos.Weapon;

namespace efragalaureano.dotnet.Services.CharacterService.WeaponService
{
    public interface IWeaponService
    {
        Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}