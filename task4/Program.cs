using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            bool f;
            do
            {
                Console.WriteLine("Ввести N= ");
                f = int.TryParse(Console.ReadLine(), out N);
                if (!f)
                {
                    Console.WriteLine("Помилка введіть ще раз");
                }
            } while (!f);
            int[] arr = new int[N];

            int min = int.MaxValue;
            int index = 0;
            int sum = 1;
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(-2, 4);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i]);
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                    index = i;
                }
            }
            index += 1;
            for (int i = index; i < arr.Length; i++)
            {

                sum *= arr[i];
            }
            Console.WriteLine("\nСума = " + sum);

            Console.ReadKey();
        }




    }

}
