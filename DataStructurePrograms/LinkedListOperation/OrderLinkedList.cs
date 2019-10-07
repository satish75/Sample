// --------------------------------------------------------------------------------------------------------------------
// <copyright file="OrderLinkedList.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// -----------------------------------------------------------------------------------
namespace DataStructurePrograms.LinkedListOperation
{
    using System;

    /// <summary>
    /// this is order linked list class.
    /// </summary>
    public class OrderLinkedList
    {
        /// <summary>
        /// The head order is node type variable
        /// </summary>
        private static NodeOrder headOrder;

        /// <summary>
        /// Add the order.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>it return data node</returns>
        public static NodeOrder AddOrder(int data)
        {
            NodeOrder newNode = new NodeOrder();
            newNode.DataOrder = data;
            NodeOrder current = headOrder;
            if (headOrder == null || headOrder.DataOrder >= newNode.DataOrder)
            {
                newNode.Next = headOrder;
                headOrder = newNode;
            }
            else
            {
                current = headOrder;
                while (current.Next != null &&
                    current.Next.DataOrder < newNode.DataOrder)
                {
                    current = current.Next;
                }

                newNode.Next = current.Next;
                current.Next = newNode;
            }

           return newNode;
        }

        /// <summary>
        /// Print this instance.
        /// </summary>
        public static void Print()
        {
            NodeOrder tempNode = headOrder;
            while (tempNode != null)
            {
                Console.Write(" " + tempNode.DataOrder);
                tempNode = tempNode.Next;
            }
        }

        /// <summary>
        /// Search the specified search item.
        /// </summary>
        /// <param name="searchItem">The search item.</param>
        /// <returns>it return boolean value</returns>
        public static bool Search(int searchItem)
        {
            NodeOrder tempNode = headOrder;
            while (tempNode != null)
            {
                if (tempNode.DataOrder == searchItem)
                {
                    return true;
                }

                tempNode = tempNode.Next;
            }

            return false;
        }

        /// <summary>
        /// Remove the specified remove item.
        /// </summary>
        /// <param name="removeItem">The remove item.</param>
        public static void Remove(int removeItem)
        {
            NodeOrder tempNode = headOrder;
            NodeOrder prevNode = headOrder;
            bool found = false;
            while (tempNode != null)
            {
                if (tempNode.DataOrder == removeItem)
                {
                    if (tempNode == headOrder)
                    {
                        headOrder = headOrder.Next;
                        return;
                    }

                    prevNode.Next = tempNode.Next;    
                    found = true;
                    break;
                }

                prevNode = tempNode;
                tempNode = tempNode.Next;
            }

            if (!found)
            {
                Console.WriteLine("Your Item Is Not Present In The List");
                Console.WriteLine("\nEnter Item Again For Remove : ");
                int data = Convert.ToInt32(Console.ReadLine());
                Remove(data);
            }
        }

        /// <summary>
        /// Order the list.
        /// </summary>
        public static void OrderList()
        {
            NodeOrder emptyNode = new NodeOrder();
        }
    }
} 