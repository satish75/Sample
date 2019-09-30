using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPracticProgram
{
    public class LinkedList
    {
        public static Node head;

        public static void Add(object data)
        {
            Node newNode = new Node();
            Node tempNode = head;
            newNode.data = data;
            if(head==null)
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
               while(tempNode.next !=null)
                {
                    tempNode = tempNode.next;
                }
                newNode.next = tempNode.next;
                tempNode.next = newNode;

            }
        }

        public static void PrintLikedList()
        {
        
            Node tempNode = head;
            while(tempNode !=null)
            {
                Console.Write(" " + tempNode.data);
                tempNode = tempNode.next;
            }
        }

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

        public static void Append(object data)
        {
            Node newNode = new Node();
            newNode.data = data;
            Node tempNode = head;
            while(tempNode.next !=null)
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
        public static void Insert(object data,int position)
        {
            Node newNode = new Node();
            Node toCheckPosition = head;
            Node tempNode = head;
            newNode.data = data;
            int count = 0;
            bool isValidePosition = false;
            while(toCheckPosition != null)
            { 
                if (count==position)
                {
                    isValidePosition = true;
                    break;
                    
                }
                count++; toCheckPosition = toCheckPosition.next;

            }
           
               if(isValidePosition)
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
        public static void Size()
        {
            Node tempNode = head;
            int size = 0;
            while(tempNode !=null)
            {
                size++;
                tempNode = tempNode.next;
              
            }
            Console.WriteLine(size);
        }

        public static bool IsEmpty()
        {
            
            if(head==null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
