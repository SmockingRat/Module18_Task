using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module18_Task
{
    class Sender
    {

        Command command;

        public void SetCommand(Command _command)
        {
            command = _command;
        }

        public void Run()
        {
            command.Run();
        }

    }
}
