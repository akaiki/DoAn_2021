#pragma checksum "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\I.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e8559e4d85f2e21a0b67141f2adc9a12fec47b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DS_and_A_I), @"mvc.1.0.view", @"/Views/DS_and_A/I.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e8559e4d85f2e21a0b67141f2adc9a12fec47b0", @"/Views/DS_and_A/I.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8b91396dfbb5c43e5379ee682f129446bb1c6c7", @"/Views/_ViewImports.cshtml")]
    public class Views_DS_and_A_I : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\I.cshtml"
  
    ViewData["Title"] = "I";
    Layout = "~/Views/DS_and_A/Menu.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div");
            BeginWriteAttribute("class", " class=\"", 91, "\"", 99, 0);
            EndWriteAttribute();
            WriteLiteral(@">
    <div id=""I_1"">
        <h3>Cấu trúc dữ liệu (Data Structure) là gì ?</h3>
        <blockquote>
            <p>Cấu trúc dữ liệu là cách lưu trữ, tổ chức dữ liệu có thứ tự, có hệ thống để dữ liệu có thể được sử dụng một cách hiệu quả. </p>
        </blockquote>
        <p>Dưới đây là hai khái niệm nền tảng hình thành nên một cấu trúc dữ liệu:</p>
        <ul>
            <li><p><b>Interface</b>: Mỗi cấu trúc dữ liệu có một Interface. Interface biểu diễn một tập hợp các phép tính mà một cấu trúc dữ liệu hỗ trợ. Một Interface chỉ cung cấp danh sách các phép tính được hỗ trợ, các loại tham số mà chúng có thể chấp nhận và kiểu trả về của các phép tính này.</p></li>
            <li><p><b>Implementation</b> (có thể hiểu là sự triển khai): Cung cấp sự biểu diễn nội bộ của một cấu trúc dữ liệu. Implementation cũng cung cấp phần định nghĩa của giải thuật được sử dụng trong các phép tính của cấu trúc dữ liệu.</p></li>
        </ul>
    </div>
    <hr />
    <h3>Thuật ngữ cơ bản trong Cấu trúc dữ liệu</");
            WriteLiteral(@"h3>
    <ul>
        <li><p><b>Dữ liệu</b>: Dữ liệu là các giá trị hoặc là tập hợp các giá trị.</p></li>
        <li><p><b>Phần tử dữ liệu</b>: Phần tử dữ liệu là một đơn vị đơn lẻ của giá trị.</p></li>
        <li><p><b>Các phần tử nhóm</b>: Phần tử dữ liệu mà được chia thành các phần tử con thì được gọi là các phần tử nhóm.</p></li>
        <li><p><b>Các phần tử cơ bản</b>: Phần tử dữ liệu mà không thể bị chia nhỏ thành các phần tử con thì gọi là các phần tử cơ bản.</p></li>
        <li><p><b>Thuộc tính và Thực thể</b>: Một thực thể là cái mà chứa một vài thuộc tính nào đó, và các thuộc tính này có thể được gán các giá trị.</p></li>
        <li><p><b>Tập hợp thực thể</b>: Các thực thể mà có các thuộc tính tương tự nhau thì cấu thành một tập hợp thực thể.</p></li>
        <li><p><b>Trường</b>: Trường là một đơn vị thông tin cơ bản biểu diễn một thuộc tính của một thực thể.</p></li>
        <li><p><b>Bản ghi</b>: Bản ghi là một tập hợp các giá trị trường của một thực thể đã cho.</p></li>
        <li");
            WriteLiteral(@"><p><b>File</b>: Là một tập hợp các bản ghi của các thực thể trong một tập hợp thực thể đã cho.</p></li>
    </ul>
    <hr />
    <h3>
        Một số cấu trúc dữ liệu thường gặp:
    </h3>
    <ul>

        <li><a href=""I_2""><b>Cấu trúc dữ liệu mảng (array)</b></a></li>
        <li><a href=""I_3""><b>Cấu trúc dữ liệu danh sách liên kết (Linked list)</b></a></li>
        <li><a href=""I_4""><b>Cấu trúc dữ liệu ngăn xếp (Stack)</b></a></li>
        <li><a href=""I_5""><b>Cấu trúc dữ liệu hàng đợi (Queue)</b></a></li>
        <li><a href=""I_6""><b>Cấu trúc dữ liệu cây (Tree)</b></a></li>
        <li><a href=""I_7""><b>Cấu trúc dữ liệu đồ thị (Graph)</b></a></li>
    </ul>
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
