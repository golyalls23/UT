using UT.Domain;

namespace UT.Services;

public class MockDataService
{
    private static List<Employee>? _employees = default!;
    private static List<JobCategory>? _jobCategories = default!;
    private static List<Country>? _countries = default!;

    public static List<Employee>? Employees
    {
        get {
            _countries ??= InitializeMockCountries();
            _jobCategories ??= InitializeJobCategories();
            _employees ??= InitializeEmployees();
            return _employees;
        }
    }

    private static List<Employee>? InitializeEmployees()
    {
        return [
            new() { EmployeeId = 1, FirstName="Bethany", LastName="Smith", Gender=Gender.Female, MartialStatus=MartialStatus.Married},
            new() { EmployeeId = 2, FirstName="Eric", LastName="Smith", Gender=Gender.Male, MartialStatus=MartialStatus.Single},
            new() { EmployeeId = 3, FirstName="Tom", LastName="Hary", Gender=Gender.Unknown, MartialStatus=MartialStatus.Other},
            new() { EmployeeId = 4, FirstName="Jeo", LastName="Plumber", },
        ];
    }

    private static List<JobCategory>? InitializeJobCategories()
    {
        return [
            new() { JobCategoryId = 1, JobCategoryDescription = "IT"},
            new() { JobCategoryId = 2, JobCategoryDescription = "QA"},
            new() { JobCategoryId = 3, JobCategoryDescription = "Sales"},
            new() { JobCategoryId = 4, JobCategoryDescription = "HR"},
        ];
    }

    private static List<Country>? InitializeMockCountries()
    {
        return [
            new() { CountryId = 1, Name="USA"},
            new() { CountryId = 2, Name="Canada"},
            new() { CountryId = 3, Name="UK"},
            new() { CountryId = 4, Name="Mexico"},
        ];
    }
}
