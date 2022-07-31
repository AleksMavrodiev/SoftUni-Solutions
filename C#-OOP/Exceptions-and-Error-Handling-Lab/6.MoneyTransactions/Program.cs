using System;
using System.Collections.Generic;

namespace _6.MoneyTransactions
{
    public class Program
    {
        public static object Dictionay { get; private set; }

        static void Main(string[] args)
        {
            Dictionary<int, double> bankAccounts = new Dictionary<int, double>();
            string[] info = Console.ReadLine().Split(',', StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < info.Length; i++)
            {
                int index = int.Parse(info[i].Split('-')[0]);
                double money = double.Parse(info[i].Split('-')[1]);
                bankAccounts.Add(index, money);
            }

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                try
                {
                    string action = cmdArgs[0];
                    int account = int.Parse(cmdArgs[1]);
                    double amount = double.Parse(cmdArgs[2]);
                    if (action == "Deposit")
                    {
                        Deposit(bankAccounts, account, amount);
                    }
                    else if (action == "Withdraw")
                    {
                        Withdraw(bankAccounts, account, amount);
                    }
                    else
                    {
                        throw new ArgumentException("Invalid command!");
                    }
                    Console.WriteLine($"Account {account} has new balance: {bankAccounts[account]:F2}");
                }
                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                }
                finally
                {
                    Console.WriteLine("Enter another command");
                }
            }
        }

        static void Withdraw(Dictionary<int, double> bankAccounts, int account, double amount)
        {
            if (!bankAccounts.ContainsKey(account))
            {
                throw new ArgumentException("Invalid account!");
            }
            if (bankAccounts[account] < amount)
            {
                throw new ArgumentException("Insufficient balance!");
            }
            bankAccounts[account] -= amount;
        }

        static void Deposit(Dictionary<int, double> bankAccounts, int account, double amount)
        {
            if (!bankAccounts.ContainsKey(account))
            {
                throw new ArgumentException("Invalid account!");
            }
            bankAccounts[account] += amount;
        }
    }
}
