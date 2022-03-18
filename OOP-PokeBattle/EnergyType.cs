using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PokeBattle
{
    internal class EnergyType 
    {

        public string Name;
        private int Value;
        public EnergyType(string name, int Value)
        {
            this.Name = name;
            this.Value = Value; 
        }

    }
}
