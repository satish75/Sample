// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Dequeue.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// -----------------------------------------------------------------------------------
namespace DataStructurePrograms.QueueOperation
{
    using System;
    using DataStructurePrograms.LinkedListOperation;
    using DataStructurePrograms.QueueOperation;
  
    /// <summary>
    /// This is Double ended Queue class.
    /// </summary>
    public class Dequeue
    {
        /// <summary>
        /// This method add the item at first.
        /// </summary>
        /// <param name="item">it add item into queue</param>
        public static void AddFront(object item)
        {    
                LinkedList.AddFirst(item);
        }

        /// <summary>
        ///  This method add the item at last.
        /// </summary>
        /// <param name="item">it add item</param>
        public static void AddRear(object item)
        {
            LinkedList.Append(item);
        }

        /// <summary>
        ///  This method remove the item at first.
        /// </summary>
        public static void RemoveFront()
        {
            Node frontItem = LinkedListOperation.Utility.Head;
            LinkedListOperation.Utility.Head = LinkedListOperation.Utility.Head.Next;
        }

        /// <summary>
        ///  This method remove the item at last.
        /// </summary>
        /// <returns>it return remove object</returns>
        public static object RemoveRear()
        {
            Node frontItem = LinkedListOperation.Utility.Head;
            Node prevNode = frontItem;
            if (LinkedListOperation.Utility.Head == null)
            {
                return -1;
            }

            while (frontItem.Next != null)
            {
                prevNode = frontItem;
                frontItem = frontItem.Next;
            }

            prevNode.Next = null;
            return frontItem.Data;
        }

        /// <summary>
        /// This method check queue is empty or not.
        /// </summary>
        /// <returns>it return boolean value</returns>
        public static bool IsEmpty()
        {
            if (LinkedList.IsEmpty())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// this method return size of queue.
        /// </summary>
        /// <returns>it return size</returns>
        public static int Size()
        {
            return LinkedList.Size();
        }
    }
}
