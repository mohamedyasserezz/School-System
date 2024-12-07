using Microsoft.EntityFrameworkCore;
using SchoolProject.Data.Entities;
using SchoolProject.Infrastructure.Base;
using SchoolProject.Infrastructure.Contract;
using SchoolProject.Infrastructure.Data;

namespace SchoolProject.Infrastructure.Repositories
{
    internal class StudentRepository(ApplicationDbContext dbContext) : GenericRepository<Student>(dbContext), IStudentRepository
    {
        #region Fields
        private readonly DbSet<Student> _students = dbContext.Students;
        #endregion

        #region Methods
        public async Task<List<Student>> GetAllStudentsAsync()
        => await _students.Include(S => S.Department).ToListAsync();
        #endregion
    }
}
