// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// ----------------------------------------------------------------------------------------------
namespace DataStructurePrograms.LinkedListOperation
{
    using System;

    /// <summary>
    /// This Is Utility Class
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// The head node stored the address of start node.
        /// </summary>
        public static Node Head;

        /// <summary>
        /// Adds the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public static void Add(object data)
        {
            Node newNode = new Node();
            Node tempNode = Head;
            newNode.Data = data;
            if (Head == null)
            {              
                Head = newNode;
            }
            else
            {
                while (tempNode.Next != null)
                {
                    tempNode = tempNode.Next;
                }
             
                tempNode.Next = newNode;
            }
        }

        /// <summary>
        /// Prints this instance.
        /// </summary>
        public static void Print()
        {
            Node tempNode = Head;
            while (tempNode != null)
            {
                Console.Write(" " + tempNode.Data);
                tempNode = tempNode.Next;
            }
        }

        /// <summary>
        /// Add the first.
        /// </summary>
        /// <param name="data">The data.</param>
        public static void AddFirst(object data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            if (Head == null)
            {
                newNode.Next = Head;
                Head = newNode;
            }
            else
            {
                newNode.Next = Head;
                Head = newNode;
            }
        }

        /// <summary>
        /// Appends the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public static void Append(object data)
        {
            Node newNode = new Node();
            newNode.Data = data;
            Node tempNode = Head;
            try
            {
                while (tempNode.Next != null)
                {
                    tempNode = tempNode.Next;
                }

                tempNode.Next = newNode;
            }
            catch (NullReferenceException e)
            {
                Console.WriteLine(" " + e);
            }
        }

        /// <summary>
        /// Inserts the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="position">The position.</param>
        public static void Insert(object data, int position)
        {
            Node newNode = new Node();
            Node toCheckPosition = Head;
            Node tempNode = Head;
            newNode.Data = data;
            int count = 0;
            bool isValidePosition = false;
            while (toCheckPosition != null)
            {
                if (count == position)
                {
                    isValidePosition = true;
                    break;
                }

                count++;
                toCheckPosition = toCheckPosition.Next;
            }

            if (isValidePosition)
            {
                for (int i = 0; i < position - 2; i++)
                {
                    tempNode = tempNode.Next;
                }

                newNode.Next = tempNode.Next;
                tempNode.Next = newNode;
            }
            else
            {
                Console.WriteLine("Please Enter Valide Position ");
                Console.WriteLine("\nPlease Enter New  Position :");
                position = Convert.ToInt32(Console.ReadLine());
                Insert(data, position);
            }
        }

        /// <summary>
        /// Size this instance.
        /// </summary>
        /// <returns>it return size</returns>
        public static int Size()
        {
            Node tempNode = Head;
            int size = 0;
            while (tempNode != null)
            {
                size++;
                tempNode = tempNode.Next;
            }

            return size;
        }

        /// <summary>
        /// Determine whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsEmpty()
        {
            if (Head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Search the specified search item.
        /// </summary>
        /// <param name="searchItem">The search item.</param>
        /// <returns>it return search item</returns>
        public static bool Search(object searchItem)
        {
            Node tempNode = Head;
            while (tempNode != null)
            {
                if (tempNode.Data.Equals(searchItem))
                {
                    return true;
                }

                tempNode = tempNode.Next;
            }

            return false;
        }

        /// <summary>
        /// Index the specified search item.
        /// </summary>
        /// <param name="searchItem">The search item.</param>
        /// <returns>it return the index value</returns>
        public static int Index(object searchItem)
        {
            Node tempNode = Head;
            int index = 0;
            while (tempNode != null)
            {
                if (tempNode.Data.Equals(searchItem))
                {
                    return index;
                }

                tempNode = tempNode.Next;
                index++;
            }

            return -1;
        }

        /// <summary>
        /// Remove the specified remove item.
        /// </summary>
        /// <param name="removeItem">The remove item.</param>
        public static void Remove(object removeItem)
        {
            Node tempNode = Head;
            Node prevNode = Head;
            bool found = false;
            while (tempNode != null)
            {
                if (tempNode.Data.Equals(removeItem))
                {
                    if (tempNode == Head)
                    {
                        Head = Head.Next;                       
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
                string data = Console.ReadLine();
                removeItem = (object)Convert.ChangeType(data, typeof(object));
                Remove(removeItem);
            }
        }

        /// <summary>
        /// Pop The Element from stack .
        /// </summary>
        public static void Pop()
        {
            Node tempNode = Head;
            Node prevNode = Head;
          if (tempNode == null)
            {
                Console.WriteLine("UnderFlow");
            }
          else if (tempNode.Next == null)
            {
                Head = null;
            }
          else
            {
                while (tempNode.Next != null)
                {
                    prevNode = tempNode;
                    tempNode = tempNode.Next;
                }

                prevNode.Next = null;
            }
        }

        /// <summary>
        /// Pops the specified position.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <returns>it delete top item</returns>
        public static object Pop(int position)
        {
            Node tempNode = Head;
            Node prevNode = Head;
            Node toCheckPosition = Head;
            int pos = 0;
            int count = 1;
            bool isValidePosition = false;
            while (toCheckPosition != null)
            {
                if (pos == position)
                {
                    isValidePosition = true;
                    break;
                }

                pos++;
                toCheckPosition = toCheckPosition.Next;
            }

            if (isValidePosition)
            {
                while (tempNode.Next != null)
                {
                    if (count == position)
                    {
                        break;
                    }

                    count++;
                    prevNode = tempNode;
                    tempNode = tempNode.Next;
                }

                prevNode.Next = tempNode.Next;
                tempNode.Next = null;
                return tempNode.Data;
            }
            else
            {
                Console.WriteLine("Please Enter Valide Position ");
                Console.WriteLine("\nPlease Enter New  Position :");
                position = Convert.ToInt32(Console.ReadLine());
                return Pop(position);
            }
        }

        /// <summary>
        /// Peek this instance.
        /// </summary>
        /// <returns>it return top item</returns>
        public static object Peek()
        {
            Node tempNode = Head;
            Node prevNode = Head;
            while (tempNode.Next != null)
            {
                tempNode = tempNode.Next;
            }

            return tempNode.Data;
        }
    }
}