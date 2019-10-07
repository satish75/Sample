﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="HashingFunction.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// -----------------------------------------------------------------------------------
namespace DataStructurePrograms
{
    using System;
    using DataStructurePrograms.LinkedListOperation;

    /// <summary>
    /// This is Hashing Class.
    /// </summary>
    public class HashingFunction
    {
        /// <summary>
        /// Hashing this instance.
        /// </summary>
        public static void Hashing()
        {
            /*  StreamReader srteamReader = new StreamReader("C:\\Users\\Admin\\Desktop\\Satya\\readFileNumber.txt");
              string firstLine;
              while ((firstLine = srteamReader.ReadLine()) != null)
              {
                  string[] stringArray = firstLine.Split(' ');
                  foreach (string item in stringArray)
                  {
                      int number = 0;
                      Int32.TryParse(item, out number);
                      //OrderLinkedList.AddOrder(number);
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
              */

            NodeOrder[][] lists = new NodeOrder[10][];
            int[] a = { 11, 12, 13, 14, 15, 16, 22, 23, 19, 33, 32 };

            for (int k = 0; k < 10; k++)
            {
                lists[k] = new NodeOrder[10];
            }

            for (int j = 0; j < 10; j++)
            {
                int rem = a[j] % 11;
                if (rem == j)
                {
                    for (int o = 0; o < 5; o++)
                    {
                        if (lists[j][o] == null)
                        {
                            lists[j][o] = OrderLinkedList.AddOrder(a[j]);
                            break;
                        }
                    }
                }
            }

            for (int k = 0; k < 10; k++)
            {
                try
                {
                    Console.Write(" list {0}", k);
                    for (int j = 0; j < 5; j++)
                    {
                        Console.Write("  " + lists[k][j].DataOrder);
                    }

                    Console.WriteLine();
                }
                catch (Exception e)
                {
                    Console.WriteLine("Exception" + e);
                }
            }
        }
    }
}
