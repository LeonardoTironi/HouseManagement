namespace HouseManagement.Application.DTOs
{
    public class TransactionAddDTO
    {
        public string Description { get; set; }
        public float Value { get; set; }
        public bool IsRevenue { get; set; }
        public int IdPerson { get; set; }
    }
}
