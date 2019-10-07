// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PrimeRange2D.cs" company="Bridgelabz">
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
    /// This is Prime Number Class.
    /// </summary>
    public class PrimeRange2D
    {
        /// <summary>
        /// Primes the number range.
        /// </summary>
        /// <param name="a">a is parameter</param>
        /// <returns>it return prime number</returns>
        public static bool PrimeNumberrange(int a)
        {
                bool flag = true;
                for (int j = 2; j < a; j++)
                {
                    if (a % j == 0)
                    {
                        flag = false;
                    }
                }

                if (flag)
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
