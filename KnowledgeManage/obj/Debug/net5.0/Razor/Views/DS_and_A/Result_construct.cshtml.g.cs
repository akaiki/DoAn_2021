#pragma checksum "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Result_construct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1379045e83a8b1080cb440d03a3f029296fd43f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DS_and_A_Result_construct), @"mvc.1.0.view", @"/Views/DS_and_A/Result_construct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1379045e83a8b1080cb440d03a3f029296fd43f6", @"/Views/DS_and_A/Result_construct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8b91396dfbb5c43e5379ee682f129446bb1c6c7", @"/Views/_ViewImports.cshtml")]
    public class Views_DS_and_A_Result_construct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<KnowledgeManage.Models.Construct>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DS_and_A", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Search", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Result_construct.cshtml"
  
    ViewData["Title"] = "Result_construct";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div style=""height: 100vh; background-color: #F5F5F5; overflow-y: auto; overflow-x:hidden; font-size: 16px; padding-left: 15%; padding-right: 15%; text-indent: 5%;"" class="" flex-fill"">
    <h1 class=""bg-light"">CÁC BIỂU DIỄN/ KHỞI TẠO CHO TỪ KHÓA ""<span class=""text-success"">");
#nullable restore
#line 8 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Result_construct.cshtml"
                                                                                    Write(ViewData["ss"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\"</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Result_construct.cshtml"
     if (Model.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-hover"">
            <thead style=""position: sticky;top: 0"" class=""thead-light"">
                <tr>
                    <th>
                        <p>Tên kiến thức</p>
                    </th>

                    <th></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 23 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Result_construct.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 27 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Result_construct.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Name_Construct));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 1126, "\"", 1153, 1);
#nullable restore
#line 30 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Result_construct.cshtml"
WriteAttributeValue("", 1133, item.Link_Construct, 1133, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 33 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Result_construct.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n");
            WriteLiteral("        <div>\r\n            <br />\r\n            <br />\r\n            <br />\r\n            <br />\r\n            <br />\r\n            <br />\r\n        </div>\r\n");
#nullable restore
#line 45 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Result_construct.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <br />\r\n        <br />\r\n        <p style=\"text-align:center\">\r\n            <b>KHÔNG THẤY KẾT QUẢ TÌM KIẾM CHO \"<span class=\"text-danger\">");
#nullable restore
#line 52 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Result_construct.cshtml"
                                                                     Write(ViewData["ss"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\"!!!!</b>\r\n        </p>\r\n");
#nullable restore
#line 54 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\Result_construct.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1379045e83a8b1080cb440d03a3f029296fd43f67996", async() => {
                WriteLiteral("Trở về trang tìm kiếm");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<KnowledgeManage.Models.Construct>> Html { get; private set; }
    }
}
#pragma warning restore 1591
