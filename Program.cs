using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    internal class Program
    {
        static void Main(string[] args)
        {
        //ax^2+bx+ c = 0
        Console.WriteLine("rozwiązywanie równania w postaci");
        Console.WriteLine("Ax^2 +Bx+c=0"); 
            int wspA, wspB, wspC;
            Console.WriteLine("Podaj wspolczynnik A: ");
            wspA = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj wspolczynnik B: ");
            wspB = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Podaj wspolczynnik C: ");
            wspC = Int32.Parse(Console.ReadLine());

        double delta = Math.Pow(wspB,2) - 4 * wspA * wspC;
        Console.WriteLine("Delta równania wynosi: " +delta);
        if (delta > 0)
        {
            //pierwiastek 1
            double x1 = (double)(-wspB - Math.Sqrt(delta)) / 2 * wspA;
            Console.WriteLine("Rozwiązanie 1: " + x1);
            //pierwiastek2
            double x2 = (double)(-wspB + Math.Sqrt(delta)) / 2 * wspA;
            Console.WriteLine("Rozwiązanie 2: " + x2);
        }
        else if(delta == 0) 
        {

            double x1 = (double)-wspB / 2 * wspA;
            Console.WriteLine("Rozwiązanie: " + x1);
        
        }
        else
        {
            Console.WriteLine("Brak rozwiązania");
        }
        
        Console.ReadLine();
        
        }
      
    }
