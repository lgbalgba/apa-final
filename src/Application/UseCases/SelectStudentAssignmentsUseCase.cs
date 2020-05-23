using Domain;

namespace Application.UseCases
{
    public class SelectStudentAssignmentsUseCase
    {
        private readonly StudentService _studentService;
        public SelectStudentAssignmentsUseCase(StudentService studentService)
        {
            this._studentService = studentService;
        }

        public void execute()
        {
            Student student = new Student();
            _studentService.SelectStudentAssignments(student);
        }
    }
}
