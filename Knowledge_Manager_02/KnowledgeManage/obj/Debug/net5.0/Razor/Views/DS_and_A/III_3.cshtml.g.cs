#pragma checksum "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\III_3.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72968cc6fd5ceb61dc5ba3564a0ae3462636b73b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DS_and_A_III_3), @"mvc.1.0.view", @"/Views/DS_and_A/III_3.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72968cc6fd5ceb61dc5ba3564a0ae3462636b73b", @"/Views/DS_and_A/III_3.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d8b91396dfbb5c43e5379ee682f129446bb1c6c7", @"/Views/_ViewImports.cshtml")]
    public class Views_DS_and_A_III_3 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Akaiki\source\repos\KnowledgeManage\KnowledgeManage\Views\DS_and_A\III_3.cshtml"
  
    ViewData["Title"] = "III_3";
    Layout = "~/Views/DS_and_A/Menu.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div id=""accordion"" style=""padding-left: 15%; padding-right: 15%; "">
    <h1>BÀI TẬP VỀ DANH SÁCH LIÊN KẾT</h1>
    <p class=""alert-warning"">BẠN CÓ THỂ NHẤN VÀO ĐỂ XEM BÀI GIẢI</p>
    <h3>Bài tập về danh sách liên kết đơn</h3>
    <div id=""don"">
        <div class=""card"">
            <div class=""card-header"">
                <a class=""card-link"" data-toggle=""collapse"" href=""#Bai1"">
                    Bài 1. Tạo danh sách liên kết đơn, chèn giá trị vào đầu danh sách và hiển thị danh sách đó
                </a>
            </div>
            <div id=""Bai1"" class=""collapse container"" data-parent=""#accordion"">
                <br />
                <u><b>Ý tưởng bài toán</b></u>
                <p>1. Khai báo kiểu dữ liệu danh sách</p>
                <p>2. Áp dụng bài học chèn danh sách liên kết đơn để viết một hàm chèn phần tử vào danh sách liên kết đơn.</p>
                <hr />
                <u><b>Bài giải:</b></u>
