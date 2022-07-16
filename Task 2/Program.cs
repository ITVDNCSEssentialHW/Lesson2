using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double grv = 850;
            Converter conv = new Converter(77.2, 85.4, 34.3, grv);

            double usd = conv.GRVUSD;
            Console.WriteLine(usd);

            Console.ReadLine();
        }
    }
}
