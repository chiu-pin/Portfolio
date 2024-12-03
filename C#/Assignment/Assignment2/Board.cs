using System;
using System.Runtime.InteropServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment1
{
    public class Board
    {
        public Board()
        {
        }
        public static char[] CreatBoard(int number)
        {
            char[] board = new char[number];
            return board;
        }
        public static bool VaildateMove(char[] board,int position)
        {
            if (board[position] != '\0')
            {
                return false;
            }
            return true;
        }
        public static char[] RecordMovePosition(char[]board, int position)
        {
            //record the move
            board[position] = 'X';
            return board;
        }
        public static void DisplayBoard(char[] board)
        {
            // print the line of board
            Console.Write("   ");
            for (int j = 0; j < board.Length; j++)
            {
                Console.Write("|" + j + "|");
            }
            Console.WriteLine(); // 换行

            // print board and X
            Console.Write("   ");
            for (int j = 0; j < board.Length; j++)
            {
                if (board[j] == '\0')
                {
                    Console.Write("|" + " " + "|"); // if board[j] is null，print 3 spaces
                }
                else
                {
                    Console.Write("|" + board[j] + "|"); // otherwise print content(X)
                }
            }
            Console.WriteLine(); // 换行
        }


    }
}
