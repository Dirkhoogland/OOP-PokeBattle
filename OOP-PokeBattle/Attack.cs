using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PokeBattle
{
    internal class Attack
    {
        private string AttackName;
        private int Damage;
        public Attack(string attackName, int Damage)
        {
            this.AttackName = attackName;
            this.Damage = Damage;
        }


    }
}
