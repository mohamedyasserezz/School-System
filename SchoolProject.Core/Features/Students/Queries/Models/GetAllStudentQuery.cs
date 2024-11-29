using MediatR;
using SchoolProject.Data.Entities;

namespace SchoolProject.Core.Features.Students.Queries.Models
{
    public class GetAllStudentQuery : IRequest<List<Student>>
    {
    }
}
