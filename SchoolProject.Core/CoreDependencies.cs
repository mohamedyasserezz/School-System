using Microsoft.Extensions.DependencyInjection;
using SchoolProject.Infrastructure.Contract;
using System.Reflection;

namespace SchoolProject.Core
{
    public static class CoreDependencies
    {
        public static IServiceCollection AddCoreDependencies(this IServiceCollection services)
        {
            services.AddMediatR(crf => crf.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));

            return services;
        }
    }
}
