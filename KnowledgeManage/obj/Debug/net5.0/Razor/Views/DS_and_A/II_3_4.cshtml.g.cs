#pragma checksum "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\II_3_4.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e642f1851a3b5e708ba85e3172cc84c9c4bd548"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DS_and_A_II_3_4), @"mvc.1.0.view", @"/Views/DS_and_A/II_3_4.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e642f1851a3b5e708ba85e3172cc84c9c4bd548", @"/Views/DS_and_A/II_3_4.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8b91396dfbb5c43e5379ee682f129446bb1c6c7", @"/Views/_ViewImports.cshtml")]
    public class Views_DS_and_A_II_3_4 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Image/Quick_sort.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Image/phan_doan.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\II_3_4.cshtml"
  
    ViewData["Title"] = "II_3_4";
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
    <div id=""II_3_4"">
        <h3>GIẢI THUẬT SẮP XẾP NHANH (QUICK SORT)</h3>
        <div id=""II_3_4_1"">
            <h5>Khái niệm giải thuật sắp xếp nhanh</h5>
            <p>Giải thuật sắp xếp nhanh (Quick Sort) là một giải thuật hiệu quả cao và dựa trên việc chia mảng dữa liệu thành các mảng nhỏ hơn. Giải thuật sắp xếp nhanh chia mảng thành hai phần bằng cách so sánh từng phần tử của mảng với một phần tử được chọn gọi là phần tử chốt (Pivot): một mảng bao gồm các phần tử nhỏ hơn hoặc bằng phần tử chốt và mảng còn lại bao gồm các phần tử lớn hơn hoặc bằng phần tử chốt. Tiến trình chia này diễn ra tiếp tục cho tới khi độ dài của các mảng con đều bằng 1.</p>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5e642f1851a3b5e708ba85e3172cc84c9c4bd5485099", async() => {
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
        <div id=""II_3_4_2"">
            <h5>Xây dựng giải thuật sắp xếp nhanh</h5>
            <p>Ý tưởng cho giải thuật sắp xếp nhanh được trình bày thành các bước như sau:</p>
            <div class=""card"" style=""background-color: #F1F1F1"">
                <p>Giả sử ta có mảng a có n phần tử</p>
                <ul>
                    <li><b>Bước 1: </b>Lấy phần tử chốt là phần tử ở cuối danh sách</li>
                    <li><b>Bước 2: </b>Chia mảng bởi sử dụng phần tử chốt</li>
                    <li><b>Bước 3: </b>Sử dụng sắp xếp nhanh một cách đệ quy với mảng con bên trái.</li>
                    <li><b>Bước 4: </b>Sử dụng sắp xếp nhanh một cách đệ quy với mảng con bên phải.</li>
                    <li><b>Bước 5: </b>Nếu left &ge; right, dừng đệ quy</li>
                </ul>
            </div><br />
            <p>Để xác định phần tử chốt</p>
            <div class=""card"" style=""background-color: #F1F1F1"">
                <ul>
                    <l");
            WriteLiteral(@"i><b>Bước 1: </b>Chọn phần tử chốt là phần tử có chỉ mục cao nhất (phần tử ở cuối danh sách)</li>
                    <li><b>Bước 2: </b>Khai báo hai biến để trỏ tới bên trái và bên phải của danh sách, ngoại trừ phần tử chốt</li>
                    <li><b>Bước 3: </b>Biến bên trái trỏ tới mảng con bên trái, biến bên phải trỏ tới mảng con bên phải.</li>
                    <li><b>Bước 4: </b>Khi giá trị tại biến bên trái là nhỏ hơn phần tử chốt thì di chuyển sang phải, khi giá trị tại biến bên phải là lớn hơn phần tử chốt thì di chuyển sang trái.</li>
                    <li><b>Bước 5: </b>Nếu không trong trường hợp cả <b>bước 5</b> và <b>bước 6</b> thì tráo đổi giá trị biến trái và phải.</li>
                    <li><b>Bước 6: </b>Nếu left &ge; right, thì đây chính là giá trị chốt mới</li>
                </ul>
            </div><br />
            <p>Quá trình phân đoan trong thuật toán quick sort:</p>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5e642f1851a3b5e708ba85e3172cc84c9c4bd5488130", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <hr />
            <p>Giải thuật mẫu cho sắp xếp nhanh</p>
            <div class=""card"" style=""background-color: #F1F1F1"">
<pre style=""padding: 1em; margin: .5em 0; overflow: auto;"" class=""card-body"">
<code>
Bắt đầu hàm quickSort(left, right)

    <span style=""color: #008"">if</span> right-left <= 0
        return
    <span style=""color: #008"">else</span>     
        pivot = A[right]
        partition = partitionFunc(left, right, pivot)
        quickSort(left,partition-1)
        quickSort(partition+1,right)    
    kết thúc if		

Kết thúc hàm
</code> </pre>
            </div><br />
            <hr />
            <p><b>Ví dụ: </b>Thủ tục sắp xếp nhanh trên một mảng các số nguyên được viết bằng C như sau:</p>
            <div class=""card"" style=""background-color: #F1F1F1"">
<pre style=""padding: 1em; margin: .5em 0; overflow: auto;"" class=""card-body"">
<code>
int partition (int a[], int low, int high)
{
    int pivot = a[high];    // pivot
    int left = low;
    int rig");
            WriteLiteral(@"ht = high - 1;
    while(true){
        while(left <= right && a[left] < pivot) left++; // Tìm phần tử >= arr[pivot]
        while(right >= left && a[right] > pivot) right--; // Tìm phần tử <= arr[pivot]
        if (left >= right) break; // Đã duyệt xong thì thoát vòng lặp
        int t = a[left];
        a[left] = a[right];
        a[right] = t;
        left++; // Vì left hiện tại đã xét, nên cần tăng
        right--; // Vì right hiện tại đã xét, nên cần giảm
    }
    int t = a[left];
        a[left] = a[high];
        a[high] = t;
    return left; // Trả về chỉ số sẽ dùng để chia đổi mảng
}

void quickSort(int a[], int low, int high)
{
    if (low < high)
    {
        int");
            BeginWriteAttribute("pi", " pi =", 4796, "", 4801, 0);
            EndWriteAttribute();
            WriteLiteral(@" partition(a, low, high);
        quickSort(a, low, pi - 1);
        quickSort(a, pi + 1, high);
    }
}
</code> </pre>
            </div><br />
            <p>Giải thuật sắp xếp nhanh tỏ ra khá hiệu quả với các tập dữ liệu lớn khi mà độ phức tạp trường hợp trung bình và trường hợp xấu nhất là O(nlogn) với n là số phần tử.</p>
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