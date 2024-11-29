using SchoolProject.Data.Entities;
using SchoolProject.Infrastructure.Contract;
using SchoolProject.Service.Contract;

namespace SchoolProject.Service.Implementation
{
    internal class StudentService(IStudentRepository studentRepository) : IStudentService
    {
        private readonly IStudentRepository _studentRepository = studentRepository;

        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _studentRepository.GetAllStudentsAsync();
        }
    }
}
