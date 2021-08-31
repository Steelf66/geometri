using System;

namespace geometri
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Square square1 = new Square();
            square1.A = 14;

            Console.WriteLine(square1.perimeter());
            Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine(square1.area());
            Console.WriteLine();
            Console.WriteLine();
           

        }
    }
}
