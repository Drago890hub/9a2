using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace _18._03._24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kolko chisla shte vuvejdash");
            int n = int.Parse(Console.ReadLine());  
            List<int> list = new List<int>();
            //vxod
            for (int i = 0;i <n;i++)
            {
                list.Add(int.Parse(Console.ReadLine()));
            }
            //1
            for(int index =0; index<list.Count;index++)
            {
                Console.Write("list[{0}] = {1}", (index+1), list[index]); 
            }
            //2
            for (int index = 0; index < list.Count; index++)
            {
                if (list[index] ==(list[index]-1))
 Console.WriteLine("list[{0}] = {1}", index+1, list[index]);
                {
                    
                   list.RemoveAt(index);
                  index--;
                  
                }
                 
            }
          
           
            
           
               

        }
    }
}
