#pragma checksum "C:\Reposit\Crud_mvc\Crud_mvc\Views\Home\Cadastro.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5056e682f848ec32109c899e37cfe419a78ddd39"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Cadastro), @"mvc.1.0.view", @"/Views/Home/Cadastro.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5056e682f848ec32109c899e37cfe419a78ddd39", @"/Views/Home/Cadastro.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"292733afced0db064488de7a6f8f2437ac40ff62", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Cadastro : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Lista"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("cadastro"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("cadastro"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("padding:10px 300px 10px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5056e682f848ec32109c899e37cfe419a78ddd395149", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <title>CADASTRO</title>
    <script
            src=""https://code.jquery.com/jquery-3.6.0.min.js""
            integrity=""sha256-/xUj+3OJU5yExlq6GSYGSHk7tPXikynS7ogEvDej/m4=""
            crossorigin=""anonymous"">
    </script>

    <script>





        function validar() {
            if ((document.getElementById(""nome"").value == """") ||(document.getElementById(""sobrenome"").value == """") ||(document.getElementById(""cpf"").value == """")||(document.getElementById(""nasc"").value == """") ||(!((document.getElementById(""masculino"").checked) || (document.getElementById(""feminino"").checked)))) {
                alert('preencha todos os campos');
                verificaNome();
                verificaSobrenome();
                verificaNasc();
                verificaCPF();
                verificaSexo();
            } else {
                $(""#cadastro"").submit();
            }


        }
        

        function verificaNome() {
            if (documen");
                WriteLiteral(@"t.getElementById(""nome"").value == """") {
                document.getElementById(""avisoNome"").style.display = ""block"";
           
            

            } else {
                document.getElementById(""avisoNome"").style.display = ""none"";
            }
        }

        function verificaSobrenome() {
            if (document.getElementById(""sobrenome"").value == """") {
                document.getElementById(""avisoSobrenome"").style.display = ""block"";

            } else {
                document.getElementById(""avisoSobrenome"").style.display = ""none"";
            }

        }

        function verificaCPF() {
            if (document.getElementById(""cpf"").value == """") {
                document.getElementById(""avisoCPF"").style.display = ""block"";

            } else {
                document.getElementById(""avisoCPF"").style.display = ""none"";
            }

        }

        function verificaNasc() {
            if (document.getElementById(""nasc"").value == """") {
            ");
                WriteLiteral(@"    document.getElementById(""avisoNasc"").style.display = ""block"";
            
            } else {
                document.getElementById(""avisoNasc"").style.display = ""none"";
            }

        }

        function verificaSexo() {
            if (!((document.getElementById(""masculino"").checked) || (document.getElementById(""feminino"").checked))) {
                document.getElementById(""avisoSexo"").style.display = ""block"";
            } else {
                document.getElementById(""avisoSexo"").style.display = ""none"";
            }
        }

        function isVazio() {
         


        }

        function alertVazio(){

        }

    </script>

");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5056e682f848ec32109c899e37cfe419a78ddd399016", async() => {
                WriteLiteral("\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">Cadastro</h1>\r\n    </div>\r\n    <div class=\"text-center\">\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5056e682f848ec32109c899e37cfe419a78ddd399415", async() => {
                    WriteLiteral(@"

            <div class=""text-center"" style=""display:flex; flex-direction:row; flex-wrap:nowrap; justify-content:space-around"">
                <div>
                    <label for='nome'>Nome</label><br>
                    <input type='text' name='nome' id='nome' onfocusout=""verificaNome()""><br>

                    <div id=""avisoNome"" style=""display:none""> 
                    <label for='nome' style=""color:red"">Preencha o campo Nome</label>
                    </div>
                </div>

                <div>
                    <label for='sobrenome'>Sobrenome</label><br>
                    <input type='text' name='sobrenome' id='sobrenome' onfocusout=""verificaSobrenome()""><br>

                    <div id=""avisoSobrenome"" style=""display:none""> 
                    <label for='sobrenome' style=""color:red"">Preencha o campo Sobrenome</label>
                    </div>
                </div>
            </div>
            <br><br>

                <div style=""display:flex; flex-d");
                    WriteLiteral(@"irection:row; flex-wrap:nowrap; justify-content:space-around; padding: 0% 20% 0%;"">
                    <div>
                        <input type=""radio"" id=""masculino"" name=""sexo"" value=""Masculino"" onclick=""verificaSexo()"" >
                        <label for=""html"">Masculino</label>
                    </div>
                    <div>
                        <input type=""radio"" id=""feminino"" name=""sexo"" value=""Feminino"" onclick=""verificaSexo()"">
                        <label for=""css"">Feminino</label>
                    </div>
                </div>
                    <div id=""avisoSexo"" style=""display:none"">
                        <label style=""color:red"">Selecione uma das Opções</label>
                    </div>


                
                <br><br>

                <div>
                    <label for='cpf'>CPF</label><br>
                    <input type='text' name='cpf' id='cpf' onfocusout=""verificaCPF()""><br>

                    <div id=""avisoCPF"" style=""display:none""");
                    WriteLiteral(@"> 
                        <label for='cpf' style=""color:red"">Preencha o campo CPF</label>
                    </div>

                </div>
                <br><br>

                <div>
                    <label for='nasc'>Data de Nascimento</label><br>
                    <input type='date' name='nasc' id='nasc'onfocusout=""verificaNasc()""
                             min=""2022-06-03"" max=""2022-06-05"" placeholder=""dd-mm-yyyy""><br>

                    <div id=""avisoNasc"" style=""display:none""> 
                    <label for='nasc' style=""color:red"">Preencha o campo Nascimento</label>
                    </div>
                </div>
                <br><br>


                <input type='button' name='validacao' id=""validacao"" value='Validar' onclick=""validar()"">

                <input type='reset'>


");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    </div>

    <script>
        var today = new Date();
        var dd = today.getDate();
        var mm = today.getMonth() + 1; //January is 0!
        var yyyy = today.getFullYear();

        if (dd < 10) {
            dd = '0' + dd;
        }

        if (mm < 10) {
            mm = '0' + mm;
        }

        today = yyyy + '-' + mm + '-' + dd;
        var past = (yyyy - 100) + '-' + mm + '-' + dd;
        alert(past);
        document.getElementById(""nasc"").setAttribute(""max"", today);
        document.getElementById(""nasc"").setAttribute(""min"", past);
    </script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
