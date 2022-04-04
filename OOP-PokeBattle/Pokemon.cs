using System.Diagnostics;
namespace OOP_PokeBattle
{
    class Pokemon
    {

        private string Name;
        private EnergyType EnergyType;
        private int Hitpoints;
        private List<Attack> Attack;
        private Weakness Weakness;
        private Resistance Resistance;
        private static int Amount = 0;

        public Pokemon(string name,
                        EnergyType EnergyType,
                        int Hitpoints,
                        List<Attack> attacks,
                        Weakness Weakness,
                        Resistance Resistance)
        {
            this.Name = name;
            this.EnergyType = EnergyType;
            this.Hitpoints = Hitpoints;
            this.Attack = attacks;
            this.Weakness = Weakness;
            this.Resistance = Resistance;
            Pokemon.Amount++;

        }

        public string GetAttackName(int Index)
        {
            return Attack[Index].GetAttackNameAttack();
        }
        public static int GetAmount()
        {
            return Pokemon.Amount;
        }

        public static void SetAmount()
        {
            Pokemon.Amount--;
        }
        public Attack GetAttack(int Index)
        {
            return Attack[Index];
        }
        public string GetName()
        {
            return Name;
        }
        public int GetHitpoints()
        {
            return Hitpoints;
        }
        public string GetEnergyType()
        {

            return EnergyType.EnergyName.ToString();
        }
        public string GetWeakness()
        {
            return Weakness.GetEnergytypeWeakness().ToString();
        }

        public string GetResistance()
        {
            return Resistance.GetEnergytypeResistance().ToString();
        }

        public int SetHitpoints(int Healthremaining)
        {
            int newhp = this.Hitpoints - Healthremaining;
            this.Hitpoints -= Healthremaining;

            return (newhp > 0) ? 0 : this.Hitpoints;
        }

        public int AttackOpponent(Attack attackname, Pokemon opponent)
        {
            if (this.EnergyType.EnergyName.ToString() == opponent.Weakness.GetEnergytypeWeakness().ToString())
            {
                return (int)(attackname.GetDamage() * opponent.Weakness.GetModifier());

            }
            if (this.EnergyType.EnergyName.ToString() == opponent.Resistance.GetEnergytypeResistance().ToString())
            {
                return attackname.GetDamage() - opponent.Resistance.GetValue();


            }
            else
            {
                return attackname.GetDamage();
            }
        }
        public void Fainted(string name)
        {
            Debug.WriteLine($@"{name} Has fainted");
            
            population();
        }
        static void population()
        {
            Pokemon.SetAmount();
            Debug.WriteLine($@"{Pokemon.GetAmount()} amount of Pokemon");
        }



    }
}
