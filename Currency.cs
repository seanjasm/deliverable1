using System;

namespace Deliverable1
{
    enum currencyType { USD, Japanese, Thai, Swedish };

    class NumberOperation
    {
        private double number1, number2, number3, sum;

        public NumberOperation(double num1, double num2, double num3)
        {
            number1 = num1;
            number2 = num2;
            number3 = num3;
            sum = num1 + num2 + num3;
        }

        public NumberOperation()
        {
            number1 = number2 = number3 = 0;
        }

        public string GetCurrencyByType(currencyType ctype)
        {
            switch (ctype)
            {
                case currencyType.Swedish:
                    {
                        return sum.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("sv-SE"));
                    }
                case currencyType.Japanese:
                    {
                        return sum.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("ja-JP"));
                    }
                case currencyType.USD:
                    {
                        return sum.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
                    }
                case currencyType.Thai:
                    {
                        return sum.ToString("C", System.Globalization.CultureInfo.CreateSpecificCulture("th-TH"));
                    }
                default:
                    return "";
            }

        }

        public double GetSmallestNumber()
        {
            double smallest = number1;

            if (number2 < smallest)
            {
                smallest = number2;

                if (number3 < smallest)
                    smallest = number3;

            }
            else if (number3 < smallest)
                smallest = number3;

            return smallest;
        }

        public double GetLargestNumber()
        {
            double largest = number1;

            if (number2 > largest)
            {
                largest = number2;

                if (number3 > largest)
                    largest = number3;

            }
            else if (number3 > largest)
                largest = number3;

            return largest;
        }

        public double GetAverage()
        {
            return (number1 + number2 + number3)/3;
        }
    }
}
