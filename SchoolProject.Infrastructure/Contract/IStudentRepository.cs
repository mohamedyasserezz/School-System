using SchoolProject.Data.Entities;
using SchoolProject.Infrastructure.Base;

namespace SchoolProject.Infrastructure.Contract
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
        Task<List<Student>> GetAllStudentsAsync();
    }
}
