using HouseManagement.Domain.Entity;
using HouseManagement.Domain.Interfaces;
using HouseManagement.Infra.Context;
using Microsoft.EntityFrameworkCore;

namespace HouseManagement.Infra.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly ApplicationDbContext _application;

        public TransactionRepository(ApplicationDbContext application)
        {
            _application = application;
        }
        public async Task<List<Transaction>> GetAllByIdPerson(int id)
        {
            List<Transaction> transactions = await _application.Transactions.Where(x => x.IdPerson == id).ToListAsync();
            if (transactions == null)
            {
                throw new ApplicationException("Sem transações.");
            }
            return transactions;
        }

        public async Task<List<Transaction>> GetAllTransactions()
        {
            List<Transaction> transactions = await _application.Transactions.ToListAsync();
            if (transactions == null)
            {
                throw new ApplicationException("Sem transações");
            }
            return transactions;
        }
        public async Task<Transaction> GetTransactionById(int id)
        {
            Transaction? transaction = await _application.Transactions.SingleOrDefaultAsync(x => x.Id == id);
            if (transaction == null)
            {
                throw new ApplicationException("Transação não encontrada.");
            }
            return transaction;
        }
    }
}
