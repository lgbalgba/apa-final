using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public interface IStudentRepository
    {
        void registerDiscipline(int id, Discipline discipline);
    }
}
