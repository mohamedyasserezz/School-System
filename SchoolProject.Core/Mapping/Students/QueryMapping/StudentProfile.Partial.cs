using SchoolProject.Core.Features.Students.Queries.Results;
using SchoolProject.Data.Entities;

namespace SchoolProject.Core.Mapping.Students
{
    public partial class StudentProfile
    {
        public void GetAllStudentMapping()
        {
            CreateMap<Student, GetAllStudentResponse>()
               .ForMember(des => des.DepartmentName, conf => conf.MapFrom(src => src.Department.Name));
        }
    }
}
