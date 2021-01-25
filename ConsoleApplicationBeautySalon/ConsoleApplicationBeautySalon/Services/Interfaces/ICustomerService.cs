using ConsoleApplicationBeautySalon.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplicationBeautySalon.Services.Interfaces
{
    interface ICustomerService
    {
        public void NewUser();
        public void FindUserById();
        public void FindAllUsers();
        public string VerifyIfExists();
    }
}
