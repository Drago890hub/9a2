using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._04
{
    internal class bankaccount
    {
        private int id;
        private double balance;
        

        public int ID
        {
            get { return  this.id; }
            set {this.id = value; }

        }
        public double Balance
        {
            get { return this. balance; } 
            set { this.balance = value; }    
        }
        public void Deposit(double amount)
        {
            this.balance += amount;
        }
        public void WithDraw(double amount)
        {
            this.balance -= amount;
        }
        public override string ToString()
        {
            return $"account{this.id},balance {this.balance}";
        }

        internal bool ContainsKey(int id)
        {
            throw new NotImplementedException();
        }

        internal void Add(int id, bankaccount acc)
        {
            throw new NotImplementedException();
        }
    }
}
