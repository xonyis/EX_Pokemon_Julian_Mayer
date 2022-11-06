using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace projPokemon
{
    internal class Pokemons
    {
        public string Name { get; set; }
        public int Pv { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Vit { get; set; }
        public int Xp { get; set; }
        public int PvMax { get; set; }


        public Pokemons()
        {
        }

        public Pokemons(string name, int PV, int ATK, int DEF, int VIT, int XP, int pvmax)
        {
            Name = name;
            Pv = PV;
            Atk = ATK;
            Def = DEF;
            Vit= VIT;
            Xp = XP;
            PvMax = pvmax;
        }



        /* Utiliser les potion */
        public void Potion()
        {
            if (Pv < PvMax)
            {
                var Potion = 20;
                Pv = Pv + Potion;

                if (Pv > PvMax)
                {
                    Pv = PvMax;

                    Console.WriteLine(Name + " a été soigné ");
                }

            }
            else
            {
                Console.WriteLine(Name +" a déja toute sa vie");
            }

        }


       /* mettre fin a la partie */
        public void GameOver()
        {
            Pv = 0;
            Console.WriteLine("GAME OVER");
            bool game = false;
        }



        /* Méthode pour recevoir des dégats */
        public void ReceiveDmg(int Atk)
        {
            var DmgRecu = 6;
            Pv = Pv - DmgRecu;
            Console.WriteLine(Name + "reçoit " + DmgRecu + " points de dégâts !");

            if (Pv <= 0)
            {
                GameOver();
            }
            else
            {
                Console.WriteLine("Il lui reste " + Pv + " PV.");
            }
        }



        /* Méthode pour le gain d'xp */
        public void GetExperiences()
        {
            Xp++;

            if (Xp == 4)
            {
                Pv = Pv + 2;
                Atk = Atk + 2;
                Def = Def + 2;
                Vit = Vit + 2;
                PvMax = PvMax + 2;
                Console.WriteLine("Votre pokémon a gagné un niveau !");

            }
            else
            {
                Console.WriteLine("Votre pokémon ne peut pas encore gagner un niveau !");
            }
        }

    }
}