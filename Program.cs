namespace home_18Sep
{
    internal class Program
    {
        public delegate void Functions();
        public void StartNewGame()
        {
            Console.WriteLine("Starting new game...");
        }

        public void LoadGame()
        {
            Console.WriteLine("Loading saved game...");
        }

        public void ShowRules()
        {
            Console.WriteLine("ffffffffffffffffffffffffffff RULES");
        }

        public void ShowAuthor()
        {
            Console.WriteLine("Andrii Hromanchuk");
        }

        public void Exit()
        {
            Console.WriteLine("Exiting");
        }

        static void Main(string[] args)
        {
            // https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/cs0120?f1url=%3FappId%3Droslyn%26k%3Dk(CS0120)
            var mc = new Program();

            Functions[] menu = new Functions[5] { mc.Exit, mc.StartNewGame, mc.LoadGame, mc.ShowRules, mc.ShowAuthor };

            Console.WriteLine("1 - New game");
            Console.WriteLine("2 - Load game");
            Console.WriteLine("3 - Rules");
            Console.WriteLine("4 - Author");
            Console.WriteLine("0 - Exit");
            int select = Convert.ToInt32(Console.ReadLine());

            menu[select]();
        }
    }
}