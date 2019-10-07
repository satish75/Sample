// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// -----------------------------------------------------------------------------------
namespace DataStructurePrograms.StackOperation
{
    using System;
    using DataStructurePrograms.LinkedListOperation;

    /// <summary>
    /// This is stack utility class.
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Stack the operation.
        /// </summary>
        public static void StackOperation()
        {
            char again;
            do
            {
                Console.WriteLine("**********************************");
                Console.WriteLine("1. Stack Push \n" + "2. Stack Pop\n" + "3. Stack Peek\n" + "4. IsEmpty\n"
                     + "5. Stack Size\n");
                Console.WriteLine("*********************************** ");
                Console.WriteLine("Enter Your Choice To Run Operation ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("How Many Element Do You Want to push ");
                       int noOfNodes = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Item To Push");
                        for (int i = 0; i < noOfNodes; i++)
                        {
                            string item = Console.ReadLine();
                            Stack.Push(item);
                        }

                        break;
                    case 2:
                        Stack.Pop();
                        break;
                    case 3:
                        Stack.Peek();
                        break;
                    case 4:
                        Console.WriteLine("IsEmpty  : " + Stack.IsEmpty());
                        break;
                    case 5:
                        Console.WriteLine("Size  : " + Stack.Size());
                        break;
                    default:
                        Console.WriteLine("Please Enter Valide Number");
                        break;
                }

                Console.WriteLine("\nDo You want To Continue the Press 'Y' Or 'N' ");
                again = Console.ReadLine()[0];
            }
            while (again == 'Y' || again == 'y');

            Console.WriteLine("\nYou Come Out From Stack Operation....");
        }
    }
}
