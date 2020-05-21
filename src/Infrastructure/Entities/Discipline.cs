
namespace Infrastructure.Entities
{
    public sealed class Discipline : Domain.Discipline
    {
        public Discipline()
        {
            
        }

        public Discipline(string name, string load, string teacher)
        {
            Name = name;
            Load = load;
            Teacher = teacher;
        }
    }
}