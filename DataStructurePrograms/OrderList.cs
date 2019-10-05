using DataStructurePrograms.LinkedListOperation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
   public class OrderList
    {
        public static void OrderListSearch()
        {
            StreamReader srteamReader = new StreamReader("C:\\Users\\Admin\\Desktop\\Satya\\readFileNumber.txt");
            string firstLine;
            while ((firstLine = srteamReader.ReadLine()) != null)
            {
                string[] stringArray = firstLine.Split(' ');
                foreach (string item in stringArray)
                {
                    int number=0;
                    Int32.TryParse(item,out number);
                    OrderLinkedList.AddOrder(number);
                }
            }
            srteamReader.Close();
            OrderLinkedList.Print();
            Console.WriteLine("\nEnter Number To Search");
            int itemSearch = Convert.ToInt32(Console.ReadLine());
           // object dataObject = (object)Convert.ChangeType(itemSearch, typeof(object));
            if (OrderLinkedList.Search(itemSearch))
            {
                OrderLinkedList.Remove(itemSearch);
            }
            else
            {
                OrderLinkedList.AddOrder(itemSearch);
            }
           
        }
    }
}
