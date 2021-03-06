#pragma checksum "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\III_8.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d850e7c09c550473e9d146aa9b3b9f2b3c703080"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DS_and_A_III_8), @"mvc.1.0.view", @"/Views/DS_and_A/III_8.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d850e7c09c550473e9d146aa9b3b9f2b3c703080", @"/Views/DS_and_A/III_8.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8b91396dfbb5c43e5379ee682f129446bb1c6c7", @"/Views/_ViewImports.cshtml")]
    public class Views_DS_and_A_III_8 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\III_8.cshtml"
  
    ViewData["Title"] = "III_8";
    Layout = "~/Views/DS_and_A/Menu.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""accordion"" style=""padding-left: 15%; padding-right: 15%; "">
    <h1>BÀI TẬP VỀ GIẢI THUẬT TÌM KIẾM</h1>
    <p class=""alert-warning"">BẠN CÓ THỂ NHẤN VÀO ĐỂ XEM BÀI GIẢI</p>
    
    <div id=""tuyentinh"">
        <h3>Bài tập tìm kiếm áp dụng giải thuật tìm kiếm tuyến tính</h3>
        <div class=""card"">
            <div class=""card-header"">
                <a class=""card-link"" data-toggle=""collapse"" href=""#Bai1"">
                    Bài 1. Cho mảng a có n phần tử, a = [1, 3, 2, 1, 4, 2]. Và một số nguyên x = 2. Hãy chỉ ra số đầu tiên của mảng xuất hiện x, nếu không tồ tại thì trả về -1.
                </a>
            </div>
            <div id=""Bai1"" class=""collapse container"" data-parent=""#accordion"">
                <br />
                <u><b>Ý tưởng bài toán</b></u>
                <p>Tìm kiếm tuyến tính là giải thuật tìm kiếm từng phần tử từ đầu đến cuối danh sách đã cho.</p>
                <p>Sử dụng tìm kiếm tuyến tính nhằm tìm kiếm được vị trí xuất hiện đầu tiên của phần t");
            WriteLiteral(@"ử đó nhằm tránh sai sót so với các giải thuật tìm kiếm khác.</p>
                <hr />
                <u><b>Bài giải:</b></u>
<pre style=""overflow: auto; font-family:Consolas"" class=""card-body"">
<code>
#include &lt;iostream&gt;

using namespace std;

int sequential_search (int *a, int x, int n){
    for (int i = 0; i < n; i++)
        if");
            BeginWriteAttribute("(a[i]", " (a[i] =", 1465, "", 1473, 0);
            EndWriteAttribute();
            WriteLiteral(@"= x)
            return(i);    
    return (-1);
}

int main()
{
    
    int a[] = {1, 3, 2, 1, 4, 2};
    int n = sizeof(a)/sizeof(a[0]);
    cout << sequential_search(a, 2, n) << endl;
    
    return 0;
}
</code> 
</pre>
            </div>
        </div>
        <div class=""card"">
            <div class=""card-header"">
                <a class=""card-link"" data-toggle=""collapse"" href=""#Bai2"">
                    Bài 2. Cho mảng a có n phần tử, a = [1, 3, 2, 1, 4, 2]. Và một số nguyên x = 2. Hãy chỉ ra quá trình tìm thấy số x đầu tiên, nếu không tìm thấy, hiển thị ""Khong co x trong mang""
                </a>
            </div>
            <div id=""Bai2"" class=""collapse container"" data-parent=""#accordion"">
                <br />
                <u><b>Ý tưởng bài toán</b></u>
                <p>Tìm kiếm tuyến tính là giải thuật tìm kiếm từng phần tử từ đầu đến cuối danh sách đã cho.</p>
                <p>Sử dụng tìm kiếm tuyến tính nhằm tìm kiếm được vị trí xuất hiện đầu tiên của p");
            WriteLiteral(@"hần tử đó nhằm tránh sai sót so với các giải thuật tìm kiếm khác.</p>
                <p>Hiển thị các bước tìm kiếm.</p>
                <hr />
                <u><b>Bài giải:</b></u>
<pre style=""overflow: auto; font-family:Consolas"" class=""card-body"">
<code>
#include &lt;iostream&gt; 

using namespace std;

void sequential_search (int *a, int x, int n){
    int t =-1;
    for (int i = 0; i < n; i++){
        cout <<""Buoc ""<< i+1<<"" : So sanh phan tu thu "" << i+1 << "" voi "" << x << "":"" << endl;
        if");
            BeginWriteAttribute("(a[i]", " (a[i] =", 3021, "", 3029, 0);
            EndWriteAttribute();
            WriteLiteral("= x){\r\n            cout << \"Da tim thay \" << x <<\" trong mang!\" << endl;");
            BeginWriteAttribute("t", "\r\n            t =", 3101, "", 3118, 0);
            EndWriteAttribute();
            WriteLiteral(" i;\r\n            break;\r\n        }\r\n        else {\r\n            cout << \"Khong bang nhau!\" << endl;\r\n        }\r\n    }\r\n        \r\n    if");
            BeginWriteAttribute("(t", " (t =", 3253, "", 3258, 0);
            EndWriteAttribute();
            WriteLiteral("= -1){\r\n        cout << \"Khong co \" << x << \" trong mang!\"<< endl;\r\n    }  \r\n    else{\r\n        cout << x << \" xuat hien dau tien tai a[\" << t <<\"]\"<< endl;\r\n    }\r\n}\r\n\r\n\r\nint main()\r\n{\r\n    \r\n    int");
            BeginWriteAttribute("a[]", " a[] =", 3458, "", 3464, 0);
            EndWriteAttribute();
            WriteLiteral(" {1, 3, 2, 1, 4, 2};\r\n    int");
            BeginWriteAttribute("n", " n =", 3493, "", 3497, 0);
            EndWriteAttribute();
            WriteLiteral(@" sizeof(a)/sizeof(a[0]);
    sequential_search(a, 2, n);
    
    return 0;
}

</code> 
</pre>
            </div>
        </div>
        <div class=""card"">
            <div class=""card-header"">
                <a class=""card-link"" data-toggle=""collapse"" href=""#Bai3"">
                    Bài 3. Cho mảng a có n phần tử, a = [2, 3, 2, 1, 2, 2]. Và một số nguyên x = 2. Hãy chỉ ra tất cả vị trí xuất hiện x, nếu không tồ tại thì trả về -1.
                </a>
            </div>
            <div id=""Bai3"" class=""collapse container"" data-parent=""#accordion"">
                <br />
                <u><b>Ý tưởng bài toán</b></u>
                <p>Dựa trên ý tưởng của giải thuật tìm kiếm tuyến tính, ta lần lượt so sánh từng phần tử của mảng sau đó xuất từng phần tử ấy ra.</p>
                <hr />
                <u><b>Bài giải:</b></u>
<pre style=""overflow: auto; font-family:Consolas"" class=""card-body"">
<code>
#include &lt;iostream&gt;   

using namespace std;

void sequential_search (int");
            WriteLiteral(" *a, int x, int n){\r\n    int t = -1;\r\n    for (int i = 0; i < n; i++){\r\n        if");
            BeginWriteAttribute("(a[i]", " (a[i] =", 4603, "", 4611, 0);
            EndWriteAttribute();
            WriteLiteral("= x){\r\n            cout << \"Tim thay \" << x << \" tai vi tri a[\" << i <<\"]\" << endl;");
            BeginWriteAttribute("t", " \r\n            t =", 4694, "", 4712, 0);
            EndWriteAttribute();
            WriteLiteral(" i;\r\n        }\r\n    }\r\n    if");
            BeginWriteAttribute("(t", " (t =", 4741, "", 4746, 0);
            EndWriteAttribute();
            WriteLiteral(@"= -1){
        cout << ""Khong tim thay "" << x << ""!"";
    }
}


int main()
{
    
    int a[] = {2, 3, 2, 1, 2, 2};
    int n = sizeof(a)/sizeof(a[0]);
    sequential_search(a, 2, n);
    return 0;
}  
</code> 
</pre>
            </div>
        </div>
    </div>
    
    <div id=""nhiphan"">
        <h3>Bài tập tìm kiếm áp dụng giải thuật tìm kiếm nhị phân </h3>
        <div class=""card"">
            <div class=""card-header"">
                <a class=""card-link"" data-toggle=""collapse"" href=""#Bai4"">
                    Bài 4. Cho mảng a đã sắp xếp có n phần tử. a = [1, 2, 5, 8, 10, 13, 17, 24, 30, 50, 55, 61]. Hãy áp dụng giải thuật tìm kiếm nhị phân để tìm x, x = 10. Nếu không tồn tại, trả về -1.
                </a>
            </div>
            <div id=""Bai4"" class=""collapse container"" data-parent=""#accordion"">
                <br />
                <u><b>Ý tưởng bài toán</b></u>
                <p>Cần xác định mảng đã cho đã sắp xếp hay chưa</p>
                <p>Áp dụng <a ");
            WriteLiteral(@"href=""II_2_2""><b>giải thuật tìm kiếm nhị phân</b></a> để tìm kiếm.</p>
                <hr />
                <u><b>Bài giải:</b></u>
<pre style=""overflow: auto; font-family:Consolas"" class=""card-body"">
<code>
#include &lt;iostream&gt;

using namespace std;

int binary_search (int *a, int x, int n){
    int k, left = 0, right = n -1;
    do {
        k = (left + right)/2;
        if (x < a[k])");
            BeginWriteAttribute("right", "\r\n            right =", 6179, "", 6200, 0);
            EndWriteAttribute();
            WriteLiteral(" k - 1;\r\n        else");
            BeginWriteAttribute("left", "\r\n            left =", 6221, "", 6241, 0);
            EndWriteAttribute();
            WriteLiteral(" k + 1;\r\n    } while ((x");
            BeginWriteAttribute("!", " !=", 6265, "", 6268, 0);
            EndWriteAttribute();
            WriteLiteral(@" a[k]) && (left <= right));
    if (x == a[k])
        return k;
    else
        return (-1);
}

int main()
{
    
    int a[] = {1, 2, 5, 8, 10, 13, 17, 24, 30, 50, 55, 61};
    int n = sizeof(a)/sizeof(a[0]);
    cout << binary_search(a, 10, n);
    
    return 0;
}
</code> 
</pre>
            </div>
        </div>

        <div class=""card"">
            <div class=""card-header"">
                <a class=""card-link"" data-toggle=""collapse"" href=""#Bai5"">
                    Bài 5. Cho mảng a có n phần tử, a = [1, 2, 5, 8, 10, 13, 17, 24, 30, 50, 55, 61], và một số nguyên x = 10 .Sử dụng giải thuật tìm kiếm nhị phân tìm kiếm x và xuất ra màn hình từng bước
                </a>
            </div>
            <div id=""Bai5"" class=""collapse container"" data-parent=""#accordion"">
                <br />
                <u><b>Ý tưởng bài toán</b></u>
                <p>Cần xác định mảng đã cho đã sắp xếp hay chưa</p>
                <p>Áp dụng <a href=""II_2_2""><b>giải thuật tìm kiếm nhị");
            WriteLiteral(@" phân</b></a> để tìm kiếm.</p>
                <hr />
                <u><b>Bài giải:</b></u>
<pre style=""overflow: auto; font-family:Consolas"" class=""card-body"">
<code>
#include &lt;iostream&gt;

using namespace std;

void binary_search (int *a, int x, int n){
    int k, left = 0, right = n -1;
    int i = 1;
    do {
        k = (left + right)/2;
        cout <<""Buoc "" << i  <<"": left = ""<< left << ""; right = "" << right <<""; k = ""<< k << endl;   
        if (x < a[k]){");
            BeginWriteAttribute("right", "\r\n            right =", 7782, "", 7803, 0);
            EndWriteAttribute();
            WriteLiteral(" k - 1;\r\n            cout <<\"    \"<< x << \" < a[\" << k << \"] = \" << a[k]<< \" -> right = \" << right << endl;\r\n        }\r\n        else{");
            BeginWriteAttribute("left", "\r\n            left =", 7936, "", 7956, 0);
            EndWriteAttribute();
            WriteLiteral(" k + 1;\r\n            cout <<\"    \"<< x << \" >= a[\" << k << \"] = \" << a[k]<< \" -> left = \" << left << endl;\r\n        }\r\n        i++;\r\n    } while ((x");
            BeginWriteAttribute("!", " !=", 8104, "", 8107, 0);
            EndWriteAttribute();
            WriteLiteral(@" a[k]) && (left <= right));
    if (x == a[k])
        cout << ""Tim thay "" << x << "" tai a["" << k << ""]"" << endl;
    else
        cout << ""Khong tim thay"";
}

int main()
{
    
    int a[] = {1, 2, 5, 8, 10, 13, 17, 24, 30, 50, 55, 61};
    int n = sizeof(a)/sizeof(a[0]);
    binary_search(a, 10, n);
    
    return 0;
}  
</code> 
</pre>
            </div>
        </div>

        <div class=""card"">
            <div class=""card-header"">
                <a class=""card-link"" data-toggle=""collapse"" href=""#Bai6"">
                    Bài 6. Cho mảng a có n phần tử, a = [1, 2, 2, 2, 2, 3], giá trị cần tìm x = 2. Hãy so sánh kết quả khi tìm kiếm x trong a giữa <b>giải thuật tìm kiếm tuyến tính</b> và <b>giải thuật tìm kiếm nhị phân:</b>
                </a>
            </div>
            <div id=""Bai6"" class=""collapse container"" data-parent=""#accordion"">
                <br />
                <u><b>Ý tưởng bài toán</b></u>
                <p>Viết 2 hàm <a href=""II_2_1"">tìm kiếm tuyến t");
            WriteLiteral(@"ính</a> và <a href=""II_2_2"">tìm kiếm nhị phân</a> sau đó so sánh kết quả</p>
                <hr />
                <u><b>Bài giải:</b></u>
<pre style=""overflow: auto; font-family:Consolas"" class=""card-body"">
<code>
#include &lt;iostream&gt;

using namespace std;

int sequential_search (int *a, int x, int n){
    int i;
    for (i = 0; i < n; i++){
        if");
            BeginWriteAttribute("(a[i]", " (a[i] =", 9504, "", 9512, 0);
            EndWriteAttribute();
            WriteLiteral("= x){\r\n            return(i);    \r\n        }\r\n    }\r\n    return (-1);\r\n}\r\n\r\nint binary_search (int *a, int x, int n){\r\n    int k, left = 0, right = n -1;\r\n    do {\r\n        k = (left + right)/2;\r\n        if (x < a[k])");
            BeginWriteAttribute("right", "\r\n            right =", 9729, "", 9750, 0);
            EndWriteAttribute();
            WriteLiteral(" k - 1;\r\n        else");
            BeginWriteAttribute("left", "\r\n            left =", 9771, "", 9791, 0);
            EndWriteAttribute();
            WriteLiteral(" k + 1;\r\n    } while ((x");
            BeginWriteAttribute("!", " !=", 9815, "", 9818, 0);
            EndWriteAttribute();
            WriteLiteral(@" a[k]) && (left <= right));
    if (x == a[k])
        return k;
    else
        return (-1);
}

int main()
{
    
    int a[] = {1, 2, 2, 2, 2, 3};
    int n = sizeof(a)/sizeof(a[0]);
    cout <<""Tim kiem tuyen tinh: "" << sequential_search(a, 2, n) << endl;
    cout <<""Tim kiem nhi phan: "" << binary_search (a, 2, n);
    
    return 0;
}  
</code> 
</pre>
                <u><b>Nhận xét:</b></u>
                <p>- Tìm kiếm nhị phân và tìm kiếm tuyến tính cho ra 2 kết quả khác nhau.</p>
                <p>- Tìm kiếm tuyến tính sẽ cho ra kết quả là phần tử đầu tiên trùng khớp.</p>
                <p>- Tìm kiếm nhị phân sẽ cho ra kết quả chưa chắc là phần tử đầu tiên.</p>
            </div>
        </div>
    </div>
    
    <div id=""noisuy"">
        <h3>Bài tập tìm kiếm áp dụng giải thuật tìm kiếm nội suy</h3>
        <div class=""card"">
            <div class=""card-header"">
                <a class=""card-link"" data-toggle=""collapse"" href=""#Bai7"">
                    Bài 7. Cho");
            WriteLiteral(@" mảng a có n phần tử. a = [10, 12, 13, 16, 18, 19, 20, 21, 22, 23, 24, 33, 35, 42, 47], x = 18 là giá trị cần tìm. Hãy áp dụng giải thuật tìm kiếm nội suy để tìm x trong mảng a.
                </a>
            </div>
            <div id=""Bai7"" class=""collapse container"" data-parent=""#accordion"">
                <br />
                <u><b>Ý tưởng bài toán</b></u>
                <p>Áp dụng kiến thức về <a href=""II_2_3"">giải thuật tìm kiếm nội suy</a> để xây dựng</p>
                <hr />
                <u><b>Bài giải:</b></u>
<pre style=""overflow: auto; font-family:Consolas"" class=""card-body"">
<code>
#include &lt;iostream&gt; 

using namespace std;

int InterPolationSearch(int *a, int x, int n)
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
            BeginWriteAttribute("left", "\r\n        left =", 11864, "", 11880, 0);
            EndWriteAttribute();
            WriteLiteral(" k + 1;\r\n    else");
            BeginWriteAttribute("right", "\r\n        right =", 11897, "", 11914, 0);
            EndWriteAttribute();
            WriteLiteral(" k - 1;\r\n    }\r\n    return -1;\r\n}\r\n\r\nint main()\r\n{\r\n    int");
            BeginWriteAttribute("a[]", " a[] =", 11973, "", 11979, 0);
            EndWriteAttribute();
            WriteLiteral(" {10, 12, 13, 16, 18, 19, 20, 21, 22, 23, 24, 33, 35, 42, 47};\r\n    int");
            BeginWriteAttribute("n", " n =", 12050, "", 12054, 0);
            EndWriteAttribute();
            WriteLiteral(" sizeof(a)/sizeof(a[0]);\r\n    cout << InterPolationSearch(a, 18, n);\r\n    return 0;\r\n}\r\n</code> \r\n</pre>\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n</div>\r\n<div>\r\n    <br />\r\n    <br /> \r\n    <br />\r\n    <br />\r\n    <br />\r\n    <br />\r\n</div>\r\n");
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
