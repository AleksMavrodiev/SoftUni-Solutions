using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9._SimpleTextEditor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            Stack<string> textChanges = new Stack<string>();
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                int index = int.Parse(command[0]);
                if (index == 1)
                {
                    textChanges.Push(text.ToString());
                    string textToAppend = command[1];
                    text.Append(textToAppend);
                    
                }
                else if (index == 2)
                {
                    textChanges.Push(text.ToString());
                    int symbolsErased = int.Parse(command[1]);
                    text.Remove(text.Length - symbolsErased, symbolsErased);
                    
                }
                else if (index == 3)
                {
                    int searchIndex = int.Parse(command[1]);
                    Console.WriteLine(text[searchIndex - 1]);
                }
                else if (index == 4)
                {
                    text = new StringBuilder(textChanges.Pop());
                }
            }
        }
    }
}
