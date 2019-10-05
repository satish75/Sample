using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructurePrograms
{
    public class PrimeRange2D
    {
        public static bool PrimeNumberrange(int a)
        {
         

           /// int k = 0, m = 0;
                bool flag = true;
                for(int j=2;j<a;j++)
                {
                    if(a%j==0)
                    {
                        flag=false;
                    }
                }
                if(flag)
                {
                return true;
                }
                else
            {
                return false;
            }
           /*     for (int l = 0; l < 10; l++)
                {
                    for (int j = 0; j < 100; j++)
                    {
                        Console.Write(" " + array[l, j]); 
                    }
                    Console.WriteLine();
                }
                */
        }
        public static void StoredIn2DArray()
        {
            int[,] array = new int[10,100];
            Console.WriteLine("Enter Range");
            int range = Convert.ToInt32(Console.ReadLine());
            int l, j ;

          
            for (int i=2;i<range;i++)
            {
                bool result = PrimeNumberrange(i);
               
                if(result)
                {
                    for (int m = 0; m < 10; m++)
                    {
                        for (int p = 0; p < 100; p++)
                        {

                         
                            if(array[m, p] == 0)
                            {
                                array[m, p] = i;
                                break;
                            }
                        }
                       
                    }
                }
            
            }
            for ( l = 0; l < 10; l++)
            {
                for ( j = 0; j < 100; j++)
                {
                        Console.Write(" " + array[l,j]);

                }
            }
            
        }
    }
}
