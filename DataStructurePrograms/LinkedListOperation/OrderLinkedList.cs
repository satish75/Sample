using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms.LinkedListOperation
{

   

    public class OrderLinkedList
    {
        public static NodeOrder headOrder;
        public static NodeOrder AddOrder(int data)
        {
            NodeOrder newNode = new NodeOrder();
            newNode.dataOrder = data;
            NodeOrder current=headOrder;

           
            if (headOrder == null || headOrder.dataOrder >= newNode.dataOrder)
            {
                newNode.next = headOrder;
                headOrder = newNode;
            }
            else
            {

                /* Locate the node before  
                point of insertion. */
                current = headOrder;

                while (current.next != null &&
                    current.next.dataOrder < newNode.dataOrder)
                    current = current.next;

                newNode.next = current.next;
                current.next = newNode;
            }
           return newNode;
        }
        public static void Print()
        {

            NodeOrder tempNode = headOrder;

            while (tempNode != null)
            {

                Console.Write(" " + tempNode.dataOrder);
                tempNode = tempNode.next;
            }
        }

        public static bool Search(int searchItem)
        {
            NodeOrder tempNode = headOrder;
            while (tempNode != null)
            {
                if (tempNode.dataOrder==searchItem)
                {

                    return true;
                }
                tempNode = tempNode.next;
            }
            return false;
        }

        public static void Remove(int removeItem)
        {
            NodeOrder tempNode = headOrder;
            NodeOrder prevNode = headOrder;
            bool found = false;
            // Node storedAddress ;
            while (tempNode != null)
            {
                if (tempNode.dataOrder==removeItem)
                {

                    if (tempNode == headOrder)
                    {
                        headOrder = headOrder.next;

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
                int data = Convert.ToInt32(Console.ReadLine());
                Remove(data);
            }
        }

        public static void OrderList()
        {
            NodeOrder emptyNode = new NodeOrder();
        }
    }
}
       
    

