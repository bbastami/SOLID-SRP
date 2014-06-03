using System;

namespace BadDesign
{
    public class BigClass
    {
        public void read()
        {
            Console.WriteLine("BigClass.read()");
        }

        public void parse()
        {
            Console.WriteLine("BigClass.parse()");
        }

        public void save()
        {
            Console.WriteLine("BigClass.save()");
        }
    }
}
