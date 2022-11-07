using System;
namespace projPokemon
{
   internal class Miaouss : Pokemons
    {
        public string Name { get; set; }
        public Miaouss()
        {
            Name = "Miaouss";
            Pv = 40;
            Atk = 45;
            Def = 35;
            Vit = 90;
            Xp = 0;
            PvMax = 40;
            Alive = true;
        }

    }
}

