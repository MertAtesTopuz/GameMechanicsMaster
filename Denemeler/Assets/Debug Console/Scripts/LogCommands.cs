using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mergen.UDCT.Utilities.DeveloperConsole.Commands
{
    [CreateAssetMenu(fileName = "New Log Command", menuName = "Debug Console/Log Commands")]

    public class LogCommands : ConsoleCommend
    {
        public override bool Process(string[] args)
        {
            string logText = string.Join(" ", args);

            Debug.Log(logText);

            return true;
        }
    }

}
