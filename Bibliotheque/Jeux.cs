namespace Bibliotheque
{
    /// <summary>
    /// Classe mère pour les jeux. Cette classe représente les paramètres du jeux sans tenir compte de l'IHM
    /// </summary>
    public class Jeux
    {
        /// <summary>
        /// Les boules qui sont disponibles dans le jeu : ce sont des lettres.
        /// </summary>
        protected IBoule[] BoulesDuJeux { get; set; }

        /// <summary>
        /// Nombre de rangées dans le jeux (correspond au nombre d'essais)
        /// </summary>
        public int NombreDeRangees { get; protected set; }

        /// <summary>
        /// Nombre de trous dans une rangée
        /// </summary>
        public int NombreDeTrous { get; protected set; }

        /// <summary>
        /// La combinaison secrete que le joueur doit trouver
        /// </summary>
        public Combinaison Secret { set; private get; }

        /// <summary>
        /// Nombre d'essai restant
        /// </summary>
        private int _nbEssaiRestant;
        public int NbEssaiRestant {
            get { return this._nbEssaiRestant; }
            private set { this._nbEssaiRestant = value; }
        }


        /*******************************************
         *
         * CONSTRUCTEURS
         *
         *******************************************/


        protected Jeux(int nbRangees, int nbTrous)
        {
            this.NombreDeRangees = nbRangees;
            this.NombreDeTrous = nbTrous;
        }

        protected Jeux(int nbRangees, int nbTrous, Combinaison secret) : this(nbRangees, nbTrous)
        {
            this.Secret = secret;

        }


        /*******************************************
         *
         * METHODES
         *
         *******************************************/

        /// <summary>
        /// Nombre de boules qui sont disponibles dans le jeu
        /// </summary>
        public int NombreDeBoule
        {
            get { return this.BoulesDuJeux.Length; }
        }

        /// <summary>
        /// Retoune une des boules disponibles en fonction de sa position
        /// </summary>
        /// <param name="position">Position de la boule</param>
        /// <returns></returns>
        public IBoule GetBoule(int position)
        {
            return this.BoulesDuJeux[position];
        }


        /// <summary>
        /// Retourne un combinaison choisie aléatoirement
        /// </summary>
        /// <returns></returns>
        public Combinaison CombinaisonAleatoire()
        {
            int nombreLettreDisponible = this.NombreDeBoule;
            Combinaison combinaison = new Combinaison(this.NombreDeTrous);

            for (int i = 0; i < this.NombreDeTrous; i++)
            {
                int n = RandomNumber.Between(0, nombreLettreDisponible - 1);
                combinaison.SetBoule(this.BoulesDuJeux[n], i);
            }

            return combinaison;

        }

        /// <summary>
        /// Compare une proposition du joueur avec la composition secrète.
        /// </summary>
        /// <param name="proposition">Proposition du joueur</param>
        /// <returns></returns>
        public ResultatCompare ComparePropositionAvecSolution(Combinaison proposition)
        {
            return this.Secret.Comparaison(proposition);

        }
    }
}