using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPE200Lab1
{
    class RPNCalculatorEngine : CalculatorEngine
    {
        public string Process(string str)
        {
            string result = string.Empty;

            Stack<string> rpnStack = new Stack<string>();
            List<string> parts = str.Split(' ').ToList<string>();
            foreach (string item in parts)
            {
                if (isNumber(item))
                {
                    rpnStack.Push(item);
                }
                if (isOperator(item))
                {
                    string second = rpnStack.Pop();
                    string first = rpnStack.Pop();
                    result = calculate(item, first, second);
                    rpnStack.Push(result);
                }
            }
            return result;
        }
    }
}