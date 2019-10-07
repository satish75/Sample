// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PalindromeChecker.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// ------------------------------------------------------------------------------------
namespace DataStructurePrograms
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// This is Palindrome class.
    /// </summary>
    public class PalindromeChecker
    {
        /// <summary>
        /// Determines whether the specified item is palindrome.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>
        ///   <c>true</c> if the specified item is palindrome; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsPalindrome(object item)
        { 
            string originString;
            originString = (string)Convert.ChangeType(item, typeof(string));
            originString = originString.ToLower();
            string newString = string.Empty;
            char[] charArray = originString.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                QueueOperation.Dequeue.AddRear(charArray[i]);
            }

            for (int j = 0; j < charArray.Length; j++)
            {
                object objectItem = QueueOperation.Dequeue.RemoveRear();
                Console.WriteLine("objetc " + objectItem);
                if (objectItem.Equals(-1))
                {
                    break;
                }

                string charItem = objectItem.ToString();
                newString = newString + charItem;
            }

            if (newString.Equals(originString))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
