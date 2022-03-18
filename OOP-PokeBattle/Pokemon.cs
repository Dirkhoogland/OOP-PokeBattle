using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PokeBattle
{
    class Pokemon
    {

        private string name;
        private EnergyType EnergyType;
        private int Hitpoints;
        private int Attack;
        private Weakness Weakness;
        private Resistance Resistance;


        public Pokemon (string name,
                        EnergyType EnergyType,
                        int Hitpoints,
                        int attacks,
                        Weakness Weakness,
                        Resistance Resistance)
        {
            this.name = name;
            this.EnergyType = EnergyType;   
            this.Hitpoints = Hitpoints;
            this.Attack = attacks;   
            this.Weakness = Weakness;   
            this.Resistance = Resistance;   
        }
        public string getname()
        {
            return name;
        }
        public int getHitpoints()
        {
            return Hitpoints;
        }
        public string GetEnergyType()
        {
           
            return EnergyType.Name.ToString();
        }
        public string GetWeakness()
        {
            return Weakness.ToString();
        }

        public string GetResistance()
        {
            return Resistance.ToString();
        }

        //private Pokemon AttackOpponent(string attackName, int SchadeDamage)
        //{

        //    return;
        //}


    }
}
