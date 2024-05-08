using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kolko shte vuvediesh");
            int n = int.Parse(Console.ReadLine());
            Console.Write("kolko puti shte zavurtam");
            int k = int.Parse(Console.ReadLine());
            int[] number = new int[n];
            int[] sum = new int[n];
            for (int i = 0; i < 5; i++)
            {

                Console.WriteLine("vuvedi chislo");
                number[i] = int.Parse(Console.ReadLine());
                sum[i] = 0;

            }
            //izxod
            for (int i = 1; i < k; i++)
            {

                Console.WriteLine("vuvedi chislo");
                number[i] = int.Parse(Console.ReadLine());
            
            }
            for (int r = 1; r < n; r++)
            {
                for(int i = 0; i <n; i++) 
                {
                    r = r + i + k;
                }

            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(number[i]);
            }
            Console.WriteLine("izxod bez posleden element");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(number[i]);
            }
            //normalen izxod
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine();
                Console.WriteLine(" ",number);

            }
        }
    }
}
