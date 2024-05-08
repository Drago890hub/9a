using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2
{
    internal class Person
    {
        public string name;
        public int age;
        public int accounts;
     
        public string Name
        {
            get { return name; }
            set { name = value; }   
        }
        
        public int Age
        {
            get { return age; } 
            set { age = value; }
        }
        public int Accounts
        {
            get { return this.Accounts; }
            set { this.Accounts = value; }  
        }
        //private List<Person>accounts
        //{
        //    get { return this.accounts; }
        //    set { this.accounts = value; }
        //}
       
        }
    }

