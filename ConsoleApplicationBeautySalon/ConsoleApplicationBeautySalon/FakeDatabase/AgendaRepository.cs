using ConsoleApplicationBeautySalon.Entities;
using ConsoleApplicationBeautySalon.FakeDatabase.Interfaces;
using System;
using System.Collections.Generic;

namespace ConsoleApplicationBeautySalon.FakeDatabase
{
    class AgendaRepository : IAgendaRepository
    {
        private List<Agenda> agendas = new List<Agenda>();

        public List<Agenda> FindAll()
        {
            return agendas;
        }

        public List<Agenda> FindAllByDate(DateTime date)
        {
            List<Agenda> agendasTemp = new List<Agenda>();

            foreach (Agenda agenda in agendas)
            {
                if (agenda.DateTime.ToString("MM/dd/YYYY") == date.ToString("MM/dd/YYYY"))
                    agendasTemp.Add(agenda);
            }

            return agendasTemp;
        }

        public Agenda FindByDateTime(DateTime date)
        {
            foreach (Agenda agenda in agendas)
            {
                if (agenda.DateTime == date)
                    return agenda;
            }
            return null;
        }

        public Agenda FindById(long Id)
        {
            foreach (Agenda agenda in agendas)
            {
                if (agenda.Id == Id)
                    return agenda;
            }
            return null;
        }

        public void Save(Agenda agenda)
        {
            agenda.Id = IterationId();
            agendas.Add(agenda);
        }

        private long IterationId()
        {
            return agendas.Count + 1;
        }
    }
}
