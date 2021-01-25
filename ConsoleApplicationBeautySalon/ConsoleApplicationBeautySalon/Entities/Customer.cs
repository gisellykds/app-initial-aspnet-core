using System;

namespace ConsoleApplicationBeautySalon.Entities
{
    class Customer
    {
        public string CPF { get; set; }
        public string Name { get; set; }
        public string CellPhone { get; set; }
        public string Email { get; set; }
        public DateTime DataRegistration { get; set; }

        public Customer(string cpf, string name, string cellPhone, string email)
        {
            CPF = cpf;
            Name = name;
            CellPhone = String.IsNullOrEmpty(cellPhone) ? "NÃO INFORMADO" : cellPhone;
            Email = String.IsNullOrEmpty(email) ? "NÃO INFORMADO" : email;
            DataRegistration = DateTime.Now;
        }

        public Customer(string cpf)
        {
            CPF = cpf;
        }

        public override string ToString() =>
              "CPF: " + CPF
            + " Nome: " + Name
            + " Telefone/Celular " + CellPhone
            + " Email: " + Email
            + " Registrado em: " + DataRegistration.ToString("MM/dd/YYYY");
    }

}
