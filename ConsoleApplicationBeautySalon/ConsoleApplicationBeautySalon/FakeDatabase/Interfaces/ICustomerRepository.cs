using ConsoleApplicationBeautySalon.Entities;
using System.Collections.Generic;

namespace ConsoleApplicationBeautySalon.FakeDatabase.Interfaces
{
    interface ICustomerRepository
    {
        public void Save(Customer customer);
        public List<Customer> FindAll();
        public Customer FindById(string Cpf);
    }
}
