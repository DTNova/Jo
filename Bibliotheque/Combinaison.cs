using System;
using System.Diagnostics;
using System.Text;

namespace Bibliotheque
{
    /// <summary>
    /// La combinaison est l'équivalent d'une rangée
    /// </summary>
    public class Combinaison
    {
        /// <summary>
        /// Nombre de trous dans la combinaison.
        /// </summary>
        private IBoule[] _trous;


        /// <summary>
        /// Instancie une nouvelle combinaison (rangée)
        /// </summary>
        /// <param name="nbTrous">Nombre de trous dans la combinaison</param>
        public Combinaison(int nbTrous)
        {
            this._trous = new IBoule[nbTrous];
        }


        /// <summary>
        /// Positionne une boule à un emplacement de la combinaison
        /// </summary>
        /// <param name="boule">La boule à placer</param>
        /// <param name="pos">La position de la boule</param>
        public void SetBoule(IBoule boule, int pos)
        {
            this._trous[pos] = boule;
        }

        /// <summary>
        /// Donne une représentation de la combinaison sous forme de chaine de caractère
        /// </summary>
        /// <returns></returns>
        public string Description()
        {
            StringBuilder sb = new StringBuilder();
            bool chaineVide = true;

            foreach (IBoule boule in this._trous)
            {
                if (!chaineVide)
                {
                    sb.Append(", ");
                }

                sb.Append(boule);
                chaineVide = false;
            }

            return sb.ToString();
        }

        /// <summary>
        /// Retourne une représentation des données de l'instance sous forme de chaîne de caractères
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Description();
        }


        /// <summary>
        /// Réalise la comparaison entre deux combinaisons.
        /// </summary>
        /// <param name="proposition">proposition de combinaison avec laquelle nous devons faire la comparaison</param>
        /// <returns>Evaluation de la comparaison</returns>
        public ResultatCompare Comparaison(Combinaison proposition)
        {
            ResultatCompare compare = null;
            

            return compare;
        }

        /// <summary>
        /// Retourne le nombre de trous dans la combinaison
        /// </summary>
        public int NbTrous
        {
            get { return this._trous.Length; }
        }
    }
}