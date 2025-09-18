using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{


    public class Calculator
    {
        public int Calculate(int a, int b, char op)
        {
            int result = 0;

            switch (op)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    result = a / b;
                    break;
                default:
                    Console.WriteLine("Invalid operation!");
                    break;
            }

            return result;
        }
    }

}
