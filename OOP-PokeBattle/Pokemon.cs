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

        public Pokemon (string name,
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
            return Attack[Index].AttackName;
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
            this.Hitpoints -= Healthremaining;


            if (newhp > 0)
            {
                return 0;
            }
            else
            {
                return this.Hitpoints;
            }
        }

        public int AttackOpponent(Attack attackname, Pokemon opponent)
        {
            if (this.EnergyType.Name.ToString() == opponent.Weakness.Energytype.ToString())
            {
               double Damage = attackname.Damage * opponent.Weakness.Modifier;


                return (int)Damage;

            }
            if (this.EnergyType.Name.ToString() == opponent.Resistance.Energytype.ToString())
            {
                int Damage = attackname.Damage - opponent.Resistance.Value;

                return Damage;
            }
            else
            {
                int Damage = attackname.Damage;

                return Damage;
            }
        }
        


    }
}
