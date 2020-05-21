
using System.Collections.Generic;
using Infrastructure.Entities;

namespace Infrastructure.DataAccess
{
    public sealed class Context
    {
        public IList<Discipline> Disciplines { get; set; }
    }
}