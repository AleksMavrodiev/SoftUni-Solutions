using System.Security.Cryptography.X509Certificates;

namespace SoftUni;

using System.Globalization;
using System.Text;

using Microsoft.EntityFrameworkCore;

using Data;
using Models;

public class StartUp
{
    static void Main(string[] args)
    {

        SoftUniContext dbContext = new SoftUniContext();

        Console.WriteLine(DeleteProjectById(dbContext));
    }

    //Task 3
    public static string GetEmployeesFullInformation(SoftUniContext context)
    {
        StringBuilder sb = new StringBuilder();

        var employees = context.Employees
            .OrderBy(e => e.EmployeeId)
            .Select(e => new
            {
                e.FirstName,
                e.LastName,
                e.MiddleName,
                e.JobTitle,
                e.Salary
            })
            .ToArray();

        foreach (var e in employees)
        {
            sb
                .AppendLine($"{e.FirstName} {e.LastName} {e.MiddleName} {e.JobTitle} {e.Salary:f2}");
        }

        return sb.ToString().TrimEnd();
    }

    //Task 4
    public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
    {
        StringBuilder sb = new StringBuilder();
        var employees = context.Employees.Where(e => e.Salary > 50000).Select(e => new
        {
            e.FirstName,
            e.Salary
        }).OrderBy(e => e.FirstName).ToArray();
        foreach (var e in employees)
        {
            sb.AppendLine($"{e.FirstName} - {e.Salary:f2}");
        }

        return sb.ToString().TrimEnd();
    }

    //Task 5

    public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
    {
        StringBuilder sb = new StringBuilder();

        var employees = context.Employees.Where(e => e.Department.Name == "Research and Development")
            .Select(e => new
            {
                e.FirstName,
                e.LastName,
                DepartmentName = e.Department.Name,
                e.Salary
            }).OrderBy(e => e.Salary)
            .ThenByDescending(e => e.FirstName)
            .ToArray();

        foreach (var e in employees)
        {
            sb.AppendLine($"{e.FirstName} {e.LastName} from {e.DepartmentName} - ${e.Salary:f2}");
        }

        return sb.ToString().TrimEnd();
    }

    //Task 6
    public static string AddNewAddressToEmployee(SoftUniContext context)
    {
        Address newAddress = new Address()
        {
            AddressText = "Vitoshka 15",
            TownId = 4
        };

        Employee employee = context.Employees.FirstOrDefault(e => e.LastName == "Nakov");
        employee.Address = newAddress;

        context.SaveChanges();

        string[] employeeAdresses = context.Employees.OrderByDescending(e => e.AddressId).Take(10)
            .Select(e => e.Address.AddressText).ToArray();
        return string.Join(Environment.NewLine, employeeAdresses);
    }

    public static string GetEmployeesInPeriod(SoftUniContext context)
    {
        StringBuilder output = new StringBuilder();

        var filteredEmployees = context
            .Employees
            .Where(e => e.EmployeesProjects
                .Any(ep => ep.Project.StartDate.Year >= 2001 && ep.Project.StartDate.Year <= 2003))
            .Take(10)
            .Select(e => new
            {
                e.FirstName,
                e.LastName,
                ManagerFirstName = e.Manager.FirstName,
                ManagerLastName = e.Manager.LastName,
                AllProject = e.EmployeesProjects
                    .Select(ep => new
                    {
                        ep.Project.Name,
                        ep.Project.StartDate,
                        ep.Project.EndDate
                    })
            })
            .ToList();



        foreach (var em in filteredEmployees)
        {
            output.AppendLine($"{em.FirstName} {em.LastName} - Manager: {em.ManagerFirstName} {em.ManagerLastName}");

            foreach (var project in em.AllProject)
            {
                var endDate = project.EndDate.HasValue
                    ? project.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt")
                    : "not finished";

                output.AppendLine(
                    $"--{project.Name} - {project.StartDate.ToString("M/d/yyyy h:mm:ss tt")} - {endDate}");
            }
        }


        return output.ToString().TrimEnd();
    }

    //Task 8

    public static string GetAddressesByTown(SoftUniContext context)
    {
        StringBuilder output = new StringBuilder();

        var allAddresses = context
            .Addresses
            .OrderByDescending(a => a.Employees.Count)
            .ThenBy(a => a.Town.Name)
            .ThenBy(a => a.AddressText)
            .Select(a => new
            {
                a.AddressText,
                a.Town.Name,
                EmployeesOnTheAddress = a.Employees.Count
            })
            .Take(10)
            .ToList();


        foreach (var address in allAddresses)
        {
            output.AppendLine($"{address.AddressText}, {address.Name} - {address.EmployeesOnTheAddress} employees");
        }


        return output.ToString().TrimEnd();


    }

    //Task 9

