using HouseManagement.Application.Helpers;
using HouseManagement.Domain.Interfaces;
using HouseManagement.Infra.Context;
using HouseManagement.Infra.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HouseManagement.Infra
{
    public static class DependecyInjection
    {
        public static void AddInfraestructure(this IServiceCollection serviceCollection, IConfiguration configuration)
        {

            serviceCollection.AddDbContext<ApplicationDBContext>(
                context => context.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
            );
            serviceCollection.AddAutoMapper(typeof(HouseManagementProfiler));



            serviceCollection.AddScoped<IGeneralRepository, GeneralRepository>();
            serviceCollection.AddScoped<IPersonRepository, PersonRepository>();
        }
    }
}
