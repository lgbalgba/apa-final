using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Exceptions
{
    public class AssignmentNotFoundException : Exception
    {
        public AssignmentNotFoundException() { }
        public AssignmentNotFoundException(string disciplineName)
        : base(String.Format("There isn't an assignment of this discipline to delete: {0}", disciplineName))
        {

        }
    }
}
