namespace OOP_PokeBattle
{
    internal class Weakness
    {
        private string Energytype;
        private double Modifier;

        public Weakness(string energytype, Double Modifier)
        {
            this.Energytype = energytype;
            this.Modifier = Modifier;
        }
        
        public string GetEnergytypeWeakness()
        {
            return Energytype;
        }

        public double GetModifier()
        {
            return Modifier;
        }
    }
}
