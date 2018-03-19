namespace Bibliotheque
{
    /// <summary>
    /// Résultat de la comparaison de deux combinaisons (rangée)
    /// </summary>
    /// 
    // TODO : renommer cette classe "EvaluationProposition"
    public class ResultatCompare
    {
        public int NbFicheBlanche { get; set; }
        public int NbFicheNoir { get; set; }

        public ResultatCompare()
        {
            this.NbFicheBlanche = 0;
            this.NbFicheNoir = 0;
        }
    }
}