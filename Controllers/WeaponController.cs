using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using efragalaureano.dotnet.Dtos.Character;
using efragalaureano.dotnet.Dtos.Weapon;
using efragalaureano.dotnet.Services.CharacterService.WeaponService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace efragalaureano.dotnet.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class WeaponController: ControllerBase
    {
        private readonly IWeaponService _weaponService;

        public WeaponController(IWeaponService weaponService)
        {
            _weaponService = weaponService;
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse< GetCharacterDto>>> AddWeapon(AddWeaponDto newWeapon)
        {
            return Ok(await _weaponService.AddWeapon(newWeapon));
            
        }
    }
}