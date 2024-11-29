using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Service.Contract;
using SchoolProject.Service.Implementation;

namespace SchoolProject.Service
{
    public static class ServicesDependencies
    {
        public static IServiceCollection AddServicesDependencies(this IServiceCollection services)
        {
            services.AddTransient(typeof(IStudentService), typeof(StudentService));

            return services;
        }
    }
}
