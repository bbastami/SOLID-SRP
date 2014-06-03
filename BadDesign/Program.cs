using System;

namespace BadDesign
{
    class Program
    {
        static void Main(string[] args)
        {
            BigClass bc = new BigClass();

            bc.read();
            bc.parse();
            bc.save();

            Console.ReadKey(true);
        }
    }
}
