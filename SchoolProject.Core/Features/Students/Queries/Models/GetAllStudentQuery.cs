using MediatR;
using SchoolProject.Core.Base;
using SchoolProject.Core.Features.Students.Queries.Results;

namespace SchoolProject.Core.Features.Students.Queries.Models
{
    public class GetAllStudentQuery : IRequest<Response<List<GetAllStudentResponse>>>
    {
    }
}
