using Domain;
using Infrastructure.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Respositories
{
    public sealed class StudentRepository : IStudentRepository
    {
        private readonly Context _context;

        public StudentRepository()
        {
            _context = new Context();
        }

        public IList<IStudent> Get()
        {
            return _context.Students
                .Select(f => (IStudent)f)
                .ToList();
        }

        public IStudent GetStudent(int id)
        {
            return _context.Students
                .Where(f => f.Id == id)
                .Select(f => (IStudent)f)
                .FirstOrDefault();
        }

        public void addDiscipline(int id, Discipline discipline)
        {
            IStudent student = GetStudent(id);
            student.RegisterDiscipline(discipline);

        }

        public void registerDiscipline(int id, Discipline discipline)
        {
            IStudent student = GetStudent(id);
            student.RegisterDiscipline(discipline);
        }
    }
}