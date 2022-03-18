using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PokeBattle
{
    internal class Pokemon
    {

        private string Name;
        private string EnergyType;
        private int Hitpoints;
        private string Attack;
        private string Weakness;
        private string Resistance;
        private int DamageAttack;
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
