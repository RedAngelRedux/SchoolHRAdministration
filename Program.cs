using HRAdministrationAPI;
using SchoolHRAdministration;


List<IEmployee> employees = [];
SeedData(employees);

decimal totalSalaries = employees.Sum(e => e.Salary);

Console.WriteLine($"Total Annual Salaries (including bonus) = {totalSalaries}");

static void SeedData(List<IEmployee> employees)
{
    employees.Add(new Teacher
    {
        Id = 1,
        FirstName = "Bob",
        LastName = "Fisher",
        Salary = 40000
    });

    employees.Add(new Teacher
    {
        Id = 2,
        FirstName = "Jenny",
        LastName = "Thomas",
        Salary = 40000
    });

    employees.Add(new HeadOfDepartment
    {
        Id = 3,
        FirstName = "Brenda",
        LastName = "Mullins",
        Salary = 50000
    });

    employees.Add(new DeputyHeadMaster
    {
        Id = 4,
        FirstName = "Devlin",
        LastName = "Brown",
        Salary = 60000
    });

    employees.Add(new HeadMaster
    {
        Id = 5,
        FirstName = "Damien",
        LastName = "Jones",
        Salary = 80000
    });
}