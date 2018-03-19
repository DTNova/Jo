namespace Bibliotheque
{
    /// <summary>
    /// Fiche sous forme de lettre plutôt que couleur
    /// </summary>
    public class BouleLettre : IBoule
    {
        public int Id { get; set; }
        public char Lettre { get; set; }

        /// <summary>
        /// Instanciation d'une boule décrite par une lettre
        /// </summary>
        /// <param name="lettre">La lettre qui décrit la boule</param>
        public BouleLettre(char lettre)
        {
            this.Lettre = lettre;
        }

        /// <summary>
        /// Instanciation d'une boule décrite par une lettre
        /// </summary>
        /// <param name="lettre">La lettre qui décrit la boule</param>
        /// <param name="id">id de la boule</param>
        public BouleLettre(char lettre, int id) : this(lettre)
        {
            this.Id = id;
        }

        public char Description()
        {
            return this.Lettre;
        }

        /// <summary>Retourne une chaîne qui représente l'objet actuel.</summary>
        /// <returns>Chaîne qui représente l'objet actuel.</returns>
        public override string ToString()
        {
            return this.Description().ToString();
        }
    }
}