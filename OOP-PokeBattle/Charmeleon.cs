

namespace OOP_PokeBattle
{
    internal class Charmeleon : Pokemon
    {


        public Charmeleon(string name,
                          EnergyType EnergyType,
                          int Hitpoints,
                          Attack attacks,
                          Weakness Weakness,
                          Resistance Resistance) : base(name, EnergyType, Hitpoints, attacks, Weakness, Resistance)

        {

        }

        public string BodyHeat()
        {   string Heat = "32";
            return Heat;
        }
    }
}
