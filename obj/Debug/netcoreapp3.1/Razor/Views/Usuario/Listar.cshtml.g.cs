#pragma checksum "D:\Users\Usuário\Documents\Programação Projetos\Atividade 3 Projeto Integrador Restaurante\Views\Usuario\Listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "057bed20b5e3fe53b9618bcc1b2782eedd2480d9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Listar), @"mvc.1.0.view", @"/Views/Usuario/Listar.cshtml")]
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
#line 1 "D:\Users\Usuário\Documents\Programação Projetos\Atividade 3 Projeto Integrador Restaurante\Views\_ViewImports.cshtml"
using Atividade_3_Projeto_Integrador;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\Usuário\Documents\Programação Projetos\Atividade 3 Projeto Integrador Restaurante\Views\_ViewImports.cshtml"
using Atividade_3_Projeto_Integrador.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"057bed20b5e3fe53b9618bcc1b2782eedd2480d9", @"/Views/Usuario/Listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72aa36b512dca01b6126e50f2f1b71082dadf2bc", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Usuario>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Users\Usuário\Documents\Programação Projetos\Atividade 3 Projeto Integrador Restaurante\Views\Usuario\Listar.cshtml"
  
    ViewData["Title"] = "Listagem de Usuário";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Listagem de Usuário</h2>\r\n<table>\r\n    <thead>\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Nome</th>\r\n            <th>Login</th>\r\n            <th>Senha</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 17 "D:\Users\Usuário\Documents\Programação Projetos\Atividade 3 Projeto Integrador Restaurante\Views\Usuario\Listar.cshtml"
         foreach (Usuario u in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 20 "D:\Users\Usuário\Documents\Programação Projetos\Atividade 3 Projeto Integrador Restaurante\Views\Usuario\Listar.cshtml"
               Write(u.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 21 "D:\Users\Usuário\Documents\Programação Projetos\Atividade 3 Projeto Integrador Restaurante\Views\Usuario\Listar.cshtml"
               Write(u.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "D:\Users\Usuário\Documents\Programação Projetos\Atividade 3 Projeto Integrador Restaurante\Views\Usuario\Listar.cshtml"
               Write(u.Login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "D:\Users\Usuário\Documents\Programação Projetos\Atividade 3 Projeto Integrador Restaurante\Views\Usuario\Listar.cshtml"
               Write(u.Senha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 25 "D:\Users\Usuário\Documents\Programação Projetos\Atividade 3 Projeto Integrador Restaurante\Views\Usuario\Listar.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591
