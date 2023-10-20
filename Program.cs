namespace home_18Sep
{
    internal class Program
    {
        public delegate void Functions();     

        static void Main(string[] args)
        {
            Menu m = new Menu();

            Functions[] menu = new Functions[5] { m.Exit, m.StartNewGame, m.LoadGame, m.ShowRules, m.ShowAuthor };

            Console.WriteLine("1 - New game");
            Console.WriteLine("2 - Load game");
            Console.WriteLine("3 - Rules");
            Console.WriteLine("4 - Author");
            Console.WriteLine("0 - Exit");
            int selected = Convert.ToInt32(Console.ReadLine());

            menu[selected]();
        }
    }
}