#pragma checksum "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\I_7_3_1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9ac95502edb02a80cb1cdd8a2828e7f85de4f98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DS_and_A_I_7_3_1), @"mvc.1.0.view", @"/Views/DS_and_A/I_7_3_1.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9ac95502edb02a80cb1cdd8a2828e7f85de4f98", @"/Views/DS_and_A/I_7_3_1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8b91396dfbb5c43e5379ee682f129446bb1c6c7", @"/Views/_ViewImports.cshtml")]
    public class Views_DS_and_A_I_7_3_1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Image/DoThiCoHuong.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("zoom"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-align:center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Image/DFS.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\I_7_3_1.cshtml"
  
    ViewData["Title"] = "I_7_3_1";
    Layout = "~/Views/DS_and_A/Menu.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    .zoom {
        /*padding: 50px;*/
        background-color: green;
        transition: transform .2s; /* Animation */
        margin: 0 auto;
    }

        .zoom:hover {
            transform: scale(1.3); /* (130% zoom - Note: if the zoom is too large, it will go outside of the viewport) */
        }

    img {
        display: inline-block;
        max-width: 100%;
        max-height: 100%;
        display: block;
        margin: 0 inherit;
    }
</style>
<div style=""padding-left: 15%; padding-right: 15%; "">
    <h1>DUYỆT ĐỒ THỊ - DUYỆT THEO CHIỀU SÂU (DEPTH FIRST SEARCH)</h1>
    <div class=""container"" id=""I_7_3_1_a"">
        <h3>Khái niệm duyệt theo chiều sâu</h3>
        <p>Quá trình duyệt theo chiều sâu bắt đầu từ một đỉnh nào đó của đồ thị, sau khi thăm đỉnh này, quá trình duyệt theo chều sâu được lặp lại với tất cả các đỉnh kể của nó. Tuy nhiên, đồ thị có thể tồn tại các chu trình, do vậy, ta cần phải đánh dấu các đỉnh đã duyệt để tránh duyệt lại đỉnh này một lần n");
            WriteLiteral(@"ữa.</p>
        <p>Với trình duyệt như trên, quá trình duyệt sẽ duyệt hết một ""nhánh"" của đồ thị rồi mới sang ""nhánh"" khác. Do vậy, phương pháp duyệt này được gọi là <b>duyệt theo chiều sâu</b></p>
    </div>
    <hr />
    <div class=""container"" id=""I_7_3_1_b"">
        <h3>Các bước duyệt theo chiều sâu</h3>
        <p>Ví dụ ta có đồ thị sau:</p>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f9ac95502edb02a80cb1cdd8a2828e7f85de4f986287", async() => {
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
        <br />
        <p>Quá trình duyệt theo chiều sâu bắt đầu tử đỉnh a sẽ có thứ tự duyệt như sau:</p>
        <ul>
            <li><p>- Sau khi thăm đỉnh a, tiến hành thăm đỉnh kề với a là b. Tiếp đến thăm đỉnh kề b là d. Đỉnh d không hề có đỉnh kề nào, do vậy quay lại bước trước</p></li>
            <li><p>- Đỉnh b chỉ có 1 đỉnh kề là d đã thăm, do vậy quay trở lại bước trước.</p></li>
            <li><p>- Đỉnh a còn đỉnh kề c là chưa thăm, do vậy thăm đỉnh c.</p></li>
        </ul>
        <p>Như vậy, thứ tự các đỉnh trong quá trình duyệt là a, b, d, c</p>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f9ac95502edb02a80cb1cdd8a2828e7f85de4f988068", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
        <br />
        <p>Quá trình duyệt sẽ chỉ duyệt theo các cạnh dẫn tới các đỉnh chưa thăm. Các cạnh dẫn tới các đỉnh đãn thăm sẽ được bỏ qua. Chẳng hạn, trong quá trình duyệt đồ thị trên, khi duyệt đến đỉnh c, cạnh nối tới b sẽ được bỏ qua vì đỉnh c đã được thăm rồi.</p>
        <p><b>Cài đặt phương pháp duyệt theo chiều sâu như sau:</b></p>
        <p>Để kiểm tra việc duyệt mỗi đỉnh đúng 1 lần, chúng ta sử dụng một mảng daxet (đã xét) gồm n phần tử (tương ứng với n đỉnh). Nếu đỉnh thứ i đã được duyệt, daxet[i] = 1, ngược lại, daxet[i] = 0. Thuật toán tìm kiếm theo chiều sâu bắt đầu từ đỉnh v nào đó sẽ duyệt tất cả các đỉnh liên thông với v. Thuật toán có thể được mô tả bằng thủ tục đệ quy DeepFirstSearch.</p>
        <div class=""card"" style=""background-color: #F1F1F1"">
<pre style=""padding: 1em; margin: .5em 0; overflow: auto;"" class=""card-body"">
            <code>
    void DeepFirstSearch (int v)
        Thăm đỉnh v;
        daxet[v] = 1;
        for mỗi đỉnh u kề với v {
            if (d");
            WriteLiteral(@"axet[u] == 0)
                DeepFirstSearch(u);
        }
    }
    </code> </pre>
        </div><br />
        <p>Thủ tục DeepFirstSearch sẽ thăm tất cả cá đỉnh cùng thành phần liên thông với v mỗi đỉnh đúng 1 lần. Để đảm bảo duyệt tất cả các đỉnh của đồ thị (có thể có nhiều thanh phần liên thông), chúng ta cần thực hiện:</p>
        <div class=""card"" style=""background-color: #F1F1F1"">
<pre style=""padding: 1em; margin: .5em 0; overflow: auto;"" class=""card-body"">
            <code>
        for (i = 1; i<=n; i++){
            daxet[i] = 0;
        }
        for (i = 1; i<=n; i++){
            if(daxet[u] == 0)
                DeepFirstSearch(i);
        }
    </code> </pre>
        </div><br />
    </div>

</div>
<div>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</div>");
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
