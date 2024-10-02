using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behave_Patterns.Command
{
    public class CommandHistory
    {
        private readonly Stack<ICommand> _commands = new Stack<ICommand>();

        public void Push(ICommand command)
        {
            _commands.Push(command);
        }

        public ICommand Pop()
        {
           return _commands.Pop();
        }
    }

}
