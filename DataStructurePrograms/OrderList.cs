// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OrderList.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// -----------------------------------------------------------------------------------
namespace DataStructurePrograms
{
    using System;
    using System.IO;
    using DataStructurePrograms.LinkedListOperation;

    /// <summary>
    /// This is Order List Class.
    /// </summary>
    public class OrderList
    {
        /// <summary>
        /// Orders the list search.
        /// </summary>
        public static void OrderListSearch()
        {
            StreamReader srteamReader = new StreamReader("C:\\Users\\Admin\\Desktop\\Satya\\readFileNumber.txt");
            string firstLine;
            while ((firstLine = srteamReader.ReadLine()) != null)
            {
                string[] stringArray = firstLine.Split(' ');
                foreach (string item in stringArray)
                {
                    int number = 0;
                    int.TryParse(item, out number);
                    OrderLinkedList.AddOrder(number);
                }
            }

            srteamReader.Close();
            OrderLinkedList.Print();
            Console.WriteLine("\nEnter Number To Search");
            int itemSearch = Convert.ToInt32(Console.ReadLine());
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
