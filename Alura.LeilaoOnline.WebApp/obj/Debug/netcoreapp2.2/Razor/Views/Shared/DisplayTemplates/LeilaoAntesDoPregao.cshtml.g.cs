#pragma checksum "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Shared\DisplayTemplates\LeilaoAntesDoPregao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0ea754feff8cff225584b2fc456a9a58541542e0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DisplayTemplates_LeilaoAntesDoPregao), @"mvc.1.0.view", @"/Views/Shared/DisplayTemplates/LeilaoAntesDoPregao.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/DisplayTemplates/LeilaoAntesDoPregao.cshtml", typeof(AspNetCore.Views_Shared_DisplayTemplates_LeilaoAntesDoPregao))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ea754feff8cff225584b2fc456a9a58541542e0", @"/Views/Shared/DisplayTemplates/LeilaoAntesDoPregao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0561bac95bfd946575bd5868d8b531582dc7ff7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DisplayTemplates_LeilaoAntesDoPregao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EstadoLeilao>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Shared\DisplayTemplates\LeilaoAntesDoPregao.cshtml"
   
    LeilaoViewModel leilao = ViewData["Leilao"] as LeilaoViewModel;
    Usuario usuarioLogado = ViewData["UsuarioLogado"] as Usuario;
    TimeSpan comecaEm = DateTime.Now - leilao.InicioPregao;
    int idInteressada = -1;
    bool interessadaLogada = (usuarioLogado != null && usuarioLogado.Interessada != null);
    if (interessadaLogada)
    {
        idInteressada = usuarioLogado.Interessada.Id;
    }

#line default
#line hidden
            BeginContext(436, 174, true);
            WriteLiteral("\n<div class=\"card estado\">\n    <div class=\"brown darken-3 white-text center-align\">\n        <h4>\n            <i class=\"fas fa-hourglass-start\"></i>\n        </h4>\n        <h5>");
            EndContext();
            BeginContext(611, 17, false);
#line 20 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Shared\DisplayTemplates\LeilaoAntesDoPregao.cshtml"
       Write(Model.ParaTexto());

#line default
#line hidden
            EndContext();
            BeginContext(628, 27, true);
            WriteLiteral("</h5>\n        <p>Começa em ");
            EndContext();
            BeginContext(656, 19, false);
#line 21 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Shared\DisplayTemplates\LeilaoAntesDoPregao.cshtml"
                Write(comecaEm.Humanize());

#line default
#line hidden
            EndContext();
            BeginContext(675, 87, true);
            WriteLiteral(".</p>\n    </div>\n    <div class=\"center-align brown-text text-darken-3\" data-idLeilao=\"");
            EndContext();
            BeginContext(763, 9, false);
#line 23 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Shared\DisplayTemplates\LeilaoAntesDoPregao.cshtml"
                                                                 Write(leilao.Id);

#line default
#line hidden
            EndContext();
            BeginContext(772, 22, true);
            WriteLiteral("\" data-idInteressada=\"");
            EndContext();
            BeginContext(795, 13, false);
#line 23 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Shared\DisplayTemplates\LeilaoAntesDoPregao.cshtml"
                                                                                                 Write(idInteressada);

#line default
#line hidden
            EndContext();
            BeginContext(808, 46, true);
            WriteLiteral("\">\n        <h6>Valor Inicial</h6>\n        <h5>");
            EndContext();
            BeginContext(855, 61, false);
#line 25 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Shared\DisplayTemplates\LeilaoAntesDoPregao.cshtml"
       Write(leilao.ValorInicial.ToString("C", CultureInfo.CurrentCulture));

#line default
#line hidden
            EndContext();
            BeginContext(916, 6, true);
            WriteLiteral("</h5>\n");
            EndContext();
#line 26 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Shared\DisplayTemplates\LeilaoAntesDoPregao.cshtml"
         if (interessadaLogada)
        {
            if (leilao.SendoSeguido)
            {

#line default
#line hidden
            BeginContext(1015, 222, true);
            WriteLiteral("                <p>Você já está seguindo esse leilão.</p>\n                <button class=\"btn waves-effect waves-light brown darken-3 btn-flat white-text abandonar\">\n                    Abandonar!\n                </button>\n");
            EndContext();
#line 34 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Shared\DisplayTemplates\LeilaoAntesDoPregao.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1282, 217, true);
            WriteLiteral("                <p>Você não está seguindo esse leilão.</p>\n                <button class=\"btn waves-effect waves-light brown darken-3 btn-flat white-text seguir\">\n                    Seguir!\n                </button>\n");
            EndContext();
#line 41 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Shared\DisplayTemplates\LeilaoAntesDoPregao.cshtml"
            }

        }

#line default
#line hidden
            BeginContext(1524, 17, true);
            WriteLiteral("    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EstadoLeilao> Html { get; private set; }
    }
}
#pragma warning restore 1591
