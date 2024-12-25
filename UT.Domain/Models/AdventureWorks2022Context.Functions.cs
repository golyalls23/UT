﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using System.Linq;
using UT.Domain.Models;

namespace UT.Domain.Models
{
    public partial class AdventureWorks2022Context
    {

        [DbFunction("ufnGetAccountingEndDate", "dbo")]
        public static DateTime? ufnGetAccountingEndDate()
        {
            throw new NotSupportedException("This method can only be called from Entity Framework Core queries");
        }

        [DbFunction("ufnGetAccountingStartDate", "dbo")]
        public static DateTime? ufnGetAccountingStartDate()
        {
            throw new NotSupportedException("This method can only be called from Entity Framework Core queries");
        }

        [DbFunction("ufnGetContactInformation", "dbo")]
        public IQueryable<ufnGetContactInformationResult> ufnGetContactInformation(int? PersonID)
        {
            return FromExpression(() => ufnGetContactInformation(PersonID));
        }

        [DbFunction("ufnGetDocumentStatusText", "dbo")]
        public static string ufnGetDocumentStatusText(byte? Status)
        {
            throw new NotSupportedException("This method can only be called from Entity Framework Core queries");
        }

        [DbFunction("ufnGetProductDealerPrice", "dbo")]
        public static decimal? ufnGetProductDealerPrice(int? ProductID, DateTime? OrderDate)
        {
            throw new NotSupportedException("This method can only be called from Entity Framework Core queries");
        }

        [DbFunction("ufnGetProductListPrice", "dbo")]
        public static decimal? ufnGetProductListPrice(int? ProductID, DateTime? OrderDate)
        {
            throw new NotSupportedException("This method can only be called from Entity Framework Core queries");
        }

        [DbFunction("ufnGetProductStandardCost", "dbo")]
        public static decimal? ufnGetProductStandardCost(int? ProductID, DateTime? OrderDate)
        {
            throw new NotSupportedException("This method can only be called from Entity Framework Core queries");
        }

        [DbFunction("ufnGetPurchaseOrderStatusText", "dbo")]
        public static string ufnGetPurchaseOrderStatusText(byte? Status)
        {
            throw new NotSupportedException("This method can only be called from Entity Framework Core queries");
        }

        [DbFunction("ufnGetSalesOrderStatusText", "dbo")]
        public static string ufnGetSalesOrderStatusText(byte? Status)
        {
            throw new NotSupportedException("This method can only be called from Entity Framework Core queries");
        }

        [DbFunction("ufnGetStock", "dbo")]
        public static int? ufnGetStock(int? ProductID)
        {
            throw new NotSupportedException("This method can only be called from Entity Framework Core queries");
        }

        [DbFunction("ufnLeadingZeros", "dbo")]
        public static string ufnLeadingZeros(int? Value)
        {
            throw new NotSupportedException("This method can only be called from Entity Framework Core queries");
        }

        protected void OnModelCreatingGeneratedFunctions(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ufnGetContactInformationResult>().HasNoKey();
        }
    }
}