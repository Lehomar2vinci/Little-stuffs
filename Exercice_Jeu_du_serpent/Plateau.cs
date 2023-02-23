using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Jeu_du_serpent
{
    class Plateau
    {
        private int[] cases;

        public int Taille { get; }

        public Plateau(int taille)
        {
            Taille = taille;
            cases = new int[Taille + 1];


            //init des cases bonus et pièges
            Random rand = new Random();
            int nbCasesBonus = (int)(taille * 0.1);
            int nbCasesPiege = (int)(taille * 0.1);
            for (int i = 0; i< nbCasesBonus; i++) 
            {
                int position = rand.Next(1, taille + 1);
                if (cases[position] != 0) 
                {
                    i--;
                }
                else
                {
                    cases[position] = 1;
                }
            }
        for (int i = 0; i < nbCasesPiege; i++)
            {
                int position = rand.Next(1, taille + 1);
                if (cases[position] != 0)
                {
                    i--;
                }
                else
                {
                    cases[position] = 2;
                }
            }

            //initialisation de la case finale
            cases[taille] = 3;
        }
    
        public int GetCase (int position)
        {
            if (position < 1)
            {
                return 0;
            }
            else if (position > Taille) 
            {
                return 0;
            }
            else 
            { 
                return cases[position]; 
            }  
        }

        public int CalculerNouvellePosition (int position, int de)
        {
            int nouvellePosition = position + de;
            if (nouvellePosition > Taille)
            {
                nouvellePosition = Taille - (nouvellePosition - Taille);
            }
            return nouvellePosition;
        }
    
    
    }
}
