// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Utility.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// -----------------------------------------------------------------------------------
namespace DataStructurePrograms.QueueOperation
{
    using System;

    /// <summary>
    /// This is queue utility class.
    /// </summary>
    public class Utility
    {
        /// <summary>
        /// Queue the operation.
        /// </summary>
        public static void QueueOperation()
        {
            char again;
            do
            {
                Console.WriteLine("**********************************");
                Console.WriteLine("1. Queue Enqueue \n" + "2. Queue Dequeue\n" + "3. Queue IsEmpty\n" +
                      "4. Queue Size\n" + "5 Dequeue AddFront\n" + "6. Dequeue AddRear\n" + "7. Dequeue Remove Front\n" +
                      "8.  Dequeue Remove Rear.\n" +
                      "9. Dequeue IsEmpty\n" + "10. Dequeue Size\n");
                Console.WriteLine("*********************************** ");
                Console.WriteLine("Enter Your Choice To Run Operation ");
                int choice = Convert.ToInt32(Console.ReadLine());
                string data;
                object dataObject;
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("How Many Element Do You Want to Stored ");
                       int noOfNodes = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Item To Push");
                        for (int i = 0; i < noOfNodes; i++)
                        {
                            string item = Console.ReadLine();
                            dataObject = (object)Convert.ChangeType(item, typeof(object));
                           Queue.Enqueue(dataObject);
                        }

                        break;
                    case 2:
                      Queue.Dequeue();
                        break;
                    case 3:
                        Console.WriteLine("Result " + Queue.IsEmpty());
                        break;
                    case 4:
                        Console.WriteLine("Size Of Queue " + Queue.Size());
                        break;
                    case 5:
                        Console.WriteLine("Enter Item To Add ");
                         data = Console.ReadLine();
                        Dequeue.AddFront(data);
                        break;
                    case 6:
                        Console.WriteLine("Enter Item To Add ");
                        data = Console.ReadLine();
                        Dequeue.AddRear(data);
                        break;
                    case 7:
                        Dequeue.RemoveFront();
                        break;
                    case 8:
                        Dequeue.RemoveRear();
                        break;
                    case 9:
                        Console.WriteLine(" " + Dequeue.IsEmpty());
                        break;
                    case 10:
                        Console.WriteLine("  " + Dequeue.Size());
                        break;
                    default:
                        Console.WriteLine("Please Enter Valide Number");
                        break;
                }

                Console.WriteLine("\nDo You want To Continue the Press 'Y' Or 'N' ");
                again = Console.ReadLine()[0];
            }
            while (again == 'Y' || again == 'y');
            Console.WriteLine("\nYou Come Out From Queue Operation....");
        }
    }
}
