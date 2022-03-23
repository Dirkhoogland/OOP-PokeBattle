

using System.Diagnostics;

namespace OOP_PokeBattle
{
    public partial class Form1 : Form 
    {
        public Form1() 
        {
            void fainted(string Pokemonname)
            {
                Debug.WriteLine($@"{Pokemonname} Has fainted");
                this.midtxt.Text = $@"{Pokemonname} has fainted";
                Pokemon.SetAmount();
                Debug.WriteLine($@"{Pokemon.GetAmount()} amount of Pokemon");
            }
            InitializeComponent();
            Resistance FightingR = new Resistance("Fighting", 20);
            Resistance LightningR = new Resistance("Lightning", 10);

            Weakness FireW = new Weakness("Fire", 1.5);
            Weakness WaterW = new Weakness("Water", 2);

            EnergyType LightningE = new EnergyType("Lightning", 10);
            EnergyType FireE = new EnergyType("Fire", 10);


            Attack ElectricRing = new Attack("ElectricRing", 50);
            Attack Pikapunch = new Attack("PikaPunch", 20);

            Attack Flare = new Attack("Flare", 50);
            Attack Headbutt = new Attack("Headbutt", 20);

            Pikachu Pikachu1 = new Pikachu("Pikachu1", LightningE, 60,ElectricRing, WaterW, FightingR);
            Charmeleon Charmeleon1 = new Charmeleon("Charmeleon1", FireE, 60, Flare, WaterW, LightningR);
     

            int RhpS = Pikachu1.getHitpoints();

            int LhpS = Charmeleon1.getHitpoints();

            this.Rnametxt.Text = Pikachu1.getname();
            this.Rhitpointstxt.Text = $@"Hitpoints {Pikachu1.getHitpoints()} / {RhpS}";
            this.Rtypetxt.Text = Pikachu1.GetEnergyType().ToString();

            this.Lnametxt.Text = Charmeleon1.getname();
            this.Lhitpointstxt.Text = $@"Hitpoints {Charmeleon1.getHitpoints()} / {LhpS}";
            this.Ltypetxt.Text = Charmeleon1.GetEnergyType().ToString();

            int sleepTime = 3000;


            Task.Delay(sleepTime).Wait();

            int Damage = Pikachu1.attackopponent(Pikachu1.getAttack(), Charmeleon1);
            int Remaining = Charmeleon1.SetHitpoints(Damage);
            Debug.WriteLine("Damage");
            Debug.WriteLine(Damage);
            Debug.WriteLine(Charmeleon1.getname().ToString());
            if (Remaining < 0) { Debug.WriteLine($@"0 Hitpoints"); }
            else { Debug.WriteLine($@"{Charmeleon1.getHitpoints()} Hitpoints"); }
            Debug.WriteLine($@"attack = { Pikachu1.GetAttackName().ToString()}");

            if (Remaining < 0)
            {
                fainted(Charmeleon1.getname().ToString());
            }

            Task.Delay(sleepTime).Wait();


            Damage = Charmeleon1.attackopponent(Charmeleon1.getAttack(), Pikachu1);
            Remaining = Pikachu1.SetHitpoints(Damage);


            Debug.WriteLine($@"{ Damage} Damage");
            Debug.WriteLine(Pikachu1.getname().ToString());
            if (Remaining < 0) { Debug.WriteLine($@"0 Hitpoints"); }
            else{Debug.WriteLine($@"{Pikachu1.getHitpoints()} Hitpoints");}
            Debug.WriteLine("Attack");
            Debug.WriteLine(@$"Attack = {Charmeleon1.GetAttackName().ToString()}");

            if (Remaining < 0)
            {
                fainted(Pikachu1.getname().ToString());
            }

            Task.Delay(sleepTime).Wait();

            Damage = Pikachu1.attackopponent(Pikachu1.getAttack(), Charmeleon1);
            Remaining = Charmeleon1.SetHitpoints(Damage);
            Debug.WriteLine("Damage");
            Debug.WriteLine(Damage);
            Debug.WriteLine(Charmeleon1.getname().ToString());
            if (Remaining < 0) { Debug.WriteLine($@"0 Hitpoints"); }
            else { Debug.WriteLine($@"{Charmeleon1.getHitpoints()} Hitpoints"); }
            Debug.WriteLine($@"attack = { Pikachu1.GetAttackName().ToString()}");


            if (Remaining < 0)
            {
                fainted(Charmeleon1.getname().ToString());
            }



            Debug.WriteLine($@"Extra Pikachu {Pikachu1.Electicity().ToString()} and Charmeleon {Charmeleon1.BodyHeat().ToString()}");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //this.Rdmgtakentxt.Text = "";
        //this.Rattacktxt.Text = Pikachu1.getAttack().ToString();
        //this.Rhitpointstxt.Text = $@"Hitpoints {Pikachu1.getHitpoints()} / {RhpS}";

        //this.Lattacktxt.Text = "";
        //this.Ldmgtaken.Text = Damage.ToString();
        //this.Lhitpointstxt.Text = $@"Hitpoints {Charmeleon1.getHitpoints()} / {LhpS}";
        //-----
        //this.Rdmgtakentxt.Text = Damage.ToString();
        //this.Rattacktxt.Text = " ";
        //this.Rhitpointstxt.Text = $@"Hitpoints {Pikachu1.getHitpoints()} / {RhpS}";

        //this.Lattacktxt.Text = Charmeleon1.getAttack().ToString();
        //this.Ldmgtaken.Text = " ";
        //this.Lhitpointstxt.Text = $@"Hitpoints {Charmeleon1.getHitpoints()} / {LhpS}";
        //----
        //this.Rdmgtakentxt.Text = "";
        //this.Rattacktxt.Text = Pikachu1.getAttack().ToString();
        //this.Rhitpointstxt.Text = $@"Hitpoints {Pikachu1.getHitpoints()} / {RhpS}";

        //this.Lattacktxt.Text = "";
        //this.Ldmgtaken.Text = Damage.ToString();
        //this.Lhitpointstxt.Text = $@"Hitpoints {Charmeleon1.getHitpoints()} / {LhpS}";
        //-----

        //public int Electricring(int Lhp)
        //        {
        //            int schade = 50;

        //            this.Rdmgtakentxt.Text = "";
        //            this.Lattacktxt.Text = "";

        //            int rschade = (int)(schade / 10);
        //            Lhp = Lhp - rschade;

        //            this.Lhitpointstxt.Text = $@"Hitpoints {Lhp} / {LhpS}";
        //            this.Ldmgtaken.Text = $@"Damage {rschade}";
        //            this.Rattacktxt.Text = "Electric ring";

        //            return Lhp;
        //        }

        //        public int Flare(int Rhp)
        //        {
        //            int schade = 30;

        //            int Lschade = (int)(schade * 1.5);
        //            Rhp = Rhp - Lschade;
        //            this.Rhitpointstxt.Text = $@"Hitpoints {Rhp} / {RhpS}";
        //            this.Rdmgtakentxt.Text = $@"Damage {Lschade}";
        //            this.Lattacktxt.Text = "Flare";

        //            this.Ldmgtaken.Text = "";
        //            this.Rattacktxt.Text = "";

        //            return Rhp;
        //        }

        //        public int pikapunch(int Lhp)
        //        {
        //            int schade = 20;

        //            Lhp = Lhp - schade;


        //            this.Rdmgtakentxt.Text = "";
        //            this.Lattacktxt.Text = "";

        //            this.Lhitpointstxt.Text = $@"Hitpoints {Lhp} / {LhpS}";
        //            this.Ldmgtaken.Text = $@"Damage {schade}";
        //            this.Rattacktxt.Text = "Pikapunch";

        //            return Lhp;
        //        }

        //        public int Headbutt(int Rhp)
        //        {
        //            int schade = 15;
        //            Rhp = Rhp - schade;
        //            this.Rhitpointstxt.Text = $@"Hitpoints {Rhp} / {RhpS}";
        //            this.Rdmgtakentxt.Text = $@"Damage {schade}";
        //            this.Lattacktxt.Text = "Headbutt";

        //            this.Ldmgtaken.Text = "";
        //            this.Rattacktxt.Text = "";

        //            return Rhp;
        //        }



        //public int Rhp = 60;

        //public int Lhp = 60;

        //public int Population = 2;

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Fight();

        //}

        //public void Fight()
        //{

        //    button1.Visible = false;
        //    int sleepTime = 3000;


        //    Task.Delay(sleepTime).Wait();

        //    Lhp = Electricring(GetLhp());
        //    getpopulation(Population);

        //    Task.Delay(sleepTime).Wait();

        //    Rhp = Flare(GetRhp());
        //    getpopulation(Population);

        //    Task.Delay(sleepTime).Wait();

        //    Lhp = pikapunch(GetLhp());
        //    getpopulation(Population);

        //    Task.Delay(sleepTime).Wait();

        //    Rhp = Headbutt(GetRhp());
        //    getpopulation(Population);
        //}

        //public int GetLhp()
        //{
        //    return Lhp;
        //}

        //public int GetRhp()
        //{
        //    return Rhp;
        //}



        //public int getpopulation(int Population)
        //{
        //    if (Lhp <= 0)
        //    {
        //        Population--;
        //        this.midtxt.Text = "Pikachu has won";
        //        this.Poptxt.Text = $@"Population = {Population}";

        //        this.Lhitpointstxt.Text = $@"Hitpoints 0 / {LhpS}";
        //        return Population;
        //    }
        //    if (Rhp <= 0)
        //    {
        //        Population--;
        //        this.midtxt.Text = "Charmeleon has won";
        //        this.Poptxt.Text = $@"Population = {Population}";

        //        this.Rhitpointstxt.Text = $@"Hitpoints 0 / {RhpS}";
        //        return Population;
        //    }
        //    else
        //    {
        //        return Population;
        //    }

        //}


    }
}