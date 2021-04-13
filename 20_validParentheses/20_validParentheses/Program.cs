using System;
using System.Collections.Generic;

namespace _20_validParentheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "()";
            Console.WriteLine(IsValid(s));
        }

        public static bool IsValid(string p)
        {
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < p.Length; i++)
            {
                char next = p[i];
                if (next == '(' || next == '[' || next == '{')
                {
                    stack.Push(p[i]);
                }
                else if (next == ')' || next == ']' || p[i] == '}' && stack.Count != 0)
                {
                    char current = stack.Pop();
                    if (current == '(' && next != ')')
                        return false;
                    if (current == '{' && next != '}')
                        return false;
                    if (current == '[' && next != ']')
                        return false;
                }
                else
                {
                    return false;
                }
            }
            return stack.Count == 0;
        }
    }
}
