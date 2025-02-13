namespace HouseManagement.Domain.Entity
{

    public class Transaction
    {
        public Transaction(int id, string description, int value, bool isRevenue, int idPerson)
        {
            Id = id;
            Description = description;
            Value = value;
            IsRevenue = isRevenue;
            IdPerson = idPerson;
        }
        protected Transaction()
        {
        }

        public int Id { get; set; }
        public string Description{ get; set; }
        public float Value { get; set; }
        public bool IsRevenue { get; set; }
        public int IdPerson { get; set; }
        public Person Person { get; set; }
    }
}
