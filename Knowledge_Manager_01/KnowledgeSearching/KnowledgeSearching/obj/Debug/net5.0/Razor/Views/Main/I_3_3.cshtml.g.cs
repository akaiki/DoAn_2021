#pragma checksum "D:\DoAn_2021\Knowledge_Manager_01\KnowledgeSearching\KnowledgeSearching\Views\Main\I_3_3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86d27aaf75ab201765fe3cbe81ebe482a8a282c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_I_3_3), @"mvc.1.0.view", @"/Views/Main/I_3_3.cshtml")]
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
#line 1 "D:\DoAn_2021\Knowledge_Manager_01\KnowledgeSearching\KnowledgeSearching\Views\_ViewImports.cshtml"
using KnowledgeSearching;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DoAn_2021\Knowledge_Manager_01\KnowledgeSearching\KnowledgeSearching\Views\_ViewImports.cshtml"
using KnowledgeSearching.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86d27aaf75ab201765fe3cbe81ebe482a8a282c7", @"/Views/Main/I_3_3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55c93d07d287d648d202a547ac41ea2a162bac7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_I_3_3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Content/Image/omega_notation.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Omega Notation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: block; margin-left: auto; margin-right: auto;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\DoAn_2021\Knowledge_Manager_01\KnowledgeSearching\KnowledgeSearching\Views\Main\I_3_3.cshtml"
  
    ViewData["Title"] = "I_3_3";
    Layout = "~/Views/Main/Menu.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <h2>Omega Notation, &Omega; trong Cấu trúc dữ liệu và giải thuật</h2>
    <p>The &Omega;(n) là một cách để biểu diễn tiệm cận dưới của thời gian chạy của một giải thuật. Nó ước lượng độ phức tạp thời gian trường hợp tốt nhất hay chính là lượng thời gian ngắn nhất cần thiết bởi một giải thuật. Đồ thị biểu diễn như sau:</p>
    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "86d27aaf75ab201765fe3cbe81ebe482a8a282c74926", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <p>Ví dụ, với một hàm f(n):</p>
    <div class=""card"" style=""background-color: #cccccc"">
<pre class=""prettyprint notranslate card-body"">
&Omega;(<i>f</i>(n)) &ge; { <i>g</i>(n) : nếu tồn tại c &gt; 0 và n<sub>0</sub> sao cho <i>g</i>(n) &le; c.<i>f</i>(n) với mọi n &gt; n<sub>0</sub>. }
</pre>
        </div>

        <hr />
        <p>
            Bạn có thể tham khảo các mục sau:
        </p>
        <ul>
            <li><a href=""I_3""><b>Phân tích tiệm cận trong cấu trúc dữ liệu và giải thuật</b></a></li>
            <li><a href=""I_3_2""><b>Big Oh Notation, &Omicron; trong Cấu trúc dữ liệu và giải thuật</b></a></li>
            <li><a href=""I_3_4""><b>Theta Notation, &theta; trong Cấu trúc dữ liệu và giải thuật</b></a></li>
            <li><a href=""I_3_5""><b>Ví dụ độ phức tạp trong cấu trúc dữ liệu và giải thuật</b></a></li>
            <li><a href=""II""><b>Độ phức tạp của thuật toán</b></a></li>
        </ul>
    </div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
