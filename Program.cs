using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silnia
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę");
            int n = Int32.Parse(Console.ReadLine());

            //silnia rekurencyjnie

            int silnia1(int i)
            {
                if (i < 1)
                    return 1;
                else
                    return i * silnia1(i - 1);

            }

            //silnia iteracyjnia
            int silnia2(int a)
            {
                int result = 1;
                for (int i = 1; i <= a; i++)
                {
                    result *= i;
                }
                return result;
            }

            Console.WriteLine($"{n}! = {silnia1(n)}");
            Console.WriteLine($"{n}! = {silnia2(n)}");
            Console.ReadKey();


        }
    }
}
