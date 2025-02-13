namespace HouseManagement.Application.DTOs
{
    public class PersonResponseDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Idade { get; set; }
        public List<TransactionsResponseDTO> Transactions { get; set; }
    }
}
