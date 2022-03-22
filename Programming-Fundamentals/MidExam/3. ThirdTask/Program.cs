using System;
using System.Collections.Generic;

namespace _3._ThirdTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> messeges = new List<string>();
            string command = String.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = cmdArgs[0];
                if (action == "Chat")
                {
                    string messeageToChat = cmdArgs[1];
                    messeges.Add(messeageToChat);
                }
                else if (action == "Delete")
                {
                    string messegeToDelete = cmdArgs[1];
                    if (messeges.Contains(messegeToDelete))
                    {
                        messeges.Remove(messegeToDelete);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (action == "Edit")
                {
                    string messegeToEdit = cmdArgs[1];
                    string editedMessege = cmdArgs[2];
                    if (messeges.Contains(messegeToEdit))
                    {
                        int indexOfMessege = messeges.IndexOf(messegeToEdit);
                        messeges[indexOfMessege] = editedMessege;
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (action == "Pin")
                {
                    string messegeToPin = cmdArgs[1];
                    if (messeges.Contains(messegeToPin))
                    {
                        int indexOfMessege = messeges.IndexOf(messegeToPin);
                        string oldValue = messeges[indexOfMessege];
                        messeges.RemoveAt(indexOfMessege);
                        messeges.Add(oldValue);
                    }
                    else
                    {
                        continue;
                    }
                }
                else if (action == "Spam")
                {
                    for (int i = 1; i < cmdArgs.Length; i++)
                    {
                        messeges.Add(cmdArgs[i]);
                    }
                }
            }

            for (int i = 0; i < messeges.Count; i++)
            {
                Console.WriteLine(messeges[i]);
            }
        }
    }
}
