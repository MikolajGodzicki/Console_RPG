namespace RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //https://patorjk.com/software/taag/#p=display&f=ANSI%20Shadow&t=ARKANII!
            //ANSI Shadow
            //Name: Legenda Arkanii
            string s = "Witaj w";
            string logo1 = "\r\n██╗     ███████╗ ██████╗ ███████╗███╗   ██╗██████╗ ███████╗██╗███████╗\r\n██║     ██╔════╝██╔════╝ ██╔════╝████╗  ██║██╔══██╗╚══███╔╝██║██╔════╝\r\n██║     █████╗  ██║  ███╗█████╗  ██╔██╗ ██║██║  ██║  ███╔╝ ██║█████╗  \r\n██║     ██╔══╝  ██║   ██║██╔══╝  ██║╚██╗██║██║  ██║ ███╔╝  ██║██╔══╝  \r\n███████╗███████╗╚██████╔╝███████╗██║ ╚████║██████╔╝███████╗██║███████╗\r\n╚══════╝╚══════╝ ╚═════╝ ╚══════╝╚═╝  ╚═══╝╚═════╝ ╚══════╝╚═╝╚══════╝\r\n═════════════════════════════════(  )═════════════════════════════════";
            string logo2 = " █████╗ ██████╗ ██╗  ██╗ █████╗ ███╗   ██╗██╗██╗██╗\r\n██╔══██╗██╔══██╗██║ ██╔╝██╔══██╗████╗  ██║██║██║██║\r\n███████║██████╔╝█████╔╝ ███████║██╔██╗ ██║██║██║██║\r\n██╔══██║██╔══██╗██╔═██╗ ██╔══██║██║╚██╗██║██║██║╚═╝\r\n██║  ██║██║  ██║██║  ██╗██║  ██║██║ ╚████║██║██║██╗\r\n╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═╝╚═╝  ╚═══╝╚═╝╚═╝╚═╝\r\n                                                   \r\n";
            Console.SetCursorPosition((Console.WindowWidth - s.Length) / 2, Console.CursorTop);
            Console.WriteLine("Witaj w");
            Console.SetCursorPosition((Console.WindowWidth - logo1.Split('\r')[0].Length) / 2, Console.CursorTop);
            Console.WriteLine(logo1);
            Console.SetCursorPosition((Console.WindowWidth - logo2.Split('\r')[0].Length) / 2, Console.CursorTop);
            Console.WriteLine(logo2);
        }
    }
}
