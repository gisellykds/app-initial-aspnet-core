using ConsoleApplicationBeautySalon.Entities;
using ConsoleApplicationBeautySalon.Services;
using ConsoleApplicationBeautySalon.Services.Interfaces;
using System;

namespace ConsoleApplicationBeautySalon
{
    class Program
    {
        private static ICustomerService customerService = new CustomerService();
        private static IAgendaService agendaService = new AgendaService();

        static void Main(string[] args)
        {
            bool continueApplication = true;
            string option;
            WriteDecorationConsole();

            while (continueApplication)
            {
                option = ReadMenuConsole();
                WriteDecorationConsole();

                switch (option)
                {
                    case "1":
                        customerService.FindAllUsers();
                        break;
                    case "2":
                        customerService.FindUserById();
                        break;
                    case "3":
                        customerService.NewUser();
                        break;
                    case "4":
                        agendaService.FindAllAgenda();
                        break;
                    case "5":
                        agendaService.FindAgendaById();
                        break;
                    case "6":
                        agendaService.FindAgendaByDate();
                        break;
                    case "7":
                        agendaService.NewAgenda(customerService.VerifyIfExists());
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }

                WriteDecorationConsole();
                continueApplication = ContinuesRunApplication();
                WriteDecorationConsole();
            }
        }
        private static string ReadMenuConsole()
        {
            Console.WriteLine(
                "Menu de opções: Digite o número da opção desejada" +
                 Environment.NewLine +
                "CLIENTE: 1. Listar todos os clientes 2. Buscar cliente por CPF 3. Cadastrar novo cliente" +
                 Environment.NewLine +
                "AGENDA: 4. Buscar todas as agendas 5. Buscar Agenda por ID 6. Buscar agendas por mes/dia/ano 7. Cadastrar nova agenda"
            );
            return Console.ReadLine();
        }

        private static void WriteDecorationConsole()
        {
            Console.WriteLine("-------------------------------------------------------");
        }

        private static bool ContinuesRunApplication()
        {
            Console.WriteLine("Deseja encerrar a aplicação? (Digite SIM para sair ou pressione a tecla ENTER para continuar)");
            return Console.ReadLine() == "SIM" ? false : true;
        }
    }
}
