

namespace OOP_PokeBattle
{
    internal class Pikachu : Pokemon
    {

        public Pikachu(string name,
                       EnergyType EnergyType,
                       int Hitpoints,
                       Attack attacks,
                       Weakness Weakness,
                       Resistance Resistance) : base(name, EnergyType, Hitpoints, attacks, Weakness, Resistance)
        {


        }

        public String Electicity()
        { String Elec = "10";
            return Elec;
        }



    }
}
