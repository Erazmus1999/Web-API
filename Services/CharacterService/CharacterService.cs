using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web_API.Models;

namespace Web_API.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        List<Character> characters = new List<Character>
        {
            new Character(),
            new Character{Id = 1, Name = "Brock", Class = Class.Necromancer}
        };
        
        public List<Character> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }

        public List<Character> GetAllCharacters()
        {
            return characters;
        }

        public Character GetCharacterById(int id)
        {
            return characters.FirstOrDefault(x => x.Id == id);
        }
    }
}