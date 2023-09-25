using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT3101_Calculator
{
    public class Calculator
    {
        public Calculator() { }

        public double DoOperation(double num1, double num2, double num3, string op)
        {
            double result = double.NaN; // Default value

            // Use a switch statement to do the math.
            switch (op)
            {
                case "a":
                    result = Add(num1, num2);
                    break;
                case "s":
                    result = Subtract(num1, num2);
                    break;
                case "m":
                    result = Multiply(num1, num2);
                    break;
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    result = Divide(num1, num2);
                    break;
                case "f":
                    // Ask the user to enter a non-zero divisor.
                    if (Math.Abs(num1 - Math.Round(num1)) > double.Epsilon)
                        throw new ArgumentException();

                    result = Factorial((int)num1);
                    break;
                case "t":
                    // Ask the user to enter a non-zero divisor.
                    result = Triangle((double)num1, (double)num2);
                    break;
                case "c":
                    // Ask the user to enter a non-zero divisor.
                    result = Circle((double)num1);
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }

        public double Add(double num1, double num2)
        {
            string str1 = num1.ToString(); 
            string str2 = num2.ToString();
            // do normal addition to non-binary values
            if (!IsBinary(str1) || !IsBinary(str2))
            {
                return (num1 + num2);
            }
            string result = str1 + str2;
            double decResult = Convert.ToInt32(result, 2);
            return decResult;
        }

        public bool IsBinary(string input)
        {
            foreach (char digit in input)
            {
                if (digit != '0' && digit != '1')
                {
                    return false; // The string contains a non-binary digit
                }
            }
            return true; // All characters in the string are '0' or '1'
        }

        public double Subtract(double num1, double num2)
        {
            return (num1 - num2);
        }
        public double Multiply(double num1, double num2)
        {
            return (num1 * num2);
        }
        public double Divide(double num1, double num2)
        {
            // lab 1
            //if (num1 == 0 || num2 == 0)
            //{
            //    throw new ArgumentException("cannot be zero");
            //}

            // lab 2
            if (num1 == num2)
            {
                return 1;
            }
            return (num1 / num2);
        }

        public int Factorial(int num1)
        {
            if (num1 < 0)
            {
                throw new ArgumentException("Cannot be negative");
            }

            if (num1 == 0)
            {
                return 1;
            }

            return num1 * Factorial(num1 - 1);
        }

        public double Triangle(double b, double h)
        {
            if (b <= 0 || h <= 0)
            {
                throw new ArgumentException("Both inputs must be non-negative.", nameof(b));
            }

            double result = (double)b * (double)h / 2;

            return result;
        }

        public double Circle(double r)
        {
            if (r <= 0)
            {
                throw new ArgumentException("Both inputs must be non-negative.", nameof(r));
            }

            double result = 3.142 * r * r;

            return result;
        }

        public double UnknownFunctionA(int n, int k)
        {
            if (n < 0 || k < 0)
            {
                throw new ArgumentException("Both n and k must be non-negative integers.");
            }

            if (k > n)
            {
                throw new ArgumentException("k cannot be greater than n.");
            }

            // Calculate n!
            double nFactorial = 1;
            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
            }

            // Calculate (n - k)!
            double nMinusKFactorial = 1;
            for (int i = 1; i <= (n - k); i++)
            {
                nMinusKFactorial *= i;
            }

            // Calculate result = n! / ((n - k)!)
            double result = nFactorial / nMinusKFactorial;

            return result;
        }


        public double UnknownFunctionB(int n, int k)
        {
            if (n < 0 || k < 0)
            {
                throw new ArgumentException("Both n and k must be non-negative integers.");
            }

            if (k > n)
            {
                throw new ArgumentException("k cannot be greater than n.");
            }

            if (k == 0)
            {
                return 1; // Special case: n choose 0 is 1
            }

            // Calculate n!
            double nFactorial = 1;
            for (int i = 1; i <= n; i++)
            {
                nFactorial *= i;
            }

            // Calculate k!
            double kFactorial = 1;
            for (int i = 1; i <= k; i++)
            {
                kFactorial *= i;
            }

            // Calculate (n - k)!
            double nMinusKFactorial = 1;
            for (int i = 1; i <= (n - k); i++)
            {
                nMinusKFactorial *= i;
            }

            // Calculate result = n! / (k! * (n - k)!)
            double result = nFactorial / (kFactorial * nMinusKFactorial);

            return result;
        }

        // lab 2
        public double Availability(int num1, int num2)
        {
            double divided = Divide(num1, num2);
            double result = divided * 100;
            // Round the result to 2dp
            result = Math.Round(result, 2);
            return result;
        }

        public int FailureIntensity(int initial, int average, int total)
        {
            double result = initial * (1 - ((double)average / total));
            // Round the result to the nearest integer
            return (int)Math.Round(result);
        }

        public double AverageFailure(int initial, int time, int total)
        {
            double powerOfE = ((double)initial / total) * time;
            double result = total * (1 - Math.Pow(Math.E, -powerOfE));
            // Round the result to the nearest integer
            return (int)Math.Round(result);
        }
    }
}
