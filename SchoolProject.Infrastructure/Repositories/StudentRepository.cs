using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using SchoolProject.Infrastructure.Contract;
using SchoolProject.Infrastructure.Data;

namespace SchoolProject.Infrastructure.Repositories
{
    internal class StudentRepository(ApplicationDbContext dbContext) : IStudentRepository
    {
        #region Fields
        private readonly ApplicationDbContext _dbContext = dbContext;
        #endregion

        #region Methods
        public async Task<List<Student>> GetAllStudentsAsync()
        => await _dbContext.Students.ToListAsync(); 
        #endregion
    }
}
