using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HouseManagement.Domain.Entity
{
    public class Person
    {
        public Person(string name, int idade)
        {
            Name = name;
            Idade = idade;
        }
        protected Person()
        {
            
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int Idade { get; set; }
    }
}
