using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delagates.Commands
{
    public class Offline : ICommand
    {
        public Offline()
        {
            Type = CommandTypes.Action;
            Name = "Offline";
            Request = "SMAN";
            Response = "SMAN K0OK";
        }

        public CommandTypes Type { get; set; }
        public string Name { get; set; }
        public string Request { get; set; }
        public string Response { get; set; }
    }
}
