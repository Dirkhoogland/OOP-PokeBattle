using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PokeBattle
{
    internal class Pikachu
    {
        
        public string Name;
        public string EnergyType;
        public int Hitpoints;
        public int Attacks;
        Weakness
        Resistance

        public Pikachu(string name, string EnergyType, int Hitpoints, int attacks, Weakness, Resistance)
        {
            this.Name = name;
            this.EnergyType = EnergyType;
            this.Hitpoints = Hitpoints;
            this.Attacks = attacks;
            this.Weakness = Weakness;
            this.Resistance = Resistance;
        }
        Pikachu Pikachu1 = new Pikachu("Pikachu1", Lightning, 60, 2 , Water, Fighting);
    }
}
