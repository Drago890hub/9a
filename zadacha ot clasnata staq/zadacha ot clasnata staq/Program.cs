using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha_ot_clasnata_staq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("kolko elementa da e masiva");
          
            int n = int.Parse(Console.ReadLine());
           
            string[] pitie = new string[n];
            
            int[] brpitie = new int[n];
            
            double[] cena = new double[n];
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine("ime na pitie");
                pitie[i] = Console.ReadLine();
                Console.WriteLine("broi");
                brpitie[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("cena");
                cena[i] = int.Parse(Console.ReadLine());    
            }
            //1 
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(cena[i] +"/" + pitie[i] +"/" + brpitie[i]);
            }
            //2
            if (brpitie[n]>2.50)
            {
                Console.WriteLine( cena + "/" + pitie + "/" + brpitie);
            }
            //3
            if (cena[n]>2)
            {
                Console.WriteLine( cena + "/" + pitie + "/" + brpitie);
            }
            //4
            Array.Sort(pitie);
            for(int i = 0; i < n;i++)
            {
                Console.WriteLine( cena + "/" + pitie + "/" + brpitie);
            }

            //5
            for(int i = 0; i < n;)
            {
                if (brpitie[i] == 3)
                {
                    Console.WriteLine(cena + "/" + pitie + "/" + brpitie);
                }
            }

         //6
            Console.WriteLine(pitie[0]);
            Console.WriteLine(brpitie[1]);
            Console.WriteLine(cena[2]);

            //7  
            for (int i = 0; i < n;)
            {
                Console.WriteLine(cena + "/" + pitie + "/" + brpitie);
            }
        }
    }
}
