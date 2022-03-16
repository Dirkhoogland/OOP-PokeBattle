using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PokeBattle
{
    internal class Attack
    {
        public string AttackName;
        public int Damage;
        public Attack(string attackName, int Damage)
        {
            this.AttackName = attackName;
            this.Damage = Damage;
        }
        public Attack ElectricRing = new Attack("ElectricRing", 50);
        public Attack Pikapunch = new Attack("PikaPunch",20);



    }
}
