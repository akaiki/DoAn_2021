#pragma checksum "D:\DoAn_2021\Knowledge_Manager_01\KnowledgeSearching\KnowledgeSearching\Views\Main\II_4_2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "368c43c49cb976200b98fcc2fdf434e45a460bc8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_II_4_2), @"mvc.1.0.view", @"/Views/Main/II_4_2.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"368c43c49cb976200b98fcc2fdf434e45a460bc8", @"/Views/Main/II_4_2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55c93d07d287d648d202a547ac41ea2a162bac7c", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_II_4_2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\DoAn_2021\Knowledge_Manager_01\KnowledgeSearching\KnowledgeSearching\Views\Main\II_4_2.cshtml"
  
    ViewData["Title"] = "Quy tắc cộng - max";
    Layout = "~/Views/Main/Menu.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <h2>Quy tắc cộng - max</h2>

    <blockquote>
        Nếu T1(n) và T2(n) là thời gian thực hiện của hai đoạn chương trình P1 và P2; và T1(n)=O(f(n)), T2(n)=O(g(n)) thì thời gian thực hiện của đoạn hai chương trình đó nối tiếp nhau là T(n)=O(max(f(n),g(n)))
    </blockquote>

    <hr />

    <p>
        Ví dụ:
    </p>
    <p>
        Ta có một lệnh gán x = 15, lệnh này tốn một hằng thời gian O(1), lệnh đọc dữ liệu read(x) tốn một hằng thời gian O(1). Vậy thời gian thực hiện cả 2 lệnh trên nối tiếp nhau theo quy tắc cộng là O(max(1, 1)) = O(1)
    </p>
    <hr />
    <p>
        Sau đây là một số quy tắc liên quan
    </p>
    <ul>
        <li><a href=""II_4_1""><b>Quy tắc bỏ hằng số</b></a></li>
        <li><a href=""II_4_3""><b>Quy tắc nhân</b></a></li>
        <li><a href=""II_4_4""><b>Quy tắc tổng quát</b></a></li>
    </ul>
    <hr />
    <p>
        Bạn có thể tham khảo các mục sau:
    </p>
    <ul>
        <li><a href=""II_5""><b>Ví dụ tính độ phức tạp");
            WriteLiteral(@" của thuật toán</b></a></li>
        <li><a href=""II""><b>Độ phức tạp của thuật toán</b></a></li>
        <li><a href=""I_3_2""><b>Big Oh Notation, &Omicron; trong Cấu trúc dữ liệu và giải thuật</b></a></li>
        <li><a href=""I_3_5""><b>Ví dụ độ phức tạp trong cấu trúc dữ liệu và giải thuật</b></a></li>
        <li><a href=""II_4""><b>Các quy tắc để xác định độ phức tạp của giải thuật</b></a></li>

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
