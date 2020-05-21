using System.Collections.Generic;
using System.Linq;
using Domain;
using Infrastructure.DataAccess;

namespace Infrastructure.Respositories
{
    public sealed class DisciplineRespository : IDisciplineRepository
    {
        private readonly Context _context;

        public DisciplineRespository()
        {
            _context = new Context();
        }

        public IList<IDiscipline> Get()
        {
            return _context.Disciplines
                .Select(f => (IDiscipline)f)
                .ToList();
        }

        public IDiscipline GetDiscipline(string name)
        {
            return _context.Disciplines
                .Where(f => f.Name == name)
                .Select(f => (IDiscipline)f)
                .FirstOrDefault();
        }
    }
}