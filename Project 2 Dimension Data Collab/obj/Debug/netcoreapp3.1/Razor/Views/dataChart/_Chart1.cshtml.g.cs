#pragma checksum "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\dataChart\_Chart1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f67cf139d38cea4f14232a690c6351f011694669"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_dataChart__Chart1), @"mvc.1.0.view", @"/Views/dataChart/_Chart1.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f67cf139d38cea4f14232a690c6351f011694669", @"/Views/dataChart/_Chart1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"847caffbc4eda1ae617d2edbe18dd653891afc96", @"/Views/_ViewImports.cshtml")]
    public class Views_dataChart__Chart1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    <h2>Gender balance</h2>\r\n    <canvas id=\"gender\"></canvas>\r\n</div>\r\n\r\n<script>\r\n\r\n    var can = document.getElementById(\"gender\");\r\n    var male = ");
#nullable restore
#line 10 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\dataChart\_Chart1.cshtml"
          Write(ViewBag.male);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n    var female = ");
#nullable restore
#line 11 "G:\Universiteit\Github\CMPG-323-Project-2\Project 2 Dimension Data Collab\Views\dataChart\_Chart1.cshtml"
            Write(ViewBag.female);

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

    var genderC = new Chart(can, {
        type: ""doughnut"",
        data: {
            labels: [""Male"", ""Female""],
            datasets: [{
                data: [male, female],
                backgroundColor: [""#4D83E9"", ""#BC27D6""],
                borderColor: [""#6B1A78"", ""#6B1A78""]
            }]
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
