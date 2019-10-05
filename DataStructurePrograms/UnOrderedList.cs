using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms.LinkedListOperation
{
    public class UnOrderedList
    {
        public static void WordOfLinkedList()
        {
            StreamWriter streamWriter = new StreamWriter("C:\\Users\\Admin\\Desktop\\Satya\\satya.txt");
            Console.WriteLine("How Many Lines Do You Want to Write Into The File ");
            int noOfLine = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Lines Here......... ");
            for (int i = 0; i < noOfLine; i++)
            {
                string lines = Console.ReadLine();
                streamWriter.WriteLine(lines);
            }

            streamWriter.Close();
            
            /// Read The File
            /// 
            StreamReader srteamReader = new StreamReader("C:\\Users\\Admin\\Desktop\\Satya\\satya.txt");
            string firstLine; 
            while ((firstLine = srteamReader.ReadLine()) != null)
            {
                string[] stringArray = firstLine.Split(' ');
                foreach(string item in stringArray)
                {
                    LinkedList.Add(firstLine);
                }  
            }
            Console.WriteLine("Enter Item To Search");
            string itemSearch = Console.ReadLine();
            object dataObject = (object)Convert.ChangeType(itemSearch, typeof(object));
            if(LinkedList.Search(dataObject))
            {
                LinkedList.Remove(dataObject);
            }
            else
            {
                LinkedList.Add(dataObject);
            }
            srteamReader.Close();
        }
    }
}
