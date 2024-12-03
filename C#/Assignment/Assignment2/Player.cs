using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public abstract class Player
    {
        public int Player_ID { get; set; }
        public string PlayerName { get; set; }

        public Player() { }
        public Player(int ID, string name)
        {
            Player_ID = ID;
            PlayerName = name;
        }

        public abstract int SelectMove(char[]Board);

    }

    public class HumanPlayer : Player
    {
        public HumanPlayer() : base() { }
        public HumanPlayer(int ID, string name) : base(ID, name) { }

        public override int SelectMove(char[] Board)
        {
            Console.WriteLine("Please Select the position");
            int number = Convert.ToInt32(Console.ReadLine());
            while(number >= Board.Length)
            {
                Console.WriteLine("Please Select the vaild position");
                number = Convert.ToInt32(Console.ReadLine());
            }
            return number;
        }

        public static int DecideSizeOfBoard()
        {
            Console.WriteLine("Please enter number of square:");
            string userInput = Console.ReadLine();
            int intValue = 0;
            // check the number is int or not
            while (int.TryParse(userInput, out intValue) == false)
            {
                Console.WriteLine("Please enter a valid number.");
                userInput = Console.ReadLine();
            }

            
            return intValue;
        }

    }

    public class ComputerPlayer : Player
    {
        public ComputerPlayer() : base() { }
        public ComputerPlayer(int ID, string name) : base(ID, name) {
            PlayerName = "computer";
        
        }

        public override int SelectMove(char[] Board)
        {
            List<int> numbers = new List<int>();
            //先判斷哪些位子是空的再從這些位子隨機挑選電腦要的
            for(int i = 0; i < Board.Length; i++)
            {
                if (Board[i] != 'X')
                {
                    numbers.Add(i);
                }
            }
            Random random = new Random();
            int selectedNumber = numbers[random.Next(numbers.Count)];
            return selectedNumber;
        }

    }

}
