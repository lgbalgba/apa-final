using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Infrastructure.Respositories;

namespace Application.UseCases
{
    public class CancelAssignmentUseCase
    {
        private StudentService _studentService;
        private StudentRepository _studentRepository;

        public CancelAssignmentUseCase (
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
            _studentService.StudentRemoveDisciplineAssignment(student, discipline);
            _studentRepository.CancelDiscipline(student.Id, discipline);
        }
    }
}
