using System;
using System.Collections.Generic;

namespace CouperFoutre
{
        class Game
    {
        private NameGenerator nameGenerator = new NameGenerator();
        private UserInput userInput = new UserInput();

        public void Run()
        {
            Console.WriteLine("Bienvenue dans le jeu du couper foutre !");

            bool continueCondition1 = true;
            while (continueCondition1)
            {
                string firstName = nameGenerator.GetRandomFirstName();
                string lastName = nameGenerator.GetRandomLastName();

                Console.WriteLine($"\nCouper\n{firstName} foutre sur {lastName}\n");

                Console.WriteLine("=================================\n" +
                                  "|  Voulez-vous continuer ? (O/N) |\n" +
                                  "=================================\n");

                continueCondition1 = userInput.GetYesNoInput();
            }

            bool continueCondition2 = true;
            while (continueCondition2)
            {
                Console.WriteLine("\nVeuillez saisir un nom avec son article (ex : Un abruti ou Une lampe )");
                string name1 = userInput.GetTextInput();

                Console.WriteLine("\nSaisissez un 2° nom avec son article (ex : Une poelle ou un string ) : ");
                string name2 = userInput.GetTextInput();

                Console.WriteLine($"\nLe résultat est :\n\nCouper {name1} foutre sur {name2}");

                Console.WriteLine("=================================\n" +
                                  "|  Voulez-vous continuer ? (O/N) |\n" +
                                  "=================================\n");

                continueCondition2 = userInput.GetYesNoInput();
            }

            Console.WriteLine("\nC'est la fin du programme. Merci d'avoir joué avec ! Au revoir!\n" +
                              "-----Nathan Chambrette-----");
        }
    }
}