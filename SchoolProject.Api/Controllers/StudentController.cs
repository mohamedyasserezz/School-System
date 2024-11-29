using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolProject.Core.Features.Students.Queries.Models;

namespace SchoolProject.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController(IMediator mediator) : ControllerBase
    {
        private readonly IMediator _mediator = mediator;

        
        [HttpGet]
        public async Task<IActionResult> GetStudents()
        {
            var response = await _mediator.Send(new GetAllStudentQuery());
            return Ok(response);
        }
    }
}
