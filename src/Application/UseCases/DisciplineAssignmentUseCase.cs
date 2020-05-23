using Domain;
using Infrastructure.Respositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCases
{
    public class DisciplineAssignmentUseCase
    {
        private StudentService _studentService;
        private IStudentRepository _studentRepository;

        public DisciplineAssignmentUseCase(
            StudentService studentService,
            IStudentRepository studentRepository
            )
        {
            this._studentService = studentService;
            this._studentRepository = studentRepository;
        }

        public void execute()
        {
            Student student = new Student();
            Discipline discipline = new Discipline();
            _studentService.StudentRegisterDiscipline(student, discipline);
            _studentRepository.registerDiscipline(student.Id, discipline);
        }
    }
}
