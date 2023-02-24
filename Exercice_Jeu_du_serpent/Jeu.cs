namespace Exercice_Jeu_du_serpent
{
    public class Jeu
    {

        private Plateau plateau;
        private Joueur[] joueurs;
        private int nbJoueurs;

        public Jeu()
        {
            // Faire une méthode AffichageJeu
            Console.WriteLine("Bienvenue dans le jeu du serpent !");

            Console.WriteLine("Appuyez sur une touche pour démarrer.");
            Console.ReadLine();
            Console.Beep(523, 300);
            Console.Beep(659, 300);
            Console.Beep(783, 300);


            // Faire une méthode InitialisationJeu
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

            plateau = new Plateau(nbCases);
            this.nbJoueurs = nbJoueurs;
            joueurs = new Joueur[nbJoueurs];
            for (int i = 0; i < nbJoueurs; i++)
            {
                Console.Write("Entrez le nom du joueur " + (i + 1) + " : ");
                string nom = Console.ReadLine();
                joueurs[i] = new Joueur(nom);
            }
        }
        public void Start()
        {
            int tour = 1;
            bool partieTerminee = false;
            while (!partieTerminee)
            {
                Console.WriteLine("Tour " + tour);

                for (int i = 0; i < nbJoueurs; i++)
                {
                    Joueur joueurCourant = joueurs[i];

                    Console.WriteLine(joueurCourant.Nom + " joue.");
                    int de = LancerDe();
                    Console.WriteLine(joueurCourant.Nom + " lance le dé et obtient : " + de);
                    int nouvellePosition = plateau.CalculerNouvellePosition(joueurCourant.Position, de);
                    joueurCourant.Position = nouvellePosition;
                    Console.WriteLine(joueurCourant.Nom + " avance en " + nouvellePosition);

                    // Le bout de code ci-dessous devrait se trouver dans la classe Plateau et retourner un booléen pour partieTerminee
                    int effetCase = plateau.GetCase(nouvellePosition);
                    switch (effetCase)
                    {
                        // Pour les "case" du switch, utiliser les constantes de Plateau
                        case 0:
                            Console.WriteLine("Case neutre.");
                            break;
                        case 1:
                            Console.WriteLine("Case bonus !");
                            joueurCourant.Position += 2;
                            Console.WriteLine(joueurCourant.Nom + " avance de 2 cases et se retrouve en " + joueurCourant.Position);
                            break;
                        case 2:
                            Console.WriteLine("Case piège !");
                            joueurCourant.Position -= 3;
                            if (joueurCourant.Position < 1)
                            {
                                joueurCourant.Position = plateau.Taille / 2;
                                Console.WriteLine(joueurCourant.Nom + " est tombé dans le piège et retourne à la case " + joueurCourant.Position);
                            }
                            else
                            {
                                Console.WriteLine(joueurCourant.Nom + " recule de 3 cases et se retrouve en " + joueurCourant.Position);
                            }
                            break;
                        case 3:
                            Console.WriteLine("Case finale !");
                            partieTerminee = true;
                            Console.WriteLine(joueurCourant.Nom + " est le vainqueur !");
                            break;
                    }
                    // Fin bout de code à mettre dans Plateau


                    Console.WriteLine();
                    if (partieTerminee)
                    {
                        break;
                    }
                    tour++;
                    Thread.Sleep(600);
                }
                Console.WriteLine("Fin du tour !");
            }

            // Faire une classe De pour rendre son utilisation modulaire dans le futur (faire un dé 12 par exemple)
            int LancerDe()
            {
                Random rand = new Random();
                return rand.Next(1, 7);
            }
        }
    }
}


//////////private int nbCases;
//////////private List<Joueur> joueurs;
//////////private int[] plateau;
//////////private int caseDepart = 1;
//////////private int caseArrivee;
//////////private Random random;

//////////public Jeu(int nbCases, int nbJoueurs) 
//////////{
//////////    this.nbCases = nbCases;
//////////    this.joueurs = new List<Joueur>();

//////////    for (int i = 1; i <= nbJoueurs; i++) 
//////////    {
//////////        joueurs.Add(new Joueur("Joueur " + i));
//////////    }
//////////    this.plateau= new int[nbCases];
//////////    for (int i = 0; i < nbCases; i++) 
//////////    {
//////////        plateau[i] = i + 1;
//////////    }

//////////    this.caseArrivee = nbCases;
//////////    this.random = new Random();
//////////}

//////////public void Start()
//////////{
//////////    bool partieTerminee = false;
//////////    int tourJoueur = 0;

//////////    //boucle partie terminée

//////////    while (!partieTerminee) 
//////////    {
//////////        joueurs joueurCourant = joueurs[tourJoueur];
//////////        int de = random.Next(1, 7);
//////////        Console.WriteLine(joueurCourant.Nom + "a réalisé un" + de);
//////////        int nouvelleCase = joueurCourant.Position + de;

//////////        if (nouvelleCase > nbCases)
//////////        {
//////////            nouvelleCase = nbCases - (nouvelleCase - nbCases);
//////////        }

//////////        if (nouvelleCase == caseArrivee) 
//////////        {
//////////            joueurCourant.Position = nouvelleCase;
//////////            Console.WriteLine(joueurCourant.Nom + " a gagné ! ");
//////////            partieTerminee = true;
//////////        } 
//////////        else 
//////////        {
//////////            joueurCourant.Position = nouvelleCase;
//////////            int effet = plateau[nouvelleCase - 1];

//////////            switch (effet) 
//////////            {
//////////                case 0:
//////////                    Console.WriteLine("C'est une case neutre, il ne se passe rien.");
//////////                    break;
//////////                case 1:
//////////                    Console.WriteLine("Case cadeau bonux !");
//////////                    joueurCourant.Position =+ random.Next(1, 4);
//////////                    break;
//////////                case 2:
//////////                    Console.WriteLine("Case pièèèèèège");
//////////                    joueurCourant.Position -= random.Next(1, 4);
//////////                    if (joueurCourant.Position < caseDepart)
//////////                    {
//////////                        joueurCourant.Position = caseDepart;
//////////                    }
//////////                    break;
//////////            }
//////////            tourJoueur = (tourJoueur + 1) % joueurs.Count;
//////////        }

