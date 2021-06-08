#pragma checksum "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\III_5.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "85031195771a01ed63213c76a8be93cc444722c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DS_and_A_III_5), @"mvc.1.0.view", @"/Views/DS_and_A/III_5.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"85031195771a01ed63213c76a8be93cc444722c4", @"/Views/DS_and_A/III_5.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8b91396dfbb5c43e5379ee682f129446bb1c6c7", @"/Views/_ViewImports.cshtml")]
    public class Views_DS_and_A_III_5 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\III_5.cshtml"
  
    ViewData["Title"] = "III_5";
    Layout = "~/Views/DS_and_A/Menu.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div id=""accordion"" style=""padding-left: 15%; padding-right: 15%; "">
    <h1>BÀI TẬP VỀ HÀNG ĐỢI (QUEUE)</h1>
    <p class=""alert-warning"">BẠN CÓ THỂ NHẤN VÀO ĐỂ XEM BÀI GIẢI</p>
    <h3>Bài tập cài đặt</h3>
    <div id=""accordion1"">
        <div class=""card"">
            <div class=""card-header"">
                <a class=""card-link"" data-toggle=""collapse"" href=""#Bai1"">
                    Bài 1. Viết các hàm trong hàng đợi
                </a>
            </div>
            <div id=""Bai1"" class=""collapse"" data-parent=""#accordion"">

                <div class=""card"">
                    <div class=""card-header"">
                        <a class=""card-link"" data-toggle=""collapse"" href=""#cre-queue"">
                            Cài đặt cấu trúc dữ liệu hàng đợi, tạo hàng đợi ở trạng thái rỗng
                        </a>
                    </div>
                    <div id=""cre-stack"" class=""collapse"" data-parent=""#accordion1"">
