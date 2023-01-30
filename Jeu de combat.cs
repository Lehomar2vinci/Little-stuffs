using System;
using System.Runtime.CompilerServices;

namespace MyApp
{ internal class Program
    {
        static void Main(string[] args)
        {


        //initialisation des variables 
            string player1Name;
            string player2Name;
            int player1Choice;
            int player2Choice;
            int player1HP;
            int player2HP;
            int player1Attack;
            int player2Attack;
            bool gameOver = false;
            Random rnd = new Random();

        Console.WriteLine("Bonjour joueur 1 ! \n"
                        + "Quel est ton nom ?");
            player1Name = Console.ReadLine();
        Console.WriteLine("Le premier joueur s'appelle donc "
                         + player1Name
                         + "\n");


            Console.WriteLine("Bonjour joueur 2 ! \n"
                    + "Quel est ton petit nom ?");
            player2Name = Console.ReadLine();

            Console.WriteLine("Le joueur 2 s'appelle donc "
                             + player2Name
                             + "."
                             + "\n"
                             + "\n");

            Console.WriteLine(player1Name
                             + " Choisissez votre classe : \n"
                             + "- Pour choisir le Guerrier saisissez 1 \n"
                             + "- Pour choisir le Mage saisissez 2"
                             + "\n");
            player1Choice = int.Parse(Console.ReadLine());

            if (player1Choice == 1)
            {

                Console.WriteLine("Vous avez choisi la classe Guerrier très cher "
                    + player1Name);
                ;
            }
            else if (player1Choice == 2)
            {
                Console.WriteLine("Vous avez choisi la classe Mage, " 
                    + player1Name
                    + " ."
                    + "\n");
            }


            Console.WriteLine( player2Name+ " ,\n "
                    + "- Pour choisir le Guerrier saisissez 1 \n"
                    + "- Pour choisir le Mage saisissez 2");
            player2Choice = int.Parse(Console.ReadLine());

            if (player2Choice == 1)
            {

                Console.WriteLine(player2Name +", vous avez choisi la classe Guerrier");
                ;
            }
            else if (player2Choice == 2)
            {
                Console.WriteLine(player2Name + ", vous avez choisi la classe Mage !");
            }

            if (player1Choice == 1)
            {
                player1HP = 150;
            }
            else
            {
                player1HP = 120;
            }

            if (player2Choice == 1)
            {
                player2HP = 150;
            }
            else
            {
                player2HP = 120;
            }

            while (!gameOver)
            {
                player1Attack = rnd.Next(15, 19);
                player2HP -= player1Attack;
                Console.WriteLine(player1Name 
                    + " attaque et inflige "
                    + player1Attack
                    + " dégâts. "
                    + player2Name
                    +" a "
                    + player2HP
                    + " Points de Vie restants !.");

                if (player2HP <= 0)
                {
                    Console.WriteLine(player1Name
                    + " a gagné et a vaincu "
                    + player2Name
                    + " !!!!");
                    gameOver = true;
                    break;
                }

                player2Attack = rnd.Next(21, 25);
                player1HP -= player2Attack;
                Console.WriteLine( player2Name
                    +" attaque et inflige "
                    + player2Attack
                    + " dégâts."
                    + player1Name
                    + "a "
                    + player1HP
                    + " PV restants.");

                if (player1HP <= 0)
                {
                    Console.WriteLine ( player2Name
                    + " a triomphé sur l'adversaire "
                    + player1Name);
                    gameOver = true;
                }
            }
        }
    }
}
