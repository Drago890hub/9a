using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banka._08._04
{
    internal class BankAccount
    {
        private int id;
        private double balnace;
     
        public int Id
       {
            get { return this.id; }
            set { this.id = value; }
        }
 public double Balance
        { 
            get { return this.balnace;}
            set { this.balnace = value; }
         }

        public void Deposit(double amount)
        {
            this.balnace += amount;
        }
        public void WithDraw(double amount)
        {
            this.balnace -= amount;
        }
        public  override string ToString() 
        {
            return $"account{this.id}, balance{this.balnace}";
        }
       
    }
}
