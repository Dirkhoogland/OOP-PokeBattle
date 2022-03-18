using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PokeBattle
{
    internal class Charmeleon
    {
        public string Name;
        public EnergyType EnergyType;
        public int Hitpoints;
        public int Attacks;
        public Weakness Weakness;
        public Resistance Resistance;

        public Charmeleon(string name, EnergyType EnergyType, int Hitpoints, int attacks, Weakness Weakness, Resistance Resistance)
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
