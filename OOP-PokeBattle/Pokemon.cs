using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PokeBattle
{
    internal class Pokemon
    {

        public string Name;
        public string EnergyType;
        public int Hitpoints;
        public string Attack;
        public string Weakness;
        public string Resistance;
        public int DamageAttack;
        public int DamageRecieved;

        public Pokemon(string Name,string EnergyType, int Hitpoints, string Attack, string Weakness,string Resistance, int DamageAttack, int DamageRecieved)
        {
            this.Name = Name;
            this.EnergyType = EnergyType;   
            this.Hitpoints = Hitpoints;
            this.Attack = Attack;   
            this.Weakness = Weakness;   
            this.Resistance = Resistance;   
            this.DamageAttack = DamageAttack;    
            this.DamageRecieved = DamageRecieved;

        }

        


    }
}
