#pragma checksum "C:\Users\Krzysiek\Desktop\KREDEK-KURS\lab6\KrzysztofJopekLab6ZadanieDomowe\Views\Home\Summary.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2131a4d6b8f00dab88df54f62525413cbb41f41"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Summary), @"mvc.1.0.view", @"/Views/Home/Summary.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2131a4d6b8f00dab88df54f62525413cbb41f41", @"/Views/Home/Summary.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee4a77cd1f3c64f8c7f6ed16aa2931f08082764e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Summary : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuizViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Krzysiek\Desktop\KREDEK-KURS\lab6\KrzysztofJopekLab6ZadanieDomowe\Views\Home\Summary.cshtml"
  
    ViewData["Title"] = "Podsumowanie";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h3>Odpowiedziałeś: ");
#nullable restore
#line 7 "C:\Users\Krzysiek\Desktop\KREDEK-KURS\lab6\KrzysztofJopekLab6ZadanieDomowe\Views\Home\Summary.cshtml"
               Write(Model.Answer);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n<br />\r\n");
#nullable restore
#line 9 "C:\Users\Krzysiek\Desktop\KREDEK-KURS\lab6\KrzysztofJopekLab6ZadanieDomowe\Views\Home\Summary.cshtml"
  
    if (@Model.Answer == "Stephen Curry")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            WriteLiteral("<h3>To poprawna odpowiedź!</h3>\r\n");
#nullable restore
#line 13 "C:\Users\Krzysiek\Desktop\KREDEK-KURS\lab6\KrzysztofJopekLab6ZadanieDomowe\Views\Home\Summary.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            WriteLiteral("<h3>To niestety zła odpowiedź. :(</h3>\r\n");
#nullable restore
#line 17 "C:\Users\Krzysiek\Desktop\KREDEK-KURS\lab6\KrzysztofJopekLab6ZadanieDomowe\Views\Home\Summary.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 20 "C:\Users\Krzysiek\Desktop\KREDEK-KURS\lab6\KrzysztofJopekLab6ZadanieDomowe\Views\Home\Summary.cshtml"
Write(Html.HiddenFor(model => model.CorrectAnswers, new { id = "Liczba poprawnych odp" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Poprawne odpowiedzi: ");
#nullable restore
#line 21 "C:\Users\Krzysiek\Desktop\KREDEK-KURS\lab6\KrzysztofJopekLab6ZadanieDomowe\Views\Home\Summary.cshtml"
                    Write(Model.CorrectAnswers);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n<h3>Dziękujemy za wspólny czas! :)</h3>\r\n\r\n<h2>");
#nullable restore
#line 25 "C:\Users\Krzysiek\Desktop\KREDEK-KURS\lab6\KrzysztofJopekLab6ZadanieDomowe\Views\Home\Summary.cshtml"
Write(Html.ActionLink("Powrót do strony głownej.", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuizViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
