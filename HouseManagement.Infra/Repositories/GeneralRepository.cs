using HouseManagement.Domain.Interfaces;
using HouseManagement.Infra.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseManagement.Infra.Repositories
{
    public class GeneralRepository : IGeneralRepository
    {
        private readonly ApplicationDBContext _application;

        public GeneralRepository(ApplicationDBContext application)
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
