using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PokeBattle
{
    internal class Charmeleon : Pokemon
    {


        public Charmeleon(string name,
                          EnergyType EnergyType,
                          int Hitpoints,
                          int attacks,
                          Weakness Weakness,
                          Resistance Resistance) : base(name, EnergyType, Hitpoints, attacks, Weakness, Resistance)

        {

        }
    }
}
