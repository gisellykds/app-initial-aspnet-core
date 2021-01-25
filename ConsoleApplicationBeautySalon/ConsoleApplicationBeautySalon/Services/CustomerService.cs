using ConsoleApplicationBeautySalon.Entities;
using ConsoleApplicationBeautySalon.FakeDatabase;
using ConsoleApplicationBeautySalon.FakeDatabase.Interfaces;
using ConsoleApplicationBeautySalon.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace ConsoleApplicationBeautySalon.Services
{
    class CustomerService : ICustomerService
    {
        private ICustomerRepository userRepository = new CustomerRepository();

        public void FindAllUsers()
        {
            List<Customer> customers = userRepository.FindAll();
            if (customers.Count == 0)
            {
                Console.WriteLine("Nenhum cadastro encontrado.");
            }
            else
            {
                foreach (Customer customer in customers)
                {
                    WriteOutputForConsole(customer);
                }
            }
        }

        public void FindUserById()
        {
            string cpf = ReadInputsForFindUser();
            Customer customer = userRepository.FindById(cpf);
            if (customer == null)
            {
                Console.WriteLine("Usuário com CPF informado não se encontra cadastrado.");
            }
            else
            {
                WriteOutputForConsole(customer);
            }
        }

        public void NewUser()
        {
            Customer customer = ReadInputsForNewUser();
            if (userRepository.FindById(customer.CPF) != null)
            {
                Console.WriteLine("Usuário com CPF informado já se encontra cadastrado.");
            }
            else
            {
                userRepository.Save(customer);
                Console.WriteLine("Cadastro efetuado com sucesso!");
            }
        }

        public string VerifyIfExists()
        {
            Console.WriteLine("Informe o CPF do cliente: ");
            string cpf = Console.ReadLine();
            return userRepository.FindById(cpf) == null ? "" : cpf;
        }

        // init read/write values console application
        private static string ReadInputsForFindUser()
        {
            Console.WriteLine("Informe o CPF para consulta:");
            return Console.ReadLine();
        }

        private static Customer ReadInputsForNewUser()
        {
            string line = Environment.NewLine;

            Console.WriteLine("Informe o CPF:");
            string CPF = Console.ReadLine();

            Console.WriteLine(line + "Informe o nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine(line + "Informe um telefone/celular para contato: ");
            string phone = Console.ReadLine();

            Console.WriteLine(line + "Informe um email para contato: ");
            string email = Console.ReadLine();

            return new Customer(CPF, nome, phone, email);
        }

        private void WriteOutputForConsole(Customer customer)
        {
            Console.WriteLine(customer.ToString());
        }
    }
}
