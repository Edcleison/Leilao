#pragma checksum "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9152a180649f963e804e297b6aacda515f21ed71"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#line 2 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#line 3 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\_ViewImports.cshtml"
using Alura.LeilaoOnline.Core;

#line default
#line hidden
#line 4 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\_ViewImports.cshtml"
using Alura.LeilaoOnline.WebApp.Models;

#line default
#line hidden
#line 5 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\_ViewImports.cshtml"
using Alura.LeilaoOnline.WebApp.Extensions;

#line default
#line hidden
#line 6 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\_ViewImports.cshtml"
using Humanizer;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9152a180649f963e804e297b6aacda515f21ed71", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0561bac95bfd946575bd5868d8b531582dc7ff7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<LeilaoViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detalhes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Categoria", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "Automóveis", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "categoria", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "Arte e Pintura", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-id", "Item de Colecionador", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Registro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Leilões Online";
    string categoria = ViewData["categoria"] as string;
    Usuario usuarioLogado = Context.Session.Get<Usuario>("usuarioLogado");

#line default
#line hidden
            BeginContext(214, 76, true);
            WriteLiteral("\n<section class=\"section section-prox-leiloes\">\n    <div class=\"container\">\n");
            EndContext();
#line 10 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Home\Index.cshtml"
         if (string.IsNullOrWhiteSpace(categoria))
        {

#line default
#line hidden
            BeginContext(351, 38, true);
            WriteLiteral("            <h4>Próximos Leilões</h4>\n");
            EndContext();
#line 13 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Home\Index.cshtml"

        }
        else
        {

#line default
#line hidden
            BeginContext(423, 37, true);
            WriteLiteral("            <h4>Leilões da categoria ");
            EndContext();
            BeginContext(461, 9, false);
#line 17 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Home\Index.cshtml"
                                Write(categoria);

#line default
#line hidden
            EndContext();
            BeginContext(470, 6, true);
            WriteLiteral("</h4>\n");
            EndContext();
#line 18 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(486, 26, true);
            WriteLiteral("        <div class=\"row\">\n");
            EndContext();
#line 20 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Home\Index.cshtml"
             foreach (var leilao in Model)
            {

#line default
#line hidden
            BeginContext(569, 98, true);
            WriteLiteral("                <div class=\"col s12 m4\">\n                    <div class=\"card hoverable\" data-id=\"");
            EndContext();
            BeginContext(668, 9, false);
#line 23 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Home\Index.cshtml"
                                                    Write(leilao.Id);

#line default
#line hidden
            EndContext();
            BeginContext(677, 3, true);
            WriteLiteral("\">\n");
            EndContext();
#line 24 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Home\Index.cshtml"
                         if (usuarioLogado != null)
                        {
                            if (leilao.SendoSeguido)
                            {

#line default
#line hidden
            BeginContext(841, 60, true);
            WriteLiteral("                                <a href=\"#!\" data-idLeilao=\"");
            EndContext();
            BeginContext(902, 9, false);
#line 28 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Home\Index.cshtml"
                                                       Write(leilao.Id);

#line default
#line hidden
            EndContext();
            BeginContext(911, 22, true);
            WriteLiteral("\" data-idInteressada=\"");
            EndContext();
            BeginContext(934, 16, false);
#line 28 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Home\Index.cshtml"
                                                                                       Write(usuarioLogado.Id);

#line default
#line hidden
            EndContext();
            BeginContext(950, 155, true);
            WriteLiteral("\" class=\"abandonar yellow-text text-darken-4\">\n                                    <i class=\"material-icons\">star</i>\n                                </a>\n");
            EndContext();
#line 31 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Home\Index.cshtml"
                            }
                            else
                            {

#line default
#line hidden
            BeginContext(1198, 60, true);
            WriteLiteral("                                <a href=\"#!\" data-idLeilao=\"");
            EndContext();
            BeginContext(1259, 9, false);
#line 34 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Home\Index.cshtml"
                                                       Write(leilao.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1268, 22, true);
            WriteLiteral("\" data-idInteressada=\"");
            EndContext();
            BeginContext(1291, 16, false);
#line 34 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Home\Index.cshtml"
                                                                                       Write(usuarioLogado.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1307, 144, true);
            WriteLiteral("\" class=\"seguir white-text\">\n                                    <i class=\"material-icons\">star_border</i>\n                                </a>\n");
            EndContext();
#line 37 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Home\Index.cshtml"
                            }
                        }

#line default
#line hidden
            BeginContext(1507, 81, true);
            WriteLiteral("                        <div class=\"card-image\">\n                            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1588, "\"", 1608, 1);
#line 40 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 1594, leilao.Imagem, 1594, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1609, 78, true);
            WriteLiteral(" class=\"responsive-img\">\n                            <span class=\"card-title\">");
            EndContext();
            BeginContext(1688, 13, false);
#line 41 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Home\Index.cshtml"
                                                Write(leilao.Titulo);

#line default
#line hidden
            EndContext();
            BeginContext(1701, 122, true);
            WriteLiteral("</span>\n\n                        </div>\n                        <div class=\"card-content\">\n                            <p>");
            EndContext();
            BeginContext(1824, 34, false);
#line 45 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Home\Index.cshtml"
                          Write(leilao.Descricao.Substring(0, 150));

#line default
#line hidden
            EndContext();
            BeginContext(1858, 114, true);
            WriteLiteral("</p>\n                        </div>\n                        <div class=\"card-action\">\n                            ");
            EndContext();
            BeginContext(1972, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9152a180649f963e804e297b6aacda515f21ed7115736", async() => {
                BeginContext(2023, 8, true);
                WriteLiteral("Detalhes");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 48 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Home\Index.cshtml"
                                                       WriteLiteral(leilao.Id);

#line default
#line hidden
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
            EndContext();
            BeginContext(2035, 82, true);
            WriteLiteral("\n                        </div>\n                    </div>\n                </div>\n");
            EndContext();
#line 52 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(2131, 841, true);
            WriteLiteral(@"        </div>
    </div>
</section>


<section class=""section section-categ-leiloes brown lighten-5"">
    <div class=""container"">
        <h4 class=""center"">Navegue pelas categorias de Leilão</h4>
        <div class=""row"">
            <div class=""col s12 m4"">
                <div class=""card"">
                    <div class=""card-content center-align"">
                        <h2 class=""icon-block brown-text""><i class=""material-icons"">directions_car</i></h2>
                        <h5>Carros e Caminhões</h5>
                        <p class=""light"">
                            Lorem ipsum dolor sit amet, consectetur adipisicing elit. Adipisci, laborum incidunt voluptatum accusantium repellendus numquam.
                        </p>
                    </div>
                    <div class=""card-action"">
                        ");
            EndContext();
            BeginContext(2972, 87, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9152a180649f963e804e297b6aacda515f21ed7119467", async() => {
                BeginContext(3046, 9, true);
                WriteLiteral("Descobrir");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3059, 629, true);
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""col s12 m4"">
                <div class=""card"">
                    <div class=""card-content center-align"">
                        <h2 class=""icon-block brown-text""><i class=""material-icons"">palette</i></h2>
                        <h5>Pinturas e Esculturas</h5>
                        <p class=""light"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Adipisci, laborum incidunt voluptatum accusantium repellendus numquam.</p>
                    </div>
                    <div class=""card-action"">
                        ");
            EndContext();
            BeginContext(3688, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9152a180649f963e804e297b6aacda515f21ed7122201", async() => {
                BeginContext(3766, 9, true);
                WriteLiteral("Descobrir");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3779, 627, true);
            WriteLiteral(@"
                    </div>
                </div>
            </div>
            <div class=""col s12 m4"">
                <div class=""card"">
                    <div class=""card-content center-align"">
                        <h2 class=""icon-block brown-text""><i class=""material-icons"">grade</i></h2>
                        <h5>Itens de Colecionador</h5>
                        <p class=""light"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Adipisci, laborum incidunt voluptatum accusantium repellendus numquam.</p>
                    </div>
                    <div class=""card-action"">
                        ");
            EndContext();
            BeginContext(4406, 97, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9152a180649f963e804e297b6aacda515f21ed7124933", async() => {
                BeginContext(4490, 9, true);
                WriteLiteral("Descobrir");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4503, 1508, true);
            WriteLiteral(@"
                    </div>

                </div>
            </div>
        </div>
    </div>
</section>
<!--section-categ-leiloes-->

<section class=""section section-registro white black-text"">
    <div class=""container"">
        <h4 class=""center"">Registre-se para participar dos leilões!</h4>
        <div class=""row"">
            <div class=""col s12 m6"">
                <div class=""card-panel white-text brown darken-3"">
                    <p class=""flow-text"">Laoreet ac, aliquam sit amet justo nunc tempor, metus vel placerat suscipit, orci nisl iaculis eros, a tincidunt nisi odio eget lorem nulla condimentum tempor.</p>
                    <ul>
                        <li>
                            <i class=""material-icons left medium"">shopping_cart</i>
                            <h6>
                                Ut fusce varius nisl ac ipsum gravida vel pretium tellus tincidunt integer eu augue augue nunc elit dolor, luctus placerat.
                            </h6>
                        </li>");
            WriteLiteral(@"
                        <li>
                            <i class=""material-icons left medium"">dashboard</i>
                            <h6>
                                Ut fusce varius nisl ac ipsum gravida vel pretium tellus tincidunt integer eu augue augue nunc elit dolor, luctus placerat.
                            </h6>
                        </li>
                    </ul>
                </div>
            </div>
            <div class=""col s12 m6"">
                ");
            EndContext();
            BeginContext(6011, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9152a180649f963e804e297b6aacda515f21ed7128585", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
#line 130 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = new Alura.LeilaoOnline.WebApp.Models.RegistroViewModel();

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6104, 129, true);
            WriteLiteral("\n            </div>\n        </div>\n        <!--div.row-->\n    </div>\n    <!--div.container-->\n</section>\n<!--section-registro-->\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<LeilaoViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
