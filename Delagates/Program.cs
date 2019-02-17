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
            var cmd = new CommandProcessor()
            {
                Name = "Command 1"
            };

            cmd.Execute();

            Console.Read();
            
        }
    }
}
