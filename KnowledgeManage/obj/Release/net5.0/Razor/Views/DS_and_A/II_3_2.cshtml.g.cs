#pragma checksum "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\II_3_2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6baecaeb07e5d02de018f718ad414bca57d1b056"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DS_and_A_II_3_2), @"mvc.1.0.view", @"/Views/DS_and_A/II_3_2.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6baecaeb07e5d02de018f718ad414bca57d1b056", @"/Views/DS_and_A/II_3_2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8b91396dfbb5c43e5379ee682f129446bb1c6c7", @"/Views/_ViewImports.cshtml")]
    public class Views_DS_and_A_II_3_2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Image/insertion_sort.gif"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\II_3_2.cshtml"
  
    ViewData["Title"] = "II_3_2";
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
    <div id=""II_3_2"">
        <h3>GIẢI THUẬT SẮP XẾP CHÈN (INSERTION SORT)</h3>
        <div id=""II_3_2_1"">
            <h5>Khái niệm giải thuật sắp xếp chèn</h5>
            <p>Sắp xếp chèn là một giải thuật sắp xếp dựa trên so sánh in-place. Ở đây, một danh sách con luôn luôn được duy trì dưới dạng đã qua sắp xếp. Sắp xếp chèn là chèn thêm một phần tử vào danh sách con đã qua sắp xếp. Phần tử được chèn vào vị trí thích hợp sao cho vẫn đảm bảo rằng danh sách con đó vẫn sắp theo thứ tự.</p>
            <p>Với cấu trúc dữ liệu mảng, chúng ta tưởng tượng là: mảng gồm hai phần: một danh sách con đã được sắp xếp và phần khác là các phần tử không có thứ tự. Giải thuật sắp xếp chèn sẽ thực hiện việc tìm kiếm liên tiếp qua mảng đó, và các phần tử không có ");
            WriteLiteral("thứ tự sẽ được di chuyển và được chèn vào vị trí thích hợp trong danh sách con (của cùng mảng đó).</p>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "6baecaeb07e5d02de018f718ad414bca57d1b0564973", async() => {
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
        <div id=""II_3_2_2"">
            <h5>Xây dựng giải thuật sắp xếp chèn</h5>
            <p>Ý tưởng cho giải thuật sắp xếp chèn được trình bày thành các bước như sau:</p>
            <div class=""card"" style=""background-color: #F1F1F1"">
                <p>Giả sử ta có mảng a có n phần tử</p>
                <ul>
                    <li><b>Bước 1: </b>Kiểm tra nếu phần tử đầu tiên đã được sắp xếp. Trả về 1</li>
                    <li><b>Bước 2: </b>Lấy phần tử kế tiếp</li>
                    <li><b>Bước 3: </b>So sánh với tất cả phần tử trong danh sách con đã qua sắp xếp</li>
                    <li><b>Bước 4: </b>Dịch chuyển tất cả phần tử trong danh sách con mà lớn hơn giá trị để được sắp xếp.</li>
                    <li><b>Bước 5: </b>Chèn giá trị đó</li>
                    <li><b>Bước 6: </b>Lặp lại cho tới khi danh sách được sắp xếp</li>
                </ul>
            </div><br />
            <hr />
            <p>Giải thuật mẫu cho sắp xếp chèn<");
            WriteLiteral(@"/p>
            <div class=""card"" style=""background-color: #F1F1F1"">
<pre style=""padding: 1em; margin: .5em 0; overflow: auto;"" class=""card-body"">
<code>
Bắt đầu hàm insertionSort( A : mảng phần tử )
    int holePosition
    int valueToInsert
	
    <span style=""color: #008"">for</span> i = 1 tới length(A) thực hiện:
	
        /* chọn một giá trị để chèn */
        valueToInsert = A[i]
        holePosition = i
      
        /*xác định vị trí cho phần tử được chèn */
		
        <span style=""color: #008"">while</span> holePosition > 0 và A[holePosition-1] > valueToInsert thực hiện:
            A[holePosition] = A[holePosition-1]
            holePosition = holePosition -1
        kết thúc while
		
        /* chèn giá trị tại vị trí trên */
        A[holePosition] = valueToInsert
      
    kết thúc for
Kết thúc hàm
</code> </pre>
            </div><br />
            <hr />
            <p><b>Ví dụ: </b>Thủ tục sắp xếp chèn trên một mảng các số nguyên được viết bằng C như sau:</p>
     ");
            WriteLiteral("       <div class=\"card\" style=\"background-color: #F1F1F1\">\r\n<pre style=\"padding: 1em; margin: .5em 0; overflow: auto;\" class=\"card-body\">\r\n<code>\r\nvoid insertionSort(int a[], int n)\r\n{\r\n\tfor (int i = 1; i < n; i++)\r\n\t{\r\n\t\tint");
            BeginWriteAttribute("x", " x =", 3544, "", 3548, 0);
            EndWriteAttribute();
            WriteLiteral(" a[i];\r\n\t\tint");
            BeginWriteAttribute("j", " j =", 3561, "", 3565, 0);
            EndWriteAttribute();
            WriteLiteral(@" i;
		while (j > 0 && a[j - 1] > x)
		{
			a[j] = a[j - 1];
			j--;
		}
		a[j] = x;
	}
}
</code> </pre>
            </div><br />
            <p>Trong trường hợp tốt nhất thuật toán sữ dụng n - 1 phép so sánh và 0 lần hoán vị. Trung bình thuật toán sử dụng n<sup>2</sup>/4 phép so sánh và n<sup>2</sup>/4 lần hoán vị. Trong trường hợp xấu nhất thuật toán sử dụng n<sup>2</sup>/2 phép so sánh và n<sup>2</sup>/2 lần hoán vị.</p>  
            <p>Giải thuật này không thích hợp sử dụng với các tập dữ liệu lớn khi độ phức tạp trường hợp xấu nhất và trường hợp trung bình là Ο(n<sup>2</sup>) với n là số phần tử.</p>
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
