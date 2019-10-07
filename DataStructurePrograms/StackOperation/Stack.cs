// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Stack.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// -----------------------------------------------------------------------------------
namespace DataStructurePrograms.StackOperation
{
    using System;
    using DataStructurePrograms.LinkedListOperation;

    /// <summary>
    /// This is stack class.
    /// </summary>
    public class Stack
    {
        /// <summary>
        /// Push the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        public static void Push(object item)
        {
            if (LinkedListOperation.Utility.Head == null)
            {
                LinkedList.Add(item);
            }
            else
            {
                LinkedList.Add(item);
            }
        }

        /// <summary>
        /// Pop this instance.
        /// </summary>
        public static void Pop()
        {
            if (LinkedListOperation.Utility.Head == null)
            {
                return;
            }
            else
            {
                LinkedList.Pop();
            }
        }

        /// <summary>
        /// Peek this instance.
        /// </summary>
        public static void Peek()
        {
            if (LinkedListOperation.Utility.Head == null)
            {
                Console.WriteLine("Stack UnderFlow");
            }
            else
            {
                Console.WriteLine(" " + LinkedList.Peek());
            }
        }

        /// <summary>
        /// Determine whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsEmpty()
        {
            if (LinkedListOperation.Utility.Head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Size this instance.
        /// </summary>
        /// <returns>it return size</returns>
        public static int Size()
        {
            return LinkedList.Size();
        }
    }
}
