#pragma checksum "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\II_2_2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1773b13910e87f90523e9d867b1992e4b9a228d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DS_and_A_II_2_2), @"mvc.1.0.view", @"/Views/DS_and_A/II_2_2.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c1773b13910e87f90523e9d867b1992e4b9a228d", @"/Views/DS_and_A/II_2_2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8b91396dfbb5c43e5379ee682f129446bb1c6c7", @"/Views/_ViewImports.cshtml")]
    public class Views_DS_and_A_II_2_2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Image/binary_search.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\II_2_2.cshtml"
  
    ViewData["Title"] = "II_2_2";
    Layout = "~/Views/DS_and_A/Menu.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<style>
    img {
        display: inline-block;
        max-width: 100%;
        max-height: 100%;
        display: block;
        margin: 0 auto;
        text-align: center;
    }
</style>
<div style=""padding-left: 15%; padding-right: 15%; "">
    <div id=""II_2_2"">
        <h3>GI???I THU???T T??M KI???M NH??? PH??N</h3>
        <div id=""II_2_2_1"">
            <h5>Kh??i ni???m gi???i thu???t t??m ki???m tuy???n t??nh</h5>
            <p>T??m ki???m nh??? ph??n (Binary Search) l??m vi???c d???a tr??n nguy??n t???c <a href=""II_5"">chia ????? tr??? (Divide and Conquer)</a>. ????? gi???i thu???t n??y c?? th??? l??m vi???c m???t c??ch ch??nh x??c th?? t???p d??? li???u n??n ??? trong d???ng ???? ???????c s???p x???p.</p>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c1773b13910e87f90523e9d867b1992e4b9a228d4472", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>
        <hr />
        <div id=""II_2_2_2"">
            <h5>X??y d???ng gi???i thu???t t??m ki???m nh??? ph??n</h5>
            <div class=""card"" style=""background-color: #F1F1F1"">
                <p>Gi??? s??? ta c?? m???ng a c?? n ph???n t??? v?? gi?? tr??? x c???n t??m, left v?? right l?? hai v??? tr?? ?????u v?? cu???i.</p>
                <ul>
                    <li><b>B?????c 1: </b>S???p x???p a theo th??? t??? t??ng d???n</li>
                    <li><b>B?????c 2: </b>G??n left = 0  v?? right = n-1</li>
                    <li><b>B?????c 3: </b>N???u left > right, k???t th??c, tr??? v??? v??? tr?? hi???n t???i</li>
                    <li><b>B?????c 4: </b>G??n k (v??? tr?? ph???n t??? ?????ng gi???a) b???ng (left + right)/2. k l?? s??? nguy??n</li>
                    <li><b>B?????c 5: </b>N???u x > a[k], g??n left v???i k + 1, quay l???i <b>b?????c 2</b></li>
                    <li><b>B?????c 6: </b>N???u x < a[k], gnas right v???i k - 1, quay l???i <b>b?????c 2</b></li>
                    <li><b>B?????c 7: </b>Khi a[k] == x, qu?? tr??nh t??m ki???m ho??n t???t, tr??? v??? m.</li>
                    <li><b");
            WriteLiteral(@">B?????c 8: </b>Tho??t</li>
                </ul>
            </div> <br />
            <p>Trong th??? t???c n??y x l?? gi?? tr??? c???n t??m trong d??y a. Hai bi???n left v?? right d??ng ????? gi???i h???n ph??n ??o???n c???a m???ng m?? qu?? tr??nh t??m ki???m s??? ???????c th???c hi???n trong m???i b?????c. ?????u ti??n 2 bi???n n??y ???????c g??n gi?? tr??? 0 v?? n - 1, t???c l?? to??n b??? m???ng s??? ???????c t??m ki???m.</p>
            <p>T???i m???i b?????c, bi???n k s??? ???????c g??n cho ch??? s??? gi???a c???a ??o???n ??ang ???????c ti???n h??nh t??m ki???m. N???u gi?? tr??? x nh??? h??n gi?? tr??? ph???n t??? t???i k, bi???n right s??? ???????c g??n b???ng k-1, cho bi???t qu?? tr??nh t??m t???i b?????c sau s??? ???????c th???c hi???n trong n???aa ?????u c???a ??o???n. Ng?????c l???i, gi?? tr??? left ???????c g??n b???ng k+1, cho bi???t qu?? tr??nh t??m t???i b?????c sau s??? ???????c th???c hi???n trong n???a sau c???a ??o???n</p>
            <hr />
            <p>Gi???i thu???t m???u cho t??m ki???m nh??? ph??n</p>
            <div class=""card"" style=""background-color: #F1F1F1"">
<pre style=""padding: 1em; margin: .5em 0; overflow: auto;"" class=""card-body"">
                <code>
Gi???i thu???t t??m ki???m nh??? ph??n (Binary Search)");
            WriteLiteral(@"
    A ??? m???t m???ng ???? ???????c s???p x???p
    n ??? k??ch c??? m???ng
    x ??? gi?? tr??? ????? t??m ki???m trong m???ng
    g??n left = 0
    g??n right = n - 1
    <span style=""color: #008"">while</span> x not found
        <span style=""color: #008"">if</span> right < left
            EXIT: x kh??ng t???n t???i.
        g??n");
            BeginWriteAttribute("midPoint", " midPoint =", 3148, "", 3159, 0);
            EndWriteAttribute();
            WriteLiteral(" ( left + right ) / 2\r\n        <span style=\"color: #008\">if</span> A[midPoint] < x\r\n            g??n");
            BeginWriteAttribute("left", " left =", 3258, "", 3265, 0);
            EndWriteAttribute();
            WriteLiteral(@" midPoint + 1
        <span style=""color: #008"">if</span> A[midPoint] > x
            g??n right = midPoint - 1
        <span style=""color: #008"">if</span> A[midPoint] = x
            EXIT: x ???????c t??m th???y t???i midPoint
    k???t th??c while
k???t th??c gi???i thu???t
    </code> </pre>
            </div><br />
            <hr />
            <p><b>V?? d???: </b>Cho m???ng a ???? ???????c s???p x???p v?? gi?? tr??? c???n t??m x. H??m t??m ki???m nh??? ph??n ???????c c??i ?????t b???ng C nh?? sau:</p>
            <div class=""card"" style=""background-color: #F1F1F1"">
<pre style=""padding: 1em; margin: .5em 0; overflow: auto;"" class=""card-body"">
<code>
int binary_search (int *a, int x, int n){
    int k, left = 0, right = n -1;
    do {
        k = (left + right)/2;
        if (x < a[k])");
            BeginWriteAttribute("right", "\r\n            right =", 4023, "", 4044, 0);
            EndWriteAttribute();
            WriteLiteral(" k - 1;\r\n        else");
            BeginWriteAttribute("left", "\r\n            left =", 4065, "", 4085, 0);
            EndWriteAttribute();
            WriteLiteral(" k + 1;\r\n    } while ((x");
            BeginWriteAttribute("!", " !=", 4109, "", 4112, 0);
            EndWriteAttribute();
            WriteLiteral(@" a[k]) && (left <= right));
    if (x == a[k])
        return k;
    else
        return (-1);
}
</code> </pre>
            </div><br />
            <p>Thu???t to??n t??m ki???m nh??? ph??n c?? th???i gian th???c hi???n l?? lg(n). Tuy nhi??n, thu???t to??n ????i h???i d??y ???? ???????c s???p x???p tr?????c khi ti???n h??nh t??m ki???m. Do v???y, n??n ??p d???ng t??m ki???m nh??? ph??n khi vi???c t??m ki???m ph???i th???c hi???n nhi???u l???n tr??n m???t t???p ph???n t??? cho tr?????c. Khi ????, ta ch??? c???n ti???n h??nh s???p t???p ph???n t??? m???t l???n v?? th???c hi???n t??m ki???m nhi???u l???n tr??n t???p ph???n t??? ???? s???p n??y.</p>
        </div>
    </div>
    <div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </div>
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
