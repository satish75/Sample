using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructurePrograms.QueueOperation;
using DataStructurePrograms.LinkedListOperation;
namespace DataStructurePrograms.QueueOperation
{
    public class Dequeue
    {
        public static void AddFront(object item)
        {    
                LinkedList.AddFirst(item);
        }
        public static void AddRear(object item)
        {
            LinkedList.Append(item);
        }
        public static void RemoveFront()
        {
            Node frontItem = LinkedListOperation.Utility.head;
            LinkedListOperation.Utility.head= LinkedListOperation.Utility.head.next;
        }
        public static object RemoveRear()
        {
            Node frontItem = LinkedListOperation.Utility.head;
            Node prevNode = frontItem;
            while(frontItem.next !=null)
            {
                prevNode = frontItem;
                frontItem = frontItem.next;
            }
            prevNode.next = null;
            return frontItem.data;

        }
        public static bool IsEmpty()
        {
            if(LinkedList.IsEmpty())
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
