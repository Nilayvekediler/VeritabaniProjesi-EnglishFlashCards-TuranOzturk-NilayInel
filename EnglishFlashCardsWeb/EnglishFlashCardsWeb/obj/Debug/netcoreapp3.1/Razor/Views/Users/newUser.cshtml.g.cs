#pragma checksum "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Users\newUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2f274d18773866a40cd8b20f380398da266bb2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Users_newUser), @"mvc.1.0.view", @"/Views/Users/newUser.cshtml")]
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
#line 1 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\_ViewImports.cshtml"
using EnglishFlashCardsWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\_ViewImports.cshtml"
using EnglishFlashCardsWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2f274d18773866a40cd8b20f380398da266bb2b", @"/Views/Users/newUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e6bb02eee33595b289adfeefa98a93c4aa0b872", @"/Views/_ViewImports.cshtml")]
    public class Views_Users_newUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EnglishFlashCardsWeb.Models.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\nilya\OneDrive\Masaüstü\EnglishFlashCardsWeb\EnglishFlashCardsWeb\Views\Users\newUser.cshtml"
Write(Html.BeginForm());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"{
<div class=""container"">
    <label for=""username""><b>Kullanıcı Adı</b></label>
    <input type=""text"" name=""username"" />

    <label for=""password""><b>Parola</b></label>
    <input type=""password"" name=""password"" />

    <label for=""email""><b>Email</b></label>
    <input type=""text"" name=""email"" />

    <button type=""submit"">Kayıt Ol</button>

</div>
}");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EnglishFlashCardsWeb.Models.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
