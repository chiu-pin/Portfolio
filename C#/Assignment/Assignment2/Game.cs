using System;

namespace Assignment1
{
    public abstract class Game
    {
        public int GameID { get; set; }
        public Game()
        { }
        public static bool ComputerorHuman()
        {
            //decide the game mode
            string userInput;
            Console.WriteLine("Please choose the mode:" +
                "\nHuman: 0 \nComputer: 1");
            userInput = Console.ReadLine();

            while (true)
            {
                if (userInput != "0" && userInput != "1")
                {
                    Console.WriteLine("Invalid Input!");
                    Console.WriteLine("Please choose the mode:" +
                    "Human: 0, Computer: 1");
                    userInput = Console.ReadLine();
                }
                if (userInput == "1")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public abstract Player[] PlayersType(bool computerPlayerExist);

        public abstract void StartNewGame(Game game1);
        public abstract void LoadGame(Game game1);
        public abstract void PlayGame(Player[] players, char[] board, int startPlayerID = 0);
        public abstract bool CheckWin(char[] board);
        public abstract void NewOrLoad(Game game);

        public abstract bool MoveVaildate(char[] board, int position);
    }
}
