using System;
using System.Collections.Generic;
namespace Domain
{
    public class Student : IStudent
    {
        /// <summary>
        ///     Nome do Aluno.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Idade do Aluno.
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        ///     Matérias com a matrícula efetivada.
        /// </summary>
        public List<ISubject> RegistredSubjects { get; set; }

        /// <summary>
        ///     Matérias com interesse de matricular.
        /// </summary>
        public List<ISubject> SelectedSubjects { get; set; }

    }
}
