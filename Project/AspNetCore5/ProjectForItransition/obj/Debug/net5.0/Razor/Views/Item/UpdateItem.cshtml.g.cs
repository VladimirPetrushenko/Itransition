#pragma checksum "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4c945d182dbdcb5377c89879367d4f546c545463"
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
    using Microsoft.AspNetCore.Mvc;
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4c945d182dbdcb5377c89879367d4f546c545463", @"/Views/Item/UpdateItem.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9759dca879eb168ea12831d93ec16c2c5c7e46c", @"/Views/_ViewImports.cshtml")]
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
#nullable restore
#line 3 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
  
    ViewData["Title"] = "Update Item";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Update Item</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4c945d182dbdcb5377c89879367d4f546c5454635650", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"itemId\"");
                BeginWriteAttribute("value", " value=\"", 240, "\"", 262, 1);
#nullable restore
#line 9 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
WriteAttributeValue("", 248, Model.Item.Id, 248, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"CollectionId\"");
                BeginWriteAttribute("value", " value=\"", 312, "\"", 339, 1);
#nullable restore
#line 10 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
WriteAttributeValue("", 320, Model.CollectionId, 320, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <h2>Name Item</h2>\r\n    <input type=\"text\" name=\"Name\" class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 424, "\"", 448, 1);
#nullable restore
#line 12 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
WriteAttributeValue("", 432, Model.Item.Name, 432, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 13 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
      
        string tags = string.Empty;
        foreach (var tag in Model.Item.Tags)
        {
            tags += tag.Name + " ";
        }

    

#line default
#line hidden
#nullable disable
                WriteLiteral("    <label>Tags</label>\r\n    <div id=\"updateTag\" class=\"form-control\" name=\"Tags\"></div>\r\n    <p>Custom Field</p>\r\n\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 26 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
          
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
#line 33 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
             foreach (var NameField in Model.Fields)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"col-12 mb-2\">\r\n                    ");
#nullable restore
#line 36 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
               Write(NameField.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" -\r\n");
#nullable restore
#line 37 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                     switch (NameField.Type)
                    {
                        case TypeField.Integer:
                            if (Model.Item.IntegerElements.Count() > integer)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <input type=\"number\" name=\"integers\"");
                BeginWriteAttribute("value", " value=\"", 1391, "\"", 1441, 1);
#nullable restore
#line 42 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
WriteAttributeValue("", 1399, Model.Item.IntegerElements[integer].Value, 1399, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 43 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <input type=\"number\" name=\"integers\" />\r\n");
#nullable restore
#line 47 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                            }
                            integer++;
                            break;
                        case TypeField.String:
                            if (Model.Item.StringElements.Count() > strings)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <input type=\"text\" class=\"form-control\" name=\"strings\"");
                BeginWriteAttribute("value", " value=\"", 1966, "\"", 2015, 1);
#nullable restore
#line 53 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
WriteAttributeValue("", 1974, Model.Item.StringElements[strings].Value, 1974, 41, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 54 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <input type=\"text\" name=\"strings\" />\r\n");
#nullable restore
#line 58 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                            }
                            strings++;
                            break;
                        case TypeField.Markdown:
                            if (Model.Item.MarkdownElements.Count() > markdown)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <textarea name=\"markdowns\" class=\"form-control\" rows=\"10\"> ");
#nullable restore
#line 64 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                                                                                      Write(Model.Item.MarkdownElements[markdown].Value);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </textarea>\r\n");
#nullable restore
#line 65 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <input type=\"text\" name=\"markdowns\" />\r\n");
#nullable restore
#line 69 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                            }
                            markdown++;
                            break;
                        case TypeField.DateTime:
                            if (Model.Item.DateTimeElements.Count() > datetime)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <input type=\"date\" name=\"datetimes\"");
                BeginWriteAttribute("value", " value=\"", 3110, "\"", 3162, 1);
#nullable restore
#line 75 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
WriteAttributeValue("", 3118, Model.Item.DateTimeElements[datetime].Value, 3118, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 76 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <input type=\"date\" name=\"datetimes\" />\r\n");
#nullable restore
#line 80 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
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
                WriteLiteral("                                    <input name=\"checkboxes\" type=\"checkbox\"");
                BeginWriteAttribute("value", " value=", 3799, "", 3810, 1);
#nullable restore
#line 88 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
WriteAttributeValue("", 3806, box, 3806, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" checked />\r\n");
#nullable restore
#line 89 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <input name=\"checkboxes\" type=\"checkbox\"");
                BeginWriteAttribute("value", " value=", 4007, "", 4018, 1);
#nullable restore
#line 92 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
WriteAttributeValue("", 4014, box, 4014, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n");
#nullable restore
#line 93 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                                }
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <input name=\"checkboxes\" type=\"checkbox\"");
                BeginWriteAttribute("value", " value=", 4226, "", 4237, 1);
#nullable restore
#line 97 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
WriteAttributeValue("", 4233, box, 4233, 4, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 98 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                            }
                            checkbox++;
                            box++;
                            break;
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n");
#nullable restore
#line 104 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n    <input type=\"submit\" value=\"Update\" />\r\n");
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
            WriteLiteral("\r\n<script>\r\n    var allTagsForUpdateItem = new Array();\r\n    var htmlUpdate = document.createElement(\'div\');\r\n\r\n");
#nullable restore
#line 113 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
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
#line 117 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                                 Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n            ");
            WriteLiteral("allTagsForUpdateItem.push(htmlUpdate.innerHTML);\r\n");
#nullable restore
#line 119 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    var updateTags = new Array();\r\n");
#nullable restore
#line 122 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
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
#line 126 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
                                 Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n            ");
            WriteLiteral("updateTags.push(htmlUpdate.innerHTML);\r\n");
#nullable restore
#line 128 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\UpdateItem.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    $(function () {\r\n        $(\'#updateTag\').magicSuggest({\r\n            data: allTagsForUpdateItem,\r\n            value: updateTags,\r\n        });\r\n    });\r\n</script>");
        }
        #pragma warning restore 1998
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
