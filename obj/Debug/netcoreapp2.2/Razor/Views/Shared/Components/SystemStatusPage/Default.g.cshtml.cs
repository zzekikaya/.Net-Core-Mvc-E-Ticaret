#pragma checksum "C:\Users\zeki\Documents\Visual Studio 2017\MyProjectFolder\CoreAppDemo-master\CoreAppDemo-master\CoreWebApp\Views\Shared\Components\SystemStatusPage\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07bd6c3bc620be185b771e54e3f0ff76a46f5882"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SystemStatusPage_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SystemStatusPage/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/SystemStatusPage/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_SystemStatusPage_Default))]
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
#line 1 "C:\Users\zeki\Documents\Visual Studio 2017\MyProjectFolder\CoreAppDemo-master\CoreAppDemo-master\CoreWebApp\Views\_ViewImports.cshtml"
using CoreWebApp.Models;

#line default
#line hidden
#line 2 "C:\Users\zeki\Documents\Visual Studio 2017\MyProjectFolder\CoreAppDemo-master\CoreAppDemo-master\CoreWebApp\Views\_ViewImports.cshtml"
using CoreWebApp.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07bd6c3bc620be185b771e54e3f0ff76a46f5882", @"/Views/Shared/Components/SystemStatusPage/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4c6b3edba172995167d8bdb4da7acc0ca08fb7b", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SystemStatusPage_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<bool>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(13, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\zeki\Documents\Visual Studio 2017\MyProjectFolder\CoreAppDemo-master\CoreAppDemo-master\CoreWebApp\Views\Shared\Components\SystemStatusPage\Default.cshtml"
 if (Model)
{

#line default
#line hidden
            BeginContext(31, 41, true);
            WriteLiteral("    <h6>All systems up and running</h6>\r\n");
            EndContext();
#line 6 "C:\Users\zeki\Documents\Visual Studio 2017\MyProjectFolder\CoreAppDemo-master\CoreAppDemo-master\CoreWebApp\Views\Shared\Components\SystemStatusPage\Default.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(84, 54, true);
            WriteLiteral("    <h6>We\'re currently encountering some issue</h6>\r\n");
            EndContext();
#line 10 "C:\Users\zeki\Documents\Visual Studio 2017\MyProjectFolder\CoreAppDemo-master\CoreAppDemo-master\CoreWebApp\Views\Shared\Components\SystemStatusPage\Default.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<bool> Html { get; private set; }
    }
}
#pragma warning restore 1591