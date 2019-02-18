using Delagates.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delagates.CommandSequences
{
    public class BasicSequence : ICommandSequence
    {
        public BasicSequence()
        {
            Commands = new List<ICommand>()
            {
                new Online(),
                new Offline(),
            };
        }

        public List<ICommand> Commands { get; set; }
    }
}
