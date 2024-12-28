using Microsoft.Identity.Client.Extensibility;
using UT.API.Models;

// using UT.API.Models;
using UT.Domain.Others;

namespace UT.API.Services;

public class MockDataService
{
    public static List<Employee>? Employees
    {
        get {
        return [
            new() { EmployeeId = 1, FirstName="Bethany", LastName="Smith", Gender=Gender.Female, MartialStatus=MartialStatus.Married},
            new() { EmployeeId = 2, FirstName="Eric", LastName="Smith", Gender=Gender.Male, MartialStatus=MartialStatus.Single},
            new() { EmployeeId = 3, FirstName="Tom", LastName="Hary", Gender=Gender.Unknown, MartialStatus=MartialStatus.Other},
            new() { EmployeeId = 4, FirstName="Jeo", LastName="Plumber", },
        ];
        }
    }

    public static List<JobCategory>? JobCategories()
    {
        return [
            new() { JobCategoryId = 1, JobCategoryDescription = "IT"},
            new() { JobCategoryId = 2, JobCategoryDescription = "QA"},
            new() { JobCategoryId = 3, JobCategoryDescription = "Sales"},
            new() { JobCategoryId = 4, JobCategoryDescription = "HR"},
        ];
    }

    public static List<Country>? Countries()
    {
        return [
            new() { CountryId = 1, Name="USA"},
            new() { CountryId = 2, Name="Canada"},
            new() { CountryId = 3, Name="UK"},
            new() { CountryId = 4, Name="Mexico"},
        ];
    }

    public static Dictionary<int, StudentDTO> Students
    {
        get
        {
            return new Dictionary<int, StudentDTO> {
                {1, new() { StudentID = 1, FirstName="AF", LastName="AL", BirthDate=new DateTime(1999, 1,1)}},
                {2, new() { StudentID = 2, FirstName="BF", LastName="BL", BirthDate=new DateTime(2000, 2,15)}},
                {3, new() { StudentID = 3, FirstName="CF", LastName="CL", BirthDate=new DateTime(2002, 8,6)}},
                {4, new() { StudentID = 4, FirstName="DF", LastName="DL", BirthDate=new DateTime(2001, 12,15)}},
            };
        }
    }
}
