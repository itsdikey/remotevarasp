#pragma checksum "C:\Users\garmu\source\repos\RemoteVar.Corev2\RemoteVar.Corev2\Views\App\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e574da5b4645d1093c960b416ef4127eebafee7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_App_List), @"mvc.1.0.view", @"/Views/App/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/App/List.cshtml", typeof(AspNetCore.Views_App_List))]
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
#line 1 "C:\Users\garmu\source\repos\RemoteVar.Corev2\RemoteVar.Corev2\Views\_ViewImports.cshtml"
using RemoteVar.Corev2;

#line default
#line hidden
#line 2 "C:\Users\garmu\source\repos\RemoteVar.Corev2\RemoteVar.Corev2\Views\_ViewImports.cshtml"
using RemoteVar.Corev2.Models;

#line default
#line hidden
#line 1 "C:\Users\garmu\source\repos\RemoteVar.Corev2\RemoteVar.Corev2\Views\App\List.cshtml"
using RemoteVar.Corev2.Models.Application;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e574da5b4645d1093c960b416ef4127eebafee7", @"/Views/App/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9903877492c059bfcb3679ae72b97e6eebef3129", @"/Views/_ViewImports.cshtml")]
    public class Views_App_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ApplicationListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\garmu\source\repos\RemoteVar.Corev2\RemoteVar.Corev2\Views\App\List.cshtml"
  
    ViewData["Title"] = "List";

#line default
#line hidden
            BeginContext(117, 41, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <h2>\r\n        ");
            EndContext();
            BeginContext(158, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d2a45f7df854ede8d5df7ec2846d53f", async() => {
                BeginContext(202, 3, true);
                WriteLiteral("#RV");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(209, 90, true);
            WriteLiteral(" > #Applications Layer\r\n    </h2>\r\n\r\n</div>\r\n\r\n<div class=\"container body-container\">\r\n   ");
            EndContext();
            BeginContext(300, 60, false);
#line 16 "C:\Users\garmu\source\repos\RemoteVar.Corev2\RemoteVar.Corev2\Views\App\List.cshtml"
Write(await Html.PartialAsync("_AddAppPartial", new AddAppModel()));

#line default
#line hidden
            EndContext();
            BeginContext(360, 1103, true);
            WriteLiteral(@"

    <div class=""row"" style=""margin-top: 15px"">
        <div class=""col-md-9"" style=""background-color:ghostwhite"">
            <table class=""table custom-list"" style=""width:100%"">
                <thead>
                    <tr>
                        <td class=""text-center"" style=""width:10%"">
                            <h3>
                                #
                            </h3>
                        </td>
                        <td class=""text-center"">
                            <h3>
                                App Id
                            </h3>
                        </td>
                        <td class=""text-center"">
                            <h3>
                                App Name
                            </h3>
                        </td>
                        <td colspan=""2"" class=""text-center"">
                            <h3>
                                Actions
                            </h3>
                        </td>");
            WriteLiteral("\n                    </tr>\r\n                </thead>\r\n                <tbody>\r\n");
            EndContext();
#line 46 "C:\Users\garmu\source\repos\RemoteVar.Corev2\RemoteVar.Corev2\Views\App\List.cshtml"
                 for (int i=0; i< Model.Applications.Count; i++)
                {
                    Application current = Model.Applications[i];

#line default
#line hidden
            BeginContext(1614, 94, true);
            WriteLiteral("                      <tr>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1710, 22, false);
#line 51 "C:\Users\garmu\source\repos\RemoteVar.Corev2\RemoteVar.Corev2\Views\App\List.cshtml"
                            Write((i + 1).ToString("D6"));

#line default
#line hidden
            EndContext();
            BeginContext(1733, 167, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <a href=\"#\" class=\"appId\">\r\n                                    ");
            EndContext();
            BeginContext(1901, 13, false);
#line 55 "C:\Users\garmu\source\repos\RemoteVar.Corev2\RemoteVar.Corev2\Views\App\List.cshtml"
                               Write(current.AppId);

#line default
#line hidden
            EndContext();
            BeginContext(1914, 141, true);
            WriteLiteral("\r\n                                </a>\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(2056, 15, false);
#line 59 "C:\Users\garmu\source\repos\RemoteVar.Corev2\RemoteVar.Corev2\Views\App\List.cshtml"
                           Write(current.AppName);

#line default
#line hidden
            EndContext();
            BeginContext(2071, 105, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2176, "\"", 2205, 2);
            WriteAttributeValue("", 2183, "/App?id=", 2183, 8, true);
#line 62 "C:\Users\garmu\source\repos\RemoteVar.Corev2\RemoteVar.Corev2\Views\App\List.cshtml"
WriteAttributeValue("", 2191, current.AppId, 2191, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2206, 76, true);
            WriteLiteral(" class=\"btn btn-primary\">Variables</a>\r\n\r\n                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2282, "\"", 2318, 2);
            WriteAttributeValue("", 2289, "/App/Delete?id=", 2289, 15, true);
#line 64 "C:\Users\garmu\source\repos\RemoteVar.Corev2\RemoteVar.Corev2\Views\App\List.cshtml"
WriteAttributeValue("", 2304, current.AppId, 2304, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2319, 102, true);
            WriteLiteral(" class=\"btn btn-danger\">Delete</a>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 67 "C:\Users\garmu\source\repos\RemoteVar.Corev2\RemoteVar.Corev2\Views\App\List.cshtml"
                }

#line default
#line hidden
            BeginContext(2440, 84, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ApplicationListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
