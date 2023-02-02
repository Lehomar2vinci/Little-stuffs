//-Réalisez un pendu, ça va être difficile car il faut gérer ça via des tableaux de caractères. 
//- Pour vous simplifier la vie : Faites un pendu avec un seul mot de démarrage (avec donc un nombre de caractères fixe pour le mot à trouver).
//-Et faites avec un mot qui n'a pas deux fois la même lettre pour vous simplifier la vie également. (par exemple "fatigue").
//- Remplacez les lettres du mot par des _ pour fatigue, ça donne "_ _ _ _ _ _ _"
//- Le joueur a 5 vies, il choisi des lettres pour essayer de deviner le mot
//- Pour chaque tour, vous devez dire au joueur s'il la lettre qu'il a proposé fait partie du mot ou non
//- Si la lettre fait partie du mot, la lettre est affichée dans le mot à la bonne position
//- Si la lettre ne fait pas partie du mot, le joueur perd une vie
#nullable disable

using System;

namespace JeuduPendu // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //initialise le mot à trouver et le nombre de vies
            string motMagique = "mot";
            int vies = 5;
            ////Console.WriteLine("Saisissez un mot magique à devoir trouver");
            ////motMagique = Console.ReadLine();

            //ToCharArray permet de copier les caractères d'une sous chaine spécifiée vers un tableau de caractères.
            char[] tableauMot = motMagique.ToCharArray();
            char[] motMasque = new char[tableauMot.Length];

            for (int i = 0; i < motMasque.Length; i++)
            {
                motMasque[i] = '_';
            }

            Console.WriteLine("            _____________________________________________ \n" +
                              "           /___/____/____/____/____/____/____/____/____/| \n" +
                              "          /___/____/____/____/____/____/____/____/____/ | \n" +
                              "          |_|                ***                    |_| | \n" +
                              "          |_|  Bienvenue dans le jeu du pendu !     |_| / \n" +
                              "          |_|_______________________________________|_|/  \n");

            while (vies > 0)
            {
                Console.WriteLine("Mot à trouver : "
                                    + new string(motMasque) + "\n"
                                    + "Nombres de vies restantes : " + vies + "\n"
                                    + "Proposer une lettre : ");
                char saisie = char.Parse(Console.ReadLine());
                bool estCorrect = false;
                for (int i = 0; i < tableauMot.Length; i++)
                {
                    if (tableauMot[i] == saisie)
                    {
                        motMasque[i] = saisie;
                        estCorrect = true;
                    }
                }
                if (!estCorrect)
                {
                    vies--;
                    Console.WriteLine("la saisie de la lettre '" + saisie + "' est fausse");
                }
                else if (new string(motMasque) == motMagique)
                {
                    Console.WriteLine("Bravo c'est une bonne réponse ! ");
                    break;
                }
            }
            if (vies == 0)
            {
                Console.WriteLine("Désolé, vous n'avez plus de vies. C'est un game over ! ");
            }
        }
    }
}