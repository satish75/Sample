using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
   public class PalindromeChecker
    {
        public static bool IsPalindrome(object item)
        { 
            string originString ;
            originString = (string)Convert.ChangeType(item, typeof(string));
            originString = originString.ToLower();
            string newString = "";
            char[] charArray = originString.ToCharArray();
            
            for (int i=0;i<charArray.Length;i++)
            {
                QueueOperation.Dequeue.AddRear(charArray[i]);
            }
            for(int j=0;j<charArray.Length;j++)
            {
                object objectItem = QueueOperation.Dequeue.RemoveRear();
                string charItem = objectItem.ToString();
                newString = newString + charItem;
            }
            if(newString.Equals(originString))
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
