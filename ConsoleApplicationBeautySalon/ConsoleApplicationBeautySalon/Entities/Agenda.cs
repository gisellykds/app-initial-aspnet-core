using ConsoleApplicationBeautySalon.Enums;
using System;
using static ConsoleApplicationBeautySalon.Enums.ProductTypeEnum;

namespace ConsoleApplicationBeautySalon.Entities
{
    class Agenda
    {
        public long Id { get; set; }
        public Customer IdCustomer { get; set; }
        public ProductType IdProduct { get; set; }
        public DateTime DateTime { get; set; }
        public string Note { get; set; }
    
        public Agenda()
        {

        }

        public Agenda(string IdCustomer, string IdProduct, string Date, string Time, string Note)
        {
            this.IdCustomer = new Customer(IdCustomer);
            this.IdProduct = ProductTypeEnum.GetDescription(IdProduct);
            this.DateTime = DateTime.Parse(Date + " " + Time);
            this.Note = (Note == "" || Note == null) ? "NÃO INFORMADO" : Note; 
        }

        public string ToString() =>
            "ID: " + this.Id
          + " CPF Cliente : " + this.IdCustomer.CPF
          + " Produto: " + this.IdProduct
          + " Data e Hora: " + this.DateTime.ToString()
          + " Observações : " + this.Note;
    }

}
