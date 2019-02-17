using System;

namespace Delagates
{
    public class CommandProcessor
    {
        public delegate void CommandHanlder();
        
        public string Name { get; set; }

        public void Execute()
        {
            var online = new CommandHanlder(Online);
            var offline = new CommandHanlder(Offline);

            var handler = online + offline;

            handler();
        }
        
        private void Online()
        {
            Console.WriteLine("Online Executed");
        }

        private void Offline()
        {
            Console.WriteLine("Offline Executed");
        }
    }
}