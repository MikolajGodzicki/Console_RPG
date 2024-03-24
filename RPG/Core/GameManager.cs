
using RPG.Core.StateCore;
using RPG.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Core {
    internal class GameManager {
        private WindowManager _windowManager;
        private StateManager _stateManager;

        public GameManager() {
            _windowManager = new WindowManager();
            _stateManager = new StateManager();
        }

        public void Start() {
            while (true) {
                _windowManager.Render(_stateManager.CurrentState);
                HandleKeyboard();
            }
        }

        private void HandleKeyboard() {
            ConsoleKey _key = Console.ReadKey().Key;

            switch (_key) {
                case ConsoleKey.Enter:
                    _stateManager.ChangeStateIf(_stateManager.IsCurrentState(State.Entrance), State.Main);
                    break;
            }
        }
    }
}
