using HouseManagement.Application.Helpers;
using HouseManagement.Application.Interfaces;
using HouseManagement.Application.Services;
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

            serviceCollection.AddDbContext<ApplicationDbContext>(
                context => context.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
            );
            serviceCollection.AddAutoMapper(typeof(HouseManagementProfiler));

            serviceCollection.AddScoped<IPersonService, PersonService>();
            serviceCollection.AddScoped<ITransactionService, TransactionService>();

            serviceCollection.AddScoped<IGeneralRepository, GeneralRepository>();
            serviceCollection.AddScoped<IPersonRepository, PersonRepository>();
            serviceCollection.AddScoped<ITransactionRepository, TransactionRepository>();

        }
    }
}
