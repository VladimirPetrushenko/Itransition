#pragma checksum "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Collection\ShowOwnCollections.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d8320bca22fd68b7b2069a1a10849c1e940bd1f9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Collection_ShowOwnCollections), @"mvc.1.0.view", @"/Views/Collection/ShowOwnCollections.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8320bca22fd68b7b2069a1a10849c1e940bd1f9", @"/Views/Collection/ShowOwnCollections.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9759dca879eb168ea12831d93ec16c2c5c7e46c", @"/Views/_ViewImports.cshtml")]
    public class Views_Collection_ShowOwnCollections : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ProjectForItransition.Models.Collection.ContentCollection>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowCollection", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Collection", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateCollection", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteCollection", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateCollection", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 5 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Collection\ShowOwnCollections.cshtml"
  
    ViewData["Title"] = Localizer["Title"];

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"text-center m-3\">");
#nullable restore
#line 9 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Collection\ShowOwnCollections.cshtml"
                       Write(Localizer["Header"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<div class=\"m-2 list\">\r\n");
#nullable restore
#line 12 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Collection\ShowOwnCollections.cshtml"
     foreach (var collection in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-sm-12\">\r\n                <div class=\"card\">\r\n");
#nullable restore
#line 19 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Collection\ShowOwnCollections.cshtml"
                         if (collection.Image != null)
                        {
                            var url = Cloudinary.Api.UrlImgUp.Format("png")
                                           .Transform(new Transformation().Width(300).Height(200));
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Collection\ShowOwnCollections.cshtml"
                       Write(Html.Raw(url.BuildImageTag(collection.Image.PublicId, new StringDictionary("alt=Image collection", "class= card-img-top"))));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Collection\ShowOwnCollections.cshtml"
                                                                                                                                                        
                        }
                        else
                        {
                            var url = Cloudinary.Api.UrlImgUp.Format("png")
                                           .Transform(new Transformation().Width(300).Height(200).Crop("fill").Gravity("north").Effect("sepia").Chain());
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Collection\ShowOwnCollections.cshtml"
                       Write(Html.Raw(url.BuildImageTag("olbzel1gbnvmqbyjgnyj", new StringDictionary("alt=Image collection", "class= card-img-top"))));

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Collection\ShowOwnCollections.cshtml"
                                                                                                                                                     
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 33 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Collection\ShowOwnCollections.cshtml"
                                          Write(collection.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <div class=\"card-text\">");
#nullable restore
#line 34 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Collection\ShowOwnCollections.cshtml"
                                          Write(Localizer["Topic"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 34 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Collection\ShowOwnCollections.cshtml"
                                                                Write(collection.Topic);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        <div class=\"card-text\">\r\n");
#nullable restore
#line 36 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Collection\ShowOwnCollections.cshtml"
                             if (collection.Description != null)
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Collection\ShowOwnCollections.cshtml"
                           Write(Html.Raw(Markdown.ToHtml(collection.Description)));

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Collection\ShowOwnCollections.cshtml"
                                                                                  
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                        <div class=\"row text-center\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8320bca22fd68b7b2069a1a10849c1e940bd1f912991", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"CollectionId\"");
                BeginWriteAttribute("value", " value=\"", 2105, "\"", 2127, 1);
#nullable restore
#line 43 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Collection\ShowOwnCollections.cshtml"
WriteAttributeValue("", 2113, collection.Id, 2113, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <button class=\"btn w-100 btn-primary btn-circle\"><i class=\"far fa-eye\"></i></button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8320bca22fd68b7b2069a1a10849c1e940bd1f915592", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 2471, "\"", 2493, 1);
#nullable restore
#line 47 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Collection\ShowOwnCollections.cshtml"
WriteAttributeValue("", 2479, collection.Id, 2479, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <button class=\"btn w-100 btn-primary btn-circle\"><i class=\"far fa-edit\"></i></button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8320bca22fd68b7b2069a1a10849c1e940bd1f918184", async() => {
                WriteLiteral("\r\n                                <input type=\"hidden\" name=\"id\"");
                BeginWriteAttribute("value", " value=\"", 2839, "\"", 2861, 1);
#nullable restore
#line 51 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Collection\ShowOwnCollections.cshtml"
WriteAttributeValue("", 2847, collection.Id, 2847, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <button class=\"btn w-100 btn-danger btn-circle\"><i class=\"fas fa-ban\"></i></button>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 59 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Collection\ShowOwnCollections.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8320bca22fd68b7b2069a1a10849c1e940bd1f921119", async() => {
                WriteLiteral("\r\n        <button class=\"btn btn-primary\">");
#nullable restore
#line 61 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Collection\ShowOwnCollections.cshtml"
                                   Write(Localizer["CreateCollection"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ProjectForItransition.Models.Collection.ContentCollection>> Html { get; private set; }
    }
}
#pragma warning restore 1591
