using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PokeBattle
{
    internal class Resistance
    {
        private string Energytype;
        private int Value;

        public Resistance(string energytype, int Value)
        {
            this.Energytype = energytype;
            this.Value = Value; 

        }
        
    }
}
