using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
        bankaccount acc = new bankaccount();
         //   acc.ID = 1;
         //   acc.Deposit(20);
         //   acc.WithDraw(30);
         //   Console.WriteLine(acc.ToString());

           
            var account =new Dictionary<string, string>();
            string command;
            while((command = Console.ReadLine()) != "End")
            {
                var cmdArgs = command.Split();
                var id = int.Parse(cmdArgs[1]);
                if (acc.ContainsKey(id))
                    Console.WriteLine("Account already exist");
                else
                {
                   // var acc = new bankaccount();
                    acc.ID = id;
                    acc.Add(id, acc);
                }
                var cmdType = cmdArgs[0];   
                switch(cmdType)
                {
                    case "Create":  Create(cmdArgs[1],account); break;
                    case "Deposit":Deposit(cmdArgs[1],account); break;
                    case "WithDraw": WithDraw(cmdArgs[1], account); break;
                    case "Print": Print(cmdArgs[1], account); break;
                }

        }
    }
}
