using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2
{
    internal class BankAccount
    {
        private int id;
        private int balance;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public int Balance
        { get { return balance; } 
            set { balance = value; } 
        }
       
    }
}
