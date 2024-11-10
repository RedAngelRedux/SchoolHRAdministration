using HRAdministrationAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolHRAdministration;

public enum EmployeeType
{
    Teacher,
    HeadOfDepartment,
    DeputyHeadMaster,
    HeadMaster
}

public static class HRActions
{
    public static IEmployee? GetEmployeeInstance(EmployeeType employeeType, int id, string firstName, string lastName, decimal salary)
    {
        IEmployee? employee = null;

        switch (employeeType)
        {
            case EmployeeType.Teacher:
                employee = FactoryPattern<IEmployee, Teacher>.GetInstance();
                break;
            case EmployeeType.HeadOfDepartment:
                employee = FactoryPattern<IEmployee, HeadOfDepartment>.GetInstance();
                break;
            case EmployeeType.DeputyHeadMaster:
                employee = FactoryPattern<IEmployee, DeputyHeadMaster>.GetInstance();
                break;
            case EmployeeType.HeadMaster:
                employee = FactoryPattern<IEmployee, HeadMaster>.GetInstance();
                break;
        }

        if(employee is not null)
        {
            employee.Id = id;
            employee.FirstName = firstName;
            employee.LastName = lastName;
            employee.Salary = salary;
            return employee;
        }
        else
        {
            throw new NullReferenceException();
        }
    }

    public static void SeedData(List<IEmployee> employees)
    {
        employees.Add(GetEmployeeInstance(EmployeeType.Teacher,
            1,"Bob","Fisher",40000)!);
        employees.Add(GetEmployeeInstance(EmployeeType.Teacher,
            2,"Jenny","Thomas",40000)!);
        employees.Add(GetEmployeeInstance(EmployeeType.HeadOfDepartment,
            3,"Brenda","Mullins",50000)!);
        employees.Add(GetEmployeeInstance(EmployeeType.DeputyHeadMaster,
            4,"Devlin","Brown",60000)!);
        employees.Add(GetEmployeeInstance(EmployeeType.HeadMaster,
            5,"Damien","Jones",80000)!);
    }

}
