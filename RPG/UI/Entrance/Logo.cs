using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.UI.Entrance
{
    internal class Logo
    {
        public void Draw()
        {
            //https://patorjk.com/software/taag/#p=display&f=ANSI%20Shadow&t=ARKANII!
            //ANSI Shadow
            //Name: Legenda Arkanii
            string[] introduction_phrase = [
                " _ _ _ _ _         _          ",
                "| | | |_| |_ ___  |_|   _ _ _ ",
                "| | | | |  _| .'| | |  | | | |",
                "|_____|_|_| |__,|_| |  |_____|",
                "                |___|         "];
            string[] logo_upper = [
                "██╗     ███████╗ ██████╗ ███████╗███╗   ██╗██████╗ ███████╗██╗███████╗",
                "██║     ██╔════╝██╔════╝ ██╔════╝████╗  ██║██╔══██╗╚══███╔╝██║██╔════╝",
                "██║     █████╗  ██║  ███╗█████╗  ██╔██╗ ██║██║  ██║  ███╔╝ ██║█████╗  ",
                "██║     ██╔══╝  ██║   ██║██╔══╝  ██║╚██╗██║██║  ██║ ███╔╝  ██║██╔══╝  ",
                "███████╗███████╗╚██████╔╝███████╗██║ ╚████║██████╔╝███████╗██║███████╗",
                "╚══════╝╚══════╝ ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚═════╝ ╚══════╝╚═╝╚══════╝"];
            string[] logo_lower = [
                " █████╗ ██████╗ ██╗  ██╗ █████╗ ███╗   ██╗██╗██╗██╗",
                "██╔══██╗██╔══██╗██║ ██╔╝██╔══██╗████╗  ██║██║██║██║",
                "███████║██████╔╝█████╔╝ ███████║██╔██╗ ██║██║██║██║",
                "██╔══██║██╔══██╗██╔═██╗ ██╔══██║██║╚██╗██║██║██║╚═╝",
                "██║  ██║██║  ██║██║  ██╗██║  ██║██║ ╚████║██║██║██╗",
                "╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝╚═╝╚═╝"
                ];
            string continue_phrase = "Press [Enter] to continue!";
            string separator = "═════════════════════════════════(  )═════════════════════════════════";

            foreach (string line in introduction_phrase) {
                WriteLineCenter(line);
            }
            Console.WriteLine();
            foreach (string logo in logo_upper)
            {
                WriteLineCenter(logo);
            }
            WriteLineCenter(separator);
            Console.WriteLine();
            foreach (string logo in logo_lower)
            {
                WriteLineCenter(logo);
            }
            Console.WriteLine();
            WriteLineCenter(continue_phrase);
        }

        private void WriteLineCenter(string phrase)
        {
            CenterCursor(phrase);
            Console.WriteLine(phrase);
        }

        private void CenterCursor(string phrase) =>
            Console.SetCursorPosition((Console.WindowWidth - phrase.Length) / 2, Console.CursorTop);
    }
}
