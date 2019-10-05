using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataStructurePrograms.StackOperation;

    namespace DataStructurePrograms.LinkedListOperation
{
    public class BalancedParentheses
    {
      
       public static bool BalancedParanthesChecker()
        {
            string expression = "(5+6)∗(7+8)/(4+3)(5+6)∗(7+8)/(4+3)";
           for(int i=0;i<expression.Length;i++)
            {
                if(expression.ElementAt(i)=='(')
                {
                  object  dataObject = (object)Convert.ChangeType(expression.ElementAt(i), typeof(object));
                    Stack.Push(dataObject); 
                }
                else if(expression.ElementAt(i)==')')
                {
                    for(int j=i-1;j>=0;j--)
                    {
                        Stack.Pop();
                        if(expression.ElementAt(j)==')')
                        {
                            return false;
                        }
                       else if(expression.ElementAt(j)=='(')
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

           if(Stack.IsEmpty())
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
