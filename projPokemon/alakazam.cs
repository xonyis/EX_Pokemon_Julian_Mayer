using System;
using System.Xml.Linq;

namespace projPokemon
{
    internal class Alakazam : Pokemons
    {
        public string Name { get; set; }
        public Alakazam()
        {
            Name = "Alakazam";
            Pv = 55;
            Atk = 55;
            Def = 45;
            Vit = 120;
            Xp = 0;
            PvMax = 55;
            Alive = true;
        }
    }
}

