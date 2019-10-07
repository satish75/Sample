// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// ----------------------------------------------------------------------------------------------------------------
namespace DataStructurePrograms
{
    using System;
    using DataStructurePrograms.LinkedListOperation;
    using DataStructurePrograms.StackOperation;
  
    /// <summary>
    /// This Is Node Structure Of Linked List Node.
    /// </summary>
    public class Node
    {
        /// <summary>
        /// The data order is variable which is used to take data from user.
        /// </summary>
        public object Data;

        /// <summary>
        /// The next pointer is variable which is used to stored address.
        /// </summary>
        public Node Next;

        /// <summary>
        /// Performs an implicit conversion from <see cref="NodeOrder"/> to <see cref="Node"/>.
        /// </summary>
        /// <param name="v">The v.</param>
        /// <returns>
        /// The result of the conversion.
        /// </returns>
        /// <exception cref="NotImplementedException">it occurs exception</exception>
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
        /// <summary>
        /// The data order is variable which is used to take data from user.
        /// </summary>
        public int DataOrder;

        /// <summary>
        /// The next pointer is variable which is used to stored address.
        /// </summary>
        public NodeOrder Next;
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
                Console.WriteLine("1. Linked List Basic Operation \n" + "2. Stack Operation\n" + "3. Queue Operation\n" +
                    "4. UnorderLinked List Program\n" + "5. Order List Search Program\n" + "6. Balanced Parentheses\n" +
                    "7. Banking Cash Counter\n" + "8. IsPalindrome Check\n" + "9. Hashing\n" +
                    "10.Binary Search Tree\n" + "11. Prime Range 2D Array\n");
                Console.WriteLine("*********************************** ");
                Console.WriteLine("Enter Your Choice To Run Operation ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        LinkedList.LinkedListBasics();
                        break;
                    case 2:
                        StackOperation.Utility.StackOperation();
                        break;
                    case 3:
                        QueueOperation.Utility.QueueOperation();
                        break;
                    case 4:
                        UnOrderedList.WordOfLinkedList();
                        break;
                    case 5:
                        OrderList.OrderListSearch();
                        break;
                    case 6:
                        bool res = BalancedParentheses.BalancedParanthesChecker();
                        Console.WriteLine("Results :" + res);
                        break;
                    case 7:
                        BankingCashCounter.BankingCounter();
                        break;
                    case 8:
                        Console.WriteLine("Enter String To check Palindrome ");
                        string stringItem = Console.ReadLine();
                        Console.WriteLine("  " + PalindromeChecker.IsPalindrome(stringItem));
                        break;
                    case 9:
                        HashingFunction.Hashing();
                        break;
                    case 10:
                        NumberofBinarySearchTree.CalculateNumberOfTree();
                        break;
                    default:
                        Console.WriteLine("Please Enter Valide Number");
                        break;
                }

                Console.WriteLine("\nDo You want To Continue the Press 'Y' Or 'N' ");
                again = Console.ReadLine()[0];
            }
            while (again == 'Y' || again == 'y');

            Console.ReadKey();
        }
    }
}
