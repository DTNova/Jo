using System.Collections.Generic;

namespace Bibliotheque
{
    /// <summary>
    /// Cette classe représente le jeux en tenant compte de l'IHM
    /// </summary>
    public class JeuxLettre : Jeux
    {
        /// <summary>
        /// Les boules qui sont disponibles dans le jeu : ce sont des lettres.
        /// </summary>
        private SortedDictionary<char, BouleLettre> _dicoBoules;


        /// <summary>
        /// Constructeur : initialise les paramètres du jeux.
        /// </summary>
        public JeuxLettre(int nbRangees, int nbTrous) : base(nbRangees, nbTrous)
        {
            this.BoulesDuJeux = CreationBoulesLettre();
            this.InitLetterDictionary();
        }


        /// <summary>
        /// Creation des boules utilisées pendant le jeux 
        /// </summary>
        /// <returns></returns>
        private static IBoule[] CreationBoulesLettre()
        {
            int id = 0;
            IBoule[] a =
            {
                new BouleLettre('V', id++), // vert
                new BouleLettre('B', id++), // bleu
                new BouleLettre('R', id++), // rouge
                new BouleLettre('J', id++), // jaune
                new BouleLettre('L', id++), // blanc
                new BouleLettre('N', id++) // noir
            };
            return a;
        }


        /// <summary>
        /// Création d'une combinaison (rangée) à partir d'une chaîne de caractères. Chaque lettre de la chaîne de caractère représente une boule.
        /// </summary>
        /// <param name="str">Chaîne de caractères où chaque lettre représente une boule.</param>
        /// <returns></returns>
        public Combinaison CreateCombinaisonFromString(string str)
        {
            Combinaison combinaison = new Combinaison(str.Length);

            int i = 0;
            foreach (char c in str)
            {
                combinaison.SetBoule(this.GetLettre(c), i);
                i++;
            }

            return combinaison;
        }

        /// <summary>
        /// Recherche un objet BouleLettre à partir de la lettre au format char
        /// </summary>
        /// <param name="l">L'objet BouleLettre si trouvé.</param>
        /// <returns></returns>
        public BouleLettre GetLettre(char l)
        {
            return this._dicoBoules[l];
        }


        /// <summary>
        /// Création d'un dictionnaire pour retrouver plus facilement une lettre.
        /// La clé du dictionnaire est la lettre au format char, la valeur correspondante est l'objet de type BouleLettre
        /// </summary>
        private void InitLetterDictionary()
        {
            this._dicoBoules = new SortedDictionary<char, BouleLettre>();

            for (int i = 0; i < this.NombreDeBoule; i++)
            {
                BouleLettre f = this.BoulesDuJeux[i] as BouleLettre;

                this._dicoBoules.Add(f.Lettre, f);
            }
        }
    }
}