using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Banka._08._04
{
    internal class person
    {
        private int age;
        private string name;
      private List<BankAccount> accounts;
        public  String Name
        {
           get { return name; } 
            set { name = value; }

        }
        public int Age
        { 
            get { return age; }
            set {  age = value; } 
        }
        public override string ToString()
        {
            return $"Name{this.name}, age{this.age}";
        }
    }
}
