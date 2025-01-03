﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using UT.Domain.Models;

namespace UT.Domain.Models
{
    public partial interface IAdventureWorks2022ContextProcedures
    {
        Task<List<uspGetBillOfMaterialsResult>> uspGetBillOfMaterialsAsync(int? StartProductID, DateTime? CheckDate, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<uspGetEmployeeManagersResult>> uspGetEmployeeManagersAsync(int? BusinessEntityID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<uspGetManagerEmployeesResult>> uspGetManagerEmployeesAsync(int? BusinessEntityID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<uspGetWhereUsedProductIDResult>> uspGetWhereUsedProductIDAsync(int? StartProductID, DateTime? CheckDate, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> uspLogErrorAsync(OutputParameter<int?> ErrorLogID, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> uspPrintErrorAsync(OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<List<uspSearchCandidateResumesResult>> uspSearchCandidateResumesAsync(string searchString, bool? useInflectional, bool? useThesaurus, int? language, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> uspUpdateEmployeeHireInfoAsync(int? BusinessEntityID, string JobTitle, DateTime? HireDate, DateTime? RateChangeDate, decimal? Rate, byte? PayFrequency, bool? CurrentFlag, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> uspUpdateEmployeeLoginAsync(int? BusinessEntityID, byte[] OrganizationNode, string LoginID, string JobTitle, DateTime? HireDate, bool? CurrentFlag, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
        Task<int> uspUpdateEmployeePersonalInfoAsync(int? BusinessEntityID, string NationalIDNumber, DateTime? BirthDate, string MaritalStatus, string Gender, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default);
    }
}
