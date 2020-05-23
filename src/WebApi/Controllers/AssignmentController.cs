using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AssignmentController : ControllerBase
    {
        private Application.UseCases.CancelAssignmentUseCase cancelAssignmentUseCase;
        private Application.UseCases.DisciplineAssignmentUseCase disciplineAssignmentUseCase;
        private Application.UseCases.SelectDisciplineUseCase selectDisciplineUseCase;
        private Application.UseCases.GetAssignmentUseCase getAssignmentUseCase;
        private readonly ILogger<AssignmentController> _logger;

        public AssignmentController(ILogger<AssignmentController> logger)
        {
            _logger = logger;

            cancelAssignmentUseCase = new Application.UseCases.CancelAssignmentUseCase(new Domain.StudentService(), new Infrastructure.Respositories.StudentRepository());
            disciplineAssignmentUseCase = new Application.UseCases.DisciplineAssignmentUseCase(new Domain.StudentService(), new Infrastructure.Respositories.StudentRepository());
            selectDisciplineUseCase = new Application.UseCases.SelectDisciplineUseCase(new Domain.StudentService(), new Infrastructure.Respositories.StudentRepository());
            getAssignmentUseCase = new Application.UseCases.GetAssignmentUseCase(new Domain.StudentService(), new Infrastructure.Respositories.StudentRepository ());
        }

        [HttpPost] 
        public IActionResult Cancel([FromBody]AssignmentRequest request)
        {
            cancelAssignmentUseCase.execute();
            return Ok();
        }       

        [HttpPost]
        public IActionResult Post([FromBody]AssignmentRequest request)
        {
            disciplineAssignmentUseCase.execute();
            return Ok();
        }

        [HttpGet("/student/{studentId}")]
        public IActionResult GetAll(int studentId)
        {
            return Ok(getAssignmentUseCase.execute(studentId));
        }

        [HttpPost]
        public IActionResult SelectDiscipline([FromBody]AssignmentRequest request)
        {
            selectDisciplineUseCase.execute();
            return Ok();
        }

        // [HttpGet]
        // public IEnumerable<WeatherForecast> Get()
        // {
        //     var rng = new Random();
        //     return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //     {
        //         Date = DateTime.Now.AddDays(index),
        //         TemperatureC = rng.Next(-20, 55),
        //         Summary = Summaries[rng.Next(Summaries.Length)]
        //     })
        //     .ToArray();
        // }
    }


        public class AssignmentRequest{
            public int StudentId {get;set;}
            public int DisciplineId {get;set;}
        }

}
