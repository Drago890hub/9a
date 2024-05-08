using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine("n=");
            int n = int.Parse(Console.ReadLine());
            for(int i =0;i<n; i++)
            {
                Console.WriteLine("Kak se kazvash");
                person.name = Console.ReadLine();
                Console.WriteLine("na kolko godini si");
                person.age = int.Parse(Console.ReadLine());  
                Console.WriteLine("ot kude si");
                person.grad = Console.ReadLine();
                Console.WriteLine($"{person.name} , {person.age} , {person.grad}");
           
            }
            if( person.grad=="Sopot")
            {
                Console.WriteLine($"{person.name} , {person.age} , {person.grad}");
            }
            else
            {
                Console.WriteLine("ne e ot Sopot");
            }
        }
    }
}
