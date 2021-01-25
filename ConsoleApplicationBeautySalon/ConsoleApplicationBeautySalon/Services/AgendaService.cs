using ConsoleApplicationBeautySalon.Entities;
using ConsoleApplicationBeautySalon.FakeDatabase;
using ConsoleApplicationBeautySalon.FakeDatabase.Interfaces;
using ConsoleApplicationBeautySalon.Services.Interfaces;
using System;
using System.Collections.Generic;

namespace ConsoleApplicationBeautySalon.Services
{
    class AgendaService : IAgendaService
    {
        private IAgendaRepository agendaRepository = new AgendaRepository();

        public void FindAgendaByDate()
        {
            DateTime date = ReadInputsForFindAgendaDate();
            List<Agenda> agendas = agendaRepository.FindAllByDate(date);
            if (agendas.Count == 0)
            {
                Console.WriteLine("Nenhuma agenda cadastrada na data informada.");
            }
            else
            {
                foreach (Agenda agenda in agendas)
                {
                    WriteOutputForConsole(agenda);
                }
            }
        }

        public void FindAgendaById()
        {
            long id = ReadInputsForFindAgenda();
            Agenda agenda = agendaRepository.FindById(id);
            if (agenda == null)
            {
                Console.WriteLine("Agenda com ID informado não se encontra cadastrada.");
            }
            else
            {
                WriteOutputForConsole(agenda);
            }
        }


        public void FindAllAgenda()
        {
            List<Agenda> agendas = agendaRepository.FindAll();
            if (agendas.Count == 0)
            {
                Console.WriteLine("Nenhuma agenda cadastrada.");
            }
            else
            {
                foreach (Agenda agenda in agendas)
                {
                    WriteOutputForConsole(agenda);
                }
            }
        }

        public void NewAgenda(string cpf)
        {
            Agenda agenda = ReadInputsForNewAgenda(cpf);
            if (agenda != null)
            {
                if (!VerifyIfExists(agenda.DateTime))
                {
                    Console.WriteLine("Já existe agenda cadastrada para dia e horário.");
                }
                else
                {
                    agendaRepository.Save(agenda);
                    Console.WriteLine("Cadastro efetuado com sucesso!");
                }
            }
        }

        private Agenda ReadInputsForNewAgenda(string cpf)
        {
            if (cpf == String.Empty)
            {
                Console.WriteLine("É necessário que o usuário possua um cadastro para prosseguir com a agenda.");
                return null;
            }
            else
            {
                Console.WriteLine("Informe o ID do procedimento a ser realizado: " +
                  "(1.COLORAÇÃO 2.TRATAMENTO 3.CORTE 4.LAVAGEM 5.ESCOVA 6.OUTROS)");
                string product = Console.ReadLine();

                Console.WriteLine("Informe a data para agendamento: (Formato: MM/DD/AAAA)");
                string date = Console.ReadLine();

                Console.WriteLine("Informe a hora para agendamento: (Formato: HH:MM)");
                string time = Console.ReadLine();

                Console.WriteLine("Há alguma observação? Caso sim informe abaixo, caso não pressione a tecla ENTER");
                string observations = Console.ReadLine();

                return new Agenda(cpf, product, date, time, observations);
            }

        }

        private long ReadInputsForFindAgenda()
        {
            Console.WriteLine("Informe o ID para consulta:");
            string id = Console.ReadLine();
            long numero;
            return long.TryParse(id, out numero) ? long.Parse(id) : numero;
        }

        private DateTime ReadInputsForFindAgendaDate()
        {
            Console.WriteLine("Informe a data para consulta: (Formato: MM/DD/AAAA)");
            return DateTime.Parse(Console.ReadLine());
        }

        private void WriteOutputForConsole(Agenda agenda)
        {
            Console.WriteLine(agenda.ToString());
        }

        public bool VerifyIfExists(DateTime date)
        {
            return agendaRepository.FindByDateTime(date) == null;
        }
    }
}
