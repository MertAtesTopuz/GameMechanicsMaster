using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Mergen.UDCT.Utilities.DeveloperConsole.Commands
{
    public abstract class ConsoleCommend : ScriptableObject, IConsoleComand
    {
        [SerializeField] private string commandWord = string.Empty;

        public string CommandWord => commandWord;

        public abstract bool Process(string[] args);
    }
}