#pragma checksum "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad135553822394a8be44d473c1b863b8d08c193a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_UpdateItem), @"mvc.1.0.view", @"/Views/Item/UpdateItem.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad135553822394a8be44d473c1b863b8d08c193a", @"/Views/Item/UpdateItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12c5e679cfc7b8bd71c160ab083035edd5b3dbee", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_UpdateItem : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectForItransition.ViewModels.Items.ShowItemModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateItem", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
  
    ViewData["Title"] = Localizer["Title"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row col-12\">\r\n    <div class=\"row mt-4\">\r\n        <h1 class=\"text-center col-12 mb-4\">");
#nullable restore
#line 11 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                                       Write(Localizer["UpdateItem"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <div class=\"col-12\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad135553822394a8be44d473c1b863b8d08c193a6519", async() => {
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"itemId\"");
                BeginWriteAttribute("value", " value=\"", 442, "\"", 464, 1);
#nullable restore
#line 14 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
WriteAttributeValue("", 450, Model.Item.Id, 450, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <input type=\"hidden\" name=\"CollectionId\"");
                BeginWriteAttribute("value", " value=\"", 526, "\"", 553, 1);
#nullable restore
#line 15 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
WriteAttributeValue("", 534, Model.CollectionId, 534, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                <div class=\"row mb-3\">\r\n                    <label class=\"col-5 col-sm-4 mt-1\">");
#nullable restore
#line 17 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                                                  Write(Localizer["NameItem"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(": </label>\r\n                    <div class=\"col-7 col-sm-8\">\r\n                        <input type=\"text\" name=\"Name\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 813, "\"", 837, 1);
#nullable restore
#line 19 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
WriteAttributeValue("", 821, Model.Item.Name, 821, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <label class=\"col-4 mt-1\">");
#nullable restore
#line 23 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                                         Write(Localizer["Tags"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@": </label>
                    <div class=""col-8"">
                        <div id=""updateTag"" class=""form-control"" name=""Tags""></div>
                    </div>
                </div>
                <div class=""row"">
                    <div class=""col-12 text-center"">
                        <label class=""mb-3 mt-3 h6"">");
#nullable restore
#line 30 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                                               Write(Localizer["CustomField"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                    </div>\r\n                </div>\r\n                <div class=\"row mb-2\">\r\n");
#nullable restore
#line 34 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                      
                        int integer = 0;
                        int strings = 0;
                        int markdown = 0;
                        int checkbox = 0;
                        int datetime = 0;
                        int box = 1;
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                         foreach (var NameField in Model.Fields)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"col-sm-4 text-center text-sm-left mt-1 mb-2\">\r\n                                ");
#nullable restore
#line 44 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                           Write(NameField.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" -\r\n                            </div>\r\n                            <div class=\"col-sm-8  mb-2\">\r\n");
#nullable restore
#line 47 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                                 switch (NameField.Type)
                                {
                                    case TypeField.Integer:
                                        if (Model.Item.IntegerElements.Count() > integer)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <input type=\"number\" name=\"integers\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 2441, "\"", 2491, 1);
#nullable restore
#line 52 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
WriteAttributeValue("", 2449, Model.Item.IntegerElements[integer].Value, 2449, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 53 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <input type=\"number\" class=\"form-control\" name=\"integers\" />\r\n");
#nullable restore
#line 57 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                                        }
                                        integer++;
                                        break;
                                    case TypeField.String:
                                        if (Model.Item.StringElements.Count() > strings)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <input type=\"text\" class=\"form-control\" name=\"strings\"");
                BeginWriteAttribute("value", " value=\"", 3169, "\"", 3218, 1);
#nullable restore
#line 63 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
WriteAttributeValue("", 3177, Model.Item.StringElements[strings].Value, 3177, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 64 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <input type=\"text\" class=\"form-control\" name=\"strings\" />\r\n");
#nullable restore
#line 68 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                                        }
                                        strings++;
                                        break;
                                    case TypeField.Markdown:
                                        if (Model.Item.MarkdownElements.Count() > markdown)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <textarea name=\"markdowns\" class=\"form-control\" rows=\"10\"> ");
#nullable restore
#line 74 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                                                                                                  Write(Model.Item.MarkdownElements[markdown].Value);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </textarea>\r\n");
#nullable restore
#line 75 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <textarea class=\"form-control\" name=\"markdowns\" rows=\"10\" />\r\n");
#nullable restore
#line 79 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                                        }
                                        markdown++;
                                        break;
                                    case TypeField.DateTime:
                                        if (Model.Item.DateTimeElements.Count() > datetime)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <input type=\"date\" name=\"datetimes\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 4641, "\"", 4693, 1);
#nullable restore
#line 85 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
WriteAttributeValue("", 4649, Model.Item.DateTimeElements[datetime].Value, 4649, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 86 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <input type=\"date\" name=\"datetimes\" class=\"form-control\" />\r\n");
#nullable restore
#line 90 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                                        }
                                        datetime++;
                                        break;
                                    case TypeField.Checkbox:
                                        if (Model.Item.CheckboxElements.Count() > checkbox)
                                        {
                                            if (Model.Item.CheckboxElements[checkbox].Value)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <input name=\"checkboxes\" type=\"checkbox\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=", 5528, "", 5539, 1);
#nullable restore
#line 98 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
WriteAttributeValue("", 5535, box, 5535, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" checked />\r\n");
#nullable restore
#line 99 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <input name=\"checkboxes\" type=\"checkbox\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=", 5805, "", 5816, 1);
#nullable restore
#line 102 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
WriteAttributeValue("", 5812, box, 5812, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 103 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                                            }
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <input name=\"checkboxes\" type=\"checkbox\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=", 6105, "", 6116, 1);
#nullable restore
#line 107 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
WriteAttributeValue("", 6112, box, 6112, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 108 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                                        }
                                        checkbox++;
                                        box++;
                                        break;
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </div>\r\n");
#nullable restore
#line 114 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-12 text-right\">\r\n                        <input type=\"submit\" class=\"btn btn-success\"");
                BeginWriteAttribute("value", " value=\"", 6612, "\"", 6640, 1);
#nullable restore
#line 119 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
WriteAttributeValue("", 6620, Localizer["Update"], 6620, 20, false);

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
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<script>\r\n    var allTagsForUpdateItem = new Array();\r\n    var htmlUpdate = document.createElement(\'div\');\r\n\r\n");
#nullable restore
#line 130 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
     if (Model.AllTags != null)
    {
        foreach (var item in Model.AllTags)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("htmlUpdate.innerHTML = \"");
#nullable restore
#line 134 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                                 Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n            ");
            WriteLiteral("allTagsForUpdateItem.push(htmlUpdate.innerHTML);\r\n");
#nullable restore
#line 136 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    var updateTags = new Array();\r\n");
#nullable restore
#line 139 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
     if (Model.Item.Tags != null)
    {
        foreach (var item in Model.Item.Tags.Select(x => x.Name).ToArray())
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            WriteLiteral("htmlUpdate.innerHTML = \"");
#nullable restore
#line 143 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                                 Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n            ");
            WriteLiteral("updateTags.push(htmlUpdate.innerHTML);\r\n");
#nullable restore
#line 145 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    $(function () {\r\n        $(\'#updateTag\').magicSuggest({\r\n            data: allTagsForUpdateItem,\r\n            value: updateTags,\r\n        });\r\n    });\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectForItransition.ViewModels.Items.ShowItemModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
