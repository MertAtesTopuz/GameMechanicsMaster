using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Mergen.UDCT.Utilities.DeveloperConsole.Commands
{
    [CreateAssetMenu(fileName = "New Gravity Command", menuName = "Debug Console/Gravity Commands")]

    public class GravityCommand : ConsoleCommend
    {
        public override bool Process(string[] args)
        {
            if (args.Length != 1)
            {
                return false;
            }

            if (!float.TryParse(args[0], out float value))
            {
                return false;
            }

            Physics.gravity = new Vector3(Physics.gravity.x, value, Physics.gravity.z);

            return true;
        }
    }

}