    public static string GetEmployee147(SoftUniContext context)
    {
        StringBuilder output = new StringBuilder();

        var employee147 = context
            .Employees
            .Where(e => e.EmployeeId == 147)
            .Select(e => new
            {
                e.FirstName,
                e.LastName,
                e.JobTitle,
                Projects = e.EmployeesProjects
                    .OrderBy(ep => ep.Project.Name)
                    .Select(ep => new
                    {
                        ProjectName = ep.Project.Name,
                    })
                    .ToArray()
            })
            .First();

        output.AppendLine($"{employee147.FirstName} {employee147.LastName} - {employee147.JobTitle}");
        foreach (var project in employee147.Projects)
        {
            output.AppendLine($"{project.ProjectName}");
        }

        return output.ToString().TrimEnd();
    }

    //Task 10

    public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
    {
        StringBuilder output = new StringBuilder();

        var allDepartments = context.Departments.Where(e => e.Employees.Count
         > 5).OrderBy(x => x.Employees.Count).ThenBy(dep => dep.Name).Select(d => new
        {
            d.Name,
            ManagerFirstName = d.Manager.FirstName,
            ManagerLastName = d.Manager.LastName,
            Employees = d.Employees.OrderBy(e => e.FirstName).ThenBy(e => e.LastName).Select(e => new
            {
                e.FirstName,
                e.LastName,
                e.JobTitle
            }).ToArray(),
            
        }).ToArray();

        foreach (var department in allDepartments)
        {
            output.AppendLine($"{department.Name} – {department.ManagerFirstName} {department.ManagerLastName}");
            foreach (var employee in department.Employees)
            {
                output.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");
            }
        }

        return output.ToString().TrimEnd();
    
    }

    //Task 11

    public static string GetLatestProjects(SoftUniContext context)
    {
        StringBuilder output = new StringBuilder();
        var projects = context.Projects.OrderByDescending(x => x.StartDate).Take(10).Select(p => new
        {
            p.Name,
            p.Description,
            p.StartDate
        }).ToList();
        
        foreach (var project in projects.OrderBy(x => x.Name))
        {
            output.AppendLine(project.Name);
            output.AppendLine(project.Description);
            output.AppendLine(project.StartDate.ToString("M/d/yyyy h:mm:ss tt"));
        }

        return output.ToString().TrimEnd();
    }

    //Task 12

    public static string IncreaseSalaries(SoftUniContext context)
    {
        StringBuilder output = new StringBuilder();

        var employeesForSalaryIcrease = context
            .Employees
            .Where(employee => employee.Department.Name == "Engineering" ||
                               employee.Department.Name == "Tool Design" ||
                               employee.Department.Name == "Marketing" ||
                               employee.Department.Name == "Information Services")
            .OrderBy(employee => employee.FirstName)
            .ThenBy(employee => employee.LastName)
            .ToList();

        foreach (var em in employeesForSalaryIcrease)
        {

            em.Salary += em.Salary * 0.12m;

        }

        context.SaveChanges();


        foreach (var em in employeesForSalaryIcrease)
        {
            output.AppendLine($"{em.FirstName} {em.LastName} (${em.Salary:F2})");

        }



        return output.ToString().TrimEnd();
    }

    //Task 13
    public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
    {
        StringBuilder output = new StringBuilder();
        var employees = context.Employees.Where(em => em.FirstName.StartsWith("Sa")).Select(em => new 
        {
            em.FirstName,
            em.LastName,
            em.JobTitle,
            em.Salary
        }).OrderBy(e => e.FirstName).ThenBy(e => e.LastName).ToArray();

        foreach (var employee in employees)
        {
            output.AppendLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle} - (${employee.Salary:F2})");
        }

        return output.ToString().TrimEnd(); 
    }

    public static string DeleteProjectById(SoftUniContext context)
    {
        StringBuilder output = new StringBuilder();
        var projectToDelete = context.Projects.Find(2);
        var referredProjects = context.EmployeeProjects.Where(p => p.ProjectId == 2).ToArray();

        context.EmployeeProjects.RemoveRange(referredProjects);
        context.Projects.Remove(projectToDelete);

        context.SaveChanges();

        foreach (var project in context.Projects.ToArray().Take(10))
        {
            output.AppendLine(project.Name);
        }

        return output.ToString().TrimEnd();
    }

    //Task 15

    public static string RemoveTown(SoftUniContext context)
    {
        StringBuilder output = new StringBuilder();

        var townToDelete = context
            .Towns?
            .Where(t => t.Name == "Seattle")
            .FirstOrDefault();

        var refferedAddresses = context
            .Addresses
            .Where(a => a.TownId == townToDelete.TownId)
            .ToList();

        foreach (var e in context.Employees)
        {
            if (refferedAddresses.Any(x => x.AddressId == e.AddressId))
            {
                e.AddressId = null;
            }
        }

        var numberOfAddressesDeleted = refferedAddresses.Count;


        context.Addresses.RemoveRange(refferedAddresses);
        context.Towns.Remove(townToDelete);

        context.SaveChanges();

        return $"{numberOfAddressesDeleted} addresses in Seattle were deleted"
    }
}