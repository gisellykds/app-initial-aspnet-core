using ConsoleApplicationBeautySalon.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationBeautySalon.FakeDatabase.Interfaces
{
    interface IAgendaRepository
    {
        public void Save(Agenda agenda);
        public List<Agenda> FindAll();
        public Agenda FindById(long Id);
        public List<Agenda> FindAllByDate(DateTime date);
        public Agenda FindByDateTime(DateTime date);
    }
}
