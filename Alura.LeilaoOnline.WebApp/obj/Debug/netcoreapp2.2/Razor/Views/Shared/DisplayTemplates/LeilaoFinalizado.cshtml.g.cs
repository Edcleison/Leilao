#pragma checksum "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Shared\DisplayTemplates\LeilaoFinalizado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5933ca92fba08e4474ad6bb2065245b64ca5f60"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DisplayTemplates_LeilaoFinalizado), @"mvc.1.0.view", @"/Views/Shared/DisplayTemplates/LeilaoFinalizado.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/DisplayTemplates/LeilaoFinalizado.cshtml", typeof(AspNetCore.Views_Shared_DisplayTemplates_LeilaoFinalizado))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5933ca92fba08e4474ad6bb2065245b64ca5f60", @"/Views/Shared/DisplayTemplates/LeilaoFinalizado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0561bac95bfd946575bd5868d8b531582dc7ff7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DisplayTemplates_LeilaoFinalizado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EstadoLeilao>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Shared\DisplayTemplates\LeilaoFinalizado.cshtml"
  
    LeilaoViewModel leilao = ViewData["Leilao"] as LeilaoViewModel;
    Usuario usuarioLogado = ViewData["UsuarioLogado"] as Usuario;

#line default
#line hidden
            BeginContext(160, 170, true);
            WriteLiteral("\n<div class=\"card estado\">\n    <div class=\"red darken-3 white-text center-align\">\n        <h4>\n            <i class=\"fas fa-hourglass-end\"></i>\n        </h4>\n        <h5>");
            EndContext();
            BeginContext(331, 17, false);
#line 13 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Shared\DisplayTemplates\LeilaoFinalizado.cshtml"
       Write(Model.ParaTexto());

#line default
#line hidden
            EndContext();
            BeginContext(348, 29, true);
            WriteLiteral("</h5>\n        <p>Terminou em ");
            EndContext();
            BeginContext(378, 43, false);
#line 14 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Shared\DisplayTemplates\LeilaoFinalizado.cshtml"
                  Write(leilao.TerminoPregao.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(421, 109, true);
            WriteLiteral(".</p>\n    </div>\n    <div class=\"center-align red-text text-darken-3\">\n        <h6>Ganhador</h6>\n        <h5>");
            EndContext();
            BeginContext(531, 61, false);
#line 18 "C:\Users\Starline\Documents\Cursos Alura\Selenium WebDriver e C# parte 2 outros recursos\Aula4.ProjetoAtualizado\Selenium.Tests\Alura.LeilaoOnline.WebApp\Views\Shared\DisplayTemplates\LeilaoFinalizado.cshtml"
       Write(leilao.ValorInicial.ToString("C", CultureInfo.CurrentCulture));

#line default
#line hidden
            EndContext();
            BeginContext(592, 23, true);
            WriteLiteral("</h5>\n    </div>\n</div>");
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
