// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BalancedParentheses.cs" company="Bridgelabz">
//   Copyright © 2019 Company
// </copyright>
// <creator name="Satish Dodake"/>
// -----------------------------------------------------------------------------------
namespace DataStructurePrograms.LinkedListOperation
{
    using System;
    using System.Linq;
    using DataStructurePrograms.StackOperation;

    /// <summary>
    /// This is Balanced Parenthesis class.
    /// </summary>
    public class BalancedParentheses
    {
        /// <summary>
        /// Balanced the parenthesis  checker.
        /// </summary>
        /// <returns>It return boolean value</returns>
        public static bool BalancedParanthesChecker()
        {
            Console.WriteLine("Enter Expression ");
            string expression = Console.ReadLine();
           for (int i = 0; i < expression.Length; i++)
            {
                if (expression.ElementAt(i) == '(')
                {
                  object dataObject = (object)Convert.ChangeType(expression.ElementAt(i), typeof(object));
                    Stack.Push(dataObject); 
                }
                else if (expression.ElementAt(i) == ')')
                {
                    for (int j = i - 1; j >= 0; j--)
                    {
                        Stack.Pop();
                        if (expression.ElementAt(j) == ')')
                        {
                            return false;
                        }
                       else if (expression.ElementAt(j) == '(')
                        {
                            Stack.Pop();
                            break;
                        }
                    }
                }
                else
                {
                    Stack.Push(expression.ElementAt(i));
                }
            }

           if (Stack.IsEmpty())
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
