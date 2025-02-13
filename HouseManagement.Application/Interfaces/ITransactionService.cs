using HouseManagement.Application.DTOs;
using HouseManagement.Domain.Entity;

namespace HouseManagement.Application.Interfaces
{
    public interface ITransactionService
    {
        Task<List<TransactionsResponseDTO>> GetAll();
        Task Add(TransactionAddDTO transactionAddDTO);
        Task Delete(int id);
    }
}
