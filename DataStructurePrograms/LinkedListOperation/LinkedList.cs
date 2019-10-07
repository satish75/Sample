// --------------------------------------------------------------------------------------------------------------------
// <copyright file="LinkedList.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// ----------------------------------------------------------------------------------------------
namespace DataStructurePrograms.LinkedListOperation
{
    using System;

    /// <summary>
    /// This Is Linked List Class
    /// </summary>
    public class LinkedList
    {
        /// <summary>
        /// Linked the list basics.
        /// </summary>
        public static void LinkedListBasics()
        {
            char again;
            do
            {
                Console.WriteLine("**********************************");
                Console.WriteLine("1. Add Node \n" + "2. Print\n" + "3. Remove\n" + "4. Search\n" + "5. IsEmpty\n" + "6. Size\n" + "7. Append\n" + "8. Index\n" + "9. Insert \n" + "10. Pop\n" + "11. Pop With Position\n" + "12. Order Linked List Add Operation\n" + "13. Order List Print " + "\n14. Remove Order List \n" + "15. Order Linked List Search Item");
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
                            Add(dataObject);
                        }

                        break;
                    case 2:
                        Print();
                        break;
                    case 3:
                        Console.WriteLine("\nEnter Item For Remove : ");
                        data = Console.ReadLine();
                        dataObject = (object)Convert.ChangeType(data, typeof(object));
                        Remove(dataObject);
                        break;
                    case 4:
                        Console.WriteLine("\nEnter Element For Search : ");
                        string search = Console.ReadLine();
                        dataObject = (object)Convert.ChangeType(search, typeof(object));
                        Console.WriteLine(" " + Search(dataObject));
                        break;
                    case 5:
                        Console.WriteLine(" " + IsEmpty());
                        break;
                    case 6:
                        Size();
                        break;
                    case 7:
                        Console.WriteLine("\nEnter data to Append : ");
                        data = Console.ReadLine();
                        dataObject = (object)Convert.ChangeType(data, typeof(object));
                        Append(dataObject);
                        break;
                    case 8:
                        Console.WriteLine("\nEnter Element Index Position : ");
                        data = Console.ReadLine();
                        dataObject = (object)Convert.ChangeType(data, typeof(object));
                        Console.WriteLine(" " + Index(dataObject));
                        break;
                    case 9:
                        Console.WriteLine("\nEnter Node to add  : ");
                        data = Console.ReadLine();
                        dataObject = (object)Convert.ChangeType(data, typeof(object));
                        Console.WriteLine("\nEnter position where You want to add element: ");
                        int position = Convert.ToInt32(Console.ReadLine());
                       Insert(dataObject, position);
                        break;
                    case 10:
                        Pop();
                        break;
                    case 11:
                        Console.WriteLine("\nEnter Position To Pop the Element : ");
                        int positionForPop = Convert.ToInt32(Console.ReadLine());
                        Pop(positionForPop);
                        break;
                    case 12:
                        Console.WriteLine("How Many Nodes Do you want to create");
                         noOfNodes = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < noOfNodes; i++)
                        {
                            Console.WriteLine("Enter Data For Node :");
                           int dataInt = Convert.ToInt32(Console.ReadLine());
                            OrderLinkedList.AddOrder(dataInt);
                        }

                        break;
                    case 13:
                        OrderLinkedList.Print();
                        break;
                    case 14:
                        Console.WriteLine("Enter Item To Remove :");
                        int dataRenove = Convert.ToInt32(Console.ReadLine());
                        OrderLinkedList.Remove(dataRenove);
                        break;
                    case 15:
                        Console.WriteLine("Enter Item To Search :");
                        int dataSearch = Convert.ToInt32(Console.ReadLine());
                        OrderLinkedList.Remove(dataSearch);
                        break;
                    default:
                        Console.WriteLine("Please Enter Valide Number");
                        break;
                }

                Console.WriteLine("\nDo You want To Continue the Press 'Y' Or 'N' ");
                again = Console.ReadLine()[0];
            }
            while (again == 'Y' || again == 'y');

            Console.WriteLine("\nYou Come Out From Linked List  Operation....\n\n");
        }

        /// <summary>
        /// Add the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public static void Add(object data)
        {
            Utility.Add(data);
        }

        /// <summary>
        /// Print this instance.
        /// </summary>
        public static void Print()
        {
            Utility.Print();
        }

        /// <summary>
        /// Add the first.
        /// </summary>
        /// <param name="data">The data.</param>
        public static void AddFirst(object data)
        {
            Utility.AddFirst(data);
        }

        /// <summary>
        /// Append the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        public static void Append(object data)
        {
            Utility.Append(data);
        }

        /// <summary>
        /// Insert the specified data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="position">The position.</param>
        public static void Insert(object data, int position)
        {
            Utility.Insert(data, position);
        }

        /// <summary>
        /// Size this instance.
        /// </summary>
        /// <returns>this function return size </returns>
        public static int Size()
        {
            return Utility.Size();
        }

        /// <summary>
        /// Determines whether this instance is empty.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if this instance is empty; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsEmpty()
        {
            return Utility.IsEmpty();
        }

        /// <summary>
        /// Search the specified search item.
        /// </summary>
        /// <param name="searchItem">The search item.</param>
        /// <returns>it return search element</returns>
        public static bool Search(object searchItem)
        {
            return Utility.Search(searchItem);
        }

        /// <summary>
        /// Indexes the specified search item.
        /// </summary>
        /// <param name="searchItem">The search item.</param>
        /// <returns>it return index value</returns>
        public static int Index(object searchItem)
        {
            return Utility.Index(searchItem);
        }

        /// <summary>
        /// Remove the specified remove item.
        /// </summary>
        /// <param name="removeItem">The remove item.</param>
        public static void Remove(object removeItem)
        {
            Utility.Remove(removeItem);
        }

        /// <summary>
        /// Pop this instance.
        /// </summary>
        public static void Pop()
        {
             Utility.Pop();
        }

        /// <summary>
        /// Pop the specified position.
        /// </summary>
        /// <param name="position">The position.</param>
        /// <returns>it return data element</returns>
        public static object Pop(int position)
        {
            return Utility.Pop(position);
        }

        /// <summary>
        /// Peek this instance.
        /// </summary>
        /// <returns>it return top element</returns>
        public static object Peek()
        {
            return Utility.Peek();
        }
    }
}