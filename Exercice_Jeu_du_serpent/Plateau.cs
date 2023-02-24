using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Jeu_du_serpent
{
    class Plateau
    {
        private int[] cases;
        private const int caseVide = 0;
        private const int caseBonus = 1;
        private const int caseMalus = 2;
        private const int caseFinale = 3;

        public int Taille { get; }

        public Plateau(int taille)
        {
            Taille = taille;
            cases = new int[Taille + 1];


            //init des cases bonus et pièges
            // Décomposer en méthodes ici également
            // Utiliser la classe De
            Random rand = new Random();
            // Faire qu'une seule variable nbCasesSpeciales
            int nbCasesBonus = taille / 10;
            int nbCasesPiege = taille / 10;

            for (int i = 0; i< nbCasesBonus; i++) 
            {
                int position = rand.Next(1, taille + 1);
                if (cases[position] != caseVide) 
                {
                    i--;
                }
                else
                {
                    cases[position] = caseBonus;
                }
            }
            for (int i = 0; i < nbCasesPiege; i++)
            {
                int position = rand.Next(1, taille + 1);
                if (cases[position] != caseVide)
                {
                    i--;
                }
                else
                {
                    cases[position] = caseMalus;
                }
            }

            //initialisation de la case finale
            cases[taille] = caseFinale;
        }
    
        public int GetCase (int position)
        {
            if (position < 1 || position > Taille)
            {
                return 0;
            }

            return cases[position]; 
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
