using AutoMapper;
using MediatR;
using SchoolProject.Core.Features.Students.Queries.Models;
using SchoolProject.Core.Features.Students.Queries.Results;
using SchoolProject.Data.Entities;
using SchoolProject.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Queries.Handlers
{
    public class StudentHandler(IStudentService studentService, IMapper mapper) : IRequestHandler<GetAllStudentQuery, List<GetAllStudentResponse>>
    {

        #region Fields
        private readonly IStudentService _studentService = studentService;
        private readonly IMapper _mapper = mapper;
        #endregion

        #region Handlers
        public async Task<List<GetAllStudentResponse>> Handle(GetAllStudentQuery request, CancellationToken cancellationToken)
        {
            var students = await _studentService.GetStudentsAsync();

            return _mapper.Map<List<GetAllStudentResponse>>(students);
        }
        #endregion
    }
}
