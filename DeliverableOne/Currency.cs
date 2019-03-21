using System;

namespace Deliverable1
{
    enum currencyType { USD, Japanese, Thai, Swedish };//enum of currency to help with readability

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

        //returns a formatted currency based on a speific culture
        public string GetCurrencyByType(currencyType ctype)
        {
            switch (ctype)
            {
                case currencyType.Swedish:
                    {
                        //formats currency to 2 decimal places
                        return sum.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("sv-SE"));
                    }
                case currencyType.Japanese:
                    {
                        //formats currency to no decimal place
                        return sum.ToString("C0", System.Globalization.CultureInfo.CreateSpecificCulture("ja-JP"));
                    }
                case currencyType.USD:
                    {
                        //formats currency to 2 decimal places
                        return sum.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("en-US"));
                    }
                case currencyType.Thai:
                    {
                        //formats currency to 2 decimal places
                        return sum.ToString("C2", System.Globalization.CultureInfo.CreateSpecificCulture("th-TH"));
                    }
                default:
                    return "";//added as reduncy because will not reach this section
            }

        }

        //this function sets number1 as smallest. If number2 is smaller then number2 is smallest 
        //else if number3 is smaller than smallest number3 is set as smallest
        //finally, returns the smallest
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

        //this function sets number1 as largest. If number2 is larger then number2 is largest 
        //else if number3 is larger than largest number3 is set as largest
        //finally returns largest
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

        //returns the average
        public double GetAverage()
        {
            return (number1 + number2 + number3)/3;
        }
    }
}
