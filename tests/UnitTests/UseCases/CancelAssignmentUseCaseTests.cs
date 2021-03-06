﻿using Domain;
using System.Collections.Generic;
using Xunit;

namespace UnitTests.UseCases
{
    public class CancelAssignmentUseCaseTests
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

            student.RemoveDisciplineAssignment(discipline);

            // Assert
            Assert.True(student.RegisteredDisciplines.Count==0);
        }
    }
}
