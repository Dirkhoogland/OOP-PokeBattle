using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PokeBattle
{
    internal class Pikachu
    {

        private string Name;
        private EnergyType EnergyType;
        private int Hitpoints;
        private int Attacks;
        private Weakness Weakness;
        private Resistance Resistance;

        public Pikachu(string name, EnergyType EnergyType, int Hitpoints, int attacks, Weakness Weakness, Resistance Resistance)
        {
            this.Name = name;
            this.EnergyType = EnergyType;
            this.Hitpoints = Hitpoints;
            this.Attacks = attacks;
            this.Weakness = Weakness;
            this.Resistance = Resistance;
        }
        
        

    }
}
