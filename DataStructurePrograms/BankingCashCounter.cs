// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BankingCashCounter.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// -----------------------------------------------------------------------------------
namespace DataStructurePrograms
{
    using System;
    using DataStructurePrograms.LinkedListOperation;
    using DataStructurePrograms.QueueOperation;

    /// <summary>
    /// This is Banking Cash Counter class.
    /// </summary>
    public class BankingCashCounter
    {
        /// <summary>
        /// The bank balance available of bank.
        /// </summary>
        private static int bankBalance = 100000;

        /// <summary>
        /// Banking the counter.
        /// </summary>
        public static void BankingCounter()
        {
            Console.WriteLine("Enter how Many User Do You Want ");
            int numberOfUser = Convert.ToInt32(Console.ReadLine());
            string userName;
            char again;
            for (int i = 1; i <= numberOfUser; i++)
            {
                Console.WriteLine("Enter User Name ");
                userName = Console.ReadLine();
                Queue.Enqueue(userName);
            }

            for (int j = 1; j <= numberOfUser; j++)
            {
                object data = Queue.Dequeue();
                userName = data.ToString();
                Console.WriteLine("**********************************");
                Console.WriteLine(" User :" + userName);
                do
                {
                    Console.WriteLine("1. Withdrawal\n" + "2.Deposite\n" + "3. Remaining Users");
                    Console.WriteLine("Enter Your Choice To Run Operation ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter Withdraw Amount : ");
                            int withdraw = Convert.ToInt32(Console.ReadLine());
                            bankBalance = bankBalance - withdraw;
                            break;
                        case 2:
                            Console.WriteLine("Enter Deposite Amount : ");
                            int deposite = Convert.ToInt32(Console.ReadLine());
                            bankBalance = bankBalance + deposite;
                            break;
                        case 3:
                            Console.WriteLine("Remaining Users  : ");
                            LinkedList.Print();
                            break;
                    }

                    Console.WriteLine("\nDo You want To Continue the Press 'Y' Or 'N' ");
                    again = Console.ReadLine()[0];
                }
                while (again == 'Y' || again == 'y');

                Console.WriteLine("*********************************** ");
            }

            Console.WriteLine("Available Bank Balance  " + bankBalance);
        }
    }
}
