using System.Collections.Generic;
using System.Diagnostics;

namespace OOP_PokeBattle
{
    public partial class Form1 : Form 
    {
        public Form1() 
        {   //Fainted function voor als er een pokemon dood is gegaan
            void fainted(string Pokemonname)
            {
                Debug.WriteLine($@"{Pokemonname} Has fainted");
                this.midtxt.Text = $@"{Pokemonname} has fainted";
                Pokemon.SetAmount();
                Debug.WriteLine($@"{Pokemon.GetAmount()} amount of Pokemon");
            }
            InitializeComponent();
            // Resistance types aanmaken, naam + value
            Resistance FightingR = new Resistance("Fighting", 20);
            Resistance LightningR = new Resistance("Lightning", 10);
            // Weakness types aanmaken, naam + value
            Weakness FireW = new Weakness("Fire", 1.5);
            Weakness WaterW = new Weakness("Water", 2);
            // Energytypes aanmaken, type + value
            EnergyType LightningE = new EnergyType("Lightning", 10);
            EnergyType FireE = new EnergyType("Fire", 10);
            // Attacks aanmaken, naam + damage(zonder modifier)
            Attack ElectricRing = new Attack("ElectricRing", 50);
            Attack Pikapunch = new Attack("PikaPunch", 20);
            Attack Flare = new Attack("Flare", 50);
            Attack Headbutt = new Attack("Headbutt", 20);
            // Lijst met twee attacks voor Pikachu, hard coded maar kan veranderd worden
            List<Attack> Attacklist = new List<Attack>();
            Attacklist.Add(ElectricRing);
            Attacklist.Add(Pikapunch);
            // Lijst met twee attacks voor Charmeleon, hard coded maar kan veranderd worden
            List<Attack> Attacklist2 = new List<Attack>();
            Attacklist2.Add(Flare);
            Attacklist2.Add(Headbutt);
            // Nieuwe pokemons aan gemaakt, Pikachu en Charmeleon met Naam, Energytype, HP, Attacks, Weakness, Resistance
            Pikachu Pikachu1 = new Pikachu("Pikachu1", LightningE, 60,Attacklist, WaterW, FightingR);
            Charmeleon Charmeleon1 = new Charmeleon("Charmeleon1", FireE, 60,Attacklist2, WaterW, LightningR);
     
            // Max hp apart variable stoppen voor beide pokemons,
            int RhpS = Pikachu1.GetHitpoints();

            int LhpS = Charmeleon1.GetHitpoints();
            // Form text opzetten met de namen, energytypes en hitpoints
            this.Rnametxt.Text = Pikachu1.GetName();
            this.Rhitpointstxt.Text = $@"Hitpoints {Pikachu1.GetHitpoints()} / {RhpS}";
            this.Rtypetxt.Text = Pikachu1.GetEnergyType().ToString();

            this.Lnametxt.Text = Charmeleon1.GetName();
            this.Lhitpointstxt.Text = $@"Hitpoints {Charmeleon1.GetHitpoints()} / {LhpS}";
            this.Ltypetxt.Text = Charmeleon1.GetEnergyType().ToString();
            //Delay tussen aanvallen/updates
            int sleepTime = 3000;
            // Turn function die speelt wanneer de applicatie opstart en de gegevens in de debug en op het sherm toont, sherm is alleen voor huidige aanvallen en active hitpoints
            Debug.WriteLine($@"Hitpoints {Pikachu1.GetName()} {Pikachu1.GetHitpoints()}");
            Debug.WriteLine($@"Hitpoints {Charmeleon1.GetName()} {Charmeleon1.GetHitpoints()}");
            
            int Turn()
            {
                
                //Laat de applicatie voor 3000 miliseconden wachten met opstart
                Task.Delay(sleepTime).Wait();
                // Dit maakt een random nummer aan tussen de 0 en 1 voor welke aanval de pokemon moet doen
                Random rand = new Random();
                int Num = rand.Next(0,2);
                // Dit vraagt de attackopponent functie aan met het randm number van hiervoor in de index voor te kiezen welke aanval, ook stuurt het de opponent mee 
                int Damage = Pikachu1.AttackOpponent(Pikachu1.GetAttack(Num), Charmeleon1);
                // functie voor hoeveel hp de opponent overheeft
                int Remaining = Charmeleon1.SetHitpoints(Damage);
                // voor in de debug te schrijven voor de damage, naam, attack en hitpoints
                Debug.WriteLine($@"{Damage} Damage to {Charmeleon1.GetName()}");
                // zet de attacknaam in de debug
                Debug.WriteLine($@"attack = { Pikachu1.GetAttackName(Num).ToString()}");
                Debug.WriteLine(Charmeleon1.GetName().ToString());
                // kijkt of de hitpoints -0 zijn en zet daar dan een 0
                if (Remaining < 0) { Debug.WriteLine($@"0 Hitpoints"); }
                else { Debug.WriteLine($@"{Charmeleon1.GetHitpoints()} Hitpoints"); }


                // zet de damage, naam en hitpoints op het scherm, maakt deze leeg als het niet van toepassing is op pikachu's turn
                this.Rdmgtakentxt.Text = "";
                this.Rattacktxt.Text = Pikachu1.GetAttackName(Num).ToString();
                this.Rhitpointstxt.Text = $@"Hitpoints {Pikachu1.GetHitpoints()} / {RhpS}";

                this.Lattacktxt.Text = "";
                this.Ldmgtaken.Text = $@"{Damage.ToString()} Damage taken";
                if (Remaining < 0) { this.Lhitpointstxt.Text = $@"Hitpoints {0} / {LhpS}"; }
                else { this.Lhitpointstxt.Text = $@"Hitpoints {Charmeleon1.GetHitpoints()} / {LhpS}"; }
                // checkt op charmeleon dood is, zo ja gaat het naar de fainted function 
                if (Remaining < 0)
                {
                    fainted(Charmeleon1.GetName().ToString());
                    return 1;
                }
                // delay tussen pikachu's en charmeleons turn
                Task.Delay(sleepTime).Wait();
                // nieuw random number voor charmeleons attack
                int Num2 = rand.Next(0, 2);
                // Charmeleon's attack op Pikachu en hp calculatie 
                Damage = Charmeleon1.AttackOpponent(Charmeleon1.GetAttack(Num2), Pikachu1);
                Remaining = Pikachu1.SetHitpoints(Damage);

                // schrijft de damage en naam in de debug
                Debug.WriteLine($@"{ Damage} Damage to {Pikachu1.GetName()}");
                // zet attack naam in de debug
                Debug.WriteLine(@$"Attack = {Charmeleon1.GetAttackName(Num2).ToString()}");
                Debug.WriteLine(Pikachu1.GetName().ToString());
                // kijkt of de hp -0 zo ja zet het - in de hp debug
                if (Remaining < 0) { Debug.WriteLine($@"0 Hitpoints remaining"); }
                else { Debug.WriteLine($@"{Pikachu1.GetHitpoints()} Hitpoints remaining"); }
                // laat op het scherm de gegevens zien voor charmeleons turn
                this.Rdmgtakentxt.Text = $@"{Damage.ToString()} Damage taken";
                this.Rattacktxt.Text = " ";
                if (Remaining < 0) { this.Rhitpointstxt.Text = $@"Hitpoints {0} / {RhpS}"; }
                else { this.Rhitpointstxt.Text = $@"Hitpoints {Pikachu1.GetHitpoints()} / {RhpS}"; }
                this.Lattacktxt.Text = $@"Used {Charmeleon1.GetAttackName(Num2).ToString()}";
                this.Ldmgtaken.Text = " ";
                this.Lhitpointstxt.Text = $@"Hitpoints {Charmeleon1.GetHitpoints()} / {LhpS}";
                // checkt of pikachu dood is
                if (Remaining < 0)
                {
                    fainted(Pikachu1.GetName().ToString());

                    return 1;

                }
                // Als geen van beide pokemon dood zijn speelt de turn functie zich opnieuw af 
                Turn();
                return 2;
            }
            int Alive = Turn();
            if (Alive == 1) { Debug.WriteLine("Er leeft nog 1 Pokemon"); }
            // write de extra lijnen voor pikachu en charmeleon
            Debug.WriteLine($@"Extra Pikachu {Pikachu1.Electicity().ToString()} and Charmeleon {Charmeleon1.BodyHeat().ToString()}");
        }
    }
}