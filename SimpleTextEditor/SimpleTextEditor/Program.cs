using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
class Solution
{
    static void Main(String[] args)
    {
        int cases = Convert.ToInt32(Console.ReadLine());
        string operation;
        string toAdd;
        int charsToRemove;
        int numToPrint;
        Stack<string> strStack = new Stack<string>();
        string s = "";
        StringBuilder sb = new StringBuilder();

        for (int i = 0; i < cases; i++)
        {
            var line = Console.ReadLine();
            if (line.StartsWith("1"))
            {
                toAdd = line.Split(' ')[1];
                s = s + toAdd;
                strStack.Push(s);
            }
            else if (line.StartsWith("2"))
            {
                charsToRemove = Convert.ToInt32(line.Split(' ')[1]);
                s = s.Substring(0, (s.Length - charsToRemove));
                strStack.Push(s);
            }
            else if (line.StartsWith("3"))
            {
                numToPrint = Convert.ToInt32(line.Split(' ')[1]);
                sb.Append($"{s[numToPrint - 1]}\n");
            }
            else
            {
                strStack.Pop();
                if (strStack.Count > 0)
                {
                    s = strStack.Peek();
                }
                else
                {
                    s = "";
                }
            }
        }
        Console.Write(sb.ToString());
    }
}
