using Domain;
using System.Collections.Generic;

namespace Application.UseCases
{
    public class SelectStudentAssignmentsUseCase
    {
        private readonly IStudentService _studentService;
        private IStudentService @object;

        public SelectStudentAssignmentsUseCase(IStudentService studentService)
        {
            this._studentService = studentService;
        }

        public IList<IDiscipline> execute()
        {
            Student student = new Student();
            return _studentService.SelectStudentAssignments(student);
        }
    }
}
