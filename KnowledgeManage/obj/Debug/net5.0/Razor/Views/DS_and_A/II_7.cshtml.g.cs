#pragma checksum "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\II_7.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46e5ed1419432ddb5600bd241b35328b17c058c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DS_and_A_II_7), @"mvc.1.0.view", @"/Views/DS_and_A/II_7.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46e5ed1419432ddb5600bd241b35328b17c058c0", @"/Views/DS_and_A/II_7.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8b91396dfbb5c43e5379ee682f129446bb1c6c7", @"/Views/_ViewImports.cshtml")]
    public class Views_DS_and_A_II_7 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\II_7.cshtml"
  
    ViewData["Title"] = "II_7";
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
    <h3>GI???I THU???T QUAY LUI</h3>
    <div id=""II_7_1"">
        <h5>Kh??i ni???m gi???i thu???t quay lui</h5>
        <p>
            Quay lui (Backtracking) l?? m???t k?? thu???t thi???t k??? gi???i thu???t d???a tr??n ????? quy. ?? t?????ng c???a quay lui l?? t??m l???i gi???i t???ng b?????c, m???i b?????c ch???n m???t trong s??? c??c l???a ch???n kh??? d?? v?? ????? quy.
        </p>
    </div>
    <div id=""II_7_2"">
        <h5>X??y d???ng gi???i thu???t quay lui</h5>
        <p>Thu???t to??n quay lui d??ng ????? li???t k?? c??c c???u h??nh m?? m???i c???u h??nh ???????c x??y d???ng b???ng c??ch x??y d???ng t???ng ph???n t???, m???i ph???n t??? ???????c ch???n b???ng t???t c??? c??c kh??? n??ng. Khi ch???n m???t gi?? tr??? c?? th??? cho m???t ph???n t???, ch??ng ta ti???p t???c li???t k?? t???t c??? c??c c???u h??nh cho nh???ng ph???n t??? c??n l???i. Gi??? s??? c???u h??nh c???n x??y d???ng c?? d???ng x[1..n], khi ???? thu???t to??n t");
            WriteLiteral(@"h???c hi???n c??c b?????c sau:</p>
        <ul>
            <li>- X??t t???t c??? c??c gi?? tr??? x[1] c?? th??? nh???n ???????c. V???i m???i gi?? tr??? g??n cho x[1] ch??ng ta s???:</li>
            <li>- X??t t???t c??? c??c gi?? tr??? x[2] c?? th??? nh???n ???????c. V???i m???i gi?? tr??? g??n cho x[2] ch??ng ta s??? x??t ti???p t???t c??? c??c gi?? tr??? cho x[3], ???</li>
            <li>- X??t t???t c??? c??c gi?? tr??? x[n] c?? th??? nh???n, v???i m???i gi?? tr??? g??n cho x[n], ch??ng ta c?? th??m m???t c???u h??nh t??m ???????c (x[1], x[2], ???, x[n])</li>
        </ul>
        <p>M?? gi??? cho thu???t to??n quay lui</p>
        <div class=""card"" style=""background-color: #F1F1F1"">
<pre style=""padding: 1em; margin: .5em 0; overflow: auto;"" class=""card-body"">
<code>
Backtracking(k) {
	for([M???i ph????ng ??n ch???n i(thu???c t???p D)]) {
		if ([Ch???p nh???n i]) {
			[Ch???n i cho X[k]];
			if ([Th??nh c??ng]) {
				[????a ra k???t qu???];
			} else {
				Backtracking(k+1);
				[B??? ch???n i cho X[k]];
			}
		}
	}
}
</code> </pre>
            </div><br />
        <u><b>??u ??i???m:</b></u>
        <p>Vi???c quay lui l?? th??? t???t c???");
            WriteLiteral(@" c??c t??? h???p ????? t??m ???????c m???t l???i gi???i. Th??? m???nh c???a ph????ng ph??p n??y l?? nhi???u c??i ?????t tr??nh ???????c vi???c ph???i th??? nhi???u tr?????ng h???p ch??a ho??n ch???nh, nh??? ???? gi???m th???i gian ch???y.</p>
        <u><b>Nh?????c ??i???m:</b></u>
        <ul>
            <li>- R??i v??o t??nh tr???ng ""thrashing"": qu?? tr??nh t??m ki???m c??? g???p ph???i b??? t???c v???i c??ng m???t nguy??n nh??n.</li>
            <li>- Th???c hi???n c??c c??ng vi???c d?? th???a: M???i l???n ch??ng ta quay lui, ch??ng ta c???n ph???i ????nh gi?? l???i l???i gi???i trong khi ????i l??c ??i???u ???? kh??ng c???n thi???t.</li>
            <li>- Kh??ng s???m ph??t hi???n ???????c c??c kh??? n??ng b??? b??? t???c trong t????ng lai. Quay lui chu???n, kh??ng c?? c?? ch??? nh??n v??? t????ng lai ????? nh???n bi???t ??c nh??nh t??m ki???m s??? ??i v??o b??? t???c.</li>
        </ul>
        <u><b>M???t s??? b??i to??n c?? b???n c???a gi???i thu???t quay lui</b></u>
        <ul>
            <li><a href=""III_13#sudoku"">Tr?? ch??i Sudoku</a></li>
            <li><a href=""III_13#madituan"">B??i to??n qu??n M?? ??i tu???n</a></li>
            <li><a href=""III_13#8quanhau"">B??i to??n 8 qu??n H???u</a></li>
        </");
            WriteLiteral("ul>\r\n    </div>\r\n    <div>\r\n        <br />\r\n        <br />\r\n        <br />\r\n        <br />\r\n        <br />\r\n        <br />\r\n    </div>\r\n</div>");
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
