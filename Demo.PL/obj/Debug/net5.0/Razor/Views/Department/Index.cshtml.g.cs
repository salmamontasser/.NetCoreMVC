#pragma checksum "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\Department\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8a4ac7153b4cdd6f3381fb4c19f3df8b0cddfe6255d787fd9391b20b7f6e3905"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Department_Index), @"mvc.1.0.view", @"/Views/Department/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8a4ac7153b4cdd6f3381fb4c19f3df8b0cddfe6255d787fd9391b20b7f6e3905", @"/Views/Department/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"dd4db1d6535322e29e426e7c47f573261168cd4b74d449ce62184bdfcccbe394", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Department_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DepartmentViewModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ButtonsPartialView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_FadeView", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\Department\Index.cshtml"
  
    ViewData["Title"] = "All Department";

#line default
#line hidden
#nullable disable

#nullable restore
#line 6 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\Department\Index.cshtml"
 if (TempData["Message"] is not null)
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div class=\" alert alert-success \" id=\"success-alert\" >\r\n    ");
            Write(
#nullable restore
#line 9 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\Department\Index.cshtml"
     TempData["Message"]

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\r\n</div>    \r\n");
#nullable restore
#line 11 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\Department\Index.cshtml"
}

#line default
#line hidden
#nullable disable

            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a4ac7153b4cdd6f3381fb4c19f3df8b0cddfe6255d787fd9391b20b7f6e39056425", async() => {
                WriteLiteral("Create New Department");
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
            WriteLiteral("\r\n<br />\r\n");
#nullable restore
#line 14 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\Department\Index.cshtml"
 if(Model.Count() > 0)
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <h1> All Departments </h1>\r\n    <br />\r\n    <table class=\"table table-striped table-hover mt-3\">\r\n        <thead>\r\n            <tr>\r\n                <td>");
            Write(
#nullable restore
#line 21 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\Department\Index.cshtml"
                     Html.DisplayNameFor(D=>D.Code)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                <td>");
            Write(
#nullable restore
#line 22 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\Department\Index.cshtml"
                     Html.DisplayNameFor(D => D.Name)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                <td>");
            Write(
#nullable restore
#line 23 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\Department\Index.cshtml"
                     Html.DisplayNameFor(D => D.DateOfCreation)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                <td>Detials</td>\r\n                <td>Update</td>\r\n                <td>Delete</td>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 30 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\Department\Index.cshtml"
           foreach(var department in Model)
            {

#line default
#line hidden
#nullable disable

            WriteLiteral("                <tr>\r\n                    <td>");
            Write(
#nullable restore
#line 33 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\Department\Index.cshtml"
                         department.Code

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 34 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\Department\Index.cshtml"
                         department.Name

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    <td>");
            Write(
#nullable restore
#line 35 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\Department\Index.cshtml"
                         department.DateOfCreation

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8a4ac7153b4cdd6f3381fb4c19f3df8b0cddfe6255d787fd9391b20b7f6e390510681", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = 
#nullable restore
#line 36 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\Department\Index.cshtml"
                                                                department.Id.ToString()

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
            WriteLiteral("</partial>\r\n                </tr>\r\n");
#nullable restore
#line 38 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\Department\Index.cshtml"
            }

#line default
#line hidden
#nullable disable

            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 41 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\Department\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable

            WriteLiteral("    <div class=\"mt-5 alert alert-warning\">\r\n        <h3>There Is No Departments</h3>\r\n    </div>\r\n");
#nullable restore
#line 47 "D:\Full-Stack_c42\backend(.net)\aliaa\07 ASP.NET Core MVC\Demos\MVCSolution\Demo.PL\Views\Department\Index.cshtml"
}

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n");
            DefineSection("Fade", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8a4ac7153b4cdd6f3381fb4c19f3df8b0cddfe6255d787fd9391b20b7f6e390513409", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("                   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DepartmentViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
