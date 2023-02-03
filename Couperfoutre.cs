using System;
using System.Net.Security;

namespace Concat // lol
{
    internal class Program
    {
        //fait avec amour par Nathan Chambrette
        static void Main(string[] args)
        {
            string name1;
            string name2;

             while (continueCondition2)
                    { 
                Console.WriteLine("Bonjour! \n"
                     + "Veuillez saisir un nom avec son article (ex : une chaussette ou un briquet )");
                name1 =Console.ReadLine();

                Console.WriteLine(" \n"
                                + "Saisis un 2° nom avec son article (ex : Une poelle ou une truelle ) : ");
                name2 = Console.ReadLine();

                Console.WriteLine("Le résultat est : \n" 
                                  "\n"
                                 +"Couper " 
                                 + name1 
                                 + " foutre sur " 
                                 + name2
                                 + "");
                Console.WriteLine("=================================\n"
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
