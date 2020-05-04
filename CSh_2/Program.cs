using System;

namespace CSh_2
{
    class Program
    {
        static void Main()
        {
            Console.Write("x = ");
            float x = float.Parse(Console.ReadLine());

            Console.Write("y = ");
            float y = float.Parse(Console.ReadLine());

            if(y > 25 || y < -25 || x > 50 || x < -50)
                Console.WriteLine("вне");

            else if(y == 25 && x * x < 2500 || x == 50 && y * y < 625)
                Console.WriteLine("на границе");

            else
                Console.WriteLine("внутри");


            Console.ReadKey();
        }
    }
}
