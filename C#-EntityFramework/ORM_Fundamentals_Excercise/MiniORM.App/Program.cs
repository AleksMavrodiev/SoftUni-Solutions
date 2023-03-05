using MiniORM.App.Data;
using MiniORM.App.Data.Entities;

var connectionString = @"Server=DESKTOP-KCHC2S4;Database=MinionsDB;Integrated security=true;TrustServerCertificate=true;";
var context = new SoftUniDbContextClass(connectionString);

context.Employees.Add(new Employee()
{
    FirstName = "Gosho",
    LastName = "Inserted",
    DepartmentId = context.Departments.First().Id,
    IsEmployed = true
});

var employee =  context.Employees.Last();
employee.FirstName = "Modified";

context.SaveChanges();