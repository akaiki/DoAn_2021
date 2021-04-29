#pragma checksum "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\I_2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "490312c2b7fbddd53617a19d86bf56f3f017020b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DS_and_A_I_2), @"mvc.1.0.view", @"/Views/DS_and_A/I_2.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"490312c2b7fbddd53617a19d86bf56f3f017020b", @"/Views/DS_and_A/I_2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8b91396dfbb5c43e5379ee682f129446bb1c6c7", @"/Views/_ViewImports.cshtml")]
    public class Views_DS_and_A_I_2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Image/array_declaration.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Khai báo mảng trong C"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Image/array_representation.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Minh họa chỉ mục"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\I_2.cshtml"
  
    ViewData["Title"] = "I_2";
    Layout = "~/Views/DS_and_A/Menu.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div");
            BeginWriteAttribute("class", " class=\"", 95, "\"", 103, 0);
            EndWriteAttribute();
            WriteLiteral(@">

    <h1>Cấu trúc dữ liệu mảng</h1>
    <div class=""container"" id=""I_2_1"">
        <h3>Cấu trúc dữ liệu mảng là gì?</h3>
        <div class=""container"">
            <p>Mảng (Array) là một trong các cấu trúc dữ liệu quan trọng nhất. Mảng có thể lưu giữ một số phần tử cố định và các phần tử này nền có cùng kiểu. Hầu hết các cấu trúc dữ liệu đều sử dụng mảng để triển khai giải thuật. Dưới đây là các khái niệm quan trọng liên quan tới Mảng:</p>
            <ul>
                <li><b>Phần tử:</b> Mỗi mục được lưu trữ trong một mảng được gọi là một phần tử</li>
                <li><b>Chỉ mục:</b> Mỗi vị trí của một phần tử trong một mảng có một số chỉ mục số được sử dụng để nhận diện phần tử</li>
            </ul>
            <p>Mảng gồm các bản ghi có kiểu giống nhau, có kích thước cố định, mỗi phân tử được xác định bởi chỉ số</p>
            <p>Mảng là cấu trúc dữ liệu được cấp phát liên tục cơ bản</p>
            <h5>Ưu điểm của mảng:</h5>
            <ul>
                <li>Truy cập phần tử v");
            WriteLiteral(@"ới <a href=""II_2""><b>độ phức tạp</b></a> là hằng số (O(1))</li>
                <li>Sử dụng bộ nhớ hiệu quả</li>
                <li>Tính cục bộ về bộ nhớ</li>
            </ul>
            <h5>Nhược điểm của mảng:</h5>
            <ul>
                <li>Không thể thay đổi kích thước khi chương trình đã thực hiện</li>
            </ul>
        </div>
    </div>
    <hr />
    <div class=""container"" id=""I_2_2"">
        <h3>Biểu diễn cấu trúc dữ liệu mảng</h3>
        <div class=""container"">
            <p>Mảng có thể được khai báo theo nhiều các đa dạng trong các ngôn ngữ lập trình. Để minh họa, chúng ta sử dụng phép khai báo trong ngôn ngữ C:</p>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "490312c2b7fbddd53617a19d86bf56f3f017020b6764", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <p>Hình minh hoạ chỉ mục:</p>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "490312c2b7fbddd53617a19d86bf56f3f017020b7934", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            <p>Dưới đây là một số điểm cần ghi nhớ về cấu trúc dữ liệu mảng:</p>
            <ul>
                <li>Chỉ mục bắt đầu với 0</li>
                <li>Nếu độ dài mảng là n, nghĩa là mảng có thể lưu trữ n phần tử</li>
                <li>Mỗi phần tử đều có thể được truy cập thông qua chỉ mục của phần tử đó. Ví dụ theo hình trên, chúng ta có thể lấy giá trị của phần tử tại chỉ mục 6 là 27</li>
            </ul>
        </div>
    </div>
    <hr />
    <div class=""container"" id=""I_2_3"">
        <h3>Phép toán thực hiện trên mảng</h3>
        <div class=""container"">
            <p>Dưới đây là các hoạt động cơ bản trên mảng:</p>
            <ul>
                <li>
                    <p><a href=""#DuyetMang""><b>Duyệt:</b> </a>Duyệt qua các phần tử có trong mảng.</p>
                </li>
                <li>
                    <p><a href=""#ChenMang""><b>Chèn:</b></a> Thêm một phần tử vào mảng tại chỉ mục đã cho</p>
                </li>
                <li>
                    ");
            WriteLiteral(@"<p><a href=""#XoaMang""><b>Xóa:</b></a> Xóa một phần tử từ mảng tại chỉ mục đã cho</p>
                </li>
                <li>
                    <p><a href=""#TimKiemMang""><b>Tìm kiếm:</b></a> Tìm kiếm một phần tử bởi sử dụng chỉ mục hay bởi giá trị.</p>
                </li>
                <li>
                    <p><a href=""#CapNhatMang""><b>Cập nhật:</b></a> Cập nhật giá trị một phần tử tại chỉ mục nào đó.</p>
                </li>
            </ul>
            <hr />
            <div id=""DuyetMang"">
                <p><b>Duyệt:</b> Duyệt qua các phần tử có trong mảng.</p>
                <p>Ví dụ duyệt mảng trong ngôn ngữ C:</p>
                <div class=""card"" style=""background-color: #F1F1F1"">
<pre style=""padding: 1em; margin: .5em 0; overflow: auto;"" class=""card-body"">
                    <code>
        //Khai báo mảng
        int array [5] = {10, 15, 7, 20, 9}
        //Giá trị của mảng tại chỉ mục thứ 2 là <span style=""color: red""><b>array[2]</b></span> có giá trị là <span style");
            WriteLiteral(@"=""color: red""><b>7</b></span>
    </code> </pre>
                </div><br />
            </div>
            <hr />
            <div id=""ChenMang"">
                <p><b>Chèn:</b> Hoạt động chèn là để chèn một hoặc nhiều phần tử dữ liệu vào trong một mảng. Tùy theo yêu cầu, phần tử mới có thể được chèn vào vị trí đầu, vị trí cuối hoặc bất kỳ vị trí chỉ mục đã cho nào của mảng.</p>
                <p>Giả sử cho array là 1 mảng tuyến tính không có thứ tự có n phần tử và k là số nguyên dương thỏa mãn k < n. Ta có giải thuật chèn phần tử a vào vị trí thứ k của mảng như sau:</p>
                <div class=""card"" style=""background-color: #F1F1F1"">
<pre style=""padding: 1em; margin: .5em 0; overflow: auto;"" class=""card-body"">
<code>1. Bắt đầu
2. Gán biến tạm j = n
3. Gán n = n + 1
4. Lặp lại bước 5 và 6 khi j >= k    
5. Gán array[j+1] = array[j]
6. Gán j = j - 1
7. Gán array[k] = a
8.Kết thúc</code> </pre>
                </div><br />
                <p>Để hiểu rõ hơn, ta tham khảo giải thuật trên");
            WriteLiteral(@" trong ngôn ngữ C:</p>
                <div class=""card"" style=""background-color: #F1F1F1"">
<pre style=""padding: 1em; margin: .5em 0; overflow: auto;"" class=""card-body"">
<code>#include &lt; stdio.h &gt;
main() {
    int array[] = {1, 7, 5, 3, 9};
    int item = 10, k = 3, n = 5;
    int j = 0;
    // Ta tăng n lên 1 do khi chèn thêm vào mảng, thì kích cỡ mảng sẽ tăng lên
    n = n + 1;
    
    while(j >= k){
        array[j+1] = array[j];
        j = j - 1;
    }
    array[k] = item;
    
    //Kết quả :
    //Trước: array[] = {1, 7, 5, 3, 9}
    //Sau: array[] = {1, 7, 5, 10, 3, 9}

}</code> </pre>

                </div>
            </div><br />
            <hr />
            <div id=""XoaMang"">
                <p><b>Xóa:</b> Hoạt động xóa là xóa một phần tử đang tồn tại từ một mảng và tổ chức lại các phần tử còn lại trong mảng đó.</p>
                <p>Giả sử cho array là một mảng tuyến tính có n phần tử và k là một số nguyên dương thỏa mãn k < n. Ta có giải thuật để xóa một ph");
            WriteLiteral(@"ần tử có trong mảng array tại vị trí k như sau:</p>
                <div class=""card"" style=""background-color: #F1F1F1"">
<pre style=""padding: 1em; margin: .5em 0; overflow: auto;"" class=""card-body"">
<code>1. Bắt đầu
2. Gán biến tạm j = k
3. Lặp lại bước 4 và 5 khi j < n    
4. Gán");
            BeginWriteAttribute("array[j]", " array[j] =", 6392, "", 6403, 0);
            EndWriteAttribute();
            WriteLiteral(" array[j+1]\r\n5. Gán");
            BeginWriteAttribute("j", " j =", 6422, "", 6426, 0);
            EndWriteAttribute();
            WriteLiteral(" j + 1\r\n6. Gán");
            BeginWriteAttribute("n", " n =", 6440, "", 6444, 0);
            EndWriteAttribute();
            WriteLiteral(@" n - 1
7.Kết thúc</code> </pre>
                </div><br />
                <p>Để hiểu rõ hơn, ta tham khảo giải thuật trên trong ngôn ngữ C:</p>
                <div class=""card"" style=""background-color: #F1F1F1"">
<pre style=""padding: 1em; margin: .5em 0; overflow: auto;"" class=""card-body"">
<code>#include &lt; stdio.h &gt;
main() {
    int array[] = {1, 7, 5, 3, 9};
    int k = 3, n = 5;
    int j;
    
    j = k
    
    while(j < n){");
            BeginWriteAttribute("array[j]", "\r\n        array[j] =", 6899, "", 6919, 0);
            EndWriteAttribute();
            WriteLiteral(" array[j+1];");
            BeginWriteAttribute("j", "\r\n        j =", 6931, "", 6944, 0);
            EndWriteAttribute();
            WriteLiteral(" j + 1;\r\n    }");
            BeginWriteAttribute("n", "\r\n    n =", 6958, "", 6967, 0);
            EndWriteAttribute();
            WriteLiteral(" n - 1; //Ta giảm n đi vì khi xóa phần tử, độ dài mảng cũng sẽ giảm đi\r\n    //Kết quả :\r\n    //Trước:");
            BeginWriteAttribute("array[]", " array[] =", 7068, "", 7078, 0);
            EndWriteAttribute();
            WriteLiteral(" {1, 7, 5, 3, 9}\r\n    //Sau:");
            BeginWriteAttribute("array[]", " array[] =", 7106, "", 7116, 0);
            EndWriteAttribute();
            WriteLiteral(@" {1, 7, 5, 9}

}</code> </pre>
                </div><br />
                <p>Như ví dụ trên, mảng đã xóa phần tử array[3] bằng cách gán giá trị của biến phía sau array[k] vào array[k] sau đó giảm n đi.</p>
            </div><hr />
            <div id=""TimKiemMang"">
                <p><b>Tìm kiếm:</b> Tìm kiếm một phần tử có trong mảng.Có rất nhiều giải thuật để tìm kiếm trong mảng, mỗi giải thuật có <a href=""II_2""><b>độ phức tạp</b></a> khác nhau. Bạn có thể tham khảo tại <a href=""II_3""><b>giải thuật tìm kiếm</b></a>. Ở đây chúng ta sẽ sử dụng giải thuật <a href=""I_3_2""><b>Tìm kiếm tuyến tính</b></a>.</p>
                <p>Giả sử ta có array là một mảng tuyến tính có n phần tử và k là số nguyên dương thỏa mãn k < n. Ta có giải thuật cho hoạt động tìm kiếm dựa theo giải thuật  <a href=""I_3_2""><b>Tìm kiếm tuyến tính</b></a>: </p>
                <div class=""card"" style=""background-color: #F1F1F1"">
<pre style=""padding: 1em; margin: .5em 0; overflow: auto;"" class=""card-body"">
<code>1. Bắt đầu
2. Gá");
            WriteLiteral("n j = 0\r\n3. Lặp lại bước 4 và 5 khi j < n    \r\n4. Nếu");
            BeginWriteAttribute("array[j]", " array[j] =", 8193, "", 8204, 0);
            EndWriteAttribute();
            WriteLiteral(@"= item thì tới bước 6
5. Gán j = j + 1
6. Xuất giá trị của j là vị trí của item đã tìm
7.Kết thúc</code> </pre>
                </div><br />
                <p>Để hiểu rõ hơn, ta tham khảo giải thuật tìm kiếm trên trong ngôn ngữ C:</p>
            <div class=""card"" style=""background-color: #F1F1F1"">
<pre style=""padding: 1em; margin: .5em 0; overflow: auto;"" class=""card-body"">
<code>#include &lt; stdio.h &gt;
main() {
    int array[] = {1, 3, 5, 7, 8};
    int item = 5, n = 5;
    int j = 0;
    
    while(j < n){
        if");
            BeginWriteAttribute("(array[j]", " (array[j] =", 8748, "", 8760, 0);
            EndWriteAttribute();
            WriteLiteral(@"= item){
            break;
        }
        j = j + 1;
    }

    if (j == n){
        printf(""Khong tim thay phan tu! "");
    }
    else{
        printf(""Tim thay phan tu %d tai vi tri %d\n"", item, j+1);
    }

    //Kết quả:
    Tim thay phan tu 5 tai vi tri 3
}</code> </pre>
                </div><br />
                <p>Như ví dụ trên, ta đã tìm được item 5 ở vị trí thứ j+1, trong khi đó, j = 2 nên cho ra kết quả như trên. Còn nếu không tìm thấy giá trị cần tìm, ta in ra cấu thông báo</p>
            </div><hr />
            <div id=""CapNhatMang"">
                <p><b>Cập nhật:</b> Cập nhật giá trị một phần tử tồn tại trong mảng tại chỉ mục nào đó.</p>
                <p>Giả sử array là một mảng tuyến tính có n phần tử và k là số nguyên dương thảo mãn k <= n. Ta có giải thuật để update phần tử tại vị trí k của mảng array như sau:</p>
            <div class=""card"" style=""background-color: #F1F1F1"">
<pre style=""padding: 1em; margin: .5em 0; overflow: auto;"" class=""card-body"">
<co");
            WriteLiteral(@"de>1. Bắt đầu
2. Thiết lập array[k-1] = item
3. Kết thúc</code> </pre>
                </div><br />
                <p>Để hiểu rõ hơn, ta tham khảo giải thuật tìm kiếm trên trong ngôn ngữ C:</p>
            <div class=""card"" style=""background-color: #F1F1F1"">
<pre style=""padding: 1em; margin: .5em 0; overflow: auto;"" class=""card-body"">
<code>#include &lt; stdio.h &gt;
main() {
    int array[] = {1, 3, 5, 7, 8};
    int item = 10, n = 5, k = 3 ;
    int i, j;
    
    array[k-1] = item;

    //Kết quả:
    //array [] = {1, 3, 10, 7, 8}
}</code> </pre>
                </div><br />
                <p>Như ví dụ trên, giá trị thứ 3 của mảng (array[2]) đã được cập nhật thành 10</p>
        
            </div><hr />
        </div>
    </div>
    <hr />
    <div class=""container"">
        <h3>Mảng động</h3>
        <a href=""I_2_4""><p>Xem thêm ...</p></a>
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