#pragma checksum "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c54daaff264905f7fe3f61a5b7bd3c149997242"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c54daaff264905f7fe3f61a5b7bd3c149997242", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9759dca879eb168ea12831d93ec16c2c5c7e46c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectForItransition.ViewModels.Collection.IndexViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Item", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowCollection", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Collection", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml"
  
    ViewData["Title"] = Localizer["Title"];

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row col-12 pr-0"">
    <div class=""col-4 border"">
        <div class=""row"">
            <div class=""col-sm-1""></div>
            <div id=""container2"" class=""col-sm-10""></div> 
            <div class=""col-sm-1""></div>
        </div>
        <div class=""row"">
            <div class=""col-12"">
                <h3 class=""text-center m-2"">");
#nullable restore
#line 18 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml"
                                       Write(Localizer["LastItems"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            </div>\r\n");
#nullable restore
#line 20 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml"
             if (Model.Items != null)
            {
                foreach (var item in Model.Items)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-12\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c54daaff264905f7fe3f61a5b7bd3c1499972427350", async() => {
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"collectionId\"");
                BeginWriteAttribute("value", " value=\"", 885, "\"", 912, 1);
#nullable restore
#line 26 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml"
WriteAttributeValue("", 893, item.Collection.Id, 893, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <input type=\"hidden\" name=\"itemId\"");
                BeginWriteAttribute("value", " value=\"", 980, "\"", 996, 1);
#nullable restore
#line 27 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml"
WriteAttributeValue("", 988, item.Id, 988, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            <input type=\"submit\" class=\"btn btn-link\"");
                BeginWriteAttribute("value", " value=\"", 1071, "\"", 1089, 1);
#nullable restore
#line 28 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml"
WriteAttributeValue("", 1079, item.Name, 1079, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-12\">\r\n");
#nullable restore
#line 32 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml"
                         if (item.Tags != null)
                        {
                            foreach (var tag in item.Tags.Select(x => x.Name))
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span>");
#nullable restore
#line 36 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml"
                                 Write(tag);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </span>\r\n");
#nullable restore
#line 37 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml"
                            }
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <hr />\r\n");
#nullable restore
#line 41 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml"
                }
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-12\">");
#nullable restore
#line 45 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml"
                               Write(Localizer["NoItems"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
#nullable restore
#line 46 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"col-8\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 51 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml"
             foreach (var collection in Model.Collections)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-sm-6 mb-3 card-group\">\r\n                    <div class=\"card\">\r\n");
#nullable restore
#line 56 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml"
                             if (collection.Image != null)
                            {
                                var url = Cloudinary.Api.UrlImgUp.Format("png")
                                               .Transform(new Transformation().Width(300).Height(250));

                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml"
                           Write(Html.Raw(url.BuildImageTag(collection.Image.PublicId, new StringDictionary("alt=Image collection", "class= card-img-top"))));

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml"
                                                                                                                                                            
                            }
                            else
                            {
                                var url = Cloudinary.Api.UrlImgUp.Format("png")
                                            .Transform(new Transformation().Width(300).Height(250).Crop("fill").Gravity("north").Effect("sepia").Chain());

                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml"
                           Write(Html.Raw(url.BuildImageTag("olbzel1gbnvmqbyjgnyj", new StringDictionary("alt=Image collection", "class= card-img-top"))));

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml"
                                                                                                                                                         
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"card-body pb-5\">\r\n                            <h5 class=\"card-title\">");
#nullable restore
#line 72 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml"
                                              Write(collection.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <div class=\"card-subtitle\">");
#nullable restore
#line 73 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml"
                                                  Write(Localizer["Topic"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 73 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml"
                                                                        Write(collection.Topic);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div class=\"card-text\">");
#nullable restore
#line 74 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml"
                                              Write(collection.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div class=\"card-text\">");
#nullable restore
#line 75 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml"
                                              Write(Localizer["Amount"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 75 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml"
                                                                     Write(collection.Items.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                            <div class=\"card-text card-bottom btn-group mr-1\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c54daaff264905f7fe3f61a5b7bd3c14999724217557", async() => {
                WriteLiteral("\r\n                                    <input type=\"hidden\" name=\"collectionId\"");
                BeginWriteAttribute("value", " value=\"", 3646, "\"", 3668, 1);
#nullable restore
#line 78 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml"
WriteAttributeValue("", 3654, collection.Id, 3654, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                    <button class=\"btn btn-primary\">");
#nullable restore
#line 79 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml"
                                                               Write(Localizer["ShowCollection"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 85 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n<script charset=\"utf-8\">\r\n    var items = new Array();\r\n    var html = document.createElement(\'div\');\r\n");
#nullable restore
#line 92 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml"
     foreach (var item in Model.Tags)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            WriteLiteral("html.innerHTML = \"");
#nullable restore
#line 94 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml"
                       Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n        ");
            WriteLiteral("items.push({ text: html.innerHTML, weight: ");
#nullable restore
#line 95 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml"
                                                Write(item.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral(", link: \'./Search/Index/?tag=\' + html.innerHTML })\r\n");
#nullable restore
#line 96 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    $(function () {\r\n        $(\"#container2\").jQCloud(items, {\r\n            height: 200,\r\n        });\r\n    });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjectForItransition.ViewModels.Collection.IndexViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
