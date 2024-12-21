using System;
using Microsoft.AspNetCore.Components;
using UT.Domain;
using UT.Services;

namespace UT.Web.Components.Pages;

public partial class EmployeeDetails
{
 
    public Employee? Employee {get; set;}

    [Parameter]
    public int EmployeeId {get; set;}

    protected async override Task OnInitializedAsync()
    {
        await Task.Delay(1000);
        Employee = MockDataService.Employees?.SingleOrDefault(e => e.EmployeeId == EmployeeId);
    }
}
