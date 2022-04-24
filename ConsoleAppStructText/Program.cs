using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppStructText
{
    internal class Program
    {
        static void RandomMas(int[] mas)
        {
            Random random = new Random();

            for (int i = 0; i < mas.Length; i++)
            {
                mas[i] = random.Next(0, 100);
            }

           
        }

        static void PrintMas(int[] mas)
        {
            for (int i = 0; i < mas.Length; i++)
            {
                Console.Write(mas[i] + " ");
            }
            Console.WriteLine();
        }

        static void ResizeMas(ref int[] mas, int newLength)
        {
            int[] temp = new int[newLength];

            for (int i = 0; i < mas.Length; i++)
            {
                temp[i] = mas[i];
            }

            mas = temp;
        }

        static void Main(string[] args)
        {
            int[] mas = new int[5];

            RandomMas(mas);
            PrintMas(mas);

            ResizeMas(ref mas, 6);
           
            mas[mas.Length - 1] = 1111;

            PrintMas(mas);
            

            Console.ReadKey();
        }
    }
}
