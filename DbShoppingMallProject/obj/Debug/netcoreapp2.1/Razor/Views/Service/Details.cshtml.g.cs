#pragma checksum "E:\IDB\MVC_Core\Project\DbShoppingMallProject\DbShoppingMallProject\Views\Service\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea92acc946a997d8381cf8b17e48550d2261f9e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Service_Details), @"mvc.1.0.view", @"/Views/Service/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Service/Details.cshtml", typeof(AspNetCore.Views_Service_Details))]
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
#line 1 "E:\IDB\MVC_Core\Project\DbShoppingMallProject\DbShoppingMallProject\Views\_ViewImports.cshtml"
using DbShoppingMallProject;

#line default
#line hidden
#line 2 "E:\IDB\MVC_Core\Project\DbShoppingMallProject\DbShoppingMallProject\Views\_ViewImports.cshtml"
using DbShoppingMallProject.Models;

#line default
#line hidden
#line 3 "E:\IDB\MVC_Core\Project\DbShoppingMallProject\DbShoppingMallProject\Views\_ViewImports.cshtml"
using DbShoppingMallProject.Data;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ea92acc946a997d8381cf8b17e48550d2261f9e7", @"/Views/Service/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df0fd73debc09b7265e2fb485d5221306d498f7f", @"/Views/_ViewImports.cshtml")]
    public class Views_Service_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DbShoppingMallProject.Data.Services>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "E:\IDB\MVC_Core\Project\DbShoppingMallProject\DbShoppingMallProject\Views\Service\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(87, 85, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <div>\r\n        <label>Service Name</label>\r\n        ");
            EndContext();
            BeginContext(173, 29, false);
#line 11 "E:\IDB\MVC_Core\Project\DbShoppingMallProject\DbShoppingMallProject\Views\Service\Details.cshtml"
   Write(Html.DisplayFor(m => m.Title));

#line default
#line hidden
            EndContext();
            BeginContext(202, 69, true);
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <label>Description</label>\r\n        ");
            EndContext();
            BeginContext(272, 27, false);
#line 15 "E:\IDB\MVC_Core\Project\DbShoppingMallProject\DbShoppingMallProject\Views\Service\Details.cshtml"
   Write(Html.Raw(Model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(299, 70, true);
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <label>Company Name</label>\r\n        ");
            EndContext();
            BeginContext(370, 31, false);
#line 19 "E:\IDB\MVC_Core\Project\DbShoppingMallProject\DbShoppingMallProject\Views\Service\Details.cshtml"
   Write(Html.DisplayFor(m => m.StallId));

#line default
#line hidden
            EndContext();
            BeginContext(401, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DbShoppingMallProject.Data.Services> Html { get; private set; }
    }
}
#pragma warning restore 1591
