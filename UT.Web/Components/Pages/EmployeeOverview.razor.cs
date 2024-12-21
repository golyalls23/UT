using System;
using UT.Domain;
using UT.Services;

namespace UT.Web.Components.Pages;

public partial class EmployeeOverview
{

    private List<Employee>? Employees {get; set;}
    protected async override Task OnInitializedAsync()
    {
        await Task.Delay(50);
        Employees = MockDataService.Employees;
    }
}