#pragma checksum "C:\Users\Krzysiek\Desktop\KREDEK-KURS\lab6\KrzysztofJopekLab6ZadanieDomowe\Views\Home\GetAllBallers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44f0db37962b716fa856a6c52df5a82990fcc1c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetAllBallers), @"mvc.1.0.view", @"/Views/Home/GetAllBallers.cshtml")]
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
#line 1 "C:\Users\Krzysiek\Desktop\KREDEK-KURS\lab6\KrzysztofJopekLab6ZadanieDomowe\Views\_ViewImports.cshtml"
using KrzysztofJopekLab6ZadanieDomowe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Krzysiek\Desktop\KREDEK-KURS\lab6\KrzysztofJopekLab6ZadanieDomowe\Views\_ViewImports.cshtml"
using KrzysztofJopekLab6ZadanieDomowe.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44f0db37962b716fa856a6c52df5a82990fcc1c3", @"/Views/Home/GetAllBallers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee4a77cd1f3c64f8c7f6ed16aa2931f08082764e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetAllBallers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BallerViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Krzysiek\Desktop\KREDEK-KURS\lab6\KrzysztofJopekLab6ZadanieDomowe\Views\Home\GetAllBallers.cshtml"
  
    ViewData["Title"] = "Lista najlepszych koszykarzy ALL-TIME";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>Lista najlepszych koszykarzy ALL-TIME</h1>\r\n\r\n<!-- Iteracja po wszystkich elementach listy-->\r\n");
#nullable restore
#line 9 "C:\Users\Krzysiek\Desktop\KREDEK-KURS\lab6\KrzysztofJopekLab6ZadanieDomowe\Views\Home\GetAllBallers.cshtml"
 foreach (var baller in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <h4>Imię: ");
#nullable restore
#line 12 "C:\Users\Krzysiek\Desktop\KREDEK-KURS\lab6\KrzysztofJopekLab6ZadanieDomowe\Views\Home\GetAllBallers.cshtml"
         Write(baller.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <h4>Nazwisko: ");
#nullable restore
#line 13 "C:\Users\Krzysiek\Desktop\KREDEK-KURS\lab6\KrzysztofJopekLab6ZadanieDomowe\Views\Home\GetAllBallers.cshtml"
             Write(baller.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <h4>Data urodzenia: ");
#nullable restore
#line 14 "C:\Users\Krzysiek\Desktop\KREDEK-KURS\lab6\KrzysztofJopekLab6ZadanieDomowe\Views\Home\GetAllBallers.cshtml"
                   Write(baller.BirthDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <h4>Ostatni klub: ");
#nullable restore
#line 15 "C:\Users\Krzysiek\Desktop\KREDEK-KURS\lab6\KrzysztofJopekLab6ZadanieDomowe\Views\Home\GetAllBallers.cshtml"
                 Write(baller.CurrentClub);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <h4>Pozycja: ");
#nullable restore
#line 16 "C:\Users\Krzysiek\Desktop\KREDEK-KURS\lab6\KrzysztofJopekLab6ZadanieDomowe\Views\Home\GetAllBallers.cshtml"
            Write(baller.Position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    <img");
            BeginWriteAttribute("src", " src=\"", 473, "\"", 505, 1);
#nullable restore
#line 17 "C:\Users\Krzysiek\Desktop\KREDEK-KURS\lab6\KrzysztofJopekLab6ZadanieDomowe\Views\Home\GetAllBallers.cshtml"
WriteAttributeValue("", 479, Url.Content(baller.Photo), 479, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 506, "\"", 528, 1);
#nullable restore
#line 17 "C:\Users\Krzysiek\Desktop\KREDEK-KURS\lab6\KrzysztofJopekLab6ZadanieDomowe\Views\Home\GetAllBallers.cshtml"
WriteAttributeValue("", 512, baller.LastName, 512, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <hr />\r\n</div>\r\n");
#nullable restore
#line 20 "C:\Users\Krzysiek\Desktop\KREDEK-KURS\lab6\KrzysztofJopekLab6ZadanieDomowe\Views\Home\GetAllBallers.cshtml"
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BallerViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
