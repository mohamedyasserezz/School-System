using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Infrastructure.Contract;
using SchoolProject.Infrastructure.Repositories;

namespace SchoolProject.Infrastructure
{
    public static class InfrastructureDependencies
    {
        public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
        {
            services.AddScoped(typeof(IStudentRepository), typeof(StudentRepository));

            return services;
        }
    }
}
