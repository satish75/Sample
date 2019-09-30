using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListPracticProgram
{
    public class Node
    {
        public object data;
        public Node next;
    }

    class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine("How Many Nodes Do you want to create");
              int noOfNodes = Convert.ToInt32(Console.ReadLine());
              string data;
             object dataObject;
            ///Create The Node
            ///
          ////  Console.WriteLine("IsEmpty : " + LinkedList.IsEmpty());

            for (int i=0;i<noOfNodes;i++)
              {
                 Console.WriteLine("Enter Data For Node :");
                 data = Console.ReadLine();
                 dataObject = (object)Convert.ChangeType(data, typeof(object));

                LinkedList.Add(dataObject);
              }
              /// Print The Node
              Console.WriteLine("All Node Is : ");
              LinkedList.PrintLikedList();


            ///Add Node At First Position
              Console.WriteLine("\nEnter data to add first position : ");
              data = Console.ReadLine();
             dataObject = (object)Convert.ChangeType(data, typeof(object));
              LinkedList.AddFirst(dataObject);

            ///Print All Node
              LinkedList.PrintLikedList();


            ///Add Node At Last Position
              Console.WriteLine("\nEnter data to add Last position : ");
              data = Console.ReadLine();
             dataObject = (object)Convert.ChangeType(data, typeof(object));
              LinkedList.Append(dataObject);
              LinkedList.PrintLikedList();

            ///
            Console.WriteLine("\nEnter data to add At Specific position : ");
            data = Console.ReadLine();
            dataObject = (object)Convert.ChangeType(data, typeof(object));
            Console.WriteLine("\nEnter position where You want to add element: ");
            int position = Convert.ToInt32(Console.ReadLine());
            LinkedList.Insert(dataObject,position);
            LinkedList.PrintLikedList();
            ///Print The Size Of Linked List
            Console.Write("\nSize is :   ");
             LinkedList.Size();


            ///To check IsEmpty Of Linked List
            ///
            Console.WriteLine("IsEmpty : " + LinkedList.IsEmpty());
            

            Console.ReadKey();
        }
    }
}
