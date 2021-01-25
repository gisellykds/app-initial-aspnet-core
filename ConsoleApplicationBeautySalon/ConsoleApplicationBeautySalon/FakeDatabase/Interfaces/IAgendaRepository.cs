using ConsoleApplicationBeautySalon.Entities;
using System;
using System.Collections.Generic;

namespace ConsoleApplicationBeautySalon.FakeDatabase.Interfaces
{
    interface IAgendaRepository
    {
        public void Save(Agenda agenda);
        public List<Agenda> FindAll();
        public Agenda FindById(long id);
        public List<Agenda> FindAllByDate(DateTime date);
        public Agenda FindByDateTime(DateTime date);
    }
}
