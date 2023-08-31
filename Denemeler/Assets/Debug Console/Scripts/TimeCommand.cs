using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mergen.UDCT.Utilities.DeveloperConsole.Commands
{
    [CreateAssetMenu(fileName = "New Time Command", menuName = "Debug Console/Time Commands")]

    public class TimeCommand : ConsoleCommend
    {
        public override bool Process(string[] args)
        {

            if (args.Length != 1)
            {
                return false;
            }

            if (!int.TryParse(args[0], out int value) || (value < 0 && value > 1))
            {
                return false;
            }

            Time.timeScale = value;

            return true;
        }
    }

}