using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._04._21_1
{

    public static class Program
    {
        public class TestCase
        {
            public int NUMBER { get; set; }
            public int Excpected { get; set; }
            public Exception ExcpectedException { get; set; }
        }

        static void TestNumber(TestCase testCase)
        {
            try
            {
                var actual = CheckNumber(testCase.NUMBER);

                if (actual == testCase.Excpected)
                {
                    Console.WriteLine("действительный тест");
                }
                else
                {
                    Console.WriteLine("недействительный тест");
                }
            }

            catch (Exception ex)
            {
                if (testCase.ExcpectedException != null)
                {
                    Console.WriteLine("действительный тест");
                }
                else
                {
                    Console.WriteLine("недействительный тест");
                }
            }

        }

        static void Main(string[] args)
        {
            var testCase1 = new TestCase()
            {
                NUMBER = 5,
                Excpected = 5,

            };

            TestNumber(testCase1);

        }

        static int CheckNumber(int number)
        {
            number = int.Parse(Console.ReadLine());
            int d = 0;
            int i = 2;

            while (i < number)
            {
                if (number % i == 0)
                {
                    d++;
                }
                else
                {
                    i++;
                }
                if (d == 0)
                {
                    Console.WriteLine("d-простое число");
                }
                else
                {
                    Console.WriteLine("d-непростое число");
                }
                break;
            }
            return number;
        }
    }
}