#pragma checksum "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf4aa810433b0bc5c041af06bf54b9b682b0eef7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cmpg323Project2Dataset_Index), @"mvc.1.0.view", @"/Views/Cmpg323Project2Dataset/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\_ViewImports.cshtml"
using Test_Database;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\_ViewImports.cshtml"
using Test_Database.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf4aa810433b0bc5c041af06bf54b9b682b0eef7", @"/Views/Cmpg323Project2Dataset/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"847caffbc4eda1ae617d2edbe18dd653891afc96", @"/Views/_ViewImports.cshtml")]
    public class Views_Cmpg323Project2Dataset_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Test_Database.Models.Cmpg323Project2Dataset>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Employee Data</h1>\r\n\r\n\r\n\r\n    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf4aa810433b0bc5c041af06bf54b9b682b0eef74795", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </p>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Attrition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.BusinessTravel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DailyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DistanceFromHome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EducationField));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeeCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 46 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EnvironmentSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 49 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 52 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.HourlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 55 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JobInvolvement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 58 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JobLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 61 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JobRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 64 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.JobSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 67 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MaritalStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 70 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MonthlyIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 73 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.MonthlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 76 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NumCompaniesWorked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 79 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Over18));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 82 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.OverTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 85 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PercentSalaryHike));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 88 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.PerformanceRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 91 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.RelationshipSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 94 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StandardHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 97 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.StockOptionLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 100 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalWorkingYears));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 103 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TrainingTimesLastYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 106 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WorkLifeBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 109 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.YearsAtCompany));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 112 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.YearsInCurrentRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 115 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.YearsSinceLastPromotion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 118 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.YearsWithCurrManager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 124 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 128 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 131 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Attrition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 134 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.BusinessTravel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 137 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DailyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 140 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 143 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DistanceFromHome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 146 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 149 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EducationField));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 152 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeeCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 155 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EnvironmentSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 158 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 161 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HourlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 164 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JobInvolvement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 167 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JobLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 170 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JobRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 173 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.JobSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 176 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaritalStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 179 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MonthlyIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 182 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MonthlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 185 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.NumCompaniesWorked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 188 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Over18));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 191 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.OverTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 194 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PercentSalaryHike));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 197 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PerformanceRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 200 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RelationshipSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 203 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StandardHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 206 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.StockOptionLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 209 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalWorkingYears));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 212 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.TrainingTimesLastYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 215 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.WorkLifeBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 218 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.YearsAtCompany));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 221 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.YearsInCurrentRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 224 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.YearsSinceLastPromotion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 227 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.YearsWithCurrManager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n");
            WriteLiteral("            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf4aa810433b0bc5c041af06bf54b9b682b0eef730929", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 233 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
                                       WriteLiteral(item.EmployeeNumber);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf4aa810433b0bc5c041af06bf54b9b682b0eef733144", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 234 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
                                          WriteLiteral(item.EmployeeNumber);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bf4aa810433b0bc5c041af06bf54b9b682b0eef735365", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 235 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
                                         WriteLiteral(item.EmployeeNumber);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("|\r\n            </td>\r\n");
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 245 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Test_Database.Models.Cmpg323Project2Dataset>> Html { get; private set; }
    }
}
#pragma warning restore 1591