<pre style=""overflow: auto; font-family:Consolas"" class=""card");
            WriteLiteral(@"-body"">
<code>    
typedef struct{
    int front, rear, count;
    int array[MAX];
} queue;

//Tao hang doi o trang thai rong:
void Init(queue *q){
    q-> front = 0;
    q-> rear = MAX - 1;
    q-> count = 0;
    return;
}   
</code> 
</pre>

                    </div>
                </div>

                <div class=""card"">
                    <div class=""card-header"">
                        <a class=""card-link"" data-toggle=""collapse"" href=""#isempty"">
                            Hàm isEmpty() - Kiểm tra rỗng
                        </a>
                    </div>
                    <div id=""isempty"" class=""collapse"" data-parent=""#accordion1"">
<pre style=""overflow: auto; font-family:Consolas"" class=""card-body"">
<code>
bool isEmpty(queue q){
    return q.count <= 0;    
}
</code> 
</pre>

                    </div>
                </div>

                <div class=""card"">
                    <div class=""card-header"">
                        <a class=""card-link"" dat");
            WriteLiteral(@"a-toggle=""collapse"" href=""#isFull"">
                            Hàm isFull() - Kiểm tra đẩy
                        </a>
                    </div>
                    <div id=""isFull"" class=""collapse"" data-parent=""#accordion1"">
<pre style=""overflow: auto; font-family:Consolas"" class=""card-body"">
<code>   
bool isFull{
    return itemCount == MAX;    
}    
</code> 
</pre>
                    </div>
                </div>

                <div class=""card"">
                    <div class=""card-header"">
                        <a class=""card-link"" data-toggle=""collapse"" href=""#peek"">
                            Hàm peek() - Lấy giá trị phần tử đầu hàng đợi (Phần tử đưa vào cuối cùng)
                        </a>
                    </div>
                    <div id=""peek"" class=""collapse"" data-parent=""#accordion1"">
<pre style=""overflow: auto; font-family:Consolas"" class=""card-body"">
<code>
int peak(queue *q){
    return q->array[q->front];
}
</code> 
</pre>
                    </d");
            WriteLiteral(@"iv>
                </div>

                <div class=""card"">
                    <div class=""card-header"">
                        <a class=""card-link"" data-toggle=""collapse"" href=""#pop"">
                            Hàm pop() - Lấy phần tử ra khỏi ngăn xếp theo thứ tự FIFO
                        </a>
                    </div>
                    <div id=""pop"" class=""collapse"" data-parent=""#accordion1"">
<pre style=""overflow: auto; font-family:Consolas"" class=""card-body"">
<code>
int Pop (queue *q){
    int x;
    if (isEmpty (*q))
        printf(""Hang doi rong!"");
    else{
        x = q -> array[q -> front];
        if (q -> front == MAX -1)
            q -> front = 0;
        else
            (q -> front) ++;
        q -> count --;
    }
    return  x;
} 
</code> 
</pre>
                    </div>
                </div>

                <div class=""card"">
                    <div class=""card-header"">
                        <a class=""card-link"" data-toggle=""collapse"" href=");
            WriteLiteral(@"""#push"">
                            Hàm push() - Đưa phần tử vào ngăn xếp
                        </a>
                    </div>
                    <div id=""push"" class=""collapse"" data-parent=""#accordion1"">
<pre style=""overflow: auto; font-family:Consolas"" class=""card-body"">
<code>
void Push (queue *q, int data){
    if (q->count == MAX)
        printf(""Hang doi day!"");
    else {
        if (q -> rear == MAX - 1)
            q -> rear = 0;
        else
            (q -> rear)++;
        q->array[q->rear] = data;
        q->count++;
    }
    return;
}
</code> 
</pre>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <h3>Bài tập áp dụng cơ bản</h3>
    <div id=""accordion2"">
        <div class=""card"">
            <div class=""card-header"">
                <a class=""card-link"" data-toggle=""collapse"" href=""#Bai2"">
                    Bài 2. Áp dụng các hàm ở <b>Bài 1.</b>, chèn lần lượt các phần tử {3, 5, 9, 1, 12}. In các phần tử");
            WriteLiteral(@" đó ra
                </a>
            </div>
            <div id=""Bai2"" class=""collapse"" data-parent=""#accordion"">
<pre style=""overflow: auto; font-family:Consolas"" class=""card-body"">
<code>
#include <stdbool.h>
#include <stdio.h>
#include <stdlib.h>
#define MAX 10

typedef struct{
    int front, rear, count;
    int array[MAX];
} queue;

//Tao hang doi o trang thai rong:
void Init(queue *q){
    q-> front = 0;
    q-> rear = MAX - 1;
    q-> count = 0;
    return;
}

bool isEmpty(queue q){
    return q.count <= 0;    
}

bool isFull(queue q){
    return q.count == MAX;
}

void Push (queue *q, int data){
    if (q->count == MAX)
        printf(""Hang doi day!"");
    else {
        if (q -> rear == MAX - 1)
            q -> rear = 0;
        else
            (q -> rear)++;
        q->array[q->rear] = data;
        q->count++;
    }
    return;
}

int Pop (queue *q){
    int x;
    if (isEmpty (*q))
        printf(""Hang doi rong!"");
    else{
        x = q -> ");
            WriteLiteral(@"array[q -> front];
        if (q -> front == MAX -1)
            q -> front = 0;
        else
            (q -> front) ++;
        q -> count --;
    }
    return  x;
} 
    

void ShowQueue(queue *q){
    printf(""\n First -"");
    while(!isEmpty(*q)){
        int data = Pop(q);
        printf("" [%d] -"", data);
    }
    printf("" Rear\n"");
}

int main()
{
    queue q;
    Init(&q);
    Push(&q, 3);
    Push(&q, 5);
    Push(&q, 9);
    Push(&q, 1);
    Push(&q, 12);
    ShowQueue(&q);
    
    return 0;
}
</code> 
</pre>
            </div>
        </div>

        <div class=""card"">
            <div class=""card-header"">
                <a class=""card-link"" data-toggle=""collapse"" href=""#Bai3"">
                    Bài 3. Từ <b>bài 2</b>, tiến hành xóa một phần tử sau đó in ra màn hình xem hàng đời sau khi xóa.
                </a>
            </div>
            <div id=""Bai3"" class=""collapse"" data-parent=""#accordion"">
<pre style=""overflow: auto; font-family:Consolas"" ");
            WriteLiteral(@"class=""card-body"">
<code>
#include <stdbool.h>
#include <stdio.h>
#include <stdlib.h>
#define MAX 10

typedef struct{
    int front, rear, count;
    int array[MAX];
} queue;

//Tao hang doi o trang thai rong:
void Init(queue *q){
    q-> front = 0;
    q-> rear = MAX - 1;
    q-> count = 0;
    return;
}

bool isEmpty(queue q){
    return q.count <= 0;    
}

bool isFull(queue q){
    return q.count == MAX;
}

void Push (queue *q, int data){
    if (q->count == MAX)
        printf(""Hang doi day!"");
    else {
        if (q -> rear == MAX - 1)
            q -> rear = 0;
        else
            (q -> rear)++;
        q->array[q->rear] = data;
        q->count++;
    }
    return;
}

int Pop (queue *q){
    int x;
    if (isEmpty (*q))
        printf(""Hang doi rong!"");
    else{
        x = q -> array[q -> front];
        if (q -> front == MAX -1)
            q -> front = 0;
        else
            (q -> front) ++;
        q -> count --;
    }
    return  ");
            WriteLiteral(@"x;
} 
    

void ShowQueue(queue *q){
    printf(""\n First -"");
    while(!isEmpty(*q)){
        int data = Pop(q);
        printf("" [%d] -"", data);
    }
    printf("" Rear\n"");
}

int main()
{
    queue q;
    Init(&q);
    Push(&q, 3);
    Push(&q, 5);
    Push(&q, 9);
    Push(&q, 1);
    Push(&q, 12);

    Pop(&q);
    ShowQueue(&q);
    //Do 3 vào trước nên đã được lấy ra trước đúng theo tính chất của hàng đợi    
    return 0;
}
</code> 
</pre>
            </div>
        </div>

        <div class=""card"">
            <div class=""card-header"">
                <a class=""card-link"" data-toggle=""collapse"" href=""#Bai4"">
                    Bài 4. Từ <b>bài 2</b>, tiến hành áp dụng hàm peak lấy phần tử đầu hàng đợi sau đó in hàng đợi nhận xét sự thay đổi
                </a>
            </div>
            <div id=""Bai4"" class=""collapse"" data-parent=""#accordion"">
<pre style=""overflow: auto; font-family:Consolas"" class=""card-body"">
<code>
#include <stdbool.h>
#include ");
            WriteLiteral(@"<stdio.h>
#include <stdlib.h>
#define MAX 10

typedef struct{
    int front, rear, count;
    int array[MAX];
} queue;

//Tao hang doi o trang thai rong:
void Init(queue *q){
    q-> front = 0;
    q-> rear = MAX - 1;
    q-> count = 0;
    return;
}

bool isEmpty(queue q){
    return q.count <= 0;    
}

bool isFull(queue q){
    return q.count == MAX;
}

void Push (queue *q, int data){
    if (q->count == MAX)
        printf(""Hang doi day!"");
    else {
        if (q -> rear == MAX - 1)
            q -> rear = 0;
        else
            (q -> rear)++;
        q->array[q->rear] = data;
        q->count++;
    }
    return;
}

int Pop (queue *q){
    int x;
    if (isEmpty (*q))
        printf(""Hang doi rong!"");
    else{
        x = q -> array[q -> front];
        if (q -> front == MAX -1)
            q -> front = 0;
        else
            (q -> front) ++;
        q -> count --;
    }
    return  x;
} 
    

void ShowQueue(queue *q){
    printf(""\n F");
            WriteLiteral(@"irst -"");
    while(!isEmpty(*q)){
        int data = Pop(q);
        printf("" [%d] -"", data);
    }
    printf("" Rear\n"");
}

int peak(queue *q){
    return q->array[q->front];
}

int main()
{
    queue q;
    Init(&q);
    Push(&q, 3);
    Push(&q, 5);
    Push(&q, 9);
    Push(&q, 1);
    Push(&q, 12);
    printf (""Lay phan tu [%d] o dau hang doi\n"",peak(&q));
    printf (""Hang doi la:"");
    ShowQueue(&q);
    return 0;
    //Hàm peak chỉ lấy phần tử đầu hàng đợi chứ không xóa đi như hàm Pop().
}




</code> 
</pre>
            </div>
        </div>
    </div>

    <hr />
</div>

<div>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
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
