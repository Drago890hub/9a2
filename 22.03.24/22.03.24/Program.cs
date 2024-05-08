using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._03._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] name = new string[n];
            int[] number = new int[n];
            string[] subjeckt = new string[n];
            double[] ocenka = new double[n];

            //vxod
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("kak se kazvash");
                name[i] = Console.ReadLine();
                Console.WriteLine("koi nomer v klas si");
                number[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("po koi predemt");
                subjeckt[i] = Console.ReadLine();
                Console.WriteLine("kolko imash");
                ocenka[i] = double.Parse(Console.ReadLine());   

            }
            //izhod1
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("az " + name[i] + " s nomer v klas " + number[i] + " po " + subjeckt[i] + " imam " + ocenka[i]);


            }
            //2
            for (int i = 0; i < n; i++)
            {
                if (ocenka[i] > 5)
                    Console.WriteLine(ocenka);

            }
            //3
            int[] arr = new int[n];
            for (int i = 0; i < subjeckt.Length - 1; i++)
            {

                for (int j = 0; j < subjeckt.Length - 1; i++)
                {
                    if (StringComparer(subjeckt[j], subjeckt[j+1])>0)
                    {
                        var swapVar = subjeckt[j];
                        subjeckt[i] = subjeckt[j+ 1];
                        subjeckt[j + 1] = subjeckt[j];
                        subjeckt[j + 1] = swapVar; 
                    }
                }
            }

            for (int i = 0; i < subjeckt.Length; i++)
            {
                Console.WriteLine(subjeckt[i] + " ");
            }
            //4


           
        }

        private static int StringComparer(string v1, string v2) => throw new NotImplementedException();
    }
}
