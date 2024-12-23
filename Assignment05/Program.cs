using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Schema;

namespace Assignment05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*
             * Passing value type by value: is passing the value that the variable is storing to the function's local variable
             * by reference: is passing the address of the container itself so function can access the original variable
             */
            #endregion

            #region Q2
            /*
             * passing ref type by value: is passing the value of the reference which is the address of the heap storage
             *      that is storing the values 
             * by ref: is passing the address of the reference itself to the function so the function can access the 
             *      reference directly which can lead to lose access to the heap storage if changed
             */
            #endregion

            #region Q3
            //Write a c# Function that accept 4 parameters from user and return result of summation 
            //and subtracting of two numbers

            //int sum = 0;
            //int sub = 0;
            //int n1 = int.Parse(Console.ReadLine());
            //int n2 = int.Parse(Console.ReadLine());
            //FuncQ3(n1,n2,out sum, ref sub);
            //Console.WriteLine($"sum = {sum}, sub = {sub}");


            #endregion

            #region Q4

            //string str = "25";
            //int sum = FuncQ4(str);
            //Console.WriteLine(sum);

            #endregion

            #region Q5

            //Console.WriteLine("Enter a number");
            //int n = int.Parse(Console.ReadLine());

            //if (IsPrime(n)) Console.WriteLine("Number is Prime");
            //else Console.WriteLine("Number is not Prime");

            #endregion

            #region Q6

            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int max = default, min = default;
            //MinMaxArray(arr, ref min, ref max);
            //Console.WriteLine($"Max = {max}, Min = {min}");

            #endregion

            #region Q7

            //Console.WriteLine("Enter a number:");
            //int n = int.Parse(Console.ReadLine());
            //Console.WriteLine($"{n}! = {Factorial(n)}");

            #endregion

            #region Q8

            //string str = "Hello";

            //Console.WriteLine(ChangeChar(str, 1, 'E'));

            #endregion

        }

        // Q3
        static void FuncQ3(int n1, int n2, out int sum, ref int sub)
        {
            sum = n1 + n2;
            sub = n1 - n2;
        }

        // Q4
        static int FuncQ4(string str)
        {
            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                sum += int.Parse(str[i].ToString());
            }
            return sum;
        }

        // Q5
        static Boolean IsPrime(int n)
        {
            Boolean isPrime = true;
            for (int i = 2;i<=n/2;i++)
                if (n%i == 0)
                {
                    isPrime = false;
                    break;
                }    

            return isPrime;
        }

        // Q6
        static void MinMaxArray(int[] arr, ref int min, ref int max)
        {
            min = arr[0];
            max = arr[0];   
            foreach (int i in arr)
            {
                if (i < min) min = i;
                if (i > max) max = i;
            }
        }

        // Q7
        static int Factorial(int n)
        {
            int Fac = 1;
            for (int i = 1;i<n;i++) Fac *= n;
            return Fac;
        }

        // Q8
        static string ChangeChar(string str, int i, char c)
        {
            string s = str.Substring(0,i) + c + str.Substring(i+1);
            return s;
        }
    }
}
