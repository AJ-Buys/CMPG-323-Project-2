#pragma checksum "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\dataChart\_Chart2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fa9350a02f10841ba79f6ba2c09c09b00b859511"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_dataChart__Chart2), @"mvc.1.0.view", @"/Views/dataChart/_Chart2.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa9350a02f10841ba79f6ba2c09c09b00b859511", @"/Views/dataChart/_Chart2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"847caffbc4eda1ae617d2edbe18dd653891afc96", @"/Views/_ViewImports.cshtml")]
    public class Views_dataChart__Chart2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<div>\r\n    <h1>Job Roles</h1>\r\n    <canvas id=\"role\"></canvas>\r\n</div>\r\n\r\n<script>\r\n\r\n    var can = document.getElementById(\"role\");\r\n    var label = ");
#nullable restore
#line 12 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\dataChart\_Chart2.cshtml"
           Write(ViewBag.label);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var value = ");
#nullable restore
#line 13 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\dataChart\_Chart2.cshtml"
           Write(ViewBag.total);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

    var roleC = new Chart(can, {
        type: ""bar"",
        data: {
            labels: label,
            datasets: [{
                data: value,
                backgroundColor: ""#000""
            }]
        },
        options: {
            title: {
                text: ""Various job roles"",
                display :true
            }
        }
    });


</script>
");
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
