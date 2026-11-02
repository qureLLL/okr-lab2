using System;

namespace OkrLab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== OKR Lab 2: Git Teamwork ===");
            Console.WriteLine("Developers: Nikita Datskyi & Maksym Davydiak");
            PrintInfo();
            Console.WriteLine($"Sum(12, 8) = {Add(12, 8)}");
            Console.WriteLine($"Multiply(6, 7) = {Multiply(6, 7)}");
            Console.WriteLine($"Power(2, 5) = {Power(2, 5)}");
        }

        static void PrintInfo()
        {
            Console.WriteLine("Module: Calculation logic by Nikita & Max");
        }

        static int Add(int a, int b) => a + b;

        static int Multiply(int a, int b) => a * b;

        static double Power(double x, int exp) => Math.Pow(x, exp);
    }
}
