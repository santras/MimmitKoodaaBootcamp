using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Herätys Sanna!");

            Console.WriteLine("Anna kokonaisluku:");
            string kayttajaInput = Console.ReadLine();
            int ii = Convert.ToInt32(kayttajaInput);

            Console.WriteLine("Anna toinen kokonaisluku:");
            string kayttajaInput2 = Console.ReadLine();
            int jj = Convert.ToInt32(kayttajaInput2);
            

            // Console.WriteLine("Anna kokonaisluku:");
            // string kayttajaInput2 = Console.ReadLine();
            // try
            // {
            //     int jj = Convert.ToInt32(kayttajaInput2);
            // }
            // catch(FormatException)
            // {
            //     Console.WriteLine("Luvun pitää olla kokonaisluku, kokeile uudelleen:");   
            // }
           
            Console.WriteLine("Lukujen summma on:"+(ii+jj));
        }
    }
}
