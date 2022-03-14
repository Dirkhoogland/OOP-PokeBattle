namespace OOP_PokeBattle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int RhpS = 60;

        int LhpS = 60;

        int Rhp = 60;

        int Lhp = 60;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Rnametxt.Text = "Pikachu";
            this.Rhitpointstxt.Text = $@"Hitpoints {Rhp} / {RhpS}";
            this.Rtypetxt.Text =  "Type: Lightning";

            this.Lnametxt.Text = "Charmeleon";
            this.Lhitpointstxt.Text =$@"Hitpoints {Lhp} / {LhpS}";
            this.Ltypetxt.Text = "Fire";

            Fight();
        }


        public void Fight()
        {

            Thread.Sleep(10000);
            Electricring(GetLhp());
            Thread.Sleep(10000);

        }

        public int GetLhp()
        {
            return Lhp;
        }

        public int GetRhp()
        {
            return Rhp;
        }

        public void Electricring(int lhp)
        {
            int schade = 50;

            int rschade = (int)(schade / 1.5);
            Lhp = Lhp - rschade;

            this.Lhitpointstxt.Text = $@"Hitpoints {Lhp} / {LhpS}";
            this.Ldmgtaken.Text = $@"Damage {rschade}";
            this.Rattacktxt.Text = "Electric ring";
        }
    }
}