using System;

namespace ConsoleApplicationBeautySalon.Entities
{
    class Customer
    {
        public string CPF { get; set; }
        public string Name { get; set; }
        public string CellPhone { get; set; }
        public string Email { get; set; }
        public DateTime DataRegistration { get;}
        
        public Customer()
        {

        }

        public Customer(string Cpf, string Name, string CellPhone, string Email)
        {
            this.CPF = Cpf; 
            this.Name = Name; 
            this.CellPhone = (CellPhone == "" || CellPhone == null) ? "NÃO INFORMADO" : CellPhone;
            this.Email = (Email == "" || Email == null) ? "NÃO INFORMADO" : Email; 
            this.DataRegistration = DateTime.Now;
        }

        public Customer(string idUser)
        {
            this.CPF = idUser;
        }

        public string ToString() => 
              "CPF: " + this.CPF 
            + " Nome: " + this.Name 
            + " Telefone/Celular " + this.CellPhone 
            + " Email: " + this.Email 
            + " Registrado em: " + this.DataRegistration.ToString("MM/dd/YYYY");
    }

}
