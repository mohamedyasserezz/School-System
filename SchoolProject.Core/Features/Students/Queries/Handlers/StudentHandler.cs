using MediatR;
using SchoolProject.Core.Features.Students.Queries.Models;
using SchoolProject.Data.Entities;
using SchoolProject.Service.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolProject.Core.Features.Students.Queries.Handlers
{
    public class StudentHandler(IStudentService studentService) : IRequestHandler<GetAllStudentQuery, List<Student>>
    {

        #region Fields
        private readonly IStudentService _studentService = studentService;
        #endregion

        #region Handlers
        public async Task<List<Student>> Handle(GetAllStudentQuery request, CancellationToken cancellationToken)
        {
            return await _studentService.GetStudentsAsync();
        } 
        #endregion
    }
}
