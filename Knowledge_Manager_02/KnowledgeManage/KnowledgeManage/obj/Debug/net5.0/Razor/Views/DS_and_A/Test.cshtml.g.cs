#pragma checksum "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43e9d3d89d932081711baab5aaa8f66db1b66cdd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DS_and_A_Test), @"mvc.1.0.view", @"/Views/DS_and_A/Test.cshtml")]
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
#line 1 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\_ViewImports.cshtml"
using KnowledgeManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\_ViewImports.cshtml"
using KnowledgeManage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43e9d3d89d932081711baab5aaa8f66db1b66cdd", @"/Views/DS_and_A/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8b91396dfbb5c43e5379ee682f129446bb1c6c7", @"/Views/_ViewImports.cshtml")]
    public class Views_DS_and_A_Test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KnowledgeManage.Models.Lesson>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Test.cshtml"
  
    ViewData["Title"] = "Test";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    ul {\r\n        list-style-type: none;\r\n        font-size: 14px;\r\n    }\r\n</style>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "43e9d3d89d932081711baab5aaa8f66db1b66cdd3943", async() => {
                WriteLiteral(@"
    <div class=""form-group"">
        <label for=""searchString"" class=""control-label""></label>
        <input name=""searchString"" class=""form-control"" />
    </div>
    <div class=""form-group"">
        <input type=""submit"" value=""Search"" class=""btn btn-primary col-5"" /><br />
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<div >\r\n");
#nullable restore
#line 24 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Test.cshtml"
     if (Model.Count() == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Khong co kq</p>\r\n");
#nullable restore
#line 27 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Test.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n   \r\n");
#nullable restore
#line 30 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Test.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul>\r\n");
#nullable restore
#line 33 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Test.cshtml"
             if (@item.Id_PreLesson == "")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\r\n                    ");
#nullable restore
#line 36 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Test.cshtml"
               Write(item.Name_Lesson);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Test.cshtml"
                     foreach (var item_childe in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <ul>\r\n");
#nullable restore
#line 40 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Test.cshtml"
                             if (item_childe.Id_PreLesson == item.Id_Lesson)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\r\n                                    ");
#nullable restore
#line 43 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Test.cshtml"
                               Write(item_childe.Name_Lesson);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 44 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Test.cshtml"
                                     foreach (var item_grandchilde in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <ul>\r\n");
#nullable restore
#line 47 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Test.cshtml"
                                             if (item_grandchilde.Id_PreLesson == item_childe.Id_Lesson)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li>\r\n                                                    ");
#nullable restore
#line 50 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Test.cshtml"
                                               Write(item_grandchilde.Name_Lesson);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 51 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Test.cshtml"
                                                     foreach (var item_ggchilde in Model)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <ul>\r\n");
#nullable restore
#line 54 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Test.cshtml"
                                                             if (item_ggchilde.Id_PreLesson == item_grandchilde.Id_Lesson)
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                                <li>\r\n                                                                    ");
#nullable restore
#line 57 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Test.cshtml"
                                                               Write(item_ggchilde.Name_Lesson);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                                </li>\r\n");
#nullable restore
#line 59 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Test.cshtml"
                                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </ul>\r\n");
#nullable restore
#line 62 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Test.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                </li>\r\n");
#nullable restore
#line 64 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Test.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </ul>\r\n");
#nullable restore
#line 67 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Test.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </li>\r\n");
#nullable restore
#line 69 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Test.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </ul>\r\n");
#nullable restore
#line 72 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Test.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </li>\r\n");
#nullable restore
#line 74 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Test.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n");
#nullable restore
#line 77 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Test.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KnowledgeManage.Models.Lesson>> Html { get; private set; }
    }
}
#pragma warning restore 1591