using System;

namespace Arvauspeli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tämä on arvauspeli. Mitä on salainen luku?");
            Random randomi = new Random();
            int luku  = randomi.Next(1, 20);
            Boolean oikeinko = false;

            for(int i = 1; i < 4; i++)
            {
                string arvaus = Console.ReadLine();
                int eka = int.Parse(arvaus);
                if (eka == luku)
                {
                    Console.WriteLine("Hurraa!!");
                    oikeinko = true;
                    break;
                }
                else if (eka<luku)
                {
                    Console.WriteLine("Arvauksesi on liian pieni.");
                }
                else
                {
                    Console.WriteLine("Arvauksesi on liian suuri.");
                }
            }
            if (oikeinko)
            {
               Console.WriteLine("Arvasit oikein!"); 
            }
            else
            {
                Console.WriteLine("Arvasit väärin, luku oli: "+luku); 
            }

        }
    }
}
