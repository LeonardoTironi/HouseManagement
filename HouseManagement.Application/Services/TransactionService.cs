using AutoMapper;
using HouseManagement.Application.DTOs;
using HouseManagement.Application.Interfaces;
using HouseManagement.Domain.Entity;
using HouseManagement.Domain.Interfaces;

namespace HouseManagement.Application.Services
{
    public class TransactionService : ITransactionService
    {
        private readonly IGeneralRepository _generalRepository;
        private readonly ITransactionRepository _transactionRepository;
        private readonly IMapper _mapper;

        public TransactionService(IGeneralRepository generalRepository, ITransactionRepository transactionRepository, IMapper mapper)
        {
            _generalRepository = generalRepository;
            _transactionRepository = transactionRepository;
            _mapper = mapper;
        }
        public async Task Add(TransactionAddDTO transactionAddDTO)
        {
            try
            {
                Transaction transaction = _mapper.Map<Transaction>(transactionAddDTO);
                await _generalRepository.Add(transaction);
            }
            catch (Exception)
            {

                throw new Exception("Erro ao cadastrar uma transação.");
            }
        }

        public async Task<List<TransactionsResponseDTO>> GetAll()
        {
            try
            {
                List<Transaction> transactions = await _transactionRepository.GetAllTransactions();
                List<TransactionsResponseDTO>? transactionsDTO = _mapper.Map<List<TransactionsResponseDTO>>(transactions);
                return transactionsDTO;

            }
            catch
            {
                throw new Exception("Não foi possível retornar Transações");
            }
        }

        public async Task Delete(int id)
        {
            try
            {
                Transaction transaction = await _transactionRepository.GetTransactionById(id);
                await _generalRepository.Delete(transaction);
            }
            catch
            {
                throw new Exception("Erro ao deletar uma transação");
            }
        }
    }
}
