using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PokeBattle
{
    internal class Resistance
    {
        public string Energytype;
        public int Value;

        public Resistance(string energytype, int Value)
        {
            this.Energytype = energytype;
            this.Value = Value; 

        }

        Resistance Fighting = new Resistance("Fighting",20);
        Resistance Lightning = new Resistance("Lightning",10);
        
    }
}
