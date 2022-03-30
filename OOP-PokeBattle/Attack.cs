

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
        public string GetAttackNameAttack() { return AttackName; }
        public int GetDamage() { return Damage; }
    }
}
