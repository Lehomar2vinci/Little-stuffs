﻿namespace Exercice_Jeu_du_serpent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue dans le jeu du serpent !");

            int nbCases;
            do
            {
                Console.Write("Entrez le nombre de cases du plateau (50, 100 ou 200) : ");
            } while (!int.TryParse(Console.ReadLine(), out nbCases) || (nbCases != 50 && nbCases != 100 && nbCases != 200));

            int nbJoueurs;
            do
            {
                Console.Write("Entrez le nombre de joueurs (entre 2 et 4) : ");
            } while (!int.TryParse(Console.ReadLine(), out nbJoueurs) || nbJoueurs < 2 || nbJoueurs > 4);

            Jeu jeu = new Jeu(nbCases, nbJoueurs);
            jeu.Start();
        }
    }
}



















//////Console.WriteLine("Entrez le nombre de case du plateau (50, 100 oubien 200");
//////int nbCases = int.Parse(Console.ReadLine());
//////while (nbCases != 50 && nbCases != 100 && nbCases != 200) 
//////{
//////    Console.WriteLine("Le nombre de case est invalide, veuillez réessayer !");
//////    Console.WriteLine("Saisir 50,100 ou 200 : ");
//////    nbCases= int.Parse(Console.ReadLine());
//////}

//////Console.WriteLine("Entrez le nombre de joueurs (2 à 4) :");
//////int nbJoueurs = int.Parse(Console.ReadLine());

//////while (nbJoueurs < 2 || nbJoueurs > 4) 
//////{
//////    Console.WriteLine("Le nombre de joueurs est invalide ! Veuillez resaisir le nombre de joueurs de 2 à 4 : ");
//////    nbJoueurs= int.Parse(Console.ReadLine());
//////}