using System;
namespace CheckPrime
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            if (IsPrime(n))
            {
                Console.WriteLine("{0} является простым", n);
            }
            else
            {
                Console.WriteLine("{0} не является простым", n);
            }
        }

        static bool IsPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
