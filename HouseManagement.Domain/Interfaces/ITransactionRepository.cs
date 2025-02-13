using HouseManagement.Domain.Entity;

namespace HouseManagement.Domain.Interfaces
{
    public interface ITransactionRepository
    {
        Task<List<Transaction>> GetAllByIdPerson(int idPerson);
        Task<List<Transaction>> GetAllTransactions();
        Task<Transaction> GetTransactionById(int id);
    }
}
