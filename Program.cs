using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silnia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę");
            int n = Int32.Parse(Console.ReadLine());

            //silnia iteracyjnie

            int silnia1(int i)
            {
                if (i < 1)
                    return 1;
                else
                    return i * silnia1(i - 1);

            }

            

        }
    }
}
