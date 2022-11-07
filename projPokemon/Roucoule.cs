using System;
namespace projPokemon
{
    internal class Roucoule : Pokemons
    {
        public string Name { get; set; }
        public Roucoule()
        {
            Name = "Roucoule";
            Pv = 40;
            Atk = 45;
            Def = 40;
            Vit = 56;
            Xp = 0;
            PvMax = 40;
            Alive = true;
        }
    }
}

