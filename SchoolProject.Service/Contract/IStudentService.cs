using SchoolProject.Data.Entities;

namespace SchoolProject.Service.Contract
{
    public interface IStudentService
    {
        public Task<List<Student>> GetStudentsAsync();
    }
}
