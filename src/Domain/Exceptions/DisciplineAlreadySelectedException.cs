using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Exceptions
{
    public class DisciplineAlreadySelectedException : Exception
    {
        public DisciplineAlreadySelectedException() { }
        public DisciplineAlreadySelectedException(string disciplineName)
        : base(String.Format("Student already selected discipline name: {0}", disciplineName))
        {

        }
    }
}
