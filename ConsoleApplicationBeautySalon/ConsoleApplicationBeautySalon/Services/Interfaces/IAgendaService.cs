using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationBeautySalon.Services.Interfaces
{
    interface IAgendaService
    {
        public void NewAgenda(string cpf);
        public void FindAgendaById();
        public void FindAllAgenda();
        public void FindAgendaByDate();
    }
}
