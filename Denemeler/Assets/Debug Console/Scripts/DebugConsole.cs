using Mergen.UDCT.Utilities.DeveloperConsole.Commands;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;

namespace Mergen.UDCT.Utilities.DeveloperConsole.Commands
{
    public class DebugConsole
    {
        private readonly string prefix;
        private readonly IEnumerable<IConsoleComand> commands;

        public DebugConsole(string prefix, IEnumerable<IConsoleComand> commands)
        {
            this.prefix = prefix;
            this.commands = commands;
        }

        public void ProcessCommand(string inputValue)
        {
            if (!inputValue.StartsWith(prefix))
            {
                return;
            }

            inputValue = inputValue.Remove(0, prefix.Length);

            string[] inputSplit = inputValue.Split(' ');

            string commandInput = inputSplit[0];
            string[] args = inputSplit.Skip(1).ToArray();

            ProcessCommand(commandInput, args);
        }

        public void ProcessCommand(string commandInput, string[] args)
        {
            foreach (var command in commands)
            {
                if (!commandInput.Equals(command.CommandWord, StringComparison.OrdinalIgnoreCase))
                {
                    continue;
                }

                if (command.Process(args))
                {
                    return;
                }
            }
        }

    }
}
