#pragma checksum "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\CreateItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "936c037dfc1ad154c061f4ce313584a3a2c46d83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_CreateItem), @"mvc.1.0.view", @"/Views/Item/CreateItem.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\_ViewImports.cshtml"
using ProjectForItransition.Models.Collection;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\_ViewImports.cshtml"
using ProjectForItransition.Models.Item;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\_ViewImports.cshtml"
using ProjectForItransition.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\_ViewImports.cshtml"
using Markdig;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\_ViewImports.cshtml"
using CloudinaryDotNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"936c037dfc1ad154c061f4ce313584a3a2c46d83", @"/Views/Item/CreateItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12c5e679cfc7b8bd71c160ab083035edd5b3dbee", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_CreateItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectForItransition.ViewModels.Collection.ShowCollectionViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Item", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 5 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\CreateItem.cshtml"
  
    ViewData["Title"] = Localizer["Title"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row col-12\">\r\n    <div class=\"row mt-4\">\r\n        <h1 class=\"text-center col-12 mb-4\">");
#nullable restore
#line 11 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\CreateItem.cshtml"
                                       Write(Localizer["CreateItem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <div class=\"col-12\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "936c037dfc1ad154c061f4ce313584a3a2c46d836534", async() => {
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"CollectionId\"");
                BeginWriteAttribute("value", " value=\"", 463, "\"", 491, 1);
#nullable restore
#line 14 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\CreateItem.cshtml"
WriteAttributeValue("", 471, Model.Collection.Id, 471, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <div class=\"row mb-3\">\r\n                    <label class=\"col-5 col-sm-4 mt-1\">");
#nullable restore
#line 16 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\CreateItem.cshtml"
                                                  Write(Localizer["NameItem"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(": </label>\r\n                    <div class=\"col-7 col-sm-8\">\r\n                        <input type=\"text\" name=\"Name\" class=\"form-control\" />\r\n                    </div>\r\n                </div>\r\n                <input id=\"createTag\" name=\"Tags\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 857, "\"", 889, 1);
#nullable restore
#line 21 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\CreateItem.cshtml"
WriteAttributeValue("", 871, Localizer["Tags"], 871, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control col-12 mb-3\" />\r\n                <div class=\"row\">\r\n                    <div class=\"col-12 text-center\">\r\n                        <label class=\"mb-3 mt-3 h6\">");
#nullable restore
#line 24 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\CreateItem.cshtml"
                                               Write(Localizer["CustomField"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    </div>\r\n                </div>\r\n                <div class=\"row mb-2\">\r\n");
#nullable restore
#line 28 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\CreateItem.cshtml"
                      
                        int box = 1;
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\CreateItem.cshtml"
                         foreach (var NameField in Model.Collection.NameElements)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col-sm-4 text-sm-left text-center mt-1 mb-2\">\r\n                                ");
#nullable restore
#line 33 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\CreateItem.cshtml"
                           Write(NameField.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" : \r\n                            </div>\r\n                            <div class=\"col-sm-8  mb-2\">\r\n");
#nullable restore
#line 36 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\CreateItem.cshtml"
                                 switch (NameField.Type)
                                {
                                    case TypeField.Integer:

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <input type=\"number\" class=\"form-control\" name=\"Integers\" />\r\n");
#nullable restore
#line 40 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\CreateItem.cshtml"
                                        break;
                                    case TypeField.String:

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <input type=\"text\" class=\"form-control\" name=\"Strings\" />\r\n");
#nullable restore
#line 43 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\CreateItem.cshtml"
                                        break;
                                    case TypeField.Markdown:

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <textarea name=\"Markdowns\" class=\"form-control\" rows=\"10\"></textarea>\r\n");
#nullable restore
#line 46 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\CreateItem.cshtml"
                                        break;
                                    case TypeField.DateTime:

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <input type=\"date\" class=\"form-control\" name=\"Datetimes\" />\r\n");
#nullable restore
#line 49 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\CreateItem.cshtml"
                                        break;
                                    case TypeField.Checkbox:

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <input name=\"Checkboxes\" class=\"form-control\" type=\"checkbox\"");
                BeginWriteAttribute("value", " value=", 2707, "", 2718, 1);
#nullable restore
#line 51 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\CreateItem.cshtml"
WriteAttributeValue("", 2714, box, 2714, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 52 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\CreateItem.cshtml"
                                        box++;
                                        break;
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>\r\n");
#nullable restore
#line 56 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\CreateItem.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-12 text-right\">\r\n                        <input type=\"submit\" class=\"btn btn-success\"");
                BeginWriteAttribute("value", " value=\"", 3118, "\"", 3146, 1);
#nullable restore
#line 61 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\CreateItem.cshtml"
WriteAttributeValue("", 3126, Localizer["Create"], 3126, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<script>\r\n    var allTags = new Array();\r\n    var htmlItem = document.createElement(\'div\');\r\n");
#nullable restore
#line 71 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\CreateItem.cshtml"
     if (Model.AllTags != null)
    {
        foreach (var item in Model.AllTags)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("htmlItem.innerHTML = \"");
#nullable restore
#line 75 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\CreateItem.cshtml"
                               Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n            ");
            WriteLiteral("allTags.push(htmlItem.innerHTML);\r\n");
#nullable restore
#line 77 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\CreateItem.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    $(function () {\r\n        $(\'#createTag\').magicSuggest({\r\n            data: allTags,\r\n        });\r\n    });\r\n</script>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Cloudinary Cloudinary { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectForItransition.ViewModels.Collection.ShowCollectionViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
