// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// ----------------------------------------------------------------------------------------------------------------
namespace DataStructurePrograms
{
    using DataStructurePrograms.LinkedListOperation;
    using DataStructurePrograms.StackOperation;
    using System;

    /// <summary>
    /// This Is Node Structure Of Linked List Node.
    /// </summary>
    public class Node
    {
        public object data;
        public Node next;

        public static implicit operator Node(NodeOrder v)
        {
            throw new NotImplementedException();
        }
    }
    /// <summary>
    /// This is Order Node Class.
    /// </summary>
    public class NodeOrder
    {
        public int dataOrder;
        public NodeOrder next;
    }

    /// <summary>
    /// This Is Main Class As Program
    /// </summary>
    public class Program 
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
       public static void Main(string[] args)
        {
            char again;
            do
            {
                Console.WriteLine("**********************************");
                Console.WriteLine("1. Add \n" + "2. Print\n" + "3. Remove\n" + /* "4. Search\n" +
                    "5. IsEmpty\n" + "6. Size\n" + "7. Append\n" + "8. Index\n" + "9. Insert \n" +
                    "10. Pop\n" + "11. Pop With Position\n" + "12. UorderList\n" + "13. orderList\n" + "14. Order Print\n" +
                    "15. Stack Push\n" + "16. Stack Pop\n" + "17.Stack Peek\n" + 
                    "18. Stack IsEmpty\n" + "19.  Size Of Stack\n" + "20. Balanced Paranthesis\n"
                     + "21. Enqueue\n" + "22. Dequeue \n" + 
                     "23. \n" + "24. Queue Size" + "25. BankingCashCounter" */"26.Deque AddFront\n" + "27. Deque AddRear\n" + 
                     "28. Deque RemoveFront\n" + "29. Deque RemoveRear" + 
                     "30 Deque IsEmpty\n" + "31. Deque Size\n" + "32. Palindrome\n" + "33.OrderLinked List Add Data\n" + 
                     "34. OrderLinked List Print\n" + "35. Order List Program");
                Console.WriteLine("*********************************** ");
                Console.WriteLine("Enter Your Choice To Run Operation ");
                int choice = Convert.ToInt32(Console.ReadLine());
                string data;
                object dataObject;
               
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("How Many Nodes Do you want to create");
                        int noOfNodes = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < noOfNodes; i++)
                        {
                            Console.WriteLine("Enter Data For Node :");
                            data = Console.ReadLine();
                            dataObject = (object)Convert.ChangeType(data, typeof(object));
                            LinkedList.Add(dataObject);
                        }
                        break;
                      case 2:
                        LinkedList.Print();
                        break;
                    case 3:
                        Console.WriteLine("\nEnter Item For Remove : ");
                        data = Console.ReadLine();
                        dataObject = (object)Convert.ChangeType(data, typeof(object));
                        LinkedList.Remove(dataObject);
                        break;
                    /*    case 4:
                            Console.WriteLine("\nEnter Element For Search : ");
                            string search = Console.ReadLine();
                            dataObject = (object)Convert.ChangeType(search, typeof(object));
                            Console.WriteLine(" " + LinkedList.Search(dataObject));
                            break;
                        case 5:
                            Console.WriteLine(" " + LinkedList.IsEmpty());
                            break;
                        case 6:
                           Console.WriteLine(LinkedList.Size());
                            break;
                        case 7:
                            Console.WriteLine("\nEnter data to Append : ");
                            data = Console.ReadLine();
                            dataObject = (object)Convert.ChangeType(data, typeof(object));
                            LinkedList.Append(dataObject);
                            break;
                        case 8:
                            Console.WriteLine("\nEnter Element Index Position : ");
                            data = Console.ReadLine();
                            dataObject = (object)Convert.ChangeType(data, typeof(object));
                            Console.WriteLine(" " + LinkedList.Index(dataObject));
                            break;

                        case 9:
                            Console.WriteLine("\nEnter Node to add  : ");
                            data = Console.ReadLine();
                            dataObject = (object)Convert.ChangeType(data, typeof(object));
                            Console.WriteLine("\nEnter position where You want to add element: ");
                            int position = Convert.ToInt32(Console.ReadLine());
                            LinkedList.Insert(dataObject, position);
                            break;
                        case 10:
                            LinkedList.Pop();
                            break;
                        case 11:
                            Console.WriteLine("\nEnter Position To Pop the Element : ");
                            int positionForPop = Convert.ToInt32(Console.ReadLine());
                             LinkedList.Pop(positionForPop);
                            break;
                        case 12:
                            UnOrderedList.WordOfLinkedList();
                            break;
                        case 13:
                            OrderLinkedList.AddOrder(12);
                            break;
                        case 14:
                            OrderLinkedList.Print();
                            break;
                        case 15:                  
                            Console.WriteLine("How Many Element Do You Want to push ");
                            noOfNodes = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Item To Push");
                            for (int i=0;i<noOfNodes;i++)
                            {
                                string item = Console.ReadLine();
                                Stack.Push(item);
                            }

                            break;
                        case 16:
                            Stack.Pop();
                            break;
                        case 17:
                            Stack.Peek();
                            break;
                        case 18:
                            Console.WriteLine("IsEmpty  : "+Stack.IsEmpty());
                            break;
                        case 19:
                            Console.WriteLine("Size  : " + Stack.Size());
                            break;
                        case 20:
                            bool res = BalancedParentheses.BalancedParanthesChecker();
                            Console.WriteLine("Results :" + res);
                            break;
                        case 21:
                            Console.WriteLine("How Many Element Do You Want to Stored ");
                            noOfNodes = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter Item To Push");
                            for (int i = 0; i < noOfNodes; i++)
                            {
                                string item = Console.ReadLine();
                                dataObject = (object)Convert.ChangeType(item, typeof(object));
                                QueueOperation.Queue.Enqueue(dataObject);
                            }
                            break;
                        case 22:
                            QueueOperation.Queue.Dequeue();
                            break;
                        case 23:
                            Console.WriteLine("Result " + QueueOperation.Queue.IsEmpty());
                            break;
                        case 24:
                            Console.WriteLine("Size Of Queue " + QueueOperation.Queue.Size());
                            break;
                        case 25:
                            BankingCashCounter.BankingCounter();
                            break;  */
                    case 26:
                        QueueOperation.Dequeue.AddFront(15);
                        break;
                    case 27:
                        QueueOperation.Dequeue.AddRear(20);
                        break;
                    case 28:
                        QueueOperation.Dequeue.RemoveFront();
                        break;
                    case 29:
                        QueueOperation.Dequeue.RemoveRear();
                        break;
                    case 30:
                        Console.WriteLine("Results " + QueueOperation.Dequeue.IsEmpty());
                        break;
                    case 31:
                        Console.WriteLine("Results " + QueueOperation.Dequeue.Size());
                        break;
                    case 32:
                        Console.WriteLine("Results Palindrome  " +PalindromeChecker.IsPalindrome("RadA"));
                        break;
                    case 33:
                        Console.WriteLine("How Many Element Do You Want to Stored ");
                        noOfNodes = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Item here ");
                        for (int i = 0; i < noOfNodes; i++)
                        {
                            int item = Convert.ToInt32(Console.ReadLine());
                            OrderLinkedList.AddOrder(item);
                        }
                        break;
                    case 34:
                        OrderLinkedList.Print();
                        break;
                    case 35:
                        OrderList.OrderListSearch();
                        break;
                    default:
                        Console.WriteLine("Please Enter Valide Number");
                        break;
                }

                Console.WriteLine("\nDo You want To Continue the Press 'Y' Or 'N' ");
                again = Console.ReadLine()[0];
            }
            while (again == 'Y' || again == 'y');

            ///Deque Method
            ///
           PrimeRange2D.StoredIn2DArray();

            ///  HashingFunction.Hashing();
           /// NumberofBinarySearchTree.CalculateNumberOfTree();
            
            Console.ReadKey();  
        }
    }
}
