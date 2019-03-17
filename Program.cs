using System;


namespace Deliverable1
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1 = 0, num2 = 0, num3 = 0;
            NumberOperation numberOperation = new NumberOperation();
            int numberErrorCounter = 0;//keeps track of user error input
            

            try
            {
                do
                {
                    Console.Clear();

                    numberErrorCounter = 0; //set counter to zero if user decides to continue

                    do
                    {
                        if (numberErrorCounter > 0)//display message if user error
                            Console.WriteLine("\n\nUser input error. Please try again.");

                        Console.Write("\n\nEnter first number then press ENTER: ");

                        numberErrorCounter++;//increments counter to display error message if user made an error

                    } while (!double.TryParse(Console.ReadLine(), out num1));//loop continues while number is not of double or floating type

                    numberErrorCounter = 0;//set counter back to zero

                    do
                    {
                        if (numberErrorCounter > 0)//display message if user error
                            Console.WriteLine("\n\nUser input error. Please try again.");

                        Console.Write("\n\nEnter second number then press ENTER: ");

                        numberErrorCounter++;//increments counter to display error message if user made an error

                    } while (!double.TryParse(Console.ReadLine(), out num2));//loop continues while number is not of double or floating type

                    numberErrorCounter = 0;//set counter back to zero

                    do
                    {
                        if (numberErrorCounter > 0)//display message if user error
                            Console.WriteLine("\n\nUser input error. Please try again.");

                        Console.Write("\n\nEnter third number then press ENTER: ");

                        numberErrorCounter++;//increments counter to display error message if user made an error

                    } while (!double.TryParse(Console.ReadLine(), out num3));//loop continues while number is not of double or floating type

                    numberOperation = new NumberOperation(num1, num2, num3);//construct accepts all 3 numbers

                    Console.WriteLine("\n\nHighest Number          Lowest Number          Average          ");

                    Console.Write("\n\n{0, -24}", numberOperation.GetLargestNumber());
                    Console.Write("{0, -23}", numberOperation.GetSmallestNumber());
                    Console.Write("{0, -17}", numberOperation.GetAverage());



                    Console.Write("\n\n\n  Total in Swedish Krona     {0}", numberOperation.GetCurrencyByType(currencyType.Swedish));
                    Console.Write("\n\n   Total in Japanese Yen     {0}", numberOperation.GetCurrencyByType(currencyType.Japanese));
                    Console.Write("\n\n      Total in US Dollar     {0}", numberOperation.GetCurrencyByType(currencyType.USD));
                    Console.WriteLine("\n\n      Total in Thai Baht     {0}", numberOperation.GetCurrencyByType(currencyType.Thai));

                    Console.Write("\n\n\nDo you want to continue?[N]:");

                } while (Console.ReadLine().ToLower() == "y");//Loop while user wants to continue

            } catch
            {
                Console.WriteLine("\n\n\nThere was an error processing the info. Only accepts double/floating type numbers. \nPress ENTER to quit.");
                Console.ReadLine();
            }
        }
    }
}
