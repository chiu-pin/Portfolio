using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class History
    {
        public int Player_ID { get; set; }
        public char[] CurrentBoard { get; set; }

        public History() { }
        public static List<History> TrackMove(List<History> trackmove, int Player_ID, char[] currentBoard)
        
        {
            History HistoryAdd = new History();
            HistoryAdd.Player_ID = Player_ID;
            HistoryAdd.CurrentBoard = currentBoard.ToArray(); // creat the copy of current board 
            trackmove.Add(HistoryAdd);
            return trackmove;
        }
    }
}
