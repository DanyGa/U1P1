using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorEnTiempoDeEjec
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Vector = new int[13] { 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };

            Console.WriteLine("Lista de numeros del 7 al 19");
            for (int y = 0; y < 13; y++)
            {
                Console.WriteLine(Vector[y]);
            }

            Console.ReadKey();
        }
    }
}
