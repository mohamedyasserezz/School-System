﻿using MediatR;
using SchoolProject.Core.Features.Students.Queries.Results;
using SchoolProject.Data.Entities;

namespace SchoolProject.Core.Features.Students.Queries.Models
{
    public class GetAllStudentQuery : IRequest<List<GetAllStudentResponse>>
    {
    }
}
