#pragma checksum "C:\proj\temp1\Crud_mvc\Crud_mvc\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e8b28fd219aad4e411ae4d78ff62c764da2d262"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\proj\temp1\Crud_mvc\Crud_mvc\Views\_ViewImports.cshtml"
using Crud_mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\proj\temp1\Crud_mvc\Crud_mvc\Views\_ViewImports.cshtml"
using Crud_mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e8b28fd219aad4e411ae4d78ff62c764da2d262", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"292733afced0db064488de7a6f8f2437ac40ff62", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\proj\temp1\Crud_mvc\Crud_mvc\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<!--
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>
-->


<div class=""text-center"">
    <h1 class=""display-4"">Cadastro de Pessoas</h1>
</div>
<br><br>
<div class=""text-center"">
    <input class=""btn btn-secondary"" type=""button"" value=""Cadastrar""");
            BeginWriteAttribute("onclick", " onclick=\"", 445, "\"", 502, 3);
            WriteAttributeValue("", 455, "location.href=\'", 455, 15, true);
#nullable restore
#line 19 "C:\proj\temp1\Crud_mvc\Crud_mvc\Views\Home\Index.cshtml"
WriteAttributeValue("", 470, Url.Action("Cadastro", "Home"), 470, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 501, "\'", 501, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n</div>\r\n\r\n\r\n<!--\r\n\r\n-->\r\n");
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
