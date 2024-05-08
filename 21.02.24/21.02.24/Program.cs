using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21._02._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kolko bukvi shte vuvedesh");
            int n = int.Parse(Console.ReadLine());
            string[] bukva = new string[n];
            //vxod
            for (int i = 0; i < n; i++)
            {
                bukva[i] = Console.ReadLine();
            }
            //izxod na obratno
            for (int i = 0; i >= n-1; i--)
            {
                Console.WriteLine(bukva[i]);
            }
            
            
            for (int i = n - 1; i >= 0; i--)
            {
                Console.WriteLine(bukva[i]);
            }
        }
        }
    }

