using System;
using System.Threading;

namespace Delagates
{
    public class CommandProcessor
    {
        public delegate void SequenceHandler(ICommand cmd);
        public event SequenceHandler SequenceStart;
        public event SequenceHandler SequenceEnd;

        public void Execute(ICommandSequence sequence)
        {            
            foreach(var command in sequence.Commands)
            {
                // Raise the OnSequenceStart event
                if (sequence.Commands.IndexOf(command) == 0)
                    OnSequenceStart(command);

                // Do some generic processing
                Console.WriteLine("Command Sent: " + command.Request);
                Thread.Sleep(2000);
                Console.WriteLine("Response Received: " + command.Response);

                // Raise the OnSequenceEndE event
                if (sequence.Commands.IndexOf(command) == sequence.Commands.Count - 1)
                    OnSequenceStop(command);
            }            
        }
        
        protected virtual void OnSequenceStart(ICommand cmd)
        {
            SequenceStart?.Invoke(cmd);
        }

        protected virtual void OnSequenceStop(ICommand cmd)
        {
            SequenceEnd?.Invoke(cmd);
        }
    }
}