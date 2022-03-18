using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PokeBattle
{
    internal class Weakness
    {
        public string Energytype;
        public double Modifier;

        public Weakness(string energytype, Double Modifier)
        {
            this.Energytype = energytype;
            this.Modifier = Modifier;
        }
        

    }
}
