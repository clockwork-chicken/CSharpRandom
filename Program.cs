using System;

namespace Csharp_learning_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;

            for (int x = 0; x < 10000 ; x += 1)
            {
                int y = new Random().Next(1, 50);
                int z = y * 2 + 1;
                if (z > 100)
                {
                    Console.WriteLine("Containment Breach");
                    break;
                }
                    
                Console.WriteLine(z);

            }
            // Console.WriteLine("The total is " + total);
        }
    }
}
