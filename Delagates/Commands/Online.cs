using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delagates.Commands
{
    public class Online : ICommand
    {
        public Online()
        {
            Type = CommandTypes.Action;
            Name = "Online";
            Request = "SREM";
            Response = "SREM K0OK";
        }

        public CommandTypes Type { get; set; }
        public string Name { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
    }
}
