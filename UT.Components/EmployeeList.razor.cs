using System;
using Microsoft.AspNetCore.Components;
using UT.Domain;

namespace UT.Components;

public partial class EmployeeList
{
    [Parameter]
    public List<Employee>? Employees {get; set;}
}
