namespace HouseManagement.Domain.Entity
{
    public class Person
    {
        public Person(string name, int idade)
        {
            Name = name;
            Idade = idade;
            Transactions = new List<Transaction>();
        }
        protected Person()
        {
            Transactions = new List<Transaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Idade { get; set; }
        public List<Transaction> Transactions { get; set; }
    }
}
