using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delagates
{
    public interface ICommand
    {
        CommandTypes Type { get; set; }
        string Name { get; set; }
        string Request { get; set; }
        string Response { get; set; }
    }
}
