﻿namespace HouseManagement.Domain.Interfaces
{
    public interface IGeneralRepository
    {
        Task Add<T>(T entity) where T:class;
        Task Delete<T>(T entity) where T : class;
        Task SaveAsync();

    }
}
