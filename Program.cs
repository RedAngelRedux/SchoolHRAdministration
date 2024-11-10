using HRAdministrationAPI;
using SchoolHRAdministration;


List<IEmployee> employees = [];
HRActions.SeedData(employees);

decimal totalSalaries = employees.Sum(e => e.Salary);
Console.WriteLine($"Total Annual Salaries (including bonus) = {totalSalaries}");

// LINQ
var employeeNames = employees.Where(e => e.Salary > 50000).Select(e => e.LastName).ToList();
Console.WriteLine($"Employees Making More Than $30,000:");
foreach (var name in employeeNames) Console.WriteLine($"{name}");

// Extension Methods
string str = "This is a sample paragraph that might be written by a student.  The teacher might ask herself the question, how many words in this paragraph?";
Console.WriteLine($"Paragraph Word Count = {str.WordCount()}");

// Delegates
HRDelegates.hrIntDouble d = HRDelegates.MultiplyNumbers;

for (int i = 1; i <= 5; i++) Console.WriteLine($"{d(i, 2)}");



