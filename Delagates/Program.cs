using Delagates.CommandSequences;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delagates
{
    class Program
    {        
        static void Main(string[] args)
        {
            // New sequence that contains only 2 commands
            var seq = new BasicSequence();
            var processor = new CommandProcessor();

            // Attach anonymous event handler to the processors SequenceStart, Sequence end events 
            processor.SequenceStart += (cmd) => Console.WriteLine("Sequence Started With Command: " + cmd.Name);
            processor.SequenceEnd += (cmd) => Console.WriteLine("Sequence Stopped! With Command: " + cmd.Name);

            // Execute the sequence processor
            processor.Execute(seq);          

            Console.Read();
            
        }
    }
}
