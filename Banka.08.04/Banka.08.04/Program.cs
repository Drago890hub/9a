using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Banka._08._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
           BankAccount acc = new BankAccount();
            
            acc.Id = 1;
            Console.WriteLine("kolko shte vkarvash");
             int Deposit = int.Parse(Console.ReadLine());   
         acc.Deposit(0);
            
            Console.WriteLine("kolko shte teglish");
            double WithDraw = double.Parse(Console.ReadLine());
           acc.WithDraw(0);
            
            Console.WriteLine(acc.ToString());
            if(WithDraw>acc.Balance)
             {
                Console.WriteLine();
             }
            //MethodInfo oldestmemberMethod = typeof(family).GetMethod("GeOldestMember");
            //MethodInfo addMemberMethod = typeof(family).GetMethod("AddMember");
            //if(oldestmemberMethod == null || addMemberMethod == null)
            //{
            //    Console.WriteLine(oldestmemberMethod);
            //}
           person person = new person();
            Console.WriteLine("kak se kazvash");
            string Name = Console.ReadLine();   
            person.Name ="";
            Console.WriteLine("na kolko godini si");
            int Age = int.Parse(Console.ReadLine());
            person.Age = 0;

        }
    }
}
