using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Exceptions
{
    public class AssignmentNotValidException : Exception
    {
        public AssignmentNotValidException() { }
        public AssignmentNotValidException(string disciplineName)
        : base(String.Format("There isn't a discipline selected with this name: {0}", disciplineName))
        {

        }
    }
}
