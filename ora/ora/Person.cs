using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ora
{
    internal class Person
    {
        public string name;
        public int age;
        public string grad;
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }
        public string Grad
        {
            get { return this.grad; }
            set { this.grad = value; }  
        }
    }
}
