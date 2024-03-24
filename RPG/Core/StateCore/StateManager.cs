using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Core.StateCore
{
    internal class StateManager
    {
        private State _currentState;
        public State CurrentState { 
            get 
            { 
                return _currentState; 
            } 
            private set
            {
                _currentState = value;
            }
        }

        public StateManager() {
            CurrentState = State.Entrance;
        }

        public void ChangeStateIf(bool statement, State state) {
            if (statement) {
                CurrentState = state;
            }
        }

        public bool IsCurrentState(State state) => CurrentState == state;
    }
}
