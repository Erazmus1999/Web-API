using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Web_API.Models;
using Web_API.Services.CharacterService;

namespace Web_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

         [HttpGet("GetAllCharacters")]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> Get()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<Character>>> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<List<Character>>>> AddCharacter(Character newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }
	
    }
}