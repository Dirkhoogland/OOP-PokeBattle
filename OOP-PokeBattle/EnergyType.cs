

namespace OOP_PokeBattle
{
    internal class EnergyType 
    {

        private string Name;
        private int Value;
        public EnergyType(string name, int Value)
        {
            this.Name = name;
            this.Value = Value; 
        }
        public string EnergyName { get { return Name; } }

    }
}
