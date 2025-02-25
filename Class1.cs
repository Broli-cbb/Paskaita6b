using System;

namespace Paskaita6b
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Random random = new Random();



            int[] pirmasMasyvas = new int[10];


            for (int i = 0; i < 10; i++)

            {

                pirmasMasyvas[i] = random.Next(1, 101);
                Console.WriteLine(pirmasMasyvas[i]);
                

            }
            
            /*
            while (true)
            {
                    
                int a = int.Parse(Console.ReadLine());
                    
                if (a % 2 == 0)
                {
                    Console.WriteLine("SKaicius lyginis");
                        
                }
                else if (a % 2 != 0)
                {
                    Console.WriteLine("Skaicius nelyginis");
                        
                }
                else
                {
                    Console.WriteLine("Bloga ivestis");
                        
                }
                */


//  Console.WriteLine(pirmasMasyvas);

           

        }
    }
}

