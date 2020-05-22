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
        private StudentRepository _studentRepository;

        public DisciplineAssignmentUseCase(
            StudentService studentService,
            StudentRepository studentRepository
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
