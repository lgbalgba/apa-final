using Application.UseCases;
using Domain;
using Moq;
using System.Collections.Generic;
using Xunit;

namespace UnitTests.UseCases
{
    public class SelectStudentAssignmentsUseCaseTests
    {
        private readonly SelectStudentAssignmentsUseCase selectStudentAssignmentsUseCase;
        private readonly Mock<IStudentService> studentService;

        public SelectStudentAssignmentsUseCaseTests()
        {
            studentService = new Mock<IStudentService>();
            selectStudentAssignmentsUseCase = new SelectStudentAssignmentsUseCase(studentService.Object);
        }

        [Fact]
        [Trait(nameof(SelectStudentAssignmentsUseCase.execute), "Sucesso")]
        public void Execute_Sucesso()
        {
            Student student = new Student();
            string name = "d1";
            var result = new List<IDiscipline> { new Discipline() { Name = name } };

            studentService.Setup(a => a.SelectStudentAssignments(It.IsAny<Student>())).Returns(result);
            var execution = selectStudentAssignmentsUseCase.execute();

            Assert.Equal(name, execution[0].Name);
        }
    }
}
