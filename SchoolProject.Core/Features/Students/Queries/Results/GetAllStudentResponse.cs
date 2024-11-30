﻿using System.ComponentModel.DataAnnotations;

namespace SchoolProject.Core.Features.Students.Queries.Results
{
    public class GetAllStudentResponse
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? DepartmentName { get; set; }
    }
}
