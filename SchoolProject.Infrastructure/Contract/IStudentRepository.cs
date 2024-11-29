using SchoolProject.Data.Entities;

namespace SchoolProject.Infrastructure.Contract
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAllStudentsAsync();
    }
}