<pre style=""overflow: auto; font-family:Consolas"" class=""card-body"">
<");
            WriteLiteral(@"code>
#include &lt; stdio.h &gt;
#include &lt; stdlib.h &gt;

struct node{
    int data;
    struct node *next;
};

struct node *head = NULL;
struct node *p = NULL; //Con trỏ p trỏ tới phần tử dữ liệu


//Chèn vào vụ trí đầu tiên
void insert(int data){
    //Tạo một node link
    struct node *link = (struct node*)malloc(sizeof(struct node));
    
    //Truyền dữ liệu vào link
    link->data = data;
    
    //Trỏ next của link đến head của dslk
    link->next = head;
    
    //Head của dslk thành head mới
    head = link;
}
    
//In danh sách liên kết
void printList(){
    struct node *r = head; //r là con trỏ duyệt dslk
    
    printf(""\n[head] -> "");
    while(r != NULL){
        printf("" %d -> "", r->data);
        r = r->next;
    }
    
    printf("" [null]\n"");
}

int main(){
    insert(10);
    insert(20);
    insert(30);
    printList();
    
    return 0;
}

</code> 
</pre>
            </div>
        </div>

        <div class=""card"">
         ");
            WriteLiteral(@"   <div class=""card-header"">
                <a class=""card-link"" data-toggle=""collapse"" href=""#Bai2"">
                    Bài 2. Tìm kích cỡ của danh sách liên kết đơn
                </a>
            </div>
            <div id=""Bai2"" class=""collapse container"" data-parent=""#accordion"">
                <br />
                <u><b>Ý tưởng bài toán</b></u>
                <p>1. Khai báo kiểu dữ liệu danh sách</p>
                <p>2. Cho một con trỏ để trỏ tới từng phần tử từ đầu đến cuối danh sách liên kết.</p>
                <p>3. Duyệt con trỏ từ đầu tới cuối danh sách, mỗi khi duyệt qua một phần tử, biến đếm tăng lên 1.</p>
                <hr />
                <u><b>Bài giải:</b></u>
<pre style=""overflow: auto; font-family:Consolas"" class=""card-body"">
<code>
#include &lt; stdio.h &gt;
#include &lt; stdlib.h &gt;

struct node{
    int data;
    struct node *next;
};

struct node *head = NULL;
struct node *p = NULL; //Con trỏ p trỏ tới phần tử dữ liệu


//Lấy kích thước hiện t");
            WriteLiteral(@"ại của danh sách liên kết đơn
void listSize(){
    int size = 0;
    
    if (head == NULL){
        printf(""Do dai dskl la: %d"", size);
        return;
    }
    
    p = head;
    size = 1;
    while (p->next != NULL){
        p = p->next;
        size ++;
    }
    printf(""Do dai dskl la: %d"", size);
}

//Chèn vào vụ trí đầu tiên
void insert(int data){
    //Tạo một node link
    struct node *link = (struct node*)malloc(sizeof(struct node));
    
    //Truyền dữ liệu vào link
    link->data = data;
    
    //Trỏ next của link đến head của dslk
    link->next = head;
    
    //Head của dslk thành head mới
    head = link;
}



int main(){
    insert(10);
    insert(20);
    insert(30);
    
    listSize();
    return 0;
}

</code> 
</pre>
            </div>
        </div>

        <div class=""card"">
            <div class=""card-header"">
                <a class=""card-link"" data-toggle=""collapse"" href=""#Bai3"">
                    Bài 3. Tìm vị trí của một");
            WriteLiteral(@" giá trị trong danh sách liên kết đơn
                </a>
            </div>
            <div id=""Bai3 "" class=""collapse container"" data-parent=""#accordion"">
                <br />
                <u><b>Ý tưởng bài toán</b></u>
                <p>1. Khai báo kiểu dữ liệu danh sách</p>
                <p>2. Sử dụng một con trỏ trỏ từ đầu đến cuối danh sách.</p>
                <p>3. Khi gặp giá trị cần tìm, xuất vị trí phần tử chứa giá trị đó.</p>
                <hr />
                <u><b>Bài giải:</b></u>
<pre style=""overflow: auto; font-family:Consolas"" class=""card-body"">
<code>
#include &lt; stdio.h &gt;
#include &lt; stdlib.h &gt;

struct node{
    int data;
    struct node *next;
};

struct node *head = NULL;
struct node *p = NULL; //Con trỏ p trỏ tới phần tử dữ liệu

//Chèn vào vụ trí đầu tiên
void insert(int data){
    //Tạo một node link
    struct node *link = (struct node*)malloc(sizeof(struct node));
    
    //Truyền dữ liệu vào link
    link->data = data;
    
 ");
            WriteLiteral(@"   //Trỏ next của link đến head của dslk
    link->next = head;
    
    //Head của dslk thành head mới
    head = link;
}

//Tìm vị trí đầu tiên xuất hiện của data trong danh sách liên kết
void findData(int data){
    int pos = 1;
    
    if(head == NULL){
        printf(""Danh sach chua duoc khoi tao! \n"");
        return;
    }
    
    p = head;
    while(p->next != NULL){
        if(p->data == data){
            printf(""Tim thay %d tai vi tri thu %d\n"", data, pos);
            return;
        }
        p = p->next;
        pos++;
    }
    printf(""%d khong ton tai trong list\n"", data);
} 

int main(){
    findData(10);
    
    insert(10);
    insert(20);
    insert(30);
    
    findData(20);
    findData(28);
    return 0;
}

</code> 
</pre>
            </div>
        </div>
    </div>
    <h3>Bài tập về danh sách liên kết đôi</h3>
    <div id=""doi"">
        <div class=""card"">
            <div class=""card-header"">
                <a class=""card-link"" dat");
            WriteLiteral(@"a-toggle=""collapse"" href=""#Bai4"">
                    Bài 4. Tạo danh sách liên kết đôi, chèn giá trị vào danh sách và xuất kết quả danh sách ra màn hình
                </a>
            </div>
            <div id=""Bai4"" class=""collapse container"" data-parent=""#accordion"">
                <br />
                <u><b>Ý tưởng bài toán</b></u>
                <p>1. Khai báo kiểu dữ liệu danh sách liên kết đôi</p>
                <p>2. Áp dụng bài học chèn danh sách liên kết đôi để viết một hàm chèn phần tử vào danh sách liên kết đơn.</p>
                <hr />
                <u><b>Bài giải:</b></u>
<pre style=""overflow: auto; font-family:Consolas"" class=""card-body"">
<code>
    #include <stdio.h>
#include <stdlib.h>

struct node{
    int data;
    struct node *prev;
    struct node *next;
};

struct node *head = NULL;
struct node *tail = NULL;

struct node *p = NULL; //Con trỏ p trỏ tới phần tử dữ liệu

//Tạo danh sách liên kết
void insert(int data){
    //Cấp phát bộ nhớ cho node m");
            WriteLiteral(@"ới
    struct node *r = (struct node*)malloc(sizeof(struct node));
    
    r->data = data;
    r->prev = NULL;
    r->next = NULL;
    
    if (head == NULL){
        head = r;
        return;
    }
    
    p = head;
    
    p->prev = r;
    head = r;
    r->next = p;
}  

// Hiển thị list
void printList() {
   struct node *q = head;

   printf(""\n[head] <=>"");
   
   //bat dau tu phan dau cua list
   while(q->next != NULL) {        
      printf("" %d <=>"",q->data);
      q = q->next;
   }
   
   printf("" %d <=>"",q->data);
   printf("" [tail]\n"");
}

int main(){
    
    insert(10);
    insert(20);
    insert(30);
    
    printList();
    return 0;
}
</code> 
</pre>
            </div>
        </div>

        <div class=""card"">
            <div class=""card-header"">
                <a class=""card-link"" data-toggle=""collapse"" href=""#Bai5"">
                    Bài 5. Tìm kích cỡ của danh sách liên kết đôi
                </a>
            </div>
           ");
            WriteLiteral(@" <div id=""Bai5"" class=""collapse container"" data-parent=""#accordion"">
                <br />
                <u><b>Ý tưởng bài toán</b></u>
                <p>1. Khai báo kiểu dữ liệu danh sách</p>
                <p>2. Cho một con trỏ để trỏ tới từng phần tử từ đầu đến cuối danh sách liên kết.</p>
                <p>3. Duyệt con trỏ từ đầu tới cuối danh sách, mỗi khi duyệt qua một phần tử, biến đếm tăng lên 1.</p>
                <hr />
                <u><b>Bài giải:</b></u>
<pre style=""overflow: auto; font-family:Consolas"" class=""card-body"">
<code>
    #include <stdio.h>
#include <stdlib.h>

struct node{
    int data;
    struct node *prev;
    struct node *next;
};

struct node *head = NULL;
struct node *tail = NULL;

struct node *p = NULL; //Con trỏ p trỏ tới phần tử dữ liệu

//Tạo danh sách liên kết
void insert(int data){
    //Cấp phát bộ nhớ cho node mới
    struct node *r = (struct node*)malloc(sizeof(struct node));
    
    r->data = data;
    r->prev = NULL;
    r->nex");
            WriteLiteral(@"t = NULL;
    
    if (head == NULL){
        head = r;
        return;
    }
    
    p = head;
    
    p->prev = r;
    head = r;
    r->next = p;
}  

//Tìm kích thước danh sách liên kết đôi hiện tại
void listSize() {
   int size = 0;
   struct node *link;
   
   if(head==NULL) {
      printf(""\nKich co cua danh sach: %d\n"", size);
      return;
   }

   link = head;            
   while(link != NULL) {
      link = link->next;
      size++;
   }

   printf(""\nKich co cua danh sach: %d\n"", size);
}

int main(){
    
    insert(10);
    insert(20);
    insert(30);
    
    listSize();
    return 0;
}
</code> 
</pre>
            </div>
        </div>

        <div class=""card"">
            <div class=""card-header"">
                <a class=""card-link"" data-toggle=""collapse"" href=""#Bai6"">
                    Bài 6. Tìm kiếm vị trí phần tử trong danh sách liên kết đôi
                </a>
            </div>
            <div id=""Bai6"" class=""collapse contain");
            WriteLiteral(@"er"" data-parent=""#accordion"">
                <br />
                <u><b>Ý tưởng bài toán</b></u>
                <p>1. Khai báo kiểu dữ liệu danh sách</p>
                <p>2. Sử dụng một con trỏ trỏ từ đầu đến cuối danh sách.</p>
                <p>3. Khi gặp giá trị cần tìm, xuất vị trí phần tử chứa giá trị đó.</p>
                <hr />
                <u><b>Bài giải:</b></u>
<pre style=""overflow: auto; font-family:Consolas"" class=""card-body"">
<code>
    #include <stdio.h>
#include <stdlib.h>

struct node{
    int data;
    struct node *prev;
    struct node *next;
};

struct node *head = NULL;
struct node *tail = NULL;

struct node *p = NULL; //Con trỏ p trỏ tới phần tử dữ liệu

//Tạo danh sách liên kết
void insert(int data){
    //Cấp phát bộ nhớ cho node mới
    struct node *r = (struct node*)malloc(sizeof(struct node));
    
    r->data = data;
    r->prev = NULL;
    r->next = NULL;
    
    if (head == NULL){
        head = r;
        return;
    }
    
    p");
            WriteLiteral(@" = head;
    
    p->prev = r;
    head = r;
    r->next = p;
}  

//Tìm vị trí đầu tiên xuất hiện phần tử
void search(int data) {
   int pos = 0;
   
   if(head==NULL) {
      printf(""Danh sach lien ket chua duoc khoi tao\n"");
      return;
   } 

   p = head;
   while(p!=NULL) {
      
    if(p->data == data) {
        printf(""Tim thay %d tai vi tri %d\n"", data, pos+1);
        return;
    }
         
    if(p->next != NULL)
        p = p->next;
    else
        break;
    pos++;
   }
      
   printf(""%d khong ton tai trong list\n"", data);
}

int main(){
    search(20);
    
    insert(10);
    insert(20);
    insert(30);
    
    search(20);
    search(28);

    return 0;
}
</code> 
</pre>
            </div>
        </div>
    </div>
    <h3>Bài tập về danh sách liên kết vòng</h3>
    <div id=""vong"">
        <div class=""card"">
            <div class=""card-header"">
                <a class=""card-link"" data-toggle=""collapse"" href=""#Bai7"">
             ");
            WriteLiteral(@"       Bài 7. Tạo danh sách liên kết vòng đơn, hiển thị danh sách liên kết đó
                </a>
            </div>
            <div id=""Bai7"" class=""collapse container"" data-parent=""#accordion"">
                <br />
                <u><b>Ý tưởng bài toán</b></u>
                <p>1. Khai báo kiểu dữ liệu danh sách liên kết đôi</p>
                <p>2. Áp dụng bài học chèn danh sách liên kết đôi để viết một hàm chèn phần tử vào danh sách liên kết đơn.</p>
                <hr />
                <u><b>Bài giải:</b></u>
<pre style=""overflow: auto; font-family:Consolas"" class=""card-body"">
<code>
#include &lt; stdio.h &gt;
#include &lt; stdlib.h &gt;

struct node {
    int data;
    struct node *next;
};

struct node *head = NULL;
struct node *p = NULL;

//Chen tai vi tri dau tien
void insert(int data){
    //cap phat bo nho cho node moi
    struct node *r = (struct node*)malloc(sizeof(struct node));
    
    r->data = data;
    r->next = NULL;
    
    //Neu head la trong, tao");
            WriteLiteral(@" dslk moi
    if(head == NULL){
        head = r;
        head->next = r;
        return;
    }
    
    p = head;
    
    // di chuyen toi phan cuoi list
    while(p->next != head)
        p = p->next;
   
    //chen vao cuoi dslk
    p->next = r;
    
    //lien ket last node voi head
    r->next = head;
}

//hien thi list
void printList(){
    struct node *q = head;
    
    printf(""\n[head] =>"");
   
   //bat dau tu phan dau cua list
   while(q->next != head) {        
      printf("" %d =>"",q->data);
      q = q->next;
   }
   
   printf("" %d =>"",q->data);
   printf("" [head]\n"");
}

int main() {
   insert(10);
   insert(20);
   insert(30);

   printList();
   return 0;
}
</code> 
</pre>
            </div>
        </div>

        <div class=""card"">
            <div class=""card-header"">
                <a class=""card-link"" data-toggle=""collapse"" href=""#Bai8"">
                    Bài 8. Tìm kích cỡ danh sách liên kết vòng
                </a>
           ");
            WriteLiteral(@" </div>
            <div id=""Bai8"" class=""collapse container"" data-parent=""#accordion"">
                <br />
                <u><b>Ý tưởng bài toán</b></u>
                <p>1. Khai báo kiểu dữ liệu danh sách</p>
                <p>2. Cho một con trỏ để trỏ tới từng phần tử từ đầu đến cuối danh sách liên kết.</p>
                <p>3. Duyệt con trỏ từ đầu tới cuối danh sách, mỗi khi duyệt qua một phần tử, biến đếm tăng lên 1.</p>
                <hr />
                <u><b>Bài giải:</b></u>
<pre style=""overflow: auto; font-family:Consolas"" class=""card-body"">
<code>
#include &lt; stdio.h &gt;
#include &lt; stdlib.h &gt; 

struct node {
   int data;
   struct node *next;
};

struct node *head = NULL;
struct node *current = NULL;

//chen link tai vi tri dau tien
void insert(int data) {
   // cap phat bo nho cho node moi;
   struct node *link = (struct node*) malloc(sizeof(struct node));

   link->data = data;
   link->next = NULL;

   // neu head la trong, tao list moi
   if(he");
            WriteLiteral(@"ad==NULL) {
      head = link;
      head->next = link;
      return;
   }

   current = head;
   
   // di chuyen toi phan cuoi list
   while(current->next != head)
      current = current->next;
   
   // chen link vao phan cuoi cua list
   current->next = link;
   
   // lien ket last node voi head
   link->next = head;
   
}

//hien thi list
void list_size(struct node *list) {
   int size = 0;
   
   if(head==NULL) {
      printf(""Kich co list: %d "", size);
      return;
   } 
   
   current = head;
   size = 1;
   
   while(current->next != head) {
      current = current->next;
      size++;
   }
      
   printf(""Kich co list: %d "", size);   
}

int main() {
   insert(10);
   insert(20);
   insert(30);
   
   list_size(head);

   return 0;
}
</code> 
</pre>
            </div>
        </div>

        <div class=""card"">
            <div class=""card-header"">
                <a class=""card-link"" data-toggle=""collapse"" href=""#Bai9"">
                  ");
            WriteLiteral(@"  Bài 9. Xóa một phần tử từ danh sách liên kết vòng
                </a>
            </div>
            <div id=""Bai9"" class=""collapse"" data-parent=""#accordion"">
                <br />
                <u><b>Ý tưởng bài toán</b></u>
                <p>1. Khai báo kiểu dữ liệu danh sách liên kết vòng</p>
                <p>2. Viết một hàm xóa phần tử đầu danh sách</p>
                <p>3. Trả về danh sách liên kết sau khi xóa.</p>
                <hr />
                <u><b>Bài giải:</b></u>
<pre style=""overflow: auto; font-family:Consolas"" class=""card-body"">
<code>
#include &lt; stdio.h &gt;
#include &lt; stdlib.h &gt;

struct node {
   int data;
   struct node *next;
};

struct node *head = NULL;
struct node *current = NULL;
struct node *prev = NULL;

//chen link tai vi tri dau tien
void insert(int data) {
   // cap phat bo nho cho node moi;
   struct node *link = (struct node*) malloc(sizeof(struct node));

   link->data = data;
   link->next = NULL;

   // neu head la tron");
            WriteLiteral(@"g, tao list moi
   if(head==NULL) {
      head = link;
      head->next = link;
      return;
   }

   current = head;
   
   // di chuyen toi phan cuoi list
   while(current->next != head)
      current = current->next;
   
   // chen link vao phan cuoi cua list
   current->next = link;
   
   // lien ket last node voi head
   link->next = head;
   
}

void remove_data(int data) {
   int pos = 0;
   
   if(head==NULL) {
      printf(""Danh sach lien ket chua duoc khoi tao"");
      return;
   } 
    
   if(head->data == data) {
      if(head->next != head) {
         current = head;
         while(current->next!=head) {
            current = current->next;
         }
         current->next = head->next;
         head = head->next;
         return;
      }else {
         head = NULL;
         printf(""List la trong\n"");
         exit(0);
      }
   }else if(head->data != data && head->next == NULL) {
      printf(""Khong tim thay %d trong list\n"", data);
      return;");
            WriteLiteral(@"
   }
        

   current = head;
   
   while(current->next != head && current->data != data) {
      prev = current;
      current = current->next;
   }        

   if(current->data == data) {
      prev->next = prev->next->next;
      free(current);
   }else
      printf(""Khong tim thay %d trong list."", data);
}

//hien thi list
void printList() {
   struct node *ptr = head;

   printf(""\n[head] =>"");
   
   //bat dau tu phan dau cua list
   while(ptr->next != head) {        
      printf("" %d =>"",ptr->data);
      ptr = ptr->next;
   }
   
   printf("" %d =>"",ptr->data);
   printf("" [head]\n"");
}

int main() {
   insert(10);
   insert(20);
   insert(30);
   insert(1);
   insert(40);
   insert(56); 
   
   printf(""List ban dau: "");
   printList();
   remove_data(1);
   
   printf(""List sau khi xoa: "");
   printList();
    
   return 0;
}
</code> 
</pre>
            </div>
        </div>
    </div>
</div>
<div>
    <br />
    <br />
    <br />
    ");
            WriteLiteral("<br />\r\n    <br />\r\n    <br />\r\n</div>\r\n");
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
