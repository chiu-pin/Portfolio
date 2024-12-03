using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment1
{
    public class Treblecross : Game
    {
        public override Player[] PlayersType(bool computerPlayerExist)
        {
            Player[] players = new Player[2];
            //First player must be Human player
            string players1Name = "Humanplayer1";
            players[0] = new HumanPlayer(1, players1Name);
            if (computerPlayerExist == true)
            {
                players[1] = new ComputerPlayer(2, "computer");
            }

            else
            {
                players[1] = new HumanPlayer(2, "Humanplayer1");
            }

            return players;
        }

        public override void NewOrLoad(Game game)
        {
            Console.WriteLine("Do you want to start new game or load the save file\nN:Start New Game\nL:Load a File");
            string action= Console.ReadLine();
            if (action=="N")
            {
                StartNewGame(game);
            }
            else
            {
                LoadGame(game);
            }
        }
        public override void StartNewGame(Game game1)
        {
            bool isComputerPlayer = ComputerorHuman();
            Player[] players = game1.PlayersType(isComputerPlayer);
            int size = HumanPlayer.DecideSizeOfBoard();
            char[] board = Board.CreatBoard(size);
            Board.DisplayBoard(board);

            // Start the game loop
            PlayGame(players, board,0);
        }
        public override void LoadGame(Game game1)
        {
            string[] GameData = GameFile.LoadFile();
            bool isComputerPlayer = (GameData[2] == "computer");
            Player[] players = game1.PlayersType(isComputerPlayer);
            char[] board = GameData[0].ToCharArray();
            Board.DisplayBoard(board);
            PlayGame(players, board, int.Parse(GameData[1]));
        }
        public override void PlayGame(Player[] players, char[] board, int startPlayerID) 
        {
            int currentPlayer = startPlayerID;
            bool endGame = false;
            List<History> gameHistories = new List<History>();
            History historysetup = new History();
            historysetup.CurrentBoard = board.ToArray();
            historysetup.Player_ID = 1;
            gameHistories.Add(historysetup);
            int CurrentRecord = -1;

            while (endGame != true)
            {
                CurrentRecord = gameHistories.Count - 1;
                if (players[currentPlayer] is ComputerPlayer)
                {
                    ComputerPlayer computerPlayer = (ComputerPlayer)players[currentPlayer];
                    Console.WriteLine();
                    Console.WriteLine("Computer select move");
                    int position = computerPlayer.SelectMove(board);
                    board = Board.RecordMovePosition(board, position);
                    Board.DisplayBoard(board);
                    gameHistories = History.TrackMove(gameHistories, currentPlayer + 1, board);

                }
                else
                { 
                    HelpSystem.showcommand(players[currentPlayer].Player_ID);
                    string action = Console.ReadLine();
                    while (action != "S" && action != "U" && action != "H" && action != "M"&& action != "R")
                    {
                        HelpSystem.showcommand(currentPlayer + 1);
                        action = Console.ReadLine();
                    }
                    while (action != "M")
                    {
                        if (action == "H")
                        {   
                            HelpSystem.showhelp();
                            HelpSystem.showcommand(currentPlayer + 1);
                            action = Console.ReadLine();
                        }
                        if (action == "S")
                        {
                            //make sure save the newest history of move
                            if (CurrentRecord != gameHistories.Count - 1) {
                                board = gameHistories[CurrentRecord].CurrentBoard.ToArray();
                            }

                            //check player2 is computer or human, and then save the files
                            if (players[1] is ComputerPlayer)
                            {
                                GameFile.SvaeGameFile(board, currentPlayer, true);

                            }
                            else
                            {
                                GameFile.SvaeGameFile(board, currentPlayer, false);
                            }
                            Console.WriteLine("Do you want to \nC:continue the game\nF:Finish the game");
                            action = Console.ReadLine();
                            if(action == "C")
                            {
                                Console.WriteLine("Continue the game ");
                                HelpSystem.showcommand(currentPlayer + 1);
                                action = Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Thanks for playing,See you next time");
                                endGame = true;
                            }
                        }
                        while (action == "R" || action == "U")
                        {
                            if (action == "U")
                            {
                                CurrentRecord = HelpSystem.CallUndoMove(gameHistories,CurrentRecord);
                                if (CurrentRecord <= 0)
                                {
                                    Console.WriteLine("Nomore track can Undo,Don't choose Undo now.");
                                }
                            }
                            else if (action == "R")
                            {
                               
                                 CurrentRecord = HelpSystem.CallRedoMove(gameHistories, CurrentRecord);

                            }
                            HelpSystem.showcommand(currentPlayer + 1);
                            action = Console.ReadLine();
                        }
                        
                    }
                    if(CurrentRecord!= gameHistories.Count - 1)
                    {
                        //every time after undo and redo, if player start make a new move, the history should be restart to record.
                        gameHistories = Move.NewRecord(gameHistories, CurrentRecord);
                        board = gameHistories[gameHistories.Count - 1].CurrentBoard.ToArray();
                    }

                        //Make a move
                        HumanPlayer humanPlayer = (HumanPlayer)players[currentPlayer];
                        int position = humanPlayer.SelectMove(board);
                        if (MoveVaildate(board, position) == true)
                        {
                            board = Board.RecordMovePosition(board, position);
                            Board.DisplayBoard(board);
                            gameHistories = History.TrackMove(gameHistories, currentPlayer + 1, board);
                        }
                        else
                        {
                            while (MoveVaildate(board, position) == false)
                            {
                                Console.WriteLine("Please choose the empty postion");
                                position = humanPlayer.SelectMove(board);
                            }
                            board = Board.RecordMovePosition(board, position);
                            Board.DisplayBoard(board);
                            gameHistories = History.TrackMove(gameHistories, currentPlayer + 1, board);
                        }
                         
                    
                }
                // Switch to the next player
                if (CheckWin(board) == false)
                {
                    currentPlayer = (players[currentPlayer].Player_ID == 1) ? 1 : 0;
                }
                else
                {
                    Console.Write("{0} win", players[currentPlayer].PlayerName);
                    endGame = true; 
                }
                
            }


        }
        public override bool CheckWin(char[] board) 
        {
            //check who win
            for (int i = 0; i <= board.Length - 3; i++)
            {
                if (board[i] == board[i + 1] && board[i] == board[i + 2] && board[i]=='X')
                {
                    return true;
                }
            }
            return false;
        }
        public override bool MoveVaildate(char[] board, int position)
        {
            return Board.VaildateMove(board, position);
        }

    }
}
