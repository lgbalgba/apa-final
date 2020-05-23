using Domain;
using System.Collections.Generic;
using Xunit;

namespace UnitTests.UseCases
{
    public class DisciplineAssignmentUseCaseTests
    {
        [Fact]
        public void Execute_Sucesso()
        {
            // Arrange
            Class classStudent = new Class() { Name = "Ciencia de dados", Department = "Computacao" };
            Discipline discipline = new Discipline() { Name = "Calculo", Load = "60", Class = classStudent, Teacher = "Alex" };
            List<IDiscipline> selected = new List<IDiscipline> { discipline };
            Student student = new Student() { Name = "Joao", Age = 20, Id = 1, SelectedDisciplines = selected};
            

            // Act

            student.RegisterDiscipline(discipline);

            // Assert
            bool RegistredAndRemovedFromSelected = student.RegisteredDisciplines.Count == 1 && student.SelectedDisciplines.Count == 0;
            Assert.True(RegistredAndRemovedFromSelected);
        }
    }
}
