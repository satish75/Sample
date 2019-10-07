// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Queue.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// -----------------------------------------------------------------------------------
namespace DataStructurePrograms.QueueOperation
{
    using System;
    using DataStructurePrograms.LinkedListOperation;

    /// <summary>
    /// This is queue class.
    /// </summary>
    public class Queue
    {
        /// <summary>
        /// The front stored the head.
        /// </summary>
        public static Node Front = LinkedListOperation.Utility.Head;

        /// <summary>
        /// The rear stored the head.
        /// </summary>
        public static Node Rear = LinkedListOperation.Utility.Head;

        /// <summary>
        /// The de queue return the data.
        /// </summary>
        public static Node DequeueReturn;

        /// <summary>
        /// Enqueue the specified item.
        /// </summary>
        /// <param name="item">The item.</param>
        public static void Enqueue(object item)
        {
            if (Front == null && Rear == null)
            {
                LinkedList.Add(item);
                Rear = LinkedListOperation.Utility.Head;
            }
            else if (Front == Rear)
            {
                LinkedList.Add(item);
                Rear = LinkedListOperation.Utility.Head.Next;
            }
            else
            {
                LinkedList.Append(item);
                Rear = Rear.Next;
            }
        }

        /// <summary>
        /// De queue this instance.
        /// </summary>
        /// <returns>it return data item</returns>
        public static object Dequeue()
        {
            if (LinkedListOperation.Utility.Head == null)
            {
                return -1;
            }
            else
            {
                DequeueReturn = LinkedListOperation.Utility.Head;
                LinkedListOperation.Utility.Head = LinkedListOperation.Utility.Head.Next;
                return DequeueReturn.Data;
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