#pragma checksum "C:\Users\zeki\Documents\Visual Studio 2017\MyProjectFolder\CoreAppDemo-master\CoreAppDemo-master\CoreWebApp\Views\Admin\UserManagement.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e2e708c6b195be8ce6873404422b28bb3b454da9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_UserManagement), @"mvc.1.0.view", @"/Views/Admin/UserManagement.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Admin/UserManagement.cshtml", typeof(AspNetCore.Views_Admin_UserManagement))]
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
#line 1 "C:\Users\zeki\Documents\Visual Studio 2017\MyProjectFolder\CoreAppDemo-master\CoreAppDemo-master\CoreWebApp\Views\Admin\UserManagement.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "C:\Users\zeki\Documents\Visual Studio 2017\MyProjectFolder\CoreAppDemo-master\CoreAppDemo-master\CoreWebApp\Views\Admin\UserManagement.cshtml"
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2e708c6b195be8ce6873404422b28bb3b454da9", @"/Views/Admin/UserManagement.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4c6b3edba172995167d8bdb4da7acc0ca08fb7b", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_UserManagement : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreWebApp.Auth.ApplicationUser>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("table table-condensed table-bordered"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("header-content", "User Management", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("anchor-style", "primary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::CoreWebApp.TagHelpers.TableHeaderTagHelper __CoreWebApp_TagHelpers_TableHeaderTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::CoreWebApp.TagHelpers.AnchorStyleTagHelper __CoreWebApp_TagHelpers_AnchorStyleTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(149, 30, true);
            WriteLiteral("\r\n<h2>User management</h2>\r\n\r\n");
            EndContext();
#line 7 "C:\Users\zeki\Documents\Visual Studio 2017\MyProjectFolder\CoreAppDemo-master\CoreAppDemo-master\CoreWebApp\Views\Admin\UserManagement.cshtml"
 if (!Model.Any())
{

#line default
#line hidden
            BeginContext(202, 72, true);
            WriteLiteral("    <tr><td colspan=\"3\" class=\"text-center\">No User Accounts</td></tr>\r\n");
            EndContext();
#line 10 "C:\Users\zeki\Documents\Visual Studio 2017\MyProjectFolder\CoreAppDemo-master\CoreAppDemo-master\CoreWebApp\Views\Admin\UserManagement.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(286, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(290, 975, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("table", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2e708c6b195be8ce6873404422b28bb3b454da97702", async() => {
                BeginContext(382, 153, true);
                WriteLiteral("\r\n        <tr>\r\n            <th>User ID</th>\r\n            <th>User name</th>\r\n            <th>Email</th>\r\n            <th>Actions</th>\r\n        </tr>\r\n\r\n");
                EndContext();
#line 21 "C:\Users\zeki\Documents\Visual Studio 2017\MyProjectFolder\CoreAppDemo-master\CoreAppDemo-master\CoreWebApp\Views\Admin\UserManagement.cshtml"
         foreach (IdentityUser user in Model)
        {

#line default
#line hidden
                BeginContext(593, 38, true);
                WriteLiteral("            <tr>\r\n                <td>");
                EndContext();
                BeginContext(632, 7, false);
#line 24 "C:\Users\zeki\Documents\Visual Studio 2017\MyProjectFolder\CoreAppDemo-master\CoreAppDemo-master\CoreWebApp\Views\Admin\UserManagement.cshtml"
               Write(user.Id);

#line default
#line hidden
                EndContext();
                BeginContext(639, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(667, 13, false);
#line 25 "C:\Users\zeki\Documents\Visual Studio 2017\MyProjectFolder\CoreAppDemo-master\CoreAppDemo-master\CoreWebApp\Views\Admin\UserManagement.cshtml"
               Write(user.UserName);

#line default
#line hidden
                EndContext();
                BeginContext(680, 27, true);
                WriteLiteral("</td>\r\n                <td>");
                EndContext();
                BeginContext(708, 10, false);
#line 26 "C:\Users\zeki\Documents\Visual Studio 2017\MyProjectFolder\CoreAppDemo-master\CoreAppDemo-master\CoreWebApp\Views\Admin\UserManagement.cshtml"
               Write(user.Email);

#line default
#line hidden
                EndContext();
                BeginContext(718, 51, true);
                WriteLiteral("</td>\r\n\r\n                <td>\r\n                    ");
                EndContext();
                BeginContext(769, 429, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2e708c6b195be8ce6873404422b28bb3b454da99991", async() => {
                    BeginContext(837, 26, true);
                    WriteLiteral("\r\n                        ");
                    EndContext();
                    BeginContext(863, 88, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2e708c6b195be8ce6873404422b28bb3b454da910417", async() => {
                        BeginContext(943, 4, true);
                        WriteLiteral("Edit");
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                    if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                    {
                        throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                    }
                    BeginWriteTagHelperAttribute();
#line 30 "C:\Users\zeki\Documents\Visual Studio 2017\MyProjectFolder\CoreAppDemo-master\CoreAppDemo-master\CoreWebApp\Views\Admin\UserManagement.cshtml"
                                                                                  WriteLiteral(user.Id);

#line default
#line hidden
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
                    EndContext();
                    BeginContext(951, 240, true);
                    WriteLiteral("\r\n                        <button type=\"submit\" onclick=\"return confirm(\'Do you really want to delete this user?\');\" class=\"btn btn-sm btn-danger\">\r\n                            Delete\r\n                        </button>\r\n                    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 29 "C:\Users\zeki\Documents\Visual Studio 2017\MyProjectFolder\CoreAppDemo-master\CoreAppDemo-master\CoreWebApp\Views\Admin\UserManagement.cshtml"
                                                    WriteLiteral(user.Id);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1198, 44, true);
                WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
                EndContext();
#line 37 "C:\Users\zeki\Documents\Visual Studio 2017\MyProjectFolder\CoreAppDemo-master\CoreAppDemo-master\CoreWebApp\Views\Admin\UserManagement.cshtml"
        }

#line default
#line hidden
                BeginContext(1253, 4, true);
                WriteLiteral("    ");
                EndContext();
            }
            );
            __CoreWebApp_TagHelpers_TableHeaderTagHelper = CreateTagHelper<global::CoreWebApp.TagHelpers.TableHeaderTagHelper>();
            __tagHelperExecutionContext.Add(__CoreWebApp_TagHelpers_TableHeaderTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("header", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            __CoreWebApp_TagHelpers_TableHeaderTagHelper.HeaderContent = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1265, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 39 "C:\Users\zeki\Documents\Visual Studio 2017\MyProjectFolder\CoreAppDemo-master\CoreAppDemo-master\CoreWebApp\Views\Admin\UserManagement.cshtml"
}

#line default
#line hidden
            BeginContext(1270, 7, true);
            WriteLiteral("\r\n<p>\r\n");
            EndContext();
            BeginContext(1351, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(1355, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e2e708c6b195be8ce6873404422b28bb3b454da918151", async() => {
                BeginContext(1402, 12, true);
                WriteLiteral("Add new user");
                EndContext();
            }
            );
            __CoreWebApp_TagHelpers_AnchorStyleTagHelper = CreateTagHelper<global::CoreWebApp.TagHelpers.AnchorStyleTagHelper>();
            __tagHelperExecutionContext.Add(__CoreWebApp_TagHelpers_AnchorStyleTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __CoreWebApp_TagHelpers_AnchorStyleTagHelper.AnchorStyle = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1418, 6, true);
            WriteLiteral("\r\n</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreWebApp.Auth.ApplicationUser>> Html { get; private set; }
    }
}
#pragma warning restore 1591
