using Domain;
using System.Collections.Generic;
using Xunit;

namespace UnitTests.UseCases
{
    public class GetAssignmentUseCaseTests
    {
        [Fact]
        public void Execute_Sucesso()
        {
            // Arrange
            Class classStudent = new Class() { Name = "Ciencia de dados", Department = "Computacao" };
            Discipline discipline = new Discipline() { Name = "Calculo", Load = "60", Class = classStudent, Teacher = "Alex" };
            List<IDiscipline> registered = new List<IDiscipline> { discipline };
            Student student = new Student() { Name = "Joao", Age = 20, Id = 1, RegisteredDisciplines = registered };

            // Act

            IList<IDiscipline> assignments = student.SelectStudentAssignments();

            // Assert
            Assert.True(assignments.Count > 0);
        }
    }
}
