using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructurePrograms.LinkedListOperation;
namespace DataStructurePrograms.StackOperation
{
  
    public class Stack
    {
        public static Node top;
        public static Node prevTop;
        public static void Push(object item)
        {

            if(LinkedListOperation.Utility.head==null)
            {
                LinkedList.Add(item);
              
          
            }
            else
            {
                LinkedList.Add(item);
              
            }
        }

        public static void Pop()
        {
            if(LinkedListOperation.Utility.head == null)
            {
                return;           
            }
            else
            { 
                LinkedList.Pop();
            }
        }
        public static void Peek()
        {
            if(LinkedListOperation.Utility.head == null)
            {
                Console.WriteLine("Stack UnderFlow");
            }
            else
            {
                Console.WriteLine(" " + LinkedList.Peek());
            }
        }

        public static bool IsEmpty()
        {
            if(LinkedListOperation.Utility.head == null)
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
