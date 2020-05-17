namespace Domain
{
    public class Discipline : IDiscipline
    {
        /// <summary>
        ///     Nome da Disciplina.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Carga horário.
        /// </summary>
        public string Load { get; set; }

        /// <summary>
        ///     Nome do Professor.
        /// </summary>
        public string Teacher { get; set; }

        /// <summary>
        ///     Turma referente a oferta da disciplina.
        /// </summary>
        public IClass Class { get; set; }


    }
}
