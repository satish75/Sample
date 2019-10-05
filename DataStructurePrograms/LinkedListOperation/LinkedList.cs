// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedList.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// ----------------------------------------------------------------------------------------------
namespace DataStructurePrograms.LinkedListOperation
{
    using System;

    /// <summary>
    /// This Is Linked List Class
    /// </summary>
    public class LinkedList
    {

        public static void Add(object data)
        {
            Utility.Add(data);
        }
        public static void Print()
        {
            Utility.Print();
        }
        public static void AddFirst(object data)
        {
            Utility.AddFirst(data);
        }
        public static void Append(object data)
        {
            Utility.Append(data);
        }
        public static void Insert(object data, int position)
        {
            Utility.Insert(data, position);
        }
        public static int Size()
        {
            return Utility.Size();
        }
        public static bool IsEmpty()
        {
            return Utility.IsEmpty();
        }
        public static bool Search(object searchItem)
        {
            return Utility.Search(searchItem);
        }
        public static int Index(object searchItem)
        {
            return Utility.Index(searchItem);
        }
        public static void Remove(object removeItem)
        {
            Utility.Remove(removeItem);
        }
        public static void Pop()
        {
             Utility.Pop();
        }
        public static object Pop(int position)
        {
            return Utility.Pop(position);
        }
        public static object Peek()
        {
            return Utility.Peek();
        }

    }
}