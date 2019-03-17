using System;


namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0, num2 = 0, num3 = 0;
            NumberOperation numberOperation = new NumberOperation();
            

            try
            {
                do
                {
                    Console.Clear();

                    Console.Write("\nEnter first number then press ENTER: ");
                    num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\nEnter second number then press ENTER: ");
                    num2 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("\nEnter third number then press ENTER: ");
                    num3 = Convert.ToDouble(Console.ReadLine());

                    numberOperation = new NumberOperation(num1, num2, num3);

                    Console.WriteLine("\n\nHighest Number          Lowest Number          Average          ");

                    Console.Write("\n\n{0, -24}", numberOperation.GetLargestNumber());
                    Console.Write("{0, -23}", numberOperation.GetSmallestNumber());
                    Console.Write("{0, -17}", numberOperation.GetAverage());



                    Console.Write("\n\n\n  Total in Swedish Krona     {0}", numberOperation.GetCurrencyByType(currencyType.Swedish));
                    Console.Write("\n\n   Total in Japanese Yen     {0}", numberOperation.GetCurrencyByType(currencyType.Japanese));
                    Console.Write("\n\n      Total in US Dollar     {0}", numberOperation.GetCurrencyByType(currencyType.USD));
                    Console.WriteLine("\n\n      Total in Thai Baht     {0}", numberOperation.GetCurrencyByType(currencyType.Thai));

                    Console.Write("\n\n\nDo you want to continue?[N]:");

                } while (Console.ReadLine().ToLower() == "y");

            } catch
            {
                Console.WriteLine("\n\n\nThere was an error processing the info. Only accepts double/floating type numbers. \nPress ENTER to quit.");
                Console.ReadLine();
            }
        }
    }
}
