#pragma checksum "E:\Workspace\.net-workspace\RestaurantWebApp\RestaurantWebApp\Views\Item\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "05102e8bbdd05779edaaf12f0a27d8da70cce20f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_Index), @"mvc.1.0.view", @"/Views/Item/Index.cshtml")]
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
#line 1 "E:\Workspace\.net-workspace\RestaurantWebApp\RestaurantWebApp\Views\_ViewImports.cshtml"
using RestaurantWebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Workspace\.net-workspace\RestaurantWebApp\RestaurantWebApp\Views\_ViewImports.cshtml"
using RestaurantWebApp.Models.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05102e8bbdd05779edaaf12f0a27d8da70cce20f", @"/Views/Item/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1375684ce105c1a0d0e70c81b32ab0b5a565203b", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ItemListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class", "btn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-normal", "btn-secondary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("page-class-selected", "btn-primary", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-group pull-right m-1"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::RestaurantWebApp.Infrastructure.ItemPerPageTagHelper __RestaurantWebApp_Infrastructure_ItemPerPageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 25 "E:\Workspace\.net-workspace\RestaurantWebApp\RestaurantWebApp\Views\Item\Index.cshtml"
 foreach (var i in Model.Items)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"card card-outline-primary m-1 p-1\">\r\n        <div class=\"bg-faded p-1\">\r\n            <h4>\r\n                ");
#nullable restore
#line 30 "E:\Workspace\.net-workspace\RestaurantWebApp\RestaurantWebApp\Views\Item\Index.cshtml"
           Write(i.ItemName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <span class=\"badge badge-pill badge-primary\" style=\"float:right\">\r\n                    <small>");
#nullable restore
#line 32 "E:\Workspace\.net-workspace\RestaurantWebApp\RestaurantWebApp\Views\Item\Index.cshtml"
                      Write(i.ItemPrice.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                </span>\r\n            </h4>\r\n        </div>\r\n        <div class=\"card-text p-1\">");
#nullable restore
#line 36 "E:\Workspace\.net-workspace\RestaurantWebApp\RestaurantWebApp\Views\Item\Index.cshtml"
                              Write(i.ItemDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n");
#nullable restore
#line 38 "E:\Workspace\.net-workspace\RestaurantWebApp\RestaurantWebApp\Views\Item\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "05102e8bbdd05779edaaf12f0a27d8da70cce20f6360", async() => {
                WriteLiteral("\r\n");
            }
            );
            __RestaurantWebApp_Infrastructure_ItemPerPageTagHelper = CreateTagHelper<global::RestaurantWebApp.Infrastructure.ItemPerPageTagHelper>();
            __tagHelperExecutionContext.Add(__RestaurantWebApp_Infrastructure_ItemPerPageTagHelper);
#nullable restore
#line 39 "E:\Workspace\.net-workspace\RestaurantWebApp\RestaurantWebApp\Views\Item\Index.cshtml"
__RestaurantWebApp_Infrastructure_ItemPerPageTagHelper.PageModel = Model.PageInfo;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-model", __RestaurantWebApp_Infrastructure_ItemPerPageTagHelper.PageModel, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __RestaurantWebApp_Infrastructure_ItemPerPageTagHelper.PageAction = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 39 "E:\Workspace\.net-workspace\RestaurantWebApp\RestaurantWebApp\Views\Item\Index.cshtml"
__RestaurantWebApp_Infrastructure_ItemPerPageTagHelper.PageClassesEnabled = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("page-classes-enabled", __RestaurantWebApp_Infrastructure_ItemPerPageTagHelper.PageClassesEnabled, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __RestaurantWebApp_Infrastructure_ItemPerPageTagHelper.PageClass = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __RestaurantWebApp_Infrastructure_ItemPerPageTagHelper.PageClassNormal = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __RestaurantWebApp_Infrastructure_ItemPerPageTagHelper.PageClassSelected = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ItemListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591