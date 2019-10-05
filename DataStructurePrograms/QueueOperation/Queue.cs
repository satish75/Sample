using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructurePrograms.LinkedListOperation;
namespace DataStructurePrograms.QueueOperation
{
    public class Queue
    {
        public static Node front= LinkedListOperation.Utility.head;
        public static Node rear= LinkedListOperation.Utility.head;
        public static Node dequeueReturn;
        public static void Enqueue(object item)
        {
            if(front==null && rear==null)
            {
                LinkedList.Add(item);
                rear = LinkedListOperation.Utility.head;
            }
            else if(front==rear)
            {
                LinkedList.Add(item);
                rear = LinkedListOperation.Utility.head.next;
            }
            else
            {
                LinkedList.Append(item);
                rear = rear.next;
             
            }
        }
        public static object Dequeue()
        {
            if(LinkedListOperation.Utility.head==null)
            {
                return -1;
            }
            else
            {
                   dequeueReturn = LinkedListOperation.Utility.head;
                LinkedListOperation.Utility.head = LinkedListOperation.Utility.head.next;
                return dequeueReturn.data;
            }
           
        }
        public static bool IsEmpty()
        {
            if(LinkedListOperation.Utility.head== null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static int Size()
        {
            return LinkedList.Size();
        }
    }
}
