using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_API.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; } = "Bart";
        public int HitPoints { get; set; } = 100;
        public int Strength {get; set; } = 10;
        public int Dexterity {get; set; } = 10;
        public int Intelligence {get; set; } = 10;
        public int Defense {get; set; } = 10;
        public Class Class {get; set; } = Class.Paladin;
    }
}