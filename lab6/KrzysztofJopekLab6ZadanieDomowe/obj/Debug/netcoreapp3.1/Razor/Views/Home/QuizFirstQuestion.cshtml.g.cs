#pragma checksum "C:\Users\Krzysiek\Desktop\KREDEK-KURS\lab6\KrzysztofJopekLab6ZadanieDomowe\Views\Home\QuizFirstQuestion.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b376fb680e6723448a26b0ea769273c3ea4c691"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_QuizFirstQuestion), @"mvc.1.0.view", @"/Views/Home/QuizFirstQuestion.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b376fb680e6723448a26b0ea769273c3ea4c691", @"/Views/Home/QuizFirstQuestion.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee4a77cd1f3c64f8c7f6ed16aa2931f08082764e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_QuizFirstQuestion : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<QuizViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Krzysiek\Desktop\KREDEK-KURS\lab6\KrzysztofJopekLab6ZadanieDomowe\Views\Home\QuizFirstQuestion.cshtml"
  
    ViewData["Title"] = "QuizFirstQuestion";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Witamy w quizie! Sprawdź swoją wiedzę!</h2>\r\n<br />\r\n\r\n<h3>Pierwsze pytanie</h3>\r\n<br />\r\n\r\n<h3> Kto jest aktualnym mistrzem NBA? (Podaj pełną nazwę)</h3>\r\n\r\n<!-- Formularz kontaktowy -->\r\n");
#nullable restore
#line 15 "C:\Users\Krzysiek\Desktop\KREDEK-KURS\lab6\KrzysztofJopekLab6ZadanieDomowe\Views\Home\QuizFirstQuestion.cshtml"
 using (Html.BeginForm("QuizFirstQuestionPost", "Home", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Krzysiek\Desktop\KREDEK-KURS\lab6\KrzysztofJopekLab6ZadanieDomowe\Views\Home\QuizFirstQuestion.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("    <!-- Odpowiedź -->\r\n    <div class=\"form-horizontal\">\r\n        ");
#nullable restore
#line 21 "C:\Users\Krzysiek\Desktop\KREDEK-KURS\lab6\KrzysztofJopekLab6ZadanieDomowe\Views\Home\QuizFirstQuestion.cshtml"
   Write(Html.LabelFor(model => model.Answer, new { @class = "control-label col-md-2" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"col-md-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Krzysiek\Desktop\KREDEK-KURS\lab6\KrzysztofJopekLab6ZadanieDomowe\Views\Home\QuizFirstQuestion.cshtml"
       Write(Html.EditorFor(model => model.Answer, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n");
            WriteLiteral("    <!-- Przycisk wysyłający formularz-->\r\n    <div class=\"form-group\">\r\n        <div class=\"col-md-offset-2 col-md-10\">\r\n            <input type=\"submit\" value=\"Zatwierdź\" class=\"btn btn-success\" />\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 33 "C:\Users\Krzysiek\Desktop\KREDEK-KURS\lab6\KrzysztofJopekLab6ZadanieDomowe\Views\Home\QuizFirstQuestion.cshtml"
Write(Html.HiddenFor(model => model.CorrectAnswers));

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Krzysiek\Desktop\KREDEK-KURS\lab6\KrzysztofJopekLab6ZadanieDomowe\Views\Home\QuizFirstQuestion.cshtml"
                                                  
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<QuizViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
