

using projPokemon;

Console.WriteLine("Choissiez un starter  pour débuter \n");
Console.WriteLine("-1- Salamèche");
Console.WriteLine("-2- Carapuce");
Console.WriteLine("-3- Bulbizarre");
var Starter = Console.ReadLine();


switch (Starter)
{
    case "1":
        Salameche salameche = new Salameche();
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("     Vous avez choisi Salamèche ! \n");
        Console.WriteLine("----------------------------------------------------");
        break;

    case "2":
        Carapuce carapuce = new Carapuce();
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("     Vous avez choisi Carapuce ! \n");
        Console.WriteLine("----------------------------------------------------");
        break;

    case "3":
        Bulbizar bulbizar = new Bulbizar();
        Console.WriteLine("----------------------------------------------------");
        Console.WriteLine("     Vous avez choisi bulbizar ! \n");
        Console.WriteLine("----------------------------------------------------");
        break;

    default:
        Console.WriteLine("Choissiez un starter  pour débuter \n");
        break;

}

    /* initialiser le jeu */

bool game = true;
while (game)
{
    Console.WriteLine("Vous avez le choix entre :");
    Console.WriteLine("-1- Combattre");
    Console.WriteLine("-2- Soigner");
    Console.WriteLine("-3- Statistiques");
    Console.WriteLine("-4- Quitter");
    Console.WriteLine(" ");
    var ChoiceTwo = Console.ReadLine();


    /* Choix d'un pokemon sauvage aléatoire */

    var random = new Random();
    var list = new List<object> { new Roucoule(), new Alakazam(), new Miaouss() };
    int index = random.Next(list.Count);
    var randomizerChoice = list[index];


    switch (ChoiceTwo)
    {

        /* La section "Combattre" n'est PAS fonctionnelle, 
         * cependant je laisse quand même ci-dessous quelques exemples de code que j'aurai inséré en cas de bon fonctionnement,
         * afin de montrer que j'aurai sû le faire. */

        /* Pour le heal en combat, exemple : new Charmander().HealPotion(); 
        Pour recevoir des dmg en combat, exemple : new Charmander().ReceiveDmg(new Pikachu().Atk);
        Pour l'xp en combat, exemple : new Charmander().GetExperiences(); */


        /* Choix pour lancer un combat */

        case "1":

            bool fight = true;
            while (fight)
            {
                Console.WriteLine("Vous envoyez votre Pokemon au combat !");
                break;
            } break;


        /* Choix pour soigner le starter hors combat */

        case "2":
            if (Starter == "Salamèche" && new Salameche().Pv < new Salameche().PvMax)
            {
                new Salameche().Pv = new Salameche().PvMax;
                Console.WriteLine("Votre Pokémon a toute sa vie !");


            }
            else if (Starter == "Carapuce" && new Carapuce().Pv < new Carapuce().PvMax)
            {
                new Carapuce().Pv = new Carapuce().PvMax;
                Console.WriteLine("Votre Pokémon a toute sa vie !");

            }
            else if (Starter == "Bulbizarre" && new Bulbizar().Pv < new Bulbizar().PvMax)
            {
                new Bulbizar().Pv = new Bulbizar().PvMax;
                Console.WriteLine("Votre Pokémon a toute sa vie !");

            }
            else
            {
                Console.WriteLine("Il n'est pas nécessaire de soigner votre Pokémon !");
                Console.WriteLine(" ");
                break;
            }
            break;
    


        /* Choix pour voir les stats */

        case "3":
            if (Starter == "1")
            {
                Console.WriteLine("PV Max : " + new Salameche().PvMax);
                Console.WriteLine("PV Actuels : " + new Salameche().Pv);
                Console.WriteLine("Attaque : " + new Salameche().Atk);
                Console.WriteLine("Défense : " + new Salameche().Def);
                Console.WriteLine("Vitesse : " + new Salameche().Vit);
                Console.WriteLine(" ");

            }
            else if (Starter == "2")
            {
                Console.WriteLine("PV Max : " + new Carapuce().PvMax);
                Console.WriteLine("PV Actuels : " + new Carapuce().Pv);
                Console.WriteLine("Attaque : " + new Carapuce().Atk);
                Console.WriteLine("Défense : " + new Carapuce().Def);
                Console.WriteLine("Vitesse : " + new Carapuce().Vit);
                Console.WriteLine(" ");

            }
            else if (Starter == "3")
            {
                Console.WriteLine("PV Max : " + new Bulbizar().PvMax);
                Console.WriteLine("PV Actuels : " + new Bulbizar().Pv);
                Console.WriteLine("Attaque : " + new Bulbizar().Atk);
                Console.WriteLine("Défense : " + new Bulbizar().Def);
                Console.WriteLine("Vitesse : " + new Bulbizar().Vit);
                Console.WriteLine(" ");
            }
            else
            {
                break;
            }
            break;



        /* Choix pour quitter l'interface */

        case "4":
            Console.WriteLine("Vous décidez de quitter la partie : Sauvegarde en cours ... Merci d'avoir joué !");
            
            break;



        /* Default pour quitter l'interface si mauvaise saisie */

        default:
            Console.WriteLine("Vous n'avez pas sélectionner une action à effectuer, la partie se termine ...");
            Console.WriteLine(" ");
            break;
    }


    Console.WriteLine("Voulez-vous continuer la partie (Oui ou Non) ?");
    Console.WriteLine(" ");
    var ChoiceThree = Console.ReadLine();

    switch (ChoiceThree)
    {

        /* Choix pour continuer et revenir à l'interface des actions */

        case "Oui":
            Console.WriteLine("Dans ce cas, retour à l'interface des actions.");
            Console.WriteLine(" ");
            Console.WriteLine("----------------------------------------------------------------------------------------------");
            Console.WriteLine(" ");
            break;

        /* Choix pour arrêter et quitter le jeu */

        case "Non":
            Console.WriteLine("Le jeu s'arrête ...");
            game = !game;
            break;

        /* Default pour boucler tant que la saisie est incorrecte */

        default:
            Console.WriteLine("Saisie incorrecte !");
            Console.WriteLine(" ");
            break;
    }

}