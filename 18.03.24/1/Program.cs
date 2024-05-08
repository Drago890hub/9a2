using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vuvedi chisla");

            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            for (int index = 0; index < nums.Count; index++)
            {
                if (nums[index] % 2 == 0)

                    Console.WriteLine(nums[index]);

            }
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int start = 0;


            for (int index = 0; index < list.Count; index++)
            {
               if (list[index]<0)
                    Console.WriteLine(nums[index]);
            }
            //1
            for (int index = 0; index < list.Count; index++)
            {
                if (list[index] <0)
                    Console.WriteLine(nums[index]);
            }
            Console.WriteLine("samo -5 i -20");

            for (int index = 0; index < list.Count; index++)

            {
                if (list[index] <0)
                    index = 1;
                index = 2;
               Console.WriteLine(nums[index]);
            }
 
           






        }
    }
}
