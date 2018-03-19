using System.Collections.Generic;

namespace Bibliotheque
{
    internal class ListeFicheToArray
    {
        /// <summary>
        /// Convertie une liste de fiches en tableau. Chaque fiche possède un identifiant défini séquentiellement.
        /// </summary>
        /// <param name="fichesList"></param>
        /// <returns></returns>
        public static IBoule[] ConvertListeToArray(List<IBoule> fichesList)
        {
            IBoule[] fichesArray;

            fichesArray = ListToArray(fichesList);
            InitIds(fichesArray);

            return fichesArray;
        }

        /// <summary>
        /// Affectation séquentielle des identifiants pour chacune des fiches
        /// </summary>
        private static void InitIds(IBoule[] fiches)
        {

            for (int i = 0; i < fiches.Length; i++)
            {
                fiches[i].Id = i;
            }
        }

        /// <summary>
        /// Convertion de la liste en tableau
        /// </summary>
        /// <param name="fiches"></param>
        /// <returns></returns>
        private static IBoule[] ListToArray(List<IBoule> fiches)
        {
            return fiches.ToArray();
        }
    }
}