#pragma checksum "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb87c2fbbcd34d6737faa195723d01c75ed3457a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb87c2fbbcd34d6737faa195723d01c75ed3457a", @"/Views/Item/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1778b3da9aa775079327aacac47da5be3e27ec4", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjectForItransition.ViewModels.Items.ShowItemModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary float-right"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowCollection", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Collection", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("formmethod", new global::Microsoft.AspNetCore.Html.HtmlString("get"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Item", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1 class=\"text-center\">Item - ");
#nullable restore
#line 3 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
                          Write(Model.Item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb87c2fbbcd34d6737faa195723d01c75ed3457a6884", async() => {
                WriteLiteral("\r\n    <h4>\r\n        Tags -\r\n");
#nullable restore
#line 8 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
         foreach (var tag in Model.Item.Tags)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <span>");
#nullable restore
#line 10 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
             Write(tag.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>\r\n");
#nullable restore
#line 11 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb87c2fbbcd34d6737faa195723d01c75ed3457a7964", async() => {
                    WriteLiteral("Back");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </h4>\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 16 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
          
            int integer = 0;
            int strings = 0;
            int markdown = 0;
            int checkbox = 0;
            int datetime = 0;
            for (int i = 0; i < Model.Fields.Count(); i++)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"col-12 h6\">\r\n                    ");
#nullable restore
#line 25 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
               Write(Model.Fields[i].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" -\r\n");
#nullable restore
#line 26 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
                     if (Model.Fields[i].Type == @TypeField.Integer)
                    {
                        if (Model.Item.IntegerElements.Count() > integer)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <span> ");
#nullable restore
#line 30 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
                              Write(Model.Item.IntegerElements[integer].Value);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>\r\n");
#nullable restore
#line 31 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
                            integer++;
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <span> field is not occupied </span>\r\n");
#nullable restore
#line 36 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
                     if (Model.Fields[i].Type == @TypeField.String)
                    {
                        if (Model.Item.StringElements.Count() > strings)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <span> ");
#nullable restore
#line 42 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
                              Write(Model.Item.StringElements[strings].Value);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>\r\n");
#nullable restore
#line 43 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
                            strings++;
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <span> field is not occupied </span>\r\n");
#nullable restore
#line 48 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
                     if (Model.Fields[i].Type == @TypeField.Markdown)
                    {
                        if (Model.Item.MarkdownElements.Count() > markdown)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <div class=\"container bg-light\">\r\n                                ");
#nullable restore
#line 55 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
                           Write(Html.Raw(Markdown.ToHtml(Model.Item.MarkdownElements[markdown].Value)));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            </div>\r\n");
#nullable restore
#line 57 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
                            markdown++;
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <span> field is not occupied </span>\r\n");
#nullable restore
#line 62 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
                     if (Model.Fields[i].Type == @TypeField.DateTime)
                    {
                        if (Model.Item.DateTimeElements.Count() > datetime)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <span> ");
#nullable restore
#line 68 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
                              Write(Model.Item.DateTimeElements[datetime].Value);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>\r\n");
#nullable restore
#line 69 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
                            datetime++;
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <span> field is not occupied </span>\r\n");
#nullable restore
#line 74 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
                     if (Model.Fields[i].Type == @TypeField.Checkbox)
                    {
                        if (Model.Item.CheckboxElements.Count() > checkbox)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <span> ");
#nullable restore
#line 80 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
                              Write(Model.Item.CheckboxElements[checkbox].Value);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>\r\n");
#nullable restore
#line 81 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
                            checkbox++;
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <span> field is not occupied </span>\r\n");
#nullable restore
#line 86 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </div>\r\n");
#nullable restore
#line 89 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
                WriteLiteral("    </div>\r\n    <input type=\"hidden\" name=\"collectionId\"");
                BeginWriteAttribute("value", " value=\"", 3661, "\"", 3688, 1);
#nullable restore
#line 92 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
WriteAttributeValue("", 3669, Model.CollectionId, 3669, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"itemId\"");
                BeginWriteAttribute("value", " value=\"", 3732, "\"", 3754, 1);
#nullable restore
#line 93 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
WriteAttributeValue("", 3740, Model.Item.Id, 3740, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"UserName\"");
                BeginWriteAttribute("value", " value=\"", 3800, "\"", 3827, 1);
#nullable restore
#line 94 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
WriteAttributeValue("", 3808, User.Identity.Name, 3808, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <div class=\"form-inline\">\r\n");
#nullable restore
#line 96 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
         if (Model.Item.Likes?.Where(x => x.UserName == User.Identity.Name).Count() == 0)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <button class=""btn"">
                <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-hand-thumbs-up"" viewBox=""0 0 16 16"">
                    <path d=""M8.864.046C7.908-.193 7.02.53 6.956 1.466c-.072 1.051-.23 2.016-.428 2.59-.125.36-.479 1.013-1.04 1.639-.557.623-1.282 1.178-2.131 1.41C2.685 7.288 2 7.87 2 8.72v4.001c0 .845.682 1.464 1.448 1.545 1.07.114 1.564.415 2.068.723l.048.03c.272.165.578.348.97.484.397.136.861.217 1.466.217h3.5c.937 0 1.599-.477 1.934-1.064a1.86 1.86 0 0 0 .254-.912c0-.152-.023-.312-.077-.464.201-.263.38-.578.488-.901.11-.33.172-.762.004-1.149.069-.13.12-.269.159-.403.077-.27.113-.568.113-.857 0-.288-.036-.585-.113-.856a2.144 2.144 0 0 0-.138-.362 1.9 1.9 0 0 0 .234-1.734c-.206-.592-.682-1.1-1.2-1.272-.847-.282-1.803-.276-2.516-.211a9.84 9.84 0 0 0-.443.05 9.365 9.365 0 0 0-.062-4.509A1.38 1.38 0 0 0 9.125.111L8.864.046zM11.5 14.721H8c-.51 0-.863-.069-1.14-.164-.281-.097-.506-.228-.776-.393l-.04-.024c-.555-.339-1.198-.731-2.");
                WriteLiteral(@"49-.868-.333-.036-.554-.29-.554-.55V8.72c0-.254.226-.543.62-.65 1.095-.3 1.977-.996 2.614-1.708.635-.71 1.064-1.475 1.238-1.978.243-.7.407-1.768.482-2.85.025-.362.36-.594.667-.518l.262.066c.16.04.258.143.288.255a8.34 8.34 0 0 1-.145 4.725.5.5 0 0 0 .595.644l.003-.001.014-.003.058-.014a8.908 8.908 0 0 1 1.036-.157c.663-.06 1.457-.054 2.11.164.175.058.45.3.57.65.107.308.087.67-.266 1.022l-.353.353.353.354c.043.043.105.141.154.315.048.167.075.37.075.581 0 .212-.027.414-.075.582-.05.174-.111.272-.154.315l-.353.353.353.354c.047.047.109.177.005.488a2.224 2.224 0 0 1-.505.805l-.353.353.353.354c.006.005.041.05.041.17a.866.866 0 0 1-.121.416c-.165.288-.503.56-1.066.56z"" />
                </svg>
            </button>
");
#nullable restore
#line 103 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <button class=""btn"">
                <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-hand-thumbs-up-fill"" viewBox=""0 0 16 16"">
                    <path d=""M6.956 1.745C7.021.81 7.908.087 8.864.325l.261.066c.463.116.874.456 1.012.965.22.816.533 2.511.062 4.51a9.84 9.84 0 0 1 .443-.051c.713-.065 1.669-.072 2.516.21.518.173.994.681 1.2 1.273.184.532.16 1.162-.234 1.733.058.119.103.242.138.363.077.27.113.567.113.856 0 .289-.036.586-.113.856-.039.135-.09.273-.16.404.169.387.107.819-.003 1.148a3.163 3.163 0 0 1-.488.901c.054.152.076.312.076.465 0 .305-.089.625-.253.912C13.1 15.522 12.437 16 11.5 16H8c-.605 0-1.07-.081-1.466-.218a4.82 4.82 0 0 1-.97-.484l-.048-.03c-.504-.307-.999-.609-2.068-.722C2.682 14.464 2 13.846 2 13V9c0-.85.685-1.432 1.357-1.615.849-.232 1.574-.787 2.132-1.41.56-.627.914-1.28 1.039-1.639.199-.575.356-1.539.428-2.59z"" />
                </svg>
            </button>
");
#nullable restore
#line 111 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <label");
                BeginWriteAttribute("class", " class=\"", 6731, "\"", 6739, 0);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 112 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
                   Write(Model.Item.Likes?.Count());

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb87c2fbbcd34d6737faa195723d01c75ed3457a24883", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"collectionId\"");
                BeginWriteAttribute("value", " value=\"", 6905, "\"", 6932, 1);
#nullable restore
#line 116 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
WriteAttributeValue("", 6913, Model.CollectionId, 6913, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"itemId\"");
                BeginWriteAttribute("value", " value=\"", 6976, "\"", 6998, 1);
#nullable restore
#line 117 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
WriteAttributeValue("", 6984, Model.Item.Id, 6984, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"UserName\"");
                BeginWriteAttribute("value", " value=\"", 7044, "\"", 7071, 1);
#nullable restore
#line 118 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
WriteAttributeValue("", 7052, User.Identity.Name, 7052, 19, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
    <div class=""container mt-3"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""card"">
                    <div class=""card-header"">
                        Комментарии
                    </div>
                    <div class=""card-body"">
                        <textarea class=""form-control"" placeholder=""Оставьте Ваш комментарий"" rows=""5"" name=""Comment""></textarea>
                        <button class=""btn btn-info float-right m-2"">Send</button>
                        <br />
                        <br />
                        <hr>
                        <ul>
");
#nullable restore
#line 133 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
                             foreach (var comment in Model.Item.Comments)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <li class=\"media\">\r\n                                    <div>\r\n                                        <div class=\"media-body\">\r\n                                            <strong class=\"text-success\">");
#nullable restore
#line 138 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
                                                                    Write(comment.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</strong>\r\n                                            <span class=\"text-muted\">\r\n                                                <small class=\"text-muted\">");
#nullable restore
#line 140 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
                                                                     Write(comment.Date);

#line default
#line hidden
#nullable disable
                WriteLiteral("</small>\r\n                                            </span>\r\n                                            <p>\r\n                                                ");
#nullable restore
#line 143 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
                                           Write(comment.Value);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                            </p>\r\n                                        </div>\r\n                                        <div></div>\r\n                                    </div>\r\n                                </li>\r\n");
#nullable restore
#line 149 "D:\RepositoryForGithub\Itransition\Project\AspNetCore5\ProjectForItransition\Views\Item\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </ul>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
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
