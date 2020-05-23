using Domain.Exceptions;
using System.Collections.Generic;

namespace Domain
{
    public class Student : IStudent
    {
        public Student()
        {
            RegisteredDisciplines = new List<IDiscipline>();
            SelectedDisciplines = new List<IDiscipline>();
        }
        /// <summary>
        ///     Id do Aluno.
        /// </summary>
        public int Id { get; set; }

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
        public List<IDiscipline> RegisteredDisciplines { get; set; }

        /// <summary>
        ///     Matérias com interesse de matricular.
        /// </summary>
        public List<IDiscipline> SelectedDisciplines { get; set; }

        public void SelectDiscipline(Discipline discipline)
        {
            SelectedDisciplines.Add(discipline);
        }

        public void RegisterDiscipline(Discipline discipline)
        {
            if(SelectedDisciplines.Contains(discipline))
            {
                SelectedDisciplines.Remove(discipline);
                RegisteredDisciplines.Add(discipline);
            }
            else
            {
                throw new AssignmentNotValidException(discipline.Name);
            }
        }

        public void RemoveDisciplineAssignment(Discipline discipline)
        {
            if (RegisteredDisciplines.Contains(discipline))
            {
                RegisteredDisciplines.Remove(discipline);
            }
            else
            {
                throw new AssignmentNotFoundException(discipline.Name);
            }
        }

        public IList<IDiscipline> SelectStudentAssignments()
        {
            return RegisteredDisciplines;
        }
    }
}
