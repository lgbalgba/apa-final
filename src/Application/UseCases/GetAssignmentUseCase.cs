using System;
using System.Collections.Generic;
using System.Text;
using Domain;
using Infrastructure.Respositories;

namespace Application.UseCases
{
    public class GetAssignmentUseCase
    {
        private StudentService _studentService;
        private StudentRepository _studentRepository;

        public GetAssignmentUseCase(
            StudentService studentService,
            StudentRepository studentRepository
            )
        {
            this._studentService = studentService;
            this._studentRepository = studentRepository;
        }
        
        public IList<IDiscipline> execute(int studentId)
        {
            return null;

        }
    }
}
