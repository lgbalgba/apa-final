using Domain;
using Xunit;

namespace UnitTests.UseCases
{
    public class SelectDisciplineUseCaseTests
    {
        [Fact]
        public void Execute_Sucesso()
        {
            // Arrange
            Class classStudent = new Class() { Name = "Ciencia de dados", Department = "Computacao" };
            Discipline discipline = new Discipline() { Name = "Calculo", Load = "60", Class = classStudent, Teacher = "Alex" };
            Student student = new Student() { Name = "Joao", Age = 20, Id = 1 };

            // Act
            student.SelectDiscipline(discipline);


            // Assert
            Assert.Equal(1, student.SelectedDisciplines.Count);
        }
    }
}
