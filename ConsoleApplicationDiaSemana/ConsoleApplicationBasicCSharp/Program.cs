using Microsoft.OpenApi.Extensions;
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplicationBasicCSharp
{
    class Program
    {

        static void Main(string[] args)
        {
            ForTraining();
            ForTrainingTwo();
            WhileTraining();
            MainWeekly();
        }

        static void ForTrainingTwo()
        {
            List<int> numberTwenty = new List<int>();
            Console.WriteLine("Numeros pares de 1 a 20 - for");
            for (int i = 1; i <= 20; i++)
            {
                verifyIsPair(i);
                numberTwenty.Add(i);
            }

            Console.WriteLine("Numeros pares de 1 a 20 - foreach");
            foreach(int number in numberTwenty)
            {
                verifyIsPair(number);
            }

        }

        private static void verifyIsPair(int i)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        static void ForTraining()
        {
            var map = new List<Tuple<string, string>>();

            int female = 0;
            int male = 0;

            Console.WriteLine("Insira a quantidade de pessoas que deseja inserir: ");
            int quantity = Int32.Parse(Console.ReadLine());

            for(int i=0; i < quantity; i++)
            {
                Console.WriteLine("Insira um nome: ");
                String name = Console.ReadLine().ToUpper();

                Console.WriteLine("Insira o sexo: formato M/F");
                String genre = Console.ReadLine().ToUpper();

                map.Add(Tuple.Create(name, genre));
            }
            
            foreach (var person in map)
            {
                string value = person.Item2;

                if(value == "M")
                {
                    male += 1;
                }
                else if(value == "F")
                {
                    female += 1;
                }
            }

            Console.WriteLine("Quantidade masculino: " + male);
            Console.WriteLine("Quantidade feminino: " + female);

        }

        static void WhileTraining()
        {
            List<String> names = new List<string>();
            Console.WriteLine("Insira 10 nomes");

            while (names.Count() != 10)
            {
                Console.WriteLine("Insira um nome: ");
                String name = Console.ReadLine();
                if (!name.Equals(String.Empty))
                    names.Add(name);
            }

            foreach(String name in names)
            {
                Console.WriteLine(name);
            }

        }

        static void MainWeekly()
        {
            Console.WriteLine("Cardápio semanal");
            Console.WriteLine("Qual dia da semana deseja saber o cardápio?");
            String dia = Console.ReadLine();
            Console.WriteLine(GetDescription(dia));
        }

        private static WeekDay GetEnumValue(String dia)
        {
            if (!verifyValidDay(dia))
            {
                return WeekDay.DEFAULT;
            }
            return (WeekDay)Enum.Parse(typeof(WeekDay), dia, true);
        }

        private static String GetDescription(String dia)
        {
            return GetEnumValue(dia).GetAttributeOfType<DescriptionAttribute>().Description;
        }

        private static bool verifyValidDay(String dia)
        {
            return Enum.IsDefined(typeof(WeekDay), dia);
        }

        enum WeekDay{
            [Description("PRATO DE SEGUNDA")]
            SEGUNDA,
            [Description("PRATO DE TERÇA")]
            TERCA,
            [Description("PRATO DE QUARTA")]
            QUARTA,
            [Description("PRATO DE QUINTA")]
            QUINTA,
            [Description("PRATO SEXTA")]
            SEXTA,
            [Description("PRATO SABADO")]
            SABADO,
            [Description("PRATO DOMINGO")]
            DOMINGO,
            [Description("DIA NÃO É VÁLIDO")]
            DEFAULT
        }

    }
}
