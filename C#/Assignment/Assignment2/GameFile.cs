using System;
using System.ComponentModel.Design;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace Assignment1
{
	public class GameFile
	{

        public int Player_ID { get; set; }
        public char[] CurrentBoard { get; set; }

        public bool ComputerorHuman { get; set; }

        public static void SvaeGameFile(char[] CurrentBoard, int Player_ID, bool computerorhuman){
            string charBoardString = new string(CurrentBoard);
            string filePath = "Lastrecord.txt";

            // check the file is exist or not
            if (!File.Exists(filePath))
            {
                // not exist, creat new file
                File.Create(filePath).Close();
            }
            string playerType = computerorhuman ? "computer" : "human";
            string textToSave = charBoardString + "|" + Player_ID + "|" + playerType;

            // record the game to file
            using (StreamWriter writer = new StreamWriter(filePath, false))
            {
                writer.WriteLine(textToSave);
            }
            Console.WriteLine("Save file sucessful ");
        }
        public static string[] LoadFile()
        {
            string filePath = "Lastrecord.txt";
            string[] context = new string[3];
            // check the file is exist or not
            if (File.Exists(filePath))
            {
                // read the file
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        context = line.Split('|');
                    }
                }
                
            }
            else
            {
                Console.WriteLine("File not found.");
            }
            return context;
        }

    }
}

