using System;
using System.ComponentModel;
using System.Net.Security;
using System.Windows.Markup;

namespace CouperFoutre // lol
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //metre le contenu d'un dictionnaire


            string name1;
            string name2;
            bool continueCondition1 = true;
            bool continueCondition2 = true;
            // liste de nom1

            while (continueCondition1)
            {

                Console.WriteLine("Bienvenu dans ");

                // liste de nom1

                List<string> nameListOne = new List<string>()
                { "un colibri","des arbres","macron","une orange","une serviette","du chocolat","Hervé"};

                // liste de nom2

                List<string> nameListTwo = new List<string>()
                {"une louche","un enfant","une chaleur etouffante","une bananer","du riz" };

                //création du random

                Random rand = new Random();
                int randomFirstNameIndex = rand.Next(nameListOne.Count);
                int randomLastNameIndex = rand.Next(nameListTwo.Count);

                Console.WriteLine( " \n"
                                  + "Couper \n"
                                  + nameListOne[randomFirstNameIndex], "\n"
                                  + "\n"
                                  + " foutre sur \n"
                                  + nameListTwo[randomLastNameIndex], "\n");
            
        


            Console.WriteLine(     "=================================\n"
                                 + "|  Voulez-vous continuer ? (O/N) |\n"
                                 + "=================================\n");
                string reponse1 = Console.ReadLine();
                continueCondition1 = (reponse1.ToUpper() == "O");
            }



            //début du jeu 

            while (continueCondition2)
                    { 
                Console.WriteLine("Bonjour! \n"
                                + "Veuillez saisir un nom avec son article (ex : Un abruti ou Une lampe )");
                name1 = Console.ReadLine();

                Console.WriteLine(" \n"
                                + "Saisis un 2° nom avec son article (ex : Une poelle ou un string ) : ");
                name2 = Console.ReadLine();

                Console.WriteLine("Le résultat est : \n"
                                + "\n"
                                + "Couper "
                                + name1
                                + " foutre sur "
                                + name2
                                + "");

                Console.WriteLine(" =================================\n"
                                 + "|  Voulez-vous continuer ? (O/N) |\n"
                                 + "=================================\n");
                string reponse2 = Console.ReadLine();
                continueCondition2 = (reponse2.ToUpper() == "O");
            }

            Console.WriteLine(" \n"
                                + "C'est la fin du programme. merci d'avoir joué avec ! Au revoir! ");
        

        }
    }
}
