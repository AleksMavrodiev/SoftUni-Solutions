using System;
using System.Collections.Generic;

namespace _8._CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyEmployee = new Dictionary<string, List<string>>();
            string input = String.Empty;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = input.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string company = cmdArgs[0];
                string id = cmdArgs[1];
                if (companyEmployee.ContainsKey(company))
                {
                    if (!companyEmployee[company].Contains(id))
                    {
                        companyEmployee[company].Add(id);
                    }
                }
                else
                {
                    companyEmployee.Add(company, new List<string>());
                    companyEmployee[company].Add(id);
                }
            }
            foreach (var company in companyEmployee)
            {
                Console.WriteLine(company.Key);
                foreach (var employee in company.Value)
                {
                    Console.WriteLine($"-- {employee}");
                }
            }
        }
    }
}
