#pragma checksum "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\II_2_3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81341f16243d70394794370d6a53d6e82eb11347"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DS_and_A_II_2_3), @"mvc.1.0.view", @"/Views/DS_and_A/II_2_3.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81341f16243d70394794370d6a53d6e82eb11347", @"/Views/DS_and_A/II_2_3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8b91396dfbb5c43e5379ee682f129446bb1c6c7", @"/Views/_ViewImports.cshtml")]
    public class Views_DS_and_A_II_2_3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Image/interpolation_search.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\II_2_3.cshtml"
  
    ViewData["Title"] = "II_2_3";
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
    <div id=""II_2_3"">
        <h3>GIẢI THUẬT TÌM KIẾM NỘI SUY</h3>
        <div id=""II_2_3_1"">
            <h5>Khái niệm giải thuật tìm kiếm nội suy</h5>
            <p>Tìm kiếm nội suy (Interpolation Search) là một sự cải tiến của <a href=""II_2_2"">tìm kiếm nhị phân</a>. Nó có xu hướng tiến gần đến vị trí, giá trị tìm kiếm. Do đó tốc độ tìm kiếm được tối ưu rất cao và nhanh hơn nhiều so với <a href=""II_2_2"">tìm kiếm nhị phân</a>.</p>
            <p>Cách thức hoạt động dựa trên <a href=""II_2_2"">tìm kiếm nhị phân</a>, nhưng có sự cải tiến hơn ở chỗ tìm ra phần tử gần với giá trị tìm kiếm nhất và bắt đầu từ đó để tìm.</p>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "81341f16243d70394794370d6a53d6e82eb113474715", async() => {
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
        <div id=""II_2_3_2"">
            <h5>Xây dựng giải thuật tìm kiếm nội suy</h5>
            <p>Ý tưởng cho giải thuật tìm kiếm nội suy được trình bày thành các bước như sau:</p>
            <div class=""card"" style=""background-color: #F1F1F1"">
                <p>Giả sử ta có mảng A và giá trị x cần tìm, left và right là hai vị trí đầu và cuối</p>
                <ul>
                    <li>
                        <b>Bước 1: </b>Tìm phần tử chính giữa của tập hợp bằng công thức được cải tiến:
                        <p><code>k = left + (x - a[left])*(right - left) / (a[right] - a[left])</code></p>
                    </li>
                    <li><b>Bước 2: </b>Nếu left > right thì thoát, không tìm thấy x.</li>
                    <li><b>Bước 3: </b>Nếu a[k] == x thì k là vị trí cần tìm. Nếu không, tiếp tục <b>bước 3</b></li>
                    <li><b>Bước 4: </b>Nếu a[k] < x thì");
            BeginWriteAttribute("left", " left =", 1984, "", 1991, 0);
            EndWriteAttribute();
            WriteLiteral(@" left + 1. Tiếp tục <b>bước 1</b>.</li>
                    <li><b>Bước 5: </b>Nếu a[k] > x thì right = right - 1. Tiếp tục <b>bước 1</b>.</li>
                    
                </ul>
            </div><br />
            <hr />
            <p>Giải thuật mẫu cho tìm kiếm nội suy</p>
            <div class=""card"" style=""background-color: #F1F1F1"">
<pre style=""padding: 1em; margin: .5em 0; overflow: auto;"" class=""card-body"">
<code>
a → Mảng
n → Kích cỡ của a
x → Giá trị cần tìm
Hàm tìm kiếm nội suy Interpolation_Search()
    Gán left  →  0
    Gán k → -1
    Gán right  →  n-1
    <span>while</span> X không khớp
        <span>if</span> left == right OR a[left] bằng a[right]
            EXIT: Thất bại, không tìm thấy x
        kết thúc if
        Gán k = left + ((right - left) / (a[right] - a[left])) * (x - a[left]) 
        <span>if</span> a[k] = x
            EXIT: Thành công, tìm thấy tại k
        <span>else</span> 
            <span>if</span> a[k] < x
                Thiết lập lef");
            WriteLiteral(@"t thành k+1
            <span>else if</span> a[k] > x
                Thiết lập right thành k-1
            kết thúc if
        kết thúc if
    Kết thúc While
Kết thúc hàm
</code> </pre>
            </div><br />
            <hr />
            <p><b>Ví dụ: </b>Thủ tục tìm kiếm nội suy trên một mảng các số nguyên được viết bằng C như sau:</p>
            <div class=""card"" style=""background-color: #F1F1F1"">
<pre style=""padding: 1em; margin: .5em 0; overflow: auto;"" class=""card-body"">
<code>
int InterPolationSearch(int *a, int n, int x)
{
    int left = 0;
    int right = n-1;
    while (left <= right && x >= a[left] && x <= a[right]){
        double val1 = (double) (x - a[left]) / (a[right]-a[left]);
        int val2 = (right-left);
        int k = left + val1*val2;
    if (a[k] == x)
        return k;
    if (a[k] < x)");
            BeginWriteAttribute("left", "\r\n        left =", 3867, "", 3883, 0);
            EndWriteAttribute();
            WriteLiteral(" k + 1;\r\n    else");
            BeginWriteAttribute("right", "\r\n        right =", 3900, "", 3917, 0);
            EndWriteAttribute();
            WriteLiteral(@" k - 1;
    }
    return -1;
}
</code> </pre>
            </div><br />
            <p>Về cơ bản tìm kiếm nội suy là một kỹ thuật đạt được tốc độ rất cao và nhanh, nhưng chỉ nên dùng cho những trường hợp phù hợp.</p>
            <p>Ví dụ với những tập có số lượng phần từ nhỏ, đối tượng phần tử đơn giản thì ko cần thiết phải sử dụng tìm kiếm nội suy. Mà chỉ nên dùng tìm kiếm nội suy cho những tập có số lượng phần tử lớn, đối tượng phần tử phức tạp, mất nhiều thời gian xử lý.</p>
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
