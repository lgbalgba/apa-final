using System.Collections.Generic;

namespace Domain
{
    public interface IStudent
    {
        void SelectDiscipline(Discipline discipline);

        void RegisterDiscipline(Discipline discipline);

        void RemoveDisciplineAssignment(Discipline discipline);

        IList<IDiscipline> SelectStudentAssignments();
    }
}
