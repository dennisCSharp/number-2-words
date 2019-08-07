using System;

namespace Number2Words
{
    public class Program
    {
        private static readonly INumberConverter _numberConverter = new NumberConverter();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n=========================================\nSelect an option:\n=========================================");
                Console.WriteLine("1 - Conver Single");
                Console.WriteLine("2 - Convert Range");
                Console.WriteLine("0 - Exit\n");

                Console.Write("Option [1, 2 or 0]: ");
                string option = Console.ReadLine();

                if (option.Equals("0"))
                    break;

                string value = string.Empty;
                double startNumber = 0;
                double endNumber = 0;
                string result = string.Empty;

                switch (option)
                {
                    case "1":
                        Console.Write("\nEnter Number : ");
                        value = Console.ReadLine();
                        double.TryParse(value, out startNumber);
                        result = _numberConverter.Convert(startNumber);
                        Console.WriteLine(string.Format("\n\n{0} - {1}\n\n", startNumber, result));
                        break;
                    case "2":
                        Console.Write("\nEnter Start Number : ");
                        value = Console.ReadLine();
                        double.TryParse(value, out startNumber);
                        Console.Write("Enter End Number   : ");
                        value = Console.ReadLine();
                        double.TryParse(value, out endNumber);

                        Console.WriteLine("\n");
                        for (double number = startNumber; number <= endNumber; number++)
                        {
                            result = _numberConverter.Convert(number, ConversionType.ToCurrency, CurrencyType.Dollars);
                            Console.WriteLine(string.Format("{0} - {1}", number, result));
                        }
                        Console.WriteLine("\n");

                        break;
                    case "0":
                        break;
                }

                if (option != "1" && option != "2" && option != "0")
                    Console.Write("\nInvalid Choice!! ");

                Console.WriteLine("Press any key...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
