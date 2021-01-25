using ConsoleApplicationBeautySalon.Entities;
using ConsoleApplicationBeautySalon.FakeDatabase.Interfaces;
using System;
using System.Collections.Generic;

namespace ConsoleApplicationBeautySalon.FakeDatabase
{
    class CustomerRepository : ICustomerRepository
    {
        private List<Customer> customers = new List<Customer>();

        public List<Customer> FindAll()
        {
            return customers;
        }

        public Customer FindById(string cpf)
        {
            foreach (Customer user in customers)
            {
                if (user.CPF.Equals(cpf))
                    return user;
            }
            return null;
        }

        public void Save(Customer user)
        {
            customers.Add(user);
        }
    }
}
