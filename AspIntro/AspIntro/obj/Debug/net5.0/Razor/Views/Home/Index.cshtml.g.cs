#pragma checksum "D:\Code Academy\Teaching\Groupes\P222\Lessons\22.11.2021-Asp.Net Intro\Codes\AspIntro\AspIntro\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "117752aa2deec7352832517a68698478f17cb9c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\Code Academy\Teaching\Groupes\P222\Lessons\22.11.2021-Asp.Net Intro\Codes\AspIntro\AspIntro\Views\_ViewImports.cshtml"
using AspIntro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Code Academy\Teaching\Groupes\P222\Lessons\22.11.2021-Asp.Net Intro\Codes\AspIntro\AspIntro\Views\_ViewImports.cshtml"
using AspIntro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"117752aa2deec7352832517a68698478f17cb9c8", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9698a9fbe3b385e71fe1b3d043d91dc608340bcc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Code Academy\Teaching\Groupes\P222\Lessons\22.11.2021-Asp.Net Intro\Codes\AspIntro\AspIntro\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
    <hr />
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-6"">
                <h1>Data from controller</h1>
                <ul class=""list-group"">
                    <li class=""list-group-item text-left"">Data with Viewbag - <b>");
#nullable restore
#line 14 "D:\Code Academy\Teaching\Groupes\P222\Lessons\22.11.2021-Asp.Net Intro\Codes\AspIntro\AspIntro\Views\Home\Index.cshtml"
                                                                            Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></li>\r\n                    <li class=\"list-group-item text-left\">Data with ViewData - <b>");
#nullable restore
#line 15 "D:\Code Academy\Teaching\Groupes\P222\Lessons\22.11.2021-Asp.Net Intro\Codes\AspIntro\AspIntro\Views\Home\Index.cshtml"
                                                                             Write(ViewData["Surname"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></li>\r\n                    <li class=\"list-group-item text-left\">Data with TemtData - <b>");
#nullable restore
#line 16 "D:\Code Academy\Teaching\Groupes\P222\Lessons\22.11.2021-Asp.Net Intro\Codes\AspIntro\AspIntro\Views\Home\Index.cshtml"
                                                                             Write(TempData.Peek("Address"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n    \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
