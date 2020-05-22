
using Infrastructure.Entities;
using System.Collections.Generic;

namespace Infrastructure.DataAccess
{
    public sealed class Context
    {
        private IList<Discipline> _disciplines = new List<Discipline>{
            new Discipline("Cálculo	I,", "", ""),
            new Discipline("Cálculo	II,", "", ""),
            new Discipline("Algoritmo e	Estrutura de Dados", "", ""),
        };

        private IList<Student> _students = new List<Student>();

        public IList<Discipline> Disciplines => _disciplines;

        public IList<Student> Students => _students;
    }
}