#pragma checksum "/home/msic/Public/NET/webAppDemo/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d2b847533f9e5b71375fac38886d0d693b87e1bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/home/msic/Public/NET/webAppDemo/Views/_ViewImports.cshtml"
using webAppDemo;

#line default
#line hidden
#line 2 "/home/msic/Public/NET/webAppDemo/Views/_ViewImports.cshtml"
using webAppDemo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d2b847533f9e5b71375fac38886d0d693b87e1bb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c26001a84e9833a05f81f4a0da5a379c85d9eda1", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<webAppDemo.Models.Users>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "List users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "/home/msic/Public/NET/webAppDemo/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";Layout = "~/Views/Shared/_Custom.cshtml";

#line default
#line hidden
            BeginContext(127, 34, true);
            WriteLiteral("\r\n<h3></h3>\r\n\r\n<div class=\"row\">\r\n");
            EndContext();
#line 9 "/home/msic/Public/NET/webAppDemo/Views/Home/Index.cshtml"
      if(ViewData["error"]!=null){

#line default
#line hidden
            BeginContext(195, 43, true);
            WriteLiteral(" <div class=\"col-sm-12 alert alert-danger\">");
            EndContext();
            BeginContext(239, 17, false);
#line 9 "/home/msic/Public/NET/webAppDemo/Views/Home/Index.cshtml"
                                                                        Write(ViewData["error"]);

#line default
#line hidden
            EndContext();
            BeginContext(256, 7, true);
            WriteLiteral("</div> ");
            EndContext();
#line 9 "/home/msic/Public/NET/webAppDemo/Views/Home/Index.cshtml"
                                                                                                      } 

#line default
#line hidden
            BeginContext(268, 13, true);
            WriteLiteral("    <p>\r\n    ");
            EndContext();
            BeginContext(281, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f59cebabf754f098a8449723d5cba6c", async() => {
                BeginContext(332, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(346, 498, true);
            WriteLiteral(@"
</p>
    <div class=""col-sm-12 table-responsive-sm"">

            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th scope=""col"">Id</th>
                        <th scope=""col"">Fisrtname</th>
                        <th scope=""col"">Username</th>
                        <th scope=""col"">Email</th>
                        <th scope=""col"">Date</th>
                    </tr>
                </thead>
                <tbody>
");
            EndContext();
#line 26 "/home/msic/Public/NET/webAppDemo/Views/Home/Index.cshtml"
                      
                        if(Model.Count > 0){
                            foreach (var item in Model)
                            {

#line default
#line hidden
            BeginContext(1002, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(1081, 7, false);
#line 31 "/home/msic/Public/NET/webAppDemo/Views/Home/Index.cshtml"
                                   Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1088, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1136, 13, false);
#line 32 "/home/msic/Public/NET/webAppDemo/Views/Home/Index.cshtml"
                                   Write(item.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(1149, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1197, 8, false);
#line 33 "/home/msic/Public/NET/webAppDemo/Views/Home/Index.cshtml"
                                   Write(item.Uid);

#line default
#line hidden
            EndContext();
            BeginContext(1205, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1253, 10, false);
#line 34 "/home/msic/Public/NET/webAppDemo/Views/Home/Index.cshtml"
                                   Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1263, 47, true);
            WriteLiteral("</td>\r\n                                    <td>");
            EndContext();
            BeginContext(1311, 12, false);
#line 35 "/home/msic/Public/NET/webAppDemo/Views/Home/Index.cshtml"
                                   Write(item.Created);

#line default
#line hidden
            EndContext();
            BeginContext(1323, 46, true);
            WriteLiteral("</td>\r\n                                </tr>\r\n");
            EndContext();
#line 37 "/home/msic/Public/NET/webAppDemo/Views/Home/Index.cshtml"
                            }
                        }
                        else{

#line default
#line hidden
            BeginContext(1458, 88, true);
            WriteLiteral("                            <tr><td colspan=\"5\" align=\"center\">No data found</td></tr>\r\n");
            EndContext();
#line 41 "/home/msic/Public/NET/webAppDemo/Views/Home/Index.cshtml"
                        }
                    

#line default
#line hidden
            BeginContext(1596, 76, true);
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n  \r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<webAppDemo.Models.Users>> Html { get; private set; }
    }
}
#pragma warning restore 1591
