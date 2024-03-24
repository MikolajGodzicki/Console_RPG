using RPG.Core.StateCore;
using RPG.UI.Entrance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.UI {
    internal class WindowManager {

        public void Render(State state) {
            Console.Clear();
            switch (state) {
                case State.Entrance:
                    Logo logo = new Logo();
                    logo.Draw();
                    break;
                case State.Main:
                    Console.WriteLine("Main");
                    break;
            }
        }
    }
}
