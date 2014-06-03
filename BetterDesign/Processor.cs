using System;

namespace BetterDesign
{
    public class Processor
    {
        Reader reader;
        Parser parser;
        Writer writer;

        public Processor()
        {
            reader = new Reader();
            parser = new Parser();
            writer = new Writer();
        }

        public void process()
        {
            Console.WriteLine("Processor.process()");
            reader.read();
            parser.parse();
            writer.save();
        }
    }
}
