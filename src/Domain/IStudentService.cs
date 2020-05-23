using System.Collections.Generic;

namespace Domain
{
    public interface IStudentService
    {
        void StudentSelectDiscipline(Student student, Discipline discipline);

        void StudentRegisterDiscipline(Student student, Discipline discipline);

        void StudentRemoveDisciplineAssignment(Student student, Discipline discipline);

        public IList<IDiscipline> SelectStudentAssignments(Student student);
    }
}
