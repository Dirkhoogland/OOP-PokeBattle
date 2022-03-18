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
        private Attack Attack;
        private Weakness Weakness;
        private Resistance Resistance;


        public Pokemon (string name,
                        EnergyType EnergyType,
                        int Hitpoints,
                        Attack attacks,
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

        public Attack getAttack()
        {
            return Attack;  
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
            return Weakness.Energytype.ToString();
        }

        public string GetResistance()
        {
            return Resistance.Energytype.ToString();
        }

        public int SetHitpoints(int Healthremaining)
        {
            int newhp = this.Hitpoints - Healthremaining;
            newhp = this.Hitpoints;
            return this.Hitpoints;
        }

        public int attackopponent(Attack attackname, Pokemon opponent)
        {
            if (this.EnergyType.ToString() == opponent.Weakness.ToString())
            {
               double Damage = this.Attack.Damage * opponent.Weakness.Modifier;


                return (int)Damage;

            }
            if (this.EnergyType.ToString() == opponent.Resistance.ToString())
            {
                int Damage = this.Attack.Damage - opponent.Resistance.Value;

                return Damage;
            }
            else
            {
                int Damage = this.Attack.Damage;

                return Damage;
            }
        }

        //private Pokemon AttackOpponent(string attackName, int SchadeDamage)
        //{

        //    return;
        //}


    }
}
