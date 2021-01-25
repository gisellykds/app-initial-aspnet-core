using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;

namespace ConsoleApplicationMailSend
{
    class Program
    {

        static void Main(string[] args)
        {

            List<EmailDTO> listMails = new List<EmailDTO>();
            Boolean isToContinue = true;

            while (isToContinue)
            {
                Console.WriteLine("1. Iniciar processamento de email / 2. Inserir email para envio");
                var option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.WriteLine("Iniciando processamento de envio de emails.");
                        SendMessage(listMails);
                        break;
                    case "2":
                        Console.WriteLine("Inserir email a ser enviado.");
                        InsertMessage(listMails);
                        break;
                    default:
                        Console.WriteLine("Opss, opção inválida.");
                        break;
                }
                isToContinue = VerifyIsContinueRunApplication();
            }
        }

        private static bool VerifyIsContinueRunApplication()
        {
            Console.WriteLine("Deseja sair da aplicação? Digite SIM para sair e qualquer tecla para continuar");
            return Console.ReadLine().ToUpper() == "SIM" ? false : true;
        }

        private static void InsertMessage(List<EmailDTO> emailDTOs)
        {
            EmailDTO email = ReadInputMail();
            emailDTOs.Add(email);
        }

        private static void SendMessage(List<EmailDTO> listEmails)
        {
            try
            {
                SmtpClient client = SetClient();

                while (listEmails.Count != 0)
                {
                    foreach (EmailDTO email in listEmails.ToList())
                    {
                        if (email.dateSend.ToString("dd/MM/yyyy") == DateTime.Now.ToString("dd/MM/yyyy"))
                        {
                            MailMessage mailMessage = SetEmail(email);
                            client.Send(mailMessage);
                            Console.WriteLine("Email Enviado com sucesso!");
                            listEmails.Remove(email);
                            Console.WriteLine("Email removido da lista!");
                        }
                    }
                }
                Console.WriteLine("Lista de envio de emails vazia.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível enviar o email. Detalhes: " + ex.Message);
            }

        }

        private static EmailDTO ReadInputMail()
        {
            Console.WriteLine("Email recebedor:");
            String mail = Console.ReadLine();

            Console.WriteLine("Assunto da mensagem:");
            String subject = Console.ReadLine();

            Console.WriteLine("Corpo do email:");
            String message = Console.ReadLine();

            Console.WriteLine("Em que data deseja que sua mensagem seja enviada? formato: MM/DD/AAAA");
            String data = Console.ReadLine();

            return new EmailDTO(mail, subject, message, data);
        }

        private static MailMessage SetEmail(EmailDTO emailDTO)
        {

            MailAddress from = new MailAddress(emailDTO.fromMail);
            MailAddress to = new MailAddress(emailDTO.toMail);
            MailMessage mailMessage = new MailMessage(from, to);

            mailMessage.Subject = emailDTO.subject;
            mailMessage.Body = emailDTO.message;
            mailMessage.IsBodyHtml = true;

            return mailMessage;
        }

        private static SmtpClient SetClient()
        {
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential(new EmailDTO().fromMail, "");
            client.Host = "smtp.gmail.com";
            client.EnableSsl = true;

            return client;
        }

        private static bool VerifyIsNotEmpty(String value)
        {
            if (String.Empty.Equals(value))
            {
                Console.WriteLine("Digite um valor válido");
                return false;
            }
            return true;
        }

        public class EmailDTO
        {
            public String fromName { get; } = "Giselly Silva";
            public String fromMail { get; } = "testemaildotnetcore@gmail.com";
            public String toMail { get; set; }
            public String subject { get; set; }
            public String message { get; set; }
            public DateTime dateSend { get; set; }

            public EmailDTO(String email, String subject, String message, String date)
            {
                this.toMail = email;
                this.subject = subject;
                this.message = message;
                this.dateSend = DateTime.Parse(date);
            }

            public EmailDTO()
            {

            }
        }
    }


}
