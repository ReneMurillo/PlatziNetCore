#pragma checksum "c:\Users\Murillo\Projects\platziNetCore\Views\School\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7ee27a0145384200f89abd4f60ecd390cf95b18"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_School_Index), @"mvc.1.0.view", @"/Views/School/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/School/Index.cshtml", typeof(AspNetCore.Views_School_Index))]
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
#line 1 "c:\Users\Murillo\Projects\platziNetCore\Views\_ViewImports.cshtml"
using platziNetCore;

#line default
#line hidden
#line 2 "c:\Users\Murillo\Projects\platziNetCore\Views\_ViewImports.cshtml"
using platziNetCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7ee27a0145384200f89abd4f60ecd390cf95b18", @"/Views/School/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23adf993cd6ab4c9fb719c5f66f81ca394219f56", @"/Views/_ViewImports.cshtml")]
    public class Views_School_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "c:\Users\Murillo\Projects\platziNetCore\Views\School\Index.cshtml"
  
    ViewData["Title"] = "School Information";

#line default
#line hidden
            BeginContext(54, 29, true);
            WriteLiteral("\r\n<h1>School</h1>\r\n<h2>Name: ");
            EndContext();
            BeginContext(84, 10, false);
#line 6 "c:\Users\Murillo\Projects\platziNetCore\Views\School\Index.cshtml"
     Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(94, 35, true);
            WriteLiteral("</h2>\r\n<p><strong>Foundation Year: ");
            EndContext();
            BeginContext(130, 19, false);
#line 7 "c:\Users\Murillo\Projects\platziNetCore\Views\School\Index.cshtml"
                       Write(Model.FundationYear);

#line default
#line hidden
            EndContext();
            BeginContext(149, 13, true);
            WriteLiteral("</strong></p>");
            EndContext();
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