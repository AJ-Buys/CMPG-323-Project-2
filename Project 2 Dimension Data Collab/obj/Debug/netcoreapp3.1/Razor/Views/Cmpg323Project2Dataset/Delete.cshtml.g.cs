#pragma checksum "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9bd3d115bb47ef1bb9c460865e37db3b9111d79"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cmpg323Project2Dataset_Delete), @"mvc.1.0.view", @"/Views/Cmpg323Project2Dataset/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9bd3d115bb47ef1bb9c460865e37db3b9111d79", @"/Views/Cmpg323Project2Dataset/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"847caffbc4eda1ae617d2edbe18dd653891afc96", @"/Views/_ViewImports.cshtml")]
    public class Views_Cmpg323Project2Dataset_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Test_Database.Models.Cmpg323Project2Dataset>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<h1>Delete record</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Cmpg323Project2Dataset</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 17 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 20 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 23 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Attrition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 26 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Attrition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 29 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BusinessTravel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 32 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BusinessTravel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 35 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DailyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 38 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DailyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 41 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 44 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Department));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 47 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DistanceFromHome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 50 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DistanceFromHome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 53 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 56 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Education));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 59 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EducationField));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 62 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EducationField));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 65 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EmployeeCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 68 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EmployeeCount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 71 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.EnvironmentSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 74 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.EnvironmentSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 77 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 80 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 83 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.HourlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 86 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.HourlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 89 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.JobInvolvement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 92 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.JobInvolvement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 95 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.JobLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 98 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.JobLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 101 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.JobRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 104 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.JobRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 107 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.JobSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 110 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.JobSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 113 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MaritalStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 116 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MaritalStatus));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 119 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MonthlyIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 122 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MonthlyIncome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 125 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.MonthlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 128 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.MonthlyRate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 131 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NumCompaniesWorked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 134 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NumCompaniesWorked));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 137 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Over18));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 140 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Over18));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 143 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OverTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 146 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OverTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 149 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PercentSalaryHike));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 152 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PercentSalaryHike));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 155 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PerformanceRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 158 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PerformanceRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 161 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.RelationshipSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 164 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.RelationshipSatisfaction));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 167 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StandardHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 170 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StandardHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 173 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.StockOptionLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 176 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.StockOptionLevel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 179 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TotalWorkingYears));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 182 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TotalWorkingYears));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 185 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TrainingTimesLastYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 188 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TrainingTimesLastYear));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 191 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.WorkLifeBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 194 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.WorkLifeBalance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 197 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.YearsAtCompany));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 200 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.YearsAtCompany));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 203 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.YearsInCurrentRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 206 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.YearsInCurrentRole));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 209 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.YearsSinceLastPromotion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 212 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.YearsSinceLastPromotion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 215 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.YearsWithCurrManager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 218 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
       Write(Html.DisplayFor(model => model.YearsWithCurrManager));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9bd3d115bb47ef1bb9c460865e37db3b9111d7929723", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a9bd3d115bb47ef1bb9c460865e37db3b9111d7929990", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 223 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\Cmpg323Project2Dataset\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.EmployeeNumber);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a9bd3d115bb47ef1bb9c460865e37db3b9111d7931827", async() => {
                    WriteLiteral("Back to List");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Test_Database.Models.Cmpg323Project2Dataset> Html { get; private set; }
    }
}
#pragma warning restore 1591
