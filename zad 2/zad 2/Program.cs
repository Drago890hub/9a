using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person persons = new Person();
            Console.WriteLine("kolko danni shte vkarvash");
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i <n;i++)
            {
                Console.WriteLine("Kak se kazvash");
                persons.name = Console.ReadLine();
                Console.WriteLine("na kolko godini si");
                persons.age = int.Parse(Console.ReadLine());

            }
            for(int i =0; i <n;i++)
            {
                Console.WriteLine(persons. name);
                Console.WriteLine(persons .age);
            }
        }
    }
}
