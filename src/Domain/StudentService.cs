using System.Collections.Generic;

namespace Domain
{
    public class StudentService : IStudentService
    {
        public void StudentRegisterDiscipline(Student student, Discipline discipline)
        {
            student.RegisterDiscipline(discipline);
        }

        public void StudentRemoveDisciplineAssignment(Student student, Discipline discipline)
        {
            student.RemoveDisciplineAssignment(discipline);
        }

        public void StudentSelectDiscipline(Student student, Discipline discipline)
        {
            student.SelectDiscipline(discipline);
        }

        public IList<IDiscipline> GetDisicplines(Student student)
        {
            return null;
        }
    }
}
