using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_Jeu_du_serpent
{
    public class Joueur
    {
        public string Nom { get; }
        public int Position { get; set; }
        public Joueur (string nom) 
        { 
            Nom= nom;
            Position = 1;
        }
    }
}
