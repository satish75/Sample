using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    public class NumberofBinarySearchTree
    {
        public static void CalculateNumberOfTree()
        {
            try
            {
                Console.WriteLine("Enter Key Value ");
                int numberOfNode = Convert.ToInt32(Console.ReadLine());
                int catalanNumber = Factorial(2 * numberOfNode) / (Factorial(numberOfNode + 1) * Factorial(numberOfNode));
                Console.WriteLine("Number Of BST : " + catalanNumber);
            }
            catch(ArithmeticException e)
            {
                Console.WriteLine(e);
            }
          
        }
        public static int Factorial(int key)
        {
           // int fact = 1;
            if (key == 0)
                return 1;
            return key * Factorial(key - 1);
        }
    }
}
