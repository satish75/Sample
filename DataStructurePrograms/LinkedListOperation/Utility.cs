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
        public static Node head;

        /// <summary>
        /// Adds the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public static void Add(object data)
        {
            Node newNode = new Node();
            Node tempNode = head;
            newNode.data = data;
            if (head == null)
            {
              
                head = newNode;
            }
            else
            {
                while (tempNode.next!= null)
                {
                    tempNode = tempNode.next;
                }
             
                tempNode.next = newNode;

            }
        }

        /// <summary>
        /// Prints this instance.
        /// </summary>
        public static void Print()
        {

            Node tempNode = head;

            while (tempNode != null)
            {
                Console.Write(" " + tempNode.data);
                tempNode = tempNode.next;
            }
        }
        /// <summary>
        /// Adds the first.
        /// </summary>
        /// <param name="data">The data.</param>
        public static void AddFirst(object data)
        {
            Node newNode = new Node();
            newNode.data = data;
            if (head == null)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                newNode.next = head;
                head = newNode;
            }
        }
        /// <summary>
        /// Appends the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public static void Append(object data)
        {
            Node newNode = new Node();
            newNode.data = data;
            Node tempNode = head;
            while (tempNode.next != null)
            {
                tempNode = tempNode.next;
            }
            newNode.next = tempNode.next;
            tempNode.next = newNode;
        }
        /// <summary>
        /// Inserts the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public static void Insert(object data, int position)
        {
            Node newNode = new Node();
            Node toCheckPosition = head;
            Node tempNode = head;
            newNode.data = data;
            int count = 0;
            bool isValidePosition = false;
            while (toCheckPosition != null)
            {
                if (count == position)
                {
                    isValidePosition = true;
                    break;

                }
                count++; toCheckPosition = toCheckPosition.next;

            }

            if (isValidePosition)
            {
                for (int i = 0; i < position - 2; i++)
                {
                    tempNode = tempNode.next;
                }
                newNode.next = tempNode.next;
                tempNode.next = newNode;
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
        /// Sizes this instance.
        /// </summary>
        public static int Size()
        {
            Node tempNode = head;
            int size = 0;
            while (tempNode != null)
            {
                size++;
                tempNode = tempNode.next;

            }
            return size;
        }

        public static bool IsEmpty()
        {

            if (head == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Searches the specified search item.
        /// </summary>
        /// <param name="searchItem">The search item.</param>
        /// <returns></returns>
        public static bool Search(object searchItem)
        {
            Node tempNode = head;
            while (tempNode != null)
            {
                if (tempNode.data.Equals(searchItem))
                {

                    return true;
                }
                tempNode = tempNode.next;
            }
            return false;
        }

        /// <summary>
        /// Indexes the specified search item.
        /// </summary>
        /// <param name="searchItem">The search item.</param>
        /// <returns></returns>
        public static int Index(object searchItem)
        {
            Node tempNode = head;
            int index = 0;
            while (tempNode != null)
            {
                if (tempNode.data.Equals(searchItem))
                {
                    return index;
                }
                tempNode = tempNode.next;
                index++;
            }
            return -1;
        }
        /// <summary>
        /// Removes the specified remove item.
        /// </summary>
        /// <param name="removeItem">The remove item.</param>
        public static void Remove(object removeItem)
        {
            Node tempNode = head;
            Node prevNode=head;
            bool found = false;
           // Node storedAddress ;
            while (tempNode != null)
            {
                if (tempNode.data.Equals(removeItem))
                {
                  
                    if(tempNode==head)
                    {
                        head = head.next;
                       
                        return;
                    }
                    prevNode.next = tempNode.next;
                   // tempNode.next = null;
                    found = true;
                    break;
                }
                prevNode = tempNode;
                tempNode = tempNode.next;

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
        /// Pops The Element from stack .
        /// </summary>
        /// <returns></returns>
        public static void Pop()
        {

            Node tempNode = head;
            Node prevNode = head;
          if(tempNode==null)
            {
                Console.WriteLine("UnderFlow");
            }
          else if(tempNode.next==null)
            {
                head = null;
            }
          else
            {
                while(tempNode.next !=null)
                {
                    prevNode = tempNode;
                    tempNode = tempNode.next;
                }
                prevNode.next = null;
            }
          
           // return tempNode.data;
        }
        /// <summary>
        /// Pops this instance.
        /// </summary>
        /// <returns></returns>
        public static object Pop(int position)
        {

            Node tempNode = head;
            Node prevNode = head;
            Node toCheckPosition = head;
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
                pos++; toCheckPosition = toCheckPosition.next;

            }

            if (isValidePosition)
            {
                while (tempNode.next != null)
                {

                    if (count == position)
                    {
                        break;
                    }
                    count++;
                    prevNode = tempNode;
                    tempNode = tempNode.next;
                }
                prevNode.next = tempNode.next;
                tempNode.next = null;
                return tempNode.data;
            }
            else
            {
                Console.WriteLine("Please Enter Valide Position ");
                Console.WriteLine("\nPlease Enter New  Position :");
                position = Convert.ToInt32(Console.ReadLine());
                return Pop(position);
            }

        }

        public static object Peek()
        {

            Node tempNode = head;
            Node prevNode = head;
            while (tempNode.next != null)
            {
                tempNode = tempNode.next;
            }
            return tempNode.data;
        }

    }
}
