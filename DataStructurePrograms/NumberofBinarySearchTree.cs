﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="NumberofBinarySearchTree.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// -----------------------------------------------------------------------------------
namespace DataStructurePrograms
{
    using System;

    /// <summary>
    /// This Is binary search tree class example.
    /// </summary>
    public class NumberofBinarySearchTree
    {
        /// <summary>
        /// Calculates the number of tree.
        /// </summary>
        public static void CalculateNumberOfTree()
        {
            try
            {
                Console.WriteLine("Enter Key Value ");
                int numberOfNode = Convert.ToInt32(Console.ReadLine());
                int catalanNumber = Factorial(2 * numberOfNode) / (Factorial(numberOfNode + 1) * Factorial(numberOfNode));
                Console.WriteLine("Number Of BST : " + catalanNumber);
            }
            catch (ArithmeticException e)
            {
                Console.WriteLine(e);
            }
        }

        /// <summary>
        /// Factorials the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>this method return factorial of number</returns>
        public static int Factorial(int key)
        {
            if (key == 0)
            {
                return 1;
            }
            else
            {
                return key * Factorial(key - 1);
            } 
        }
    }
}
