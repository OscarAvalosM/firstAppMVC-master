#pragma checksum "C:\Users\11471\OneDrive\Escritorio\firstAppMVC-master\Views\Personal\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88a93abfb551d719f5c9c914c4731e9184e379e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Personal_Index), @"mvc.1.0.view", @"/Views/Personal/Index.cshtml")]
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
#line 1 "C:\Users\11471\OneDrive\Escritorio\firstAppMVC-master\Views\_ViewImports.cshtml"
using firstApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\11471\OneDrive\Escritorio\firstAppMVC-master\Views\_ViewImports.cshtml"
using firstApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88a93abfb551d719f5c9c914c4731e9184e379e9", @"/Views/Personal/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4437ac880a316864a54fd205e7f99653113a40c7", @"/Views/_ViewImports.cshtml")]
    public class Views_Personal_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Personal>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Pagina Personal</h1>\n");
            WriteLiteral("\n\n");
#nullable restore
#line 5 "C:\Users\11471\OneDrive\Escritorio\firstAppMVC-master\Views\Personal\Index.cshtml"
Write(Html.LabelFor(c=>c.name, "Nombre: "));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 5 "C:\Users\11471\OneDrive\Escritorio\firstAppMVC-master\Views\Personal\Index.cshtml"
                                 Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 6 "C:\Users\11471\OneDrive\Escritorio\firstAppMVC-master\Views\Personal\Index.cshtml"
Write(Html.LabelFor(m=>m.lastname, "Apellido: "));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 6 "C:\Users\11471\OneDrive\Escritorio\firstAppMVC-master\Views\Personal\Index.cshtml"
                                       Write(Model.lastname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 7 "C:\Users\11471\OneDrive\Escritorio\firstAppMVC-master\Views\Personal\Index.cshtml"
Write(Html.LabelFor(m=>m.age, "Edad: "));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "C:\Users\11471\OneDrive\Escritorio\firstAppMVC-master\Views\Personal\Index.cshtml"
                              Write(Model.age);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 8 "C:\Users\11471\OneDrive\Escritorio\firstAppMVC-master\Views\Personal\Index.cshtml"
Write(Html.LabelFor(m=>m.phone, "Telefono: "));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 8 "C:\Users\11471\OneDrive\Escritorio\firstAppMVC-master\Views\Personal\Index.cshtml"
                                    Write(Model.phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 9 "C:\Users\11471\OneDrive\Escritorio\firstAppMVC-master\Views\Personal\Index.cshtml"
Write(Html.LabelFor(m=>m.direccion, "Direccion: "));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 9 "C:\Users\11471\OneDrive\Escritorio\firstAppMVC-master\Views\Personal\Index.cshtml"
                                         Write(Model.direccion);

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Personal> Html { get; private set; }
    }
}
#pragma warning restore 1591
