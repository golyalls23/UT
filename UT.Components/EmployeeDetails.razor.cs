using System;
using Microsoft.AspNetCore.Components;
using UT.Domain;

namespace UT.Components;

public partial class EmployeeDetails
{

    [Parameter]
    public Employee? Employee {get; set;}

    public void ChangeHolidayState()
    {
        if (Employee is not null)
        {
            Employee.IsOnHoliday = !Employee?.IsOnHoliday;
        }
    }
}
