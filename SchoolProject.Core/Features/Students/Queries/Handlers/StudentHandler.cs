using AutoMapper;
using MediatR;
using SchoolProject.Core.Base;
using SchoolProject.Core.Features.Students.Queries.Models;
using SchoolProject.Core.Features.Students.Queries.Results;
using SchoolProject.Service.Contract;

namespace SchoolProject.Core.Features.Students.Queries.Handlers
{
    public class StudentHandler(IStudentService studentService, IMapper mapper) : ResponseHandler, IRequestHandler<GetAllStudentQuery, Response<List<GetAllStudentResponse>>>
    {

        #region Fields
        private readonly IStudentService _studentService = studentService;
        private readonly IMapper _mapper = mapper;
        #endregion

        #region Handlers
        public async Task<Response<List<GetAllStudentResponse>>> Handle(GetAllStudentQuery request, CancellationToken cancellationToken)
        {
            var students = await _studentService.GetStudentsAsync();

            return Success(_mapper.Map<List<GetAllStudentResponse>>(students));
        }
        #endregion
    }
}
