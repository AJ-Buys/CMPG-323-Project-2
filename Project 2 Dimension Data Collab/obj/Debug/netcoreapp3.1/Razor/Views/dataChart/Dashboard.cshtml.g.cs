#pragma checksum "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\dataChart\Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a841b38971dbdc3e770414545e52e7b878e45325"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_dataChart_Dashboard), @"mvc.1.0.view", @"/Views/dataChart/Dashboard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a841b38971dbdc3e770414545e52e7b878e45325", @"/Views/dataChart/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"847caffbc4eda1ae617d2edbe18dd653891afc96", @"/Views/_ViewImports.cshtml")]
    public class Views_dataChart_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\dataChart\Dashboard.cshtml"
  
    ViewData["Title"] = "Dashboard";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Data Dashboard</h1>


<table>
    <thead>
        <tr>
            <th>
                Chart 1
            </th>
            <th>
                Chart 2
            </th>
        </tr>


    </thead>
    <tbody>
        <tr>
            <td>
                ");
#nullable restore
#line 25 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\dataChart\Dashboard.cshtml"
           Write(await Html.PartialAsync("_Chart1"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 28 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\dataChart\Dashboard.cshtml"
           Write(await Html.PartialAsync("_Chart2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n\r\n\r\n    </tbody>\r\n    \r\n</table>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
