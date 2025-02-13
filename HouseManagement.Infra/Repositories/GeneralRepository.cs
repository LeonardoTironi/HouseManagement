using HouseManagement.Domain.Interfaces;
using HouseManagement.Infra.Context;

namespace HouseManagement.Infra.Repositories
{
    public class GeneralRepository : IGeneralRepository
    {
        private readonly ApplicationDbContext _application;

        public GeneralRepository(ApplicationDbContext application)
        {
            _application = application;
        }

        public async Task Add<T>(T entity) where T : class
        {
            await _application.AddAsync(entity);

            await _application.SaveChangesAsync();
        }

        public async Task Delete<T>(T entity) where T : class
        {
            _application.Remove(entity);
            await _application.SaveChangesAsync();
        }

        public async Task SaveAsync()
        {
            await _application.SaveChangesAsync();
        }
    }
}
