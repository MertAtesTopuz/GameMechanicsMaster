using Mergen.UDCT.Utilities.DeveloperConsole.Commands;
using TMPro;
using UnityEngine;
using static UnityEngine.InputSystem.InputAction;

namespace Mergen.UDCT.Utilities.DeveloperConsole.Commands
{
    public class DebugConsoleBehaviour : MonoBehaviour
    {
        [SerializeField] private string prefix = string.Empty;
        [SerializeField] private ConsoleCommend[] commands = new ConsoleCommend[0];

        [Header("UI")]
        [SerializeField] private GameObject uiCanvas = null;
        [SerializeField] private TMP_InputField inputField = null;

        private static DebugConsoleBehaviour instance;

        private DebugConsole debugConsole;

        private DebugConsole DebugConsole
        {
            get
            {
                if (debugConsole != null)
                {
                    return debugConsole;
                }

                return debugConsole = new DebugConsole(prefix, commands);
            }
        }

        private void Awake()
        {
            if (instance != null && instance != this)
            {
                Destroy(gameObject);
                return;
            }

            instance = this;

            DontDestroyOnLoad(gameObject);
        }

        public void Toggle(CallbackContext context)
        {
            if (!context.action.triggered)
            {
                return;
            }

            if (uiCanvas.activeSelf)
            {
                CharacterController.instance.consoleCheck = false;
                uiCanvas.SetActive(false);
            }
            else
            {
                CharacterController.instance.consoleCheck = true;
                uiCanvas.SetActive(true);
                inputField.ActivateInputField();
            }
        }

        public void ProcessCommand(string inputValue)
        {
            DebugConsole.ProcessCommand(inputValue);
            inputField.text = string.Empty;
        }
    }

}
