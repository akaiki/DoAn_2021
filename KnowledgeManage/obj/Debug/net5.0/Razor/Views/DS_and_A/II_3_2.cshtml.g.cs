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
        <h3>GI???I THU???T S???P X???P CH??N (INSERTION SORT)</h3>
        <div id=""II_3_2_1"">
            <h5>Kh??i ni???m gi???i thu???t s???p x???p ch??n</h5>
            <p>S???p x???p ch??n l?? m???t gi???i thu???t s???p x???p d???a tr??n so s??nh in-place. ??? ????y, m???t danh s??ch con lu??n lu??n ???????c duy tr?? d?????i d???ng ???? qua s???p x???p. S???p x???p ch??n l?? ch??n th??m m???t ph???n t??? v??o danh s??ch con ???? qua s???p x???p. Ph???n t??? ???????c ch??n v??o v??? tr?? th??ch h???p sao cho v???n ?????m b???o r???ng danh s??ch con ???? v???n s???p theo th??? t???.</p>
            <p>V???i c???u tr??c d??? li???u m???ng, ch??ng ta t?????ng t?????ng l??: m???ng g???m hai ph???n: m???t danh s??ch con ???? ???????c s???p x???p v?? ph???n kh??c l?? c??c ph???n t??? kh??ng c?? th??? t???. Gi???i thu???t s???p x???p ch??n s??? th???c hi???n vi???c t??m ki???m li??n ti???p qua m???ng ????, v?? c??c ph???n t??? kh??ng c?? ");
            WriteLiteral("th??? t??? s??? ???????c di chuy???n v?? ???????c ch??n v??o v??? tr?? th??ch h???p trong danh s??ch con (c???a c??ng m???ng ????).</p>\r\n            ");
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
            <h5>X??y d???ng gi???i thu???t s???p x???p ch??n</h5>
            <p>?? t?????ng cho gi???i thu???t s???p x???p ch??n ???????c tr??nh b??y th??nh c??c b?????c nh?? sau:</p>
            <div class=""card"" style=""background-color: #F1F1F1"">
                <p>Gi??? s??? ta c?? m???ng a c?? n ph???n t???</p>
                <ul>
                    <li><b>B?????c 1: </b>Ki???m tra n???u ph???n t??? ?????u ti??n ???? ???????c s???p x???p. Tr??? v??? 1</li>
                    <li><b>B?????c 2: </b>L???y ph???n t??? k??? ti???p</li>
                    <li><b>B?????c 3: </b>So s??nh v???i t???t c??? ph???n t??? trong danh s??ch con ???? qua s???p x???p</li>
                    <li><b>B?????c 4: </b>D???ch chuy???n t???t c??? ph???n t??? trong danh s??ch con m?? l???n h??n gi?? tr??? ????? ???????c s???p x???p.</li>
                    <li><b>B?????c 5: </b>Ch??n gi?? tr??? ????</li>
                    <li><b>B?????c 6: </b>L???p l???i cho t???i khi danh s??ch ???????c s???p x???p</li>
                </ul>
            </div><br />
            <hr />
            <p>Gi???i thu???t m???u cho s???p x???p ch??n<");
            WriteLiteral(@"/p>
            <div class=""card"" style=""background-color: #F1F1F1"">
<pre style=""padding: 1em; margin: .5em 0; overflow: auto;"" class=""card-body"">
<code>
B???t ?????u h??m insertionSort( A : m???ng ph???n t??? )
    int holePosition
    int valueToInsert
	
    <span style=""color: #008"">for</span> i = 1 t???i length(A) th???c hi???n:
	
        /* ch???n m???t gi?? tr??? ????? ch??n */
        valueToInsert = A[i]
        holePosition = i
      
        /*x??c ?????nh v??? tr?? cho ph???n t??? ???????c ch??n */
		
        <span style=""color: #008"">while</span> holePosition > 0 v?? A[holePosition-1] > valueToInsert th???c hi???n:
            A[holePosition] = A[holePosition-1]
            holePosition = holePosition -1
        k???t th??c while
		
        /* ch??n gi?? tr??? t???i v??? tr?? tr??n */
        A[holePosition] = valueToInsert
      
    k???t th??c for
K???t th??c h??m
</code> </pre>
            </div><br />
            <hr />
            <p><b>V?? d???: </b>Th??? t???c s???p x???p ch??n tr??n m???t m???ng c??c s??? nguy??n ???????c vi???t b???ng C nh?? sau:</p>
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
            <p>Trong tr?????ng h???p t???t nh???t thu???t to??n s??? d???ng n - 1 ph??p so s??nh v?? 0 l???n ho??n v???. Trung b??nh thu???t to??n s??? d???ng n<sup>2</sup>/4 ph??p so s??nh v?? n<sup>2</sup>/4 l???n ho??n v???. Trong tr?????ng h???p x???u nh???t thu???t to??n s??? d???ng n<sup>2</sup>/2 ph??p so s??nh v?? n<sup>2</sup>/2 l???n ho??n v???.</p>  
            <p>Gi???i thu???t n??y kh??ng th??ch h???p s??? d???ng v???i c??c t???p d??? li???u l???n khi ????? ph???c t???p tr?????ng h???p x???u nh???t v?? tr?????ng h???p trung b??nh l?? ??(n<sup>2</sup>) v???i n l?? s??? ph???n t???.</p>
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
