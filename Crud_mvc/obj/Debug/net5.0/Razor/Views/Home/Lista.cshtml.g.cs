#pragma checksum "C:\Reposit\Crud_mvc\Crud_mvc\Views\Home\Lista.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a272995bf82323277257208f1f0926488af8925a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Lista), @"mvc.1.0.view", @"/Views/Home/Lista.cshtml")]
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
#line 1 "C:\Reposit\Crud_mvc\Crud_mvc\Views\_ViewImports.cshtml"
using Crud_mvc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Reposit\Crud_mvc\Crud_mvc\Views\_ViewImports.cshtml"
using Crud_mvc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a272995bf82323277257208f1f0926488af8925a", @"/Views/Home/Lista.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"292733afced0db064488de7a6f8f2437ac40ff62", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Lista : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Reposit\Crud_mvc\Crud_mvc\Views\Home\Lista.cshtml"
  
    ViewBag.Title = "Lista";

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Reposit\Crud_mvc\Crud_mvc\Views\Home\Lista.cshtml"
 if (@ViewData["codNome"].Equals("válido"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        document.getElementById(\'erroNome\').style.display = \"none\";\r\n\r\n    </script>\r\n");
#nullable restore
#line 13 "C:\Reposit\Crud_mvc\Crud_mvc\Views\Home\Lista.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <script>\r\n        document.getElementById(\'erroNome\').style.display = \"block\";\r\n\r\n    </script>\r\n");
#nullable restore
#line 20 "C:\Reposit\Crud_mvc\Crud_mvc\Views\Home\Lista.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<style>
    .info {
        color: white;
        padding: 20px 0px 20px;
    }

    .check {
        color: white;
        padding: 20px 0px 20px;
        width: 100%;
    }
</style>
<h2 class=""text-center"" style=""padding:20px 0px 30px;"">Visualizar</h2>

<div style=""display: flex; flex-direction: column;"">

    <h2 class=""text-center"">");
#nullable restore
#line 39 "C:\Reposit\Crud_mvc\Crud_mvc\Views\Home\Lista.cshtml"
                       Write(ViewData["nome"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 39 "C:\Reposit\Crud_mvc\Crud_mvc\Views\Home\Lista.cshtml"
                                         Write(ViewData["sobrenome"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>

    <div style=""display: flex; flex-direction: row; flex-wrap: nowrap; justify-content: space-around;
     background-color:dodgerblue; border-radius:50px; width:100%;"">



        <div class=""text-center info"">
            <h3>Nome</h3>
            <p>
                ");
#nullable restore
#line 49 "C:\Reposit\Crud_mvc\Crud_mvc\Views\Home\Lista.cshtml"
           Write(ViewData["nome"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <br>\r\n            <h3>Sobrenome</h3>\r\n            <p>\r\n                ");
#nullable restore
#line 54 "C:\Reposit\Crud_mvc\Crud_mvc\Views\Home\Lista.cshtml"
           Write(ViewData["sobrenome"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n        </div>\r\n        <div class=\"text-center info\">\r\n            <h3>Data de Nascimento</h3>\r\n            <p>\r\n                ");
#nullable restore
#line 60 "C:\Reposit\Crud_mvc\Crud_mvc\Views\Home\Lista.cshtml"
           Write(ViewData["nasc"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <br>\r\n            <h3>Idade</h3>\r\n            <p>\r\n                ");
#nullable restore
#line 65 "C:\Reposit\Crud_mvc\Crud_mvc\Views\Home\Lista.cshtml"
           Write(ViewData["idade"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n\r\n        </div>\r\n        <div class=\"text-center info\">\r\n            <h3>Sexo</h3>\r\n            <p>\r\n                ");
#nullable restore
#line 72 "C:\Reposit\Crud_mvc\Crud_mvc\Views\Home\Lista.cshtml"
           Write(ViewData["sexo"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </p>\r\n            <br>\r\n            <h3>CPF</h3>\r\n            <p>\r\n                ");
#nullable restore
#line 77 "C:\Reposit\Crud_mvc\Crud_mvc\Views\Home\Lista.cshtml"
           Write(ViewData["cpf"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </p>
        </div>
    </div>
    <br>

    <div class=""text-center"" style=""background-color:indianred; border-radius:50px; width:100%;"">

        <h2 class=""text-center"" style=""color:darkred"">Cadastro Inválido</h2>

        <div style=""display: flex; flex-direction: row; flex-wrap: nowrap; justify-content: space-around;"">

            
            <div class=""text-center check"" id=""erroNome"">
                <p>Nome</p>
                <p>
                    ");
#nullable restore
#line 93 "C:\Reposit\Crud_mvc\Crud_mvc\Views\Home\Lista.cshtml"
               Write(ViewData["codNome"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n\r\n            <div class=\"text-center check\" id=\"erroSobrenome\">\r\n                <p>Sobrenome</p>\r\n                <p>\r\n                    ");
#nullable restore
#line 100 "C:\Reposit\Crud_mvc\Crud_mvc\Views\Home\Lista.cshtml"
               Write(ViewData["codSobrenome"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>          \r\n\r\n\r\n            <div class=\"text-center check\" id=\"erroNasc\">\r\n                <p>Data de Nascimento</p>\r\n                <p>\r\n                    ");
#nullable restore
#line 108 "C:\Reposit\Crud_mvc\Crud_mvc\Views\Home\Lista.cshtml"
               Write(ViewData["codNasc"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n\r\n            </div>\r\n\r\n            <div class=\"text-center check\" id=\"erroCPF\">\r\n                <p>CPF</p>\r\n                <p>\r\n                    ");
#nullable restore
#line 116 "C:\Reposit\Crud_mvc\Crud_mvc\Views\Home\Lista.cshtml"
               Write(ViewData["codCPF"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </p>
            </div>

        </div>

        <input class=""text-center btn"" type=""button"" value=""Novo Cadastro""><br>
    </div>

    <div style=""display: flex; flex-direction: row; flex-wrap: nowrap; justify-content: space-around;
     background-color:lightgreen; border-radius:50px; width:100%;"">

        <h2 style=""color:green"">Cadastro válido</h2>


    </div>


</div>

<script>

    if ('");
#nullable restore
#line 138 "C:\Reposit\Crud_mvc\Crud_mvc\Views\Home\Lista.cshtml"
    Write(ViewData["codNome"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\' == (\"Válido\")) {\r\n        alert(\'aaaaaa\')\r\n        //document.getElementById(\'erroNome\').style.display = \"none\";\r\n    }\r\n   \r\n\r\n</script>");
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
