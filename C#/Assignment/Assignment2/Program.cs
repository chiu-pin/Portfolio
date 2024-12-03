namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Game currentGame = ChooseGame();
            currentGame.NewOrLoad(currentGame);
            Console.WriteLine("The game ends! Thank you for playing!");
            Console.ReadKey();
        }
        public static Game ChooseGame()
        {
            string GameCode;

            Console.WriteLine("Please select the game: " +
                "\n R: Reversi" +
                "\n C: Treblecross");
            GameCode = Console.ReadLine().ToUpper();

            while (true)
            {
                if (GameCode == "R")
                {
                    Console.WriteLine("The game is under development. Please play Treblecross first^^");
                    Game game1 = new Treblecross();
                    return game1;
                }

                else if (GameCode == "C")
                {
                    
                    Game game1 = new Treblecross();
                    return game1;
                }

                else
                {
                    Console.WriteLine("Invalid input. Please try again!");
                    Console.WriteLine("Please select the game: " +
                    "\n R: Reversi" +
                    "\n C: Treblecross");
                    GameCode = Console.ReadLine().ToUpper();
                }
            }
        }
    }
}
