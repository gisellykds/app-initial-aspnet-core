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
    
        public Agenda(string idCustomer, string idProduct, string date, string time, string note)
        {
            IdCustomer = new Customer(idCustomer);
            IdProduct = ProductTypeEnum.GetDescription(idProduct);
            DateTime = DateTime.Parse(date + " " + time);
            Note = String.IsNullOrEmpty(note) ? "NÃO INFORMADO" : note; 
        }

        public override string ToString() =>
            "ID: " + Id
          + " CPF Cliente : " + IdCustomer.CPF
          + " Produto: " + IdProduct
          + " Data e Hora: " + DateTime.ToString()
          + " Observações : " + Note;
    }

}
