#pragma checksum "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\RoleController1\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "72455851b59b8c79d9b9f33b2d43d656d2c33f4d8fe36532fb87cc183e4d2f3c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RoleController1_Index), @"mvc.1.0.view", @"/Views/RoleController1/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\_ViewImports.cshtml"
using Demo.PL

#nullable disable
    ;
#nullable restore
#line 2 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\_ViewImports.cshtml"
using Demo.PL.Models

#nullable disable
    ;
#nullable restore
#line 3 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\_ViewImports.cshtml"
using DemoDAL.Models

#nullable disable
    ;
#nullable restore
#line 4 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\_ViewImports.cshtml"
using Demo.BLL.InterFaces

#nullable disable
    ;
#nullable restore
#line 5 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\_ViewImports.cshtml"
using Demo.PL.ViewModels

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"72455851b59b8c79d9b9f33b2d43d656d2c33f4d8fe36532fb87cc183e4d2f3c", @"/Views/RoleController1/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"dd4db1d6535322e29e426e7c47f573261168cd4b74d449ce62184bdfcccbe394", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_RoleController1_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<RoleViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("row offset-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonsPartialView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\RoleController1\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable

            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72455851b59b8c79d9b9f33b2d43d656d2c33f4d8fe36532fb87cc183e4d2f3c6243", async() => {
                WriteLiteral("Add New Role");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 8 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\RoleController1\Index.cshtml"
 if (Model.Count() > 0)
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div class=\"m-2\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "72455851b59b8c79d9b9f33b2d43d656d2c33f4d8fe36532fb87cc183e4d2f3c7810", async() => {
                WriteLiteral(@"
            <div class=""col-8"">
                <input class=""form-control"" type=""text"" name=""SearchValue"" placeholder=""User's Name"" />
            </div>
            <div class=""col-4"">
                <input type=""submit"" class=""btn btn-info"" value=""Search"" />
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <table class=\"table table-striped table-hover mt-5\">\r\n        <thead>\r\n            <tr>\r\n                <td>");
            Write(
#nullable restore
#line 23 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\RoleController1\Index.cshtml"
                     Html.DisplayNameFor(U => U.Id)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                <td>");
            Write(
#nullable restore
#line 24 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\RoleController1\Index.cshtml"
                     Html.DisplayNameFor(U => U.RoleName)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                <td>Detials</td>\r\n                <td>Update</td>\r\n                <td>Delete</td>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 31 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\RoleController1\Index.cshtml"
             foreach (var Role in Model)
            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                <tr>\r\n                    <td>");
            Write(
#nullable restore
#line 34 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\RoleController1\Index.cshtml"
                         Role.Id

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 35 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\RoleController1\Index.cshtml"
                         Role.RoleName

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "72455851b59b8c79d9b9f33b2d43d656d2c33f4d8fe36532fb87cc183e4d2f3c11654", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = 
#nullable restore
#line 36 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\RoleController1\Index.cshtml"
                                                                Role.Id

#line default
#line hidden
#nullable disable
            ;
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </tr>\r\n");
#nullable restore
#line 38 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\RoleController1\Index.cshtml"
            }

#line default
#line hidden
#nullable disable

            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 41 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\RoleController1\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div>\r\n        <h1>Therr Is No Roles</h1>\r\n    </div>\r\n");
#nullable restore
#line 47 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\RoleController1\Index.cshtml"
}

#line default
#line hidden
#nullable disable

        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<RoleViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
