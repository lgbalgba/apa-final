
using System.Collections.Generic;
using Infrastructure.Entities;

namespace Infrastructure.DataAccess
{
    public sealed class Context
    {
        private IList<Discipline> _disciplines = new List<Discipline>{
            new Discipline("Cálculo	I,", "", ""),
            new Discipline("Cálculo	II,", "", ""),
            new Discipline("Algoritmo e	Estrutura de Dados", "", ""),
        };

        public IList<Discipline> Disciplines => _disciplines;
    }
}