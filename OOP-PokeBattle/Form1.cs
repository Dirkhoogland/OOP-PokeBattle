using System.Threading.Tasks;

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

            public int Rhp = 60;

            public int Lhp = 60;

            public int Population = 2;
            private void Form1_Load(object sender, EventArgs e)
            {
                this.Rnametxt.Text = "Pikachu";
                this.Rhitpointstxt.Text = $@"Hitpoints {Rhp} / {RhpS}";
                this.Rtypetxt.Text = "Type: Lightning";

                this.Lnametxt.Text = "Charmeleon";
                this.Lhitpointstxt.Text = $@"Hitpoints {Lhp} / {LhpS}";
                this.Ltypetxt.Text = "Fire";

                this.Poptxt.Text = $@"Population = {Population}";

            }
            private void button1_Click(object sender, EventArgs e)
            {
                Fight();

            }

            public void Fight()
            {
                int sleepTime = 1000;


                Task.Delay(sleepTime).Wait();

                Lhp = Electricring(GetLhp());
                getpopulation(Population);

                Task.Delay(sleepTime).Wait();

                Rhp = Flare(GetRhp());
                getpopulation(Population);

                Task.Delay(sleepTime).Wait();

                Lhp = Pikapunch(GetLhp());
                getpopulation(Population);

                Task.Delay(sleepTime).Wait();

                Rhp = Headbutt(GetRhp());
                getpopulation(Population);




            }

            public int GetLhp()
            {
                return Lhp;
            }

            public int GetRhp()
            {
                return Rhp;
            }

            public int Electricring(int Lhp)
            {
                int schade = 50;

                int rschade = (int)(schade / 10);
                Lhp = Lhp - rschade;

                this.Lhitpointstxt.Text = $@"Hitpoints {Lhp} / {LhpS}";
                this.Ldmgtaken.Text = $@"Damage {rschade}";
                this.Rattacktxt.Text = "Electric ring";

                return Lhp;
            }

            public int Flare(int Rhp)
            {
                int schade = 30;

                int Lschade = (int)(schade * 1.5);
                Rhp = Rhp - Lschade;
                this.Rhitpointstxt.Text = $@"Hitpoints {Rhp} / {RhpS}";
                this.Rdmgtakentxt.Text = $@"Damage {Lschade}";
                this.Lattacktxt.Text = "Flare";

                this.Ldmgtaken.Text = "";
                this.Rattacktxt.Text = "";

                return Rhp;
            }

            public int Pikapunch(int Lhp)
            {
                int schade = 20;

                Rhp = Rhp - schade;


                this.Rdmgtakentxt.Text = "";
                this.Lattacktxt.Text = "";

                this.Lhitpointstxt.Text = $@"Hitpoints {Lhp} / {LhpS}";
                this.Ldmgtaken.Text = $@"Damage {schade}";
                this.Rattacktxt.Text = "Pikapunch";

                return Lhp;
            }

            public int Headbutt(int Rhp)
            {
                int schade = 10;
                Rhp = Rhp - schade;
                this.Rhitpointstxt.Text = $@"Hitpoints {Rhp} / {RhpS}";
                this.Rdmgtakentxt.Text = $@"Damage {schade}";
                this.Lattacktxt.Text = "Headbutt";

                this.Ldmgtaken.Text = "";
                this.Rattacktxt.Text = "";

                return Rhp;
            }

            public int getpopulation(int Population)
            {
                if (Lhp <= 0)
                {
                    Population--;
                    this.midtxt.Text = "Pikachu has won";
                    this.Poptxt.Text = $@"Population = {Population}";

                    this.Lhitpointstxt.Text = $@"Hitpoints 0 / {LhpS}";
                    return Population;
                }
                if (Rhp <= 0)
                {
                    Population--;
                    this.midtxt.Text = "Charmeleon has won";
                    this.Poptxt.Text = $@"Population = {Population}";

                    this.Rhitpointstxt.Text = $@"Hitpoints 0 / {RhpS}";
                    return Population;
                }
                else
                {
                    return Population;
                }

            }
        

    }
}