namespace Domain
{
    public interface IDiscipline
    {
        /// <summary>
        ///     Nome da Disciplina.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        ///     Carga horário.
        /// </summary>
        string Load { get; set; }

        /// <summary>
        ///     Nome do Professor.
        /// </summary>
        string Teacher { get; set; }

        /// <summary>
        ///     Turma referente a oferta da disciplina.
        /// </summary>
        IClass Class { get; set; }
    }
}
