using Domain;
using Infrastructure.Respositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.UseCases
{
    public class SelectDisciplineUseCase
    {
        private readonly StudentRepository _studentRepository;
        private readonly StudentService _studentService;
        public SelectDisciplineUseCase(
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
            _studentService.StudentSelectDiscipline(student, discipline);
            _studentRepository.addDiscipline(student.Id, discipline);
        }
    }
}
