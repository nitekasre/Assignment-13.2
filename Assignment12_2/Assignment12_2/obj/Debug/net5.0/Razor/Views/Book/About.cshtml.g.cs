#pragma checksum "C:\MSSA 2022\04 - 20486\Assignments\Assignment12_2\Assignment12_2\Views\Book\About.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "849aa8d23053317294258d9e60a8067fec67a6af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_About), @"mvc.1.0.view", @"/Views/Book/About.cshtml")]
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
#line 1 "C:\MSSA 2022\04 - 20486\Assignments\Assignment12_2\Assignment12_2\Views\_ViewImports.cshtml"
using Assignment12_2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MSSA 2022\04 - 20486\Assignments\Assignment12_2\Assignment12_2\Views\_ViewImports.cshtml"
using Assignment12_2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"849aa8d23053317294258d9e60a8067fec67a6af", @"/Views/Book/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1026c8ae2afb0ab342a524e9d9c159255e1df5ab", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Book_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\MSSA 2022\04 - 20486\Assignments\Assignment12_2\Assignment12_2\Views\Book\About.cshtml"
  
    ViewData["Title"] = "About";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<center><h1>About us</h1> </center>\r\n\r\n\r\n\r\n    <div style=\"width: 100%;\">\r\n        <div style=\"width: 50%; height: 100px; float: left;\"> \r\n        <dl class=\"align-middle\">\r\n        ");
#nullable restore
#line 14 "C:\MSSA 2022\04 - 20486\Assignments\Assignment12_2\Assignment12_2\Views\Book\About.cshtml"
   Write(await Html.PartialAsync("_BookPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dl>
        </div>
        <div style=""margin-left: 50%; height: 100px;""> 
            <p>Hey, it's me again! We are doing this assignment on books, so a fun fact about me is that my husband and I have over 300 books in our house. We love to read! Reading makes us really happy. He likes to read American History and autobiographies (since he was a history major in college) and I like to read fiction, poetry, and books about social statuses. Honestly, I would like to use a book idea for my project, because we REALLY need to find a way to organize these things! </p>
    <p>
        Anyway...I'm sure there will be another about page, so maybe another fun fact at another time! See ya!<br />
    </p>
        <p></p>
        <P></P>
        </div>
    </div>
");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591