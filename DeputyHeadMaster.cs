using HRAdministrationAPI;

namespace SchoolHRAdministration;

public class DeputyHeadMaster : EmployeeBase
{
    public override decimal Salary { get => base.Salary + (base.Salary * 0.04m); }
}
