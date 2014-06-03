using System;

namespace BetterDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            Processor p = new Processor();
            p.process();

            Console.ReadKey(true);
        }
    }
}
