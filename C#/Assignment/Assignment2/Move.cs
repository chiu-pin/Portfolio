using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Move
    {
        public Move() { }

        public static int UndoMove(int currentdata)
        {
            //i need to know which number of record, the index of record
            if (currentdata < 2)
            {
                return currentdata;
            }
            else
            {
                return currentdata-2;
            }
        }
        public static int RedoMove(List<History> trackmove, int CurrentnumberofRecord)
        {
           
            int totalcount = trackmove.Count;
            if (CurrentnumberofRecord+2 > totalcount)
            {
                Console.WriteLine("sorry, there are not enough trackmove can redo");
                return CurrentnumberofRecord;
            }
            else
            {
                return CurrentnumberofRecord +2 ;
            }
        }
        public static List<History> NewRecord(List<History> trackmove, int CurrentnumberofRecord)
        {
            History HistoryAdd = new History();
            List<History> result = new List<History>();
            char[] recordboard;
            for (int i = 0; i <= CurrentnumberofRecord; i++)
            {
                HistoryAdd.Player_ID = trackmove[i].Player_ID;
                HistoryAdd.CurrentBoard = trackmove[i].CurrentBoard.ToArray();
                result.Add(HistoryAdd);
            }
            return result;    
            

        }


    }



}
