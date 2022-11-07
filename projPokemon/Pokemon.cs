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
        public int Pv { get; set; }
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Vit { get; set; }
        public int Xp { get; set; }
        public int PvMax { get; set; }
        public bool Alive { get; set; }

        public Pokemons()
        {
        }

        public Pokemons(int PV, int ATK, int DEF, int VIT, int XP, int pvmax)
        {
            
            Pv = PV;
            Atk = ATK;
            Def = DEF;
            Vit= VIT;
            Xp = XP;
            PvMax = pvmax;
            bool Alive = true;
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

                    Console.WriteLine("Votre pokemon été soigné ");
                }

            }
            else
            {
                Console.WriteLine("Votre pokemon a déja toute sa vie");
            }

        }

        public void TakingDamages(int pokemonAttack)//Method to take damages
        {
            Pv -= pokemonAttack - Def;//The pokemon's defense blocks damages
            if (Pv <= 0)//If a pokemon has no health points the pokemon is beaten
            {
                GameOver();
            }
            else
            {
                Console.WriteLine("Votre Pokemon a pris" + (pokemonAttack - Def) + "de dégaats. Il lui rest" + Pv + "HP/" + PvMax + "HP.\n");
            }

        }


        /* mettre fin a la partie */
        public void GameOver()
        {
            Pv = 0;
            Console.WriteLine("GAME OVER");
            Alive = false;
            
        }



        /* Méthode pour recevoir des dégats */
        public void ReceiveDmg(int Atk)
        {
            var DmgRecu = 6;
            Pv = Pv - DmgRecu;
            Console.WriteLine("Votre pokemon reçoit " + DmgRecu + " points de dégâts !");

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