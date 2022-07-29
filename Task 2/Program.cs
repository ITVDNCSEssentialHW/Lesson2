using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double rub;
            bool sell = true;
            Console.WriteLine("Buy or sell? (B/S)");
            string operation = Console.ReadLine();
            //Add try catch

            if (operation == "S")
                //Sell
            {
                Console.WriteLine("What currency do you want to sell? (USD, EUR, GRV)");
                string currency = Console.ReadLine();
                //Add try catch

                Console.WriteLine("How many?");
                double currencyVol = Convert.ToDouble(Console.ReadLine());
                //Add try catch

                Converter conv1 = new Converter(77.2, 85.4, 34.3, currencyVol, sell);

                switch (currency)
                {
                    case "USD":
                        Console.WriteLine("Result of rhe operation is {0}", conv1.USDRUB);
                        break;
                    case "EUR":
                        Console.WriteLine("Result of rhe operation is {0}", conv1.EURRUB);
                        break;
                    case "GRV":
                        Console.WriteLine("Result of rhe operation is {0}", conv1.GRVRUB);
                        break;
                }
            }
            else
            //Buy
            {
                sell = false;
                Console.WriteLine("What currency do you want to buy? (USD, EUR, GRV)");
                string currency = Console.ReadLine();
                //Add try catch

                Console.WriteLine("How many rubles do you have?");
                rub = Convert.ToDouble(Console.ReadLine());
                //Add try catch

                Converter conv2 = new Converter(77.2, 85.4, rub, 34.3);
                switch (currency)
                {
                    case "USD":
                        Console.WriteLine("Result of rhe operation is {0:f2}", conv2.RUBUSD);
                        break;
                    case "EUR":
                        Console.WriteLine("Result of rhe operation is {0:f2}", conv2.RUBEUR);
                        break;
                    case "GRV":
                        Console.WriteLine("Result of rhe operation is {0:f2}", conv2.RUBGRV);
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
