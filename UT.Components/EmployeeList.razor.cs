using System;
using Microsoft.AspNetCore.Components;
using UT.Domain;
using UT.Domain.Others;

namespace UT.Components;

public partial class EmployeeList
{
    [Parameter]
    public List<Employee>? Employees {get; set;}
}
