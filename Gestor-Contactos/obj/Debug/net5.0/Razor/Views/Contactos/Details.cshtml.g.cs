#pragma checksum "D:\Escritorio\Gestor-Contactos\Gestor-Contactos\Views\Contactos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51019e5032ba617c5edd4ea8b19005823be9a85b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contactos_Details), @"mvc.1.0.view", @"/Views/Contactos/Details.cshtml")]
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
#line 1 "D:\Escritorio\Gestor-Contactos\Gestor-Contactos\Views\_ViewImports.cshtml"
using Gestor_Contactos;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Escritorio\Gestor-Contactos\Gestor-Contactos\Views\_ViewImports.cshtml"
using Gestor_Contactos.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51019e5032ba617c5edd4ea8b19005823be9a85b", @"/Views/Contactos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92b0e7f691a4fb77810d935c320fc8ed87cf6853", @"/Views/_ViewImports.cshtml")]
    public class Views_Contactos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gestor_Contactos.Models.Contactos>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Escritorio\Gestor-Contactos\Gestor-Contactos\Views\Contactos\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Contactos</h1>\r\n\r\n<div>\r\n    <h4>Detalles</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">ID</dt>\r\n        <dd class=\"col-sm-10\">");
#nullable restore
#line 14 "D:\Escritorio\Gestor-Contactos\Gestor-Contactos\Views\Contactos\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-2\">Favorito</dt>\r\n        <dd class=\"col-sm-10\">");
#nullable restore
#line 16 "D:\Escritorio\Gestor-Contactos\Gestor-Contactos\Views\Contactos\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Favorito));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-2\">Nombre(s)</dt>\r\n        <dd class=\"col-sm-10\">");
#nullable restore
#line 18 "D:\Escritorio\Gestor-Contactos\Gestor-Contactos\Views\Contactos\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Nombres));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-2\">Apellido(s)</dt>\r\n        <dd class=\"col-sm-10\">");
#nullable restore
#line 20 "D:\Escritorio\Gestor-Contactos\Gestor-Contactos\Views\Contactos\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Apellidos));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-2\">Número telefónico</dt>\r\n        <dd class=\"col-sm-10\">");
#nullable restore
#line 22 "D:\Escritorio\Gestor-Contactos\Gestor-Contactos\Views\Contactos\Details.cshtml"
                         Write(Html.DisplayFor(model => model.NumTel));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-2\">Trabajo</dt>\r\n        <dd class=\"col-sm-10\">");
#nullable restore
#line 24 "D:\Escritorio\Gestor-Contactos\Gestor-Contactos\Views\Contactos\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Trabajo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-2\">Correo</dt>\r\n        <dd class=\"col-sm-10\">");
#nullable restore
#line 26 "D:\Escritorio\Gestor-Contactos\Gestor-Contactos\Views\Contactos\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Correo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-2\">Grupo</dt>\r\n        <dd class=\"col-sm-10\">");
#nullable restore
#line 28 "D:\Escritorio\Gestor-Contactos\Gestor-Contactos\Views\Contactos\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Grupo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-2\">Dirección</dt>\r\n        <dd class=\"col-sm-10\">");
#nullable restore
#line 30 "D:\Escritorio\Gestor-Contactos\Gestor-Contactos\Views\Contactos\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Direccion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-2\">Relación</dt>\r\n        <dd class=\"col-sm-10\">");
#nullable restore
#line 32 "D:\Escritorio\Gestor-Contactos\Gestor-Contactos\Views\Contactos\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Relacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-2\">Notas</dt>\r\n        <dd class=\"col-sm-10\">");
#nullable restore
#line 34 "D:\Escritorio\Gestor-Contactos\Gestor-Contactos\Views\Contactos\Details.cshtml"
                         Write(Html.DisplayFor(model => model.Notas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n        <dt class=\"col-sm-2\">Fecha de creación</dt>\r\n        <dd class=\"col-sm-10\">");
#nullable restore
#line 36 "D:\Escritorio\Gestor-Contactos\Gestor-Contactos\Views\Contactos\Details.cshtml"
                         Write(Html.DisplayFor(model => model.FechaCreacion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51019e5032ba617c5edd4ea8b19005823be9a85b8342", async() => {
                WriteLiteral("Editar");
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
#nullable restore
#line 40 "D:\Escritorio\Gestor-Contactos\Gestor-Contactos\Views\Contactos\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51019e5032ba617c5edd4ea8b19005823be9a85b10485", async() => {
                WriteLiteral("Regresar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gestor_Contactos.Models.Contactos> Html { get; private set; }
    }
}
#pragma warning restore 1591