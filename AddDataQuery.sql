﻿---ADD to table lesson---------------------------------------------------------------------
INSERT INTO Lesson VALUES('I', N'Cấu trúc dữ liệu')
INSERT INTO Lesson VALUES('I_2', N'Cấu trúc dữ liệu mảng')
INSERT INTO Lesson VALUES('I_2#I_2_2', N'Mảng động')
INSERT INTO Lesson VALUES('I_3', N'Cấu trúc dữ liệu danh sách liên kết')
INSERT INTO Lesson VALUES('I_3#I_3_2', N'Danh sách liên kết đơn')
INSERT INTO Lesson VALUES('I_3#I_3_3', N'Danh sách liên kết đôi')
INSERT INTO Lesson VALUES('I_3#I_3_4', N'Danh sách liên kết vòng')
INSERT INTO Lesson VALUES('I_4', N'Cấu trúc dữ liệu ngăn xếp')
INSERT INTO Lesson VALUES('I_5', N'Cấu trúc dữ liệu hàng đợi')
INSERT INTO Lesson VALUES('I_6', N'Cấu trúc dữ liệu cây')
INSERT INTO Lesson VALUES('I_6_4', N'Cây nhị phân')
INSERT INTO Lesson VALUES('I_6_5', N'Cây Heap')
INSERT INTO Lesson VALUES('I_7', N'Cấu trúc dữ liệu đồ thị')
INSERT INTO Lesson VALUES('I_7_3_1', N'Duyệt theo chiều sâu')
INSERT INTO Lesson VALUES('I_7_3_2', N'Duyệt theo chiều rộng')
----ADD to table Relationship---------------------------------------------------------------------------------
--I CẤU TRÚC DỮ LIỆU 
INSERT INTO Relationship VALUES('I','I_2')
INSERT INTO Relationship VALUES('I','I_3')
INSERT INTO Relationship VALUES('I','I_4')
INSERT INTO Relationship VALUES('I','I_5')
INSERT INTO Relationship VALUES('I','I_6')
INSERT INTO Relationship VALUES('I','I_7')

--I_2 Mảng
INSERT INTO Relationship VALUES('I_2','I')
INSERT INTO Relationship VALUES('I_2','I_2#I_2_2')
INSERT INTO Relationship VALUES('I_2','I_3')
INSERT INTO Relationship VALUES('I_2','I_4')
INSERT INTO Relationship VALUES('I_2','I_5')
INSERT INTO Relationship VALUES('I_2','I_6')
INSERT INTO Relationship VALUES('I_2','I_7')

--I_2_4 Mảng động
INSERT INTO Relationship VALUES('I_2#I_2_2','I')
INSERT INTO Relationship VALUES('I_2#I_2_2','I_2')
INSERT INTO Relationship VALUES('I_2#I_2_2','I_3')
INSERT INTO Relationship VALUES('I_2#I_2_2','I_4')
INSERT INTO Relationship VALUES('I_2#I_2_2','I_5')
INSERT INTO Relationship VALUES('I_2#I_2_2','I_6')
INSERT INTO Relationship VALUES('I_2#I_2_2','I_7')

--I_3 Danh sách liên kết
INSERT INTO Relationship VALUES('I_3','I')
INSERT INTO Relationship VALUES('I_3','I_3#I_3_2') --DSLK Đơn
INSERT INTO Relationship VALUES('I_3','I_3#I_3_3') --DSLK Đôi
INSERT INTO Relationship VALUES('I_3','I_3#I_3_4') --DSLK Vòng
INSERT INTO Relationship VALUES('I_3','I_4')
INSERT INTO Relationship VALUES('I_3','I_5')
INSERT INTO Relationship VALUES('I_3','I_6')
INSERT INTO Relationship VALUES('I_3','I_7')
--I_3_2 -DSLK Đơn
INSERT INTO Relationship VALUES('I_3#I_3_2','I')
INSERT INTO Relationship VALUES('I_3#I_3_2','I_3')
INSERT INTO Relationship VALUES('I_3#I_3_2','I_3#I_3_3')
INSERT INTO Relationship VALUES('I_3#I_3_2','I_3#I_3_4')
INSERT INTO Relationship VALUES('I_3#I_3_2','I_2')
INSERT INTO Relationship VALUES('I_3#I_3_2','I_4')
INSERT INTO Relationship VALUES('I_3#I_3_2','I_5')
INSERT INTO Relationship VALUES('I_3#I_3_2','I_6')
INSERT INTO Relationship VALUES('I_3#I_3_2','I_7')
--I_3_3 -DSLK Đôi
INSERT INTO Relationship VALUES('I_3#I_3_3','I')
INSERT INTO Relationship VALUES('I_3#I_3_3','I_3')
INSERT INTO Relationship VALUES('I_3#I_3_3','I_3#I_3_2')
INSERT INTO Relationship VALUES('I_3#I_3_3','I_3#I_3_4')
INSERT INTO Relationship VALUES('I_3#I_3_3','I_2')
INSERT INTO Relationship VALUES('I_3#I_3_3','I_4')
INSERT INTO Relationship VALUES('I_3#I_3_3','I_5')
INSERT INTO Relationship VALUES('I_3#I_3_3','I_6')
INSERT INTO Relationship VALUES('I_3#I_3_3','I_7')
--I_3_4 -DSLK Vòng
INSERT INTO Relationship VALUES('I_3#I_3_4','I')
INSERT INTO Relationship VALUES('I_3#I_3_4','I_3')
INSERT INTO Relationship VALUES('I_3#I_3_4','I_3#I_3_2')
INSERT INTO Relationship VALUES('I_3#I_3_4','I_3#I_3_3')
INSERT INTO Relationship VALUES('I_3#I_3_4','I_2')
INSERT INTO Relationship VALUES('I_3#I_3_4','I_4')
INSERT INTO Relationship VALUES('I_3#I_3_4','I_5')
INSERT INTO Relationship VALUES('I_3#I_3_4','I_6')
INSERT INTO Relationship VALUES('I_3#I_3_4','I_7')

--I_4 Ngăn xếp
INSERT INTO Relationship VALUES('I_4','I')
INSERT INTO Relationship VALUES('I_4','I_2') --Ngăn xếp biểu diễn bằng mảng
INSERT INTO Relationship VALUES('I_4','I_3') --Ngăn xếp biểu diễn bằng DSLK
INSERT INTO Relationship VALUES('I_4','I_5')
INSERT INTO Relationship VALUES('I_4','I_6')
INSERT INTO Relationship VALUES('I_4','I_7')

--I_5 Hàng đợi
INSERT INTO Relationship VALUES('I_5','I')
INSERT INTO Relationship VALUES('I_5','I_2') --Hàng đợi biểu diễn bằng mảng
INSERT INTO Relationship VALUES('I_5','I_3') --Hàng đợi biểu diễn bằng DSLK
INSERT INTO Relationship VALUES('I_5','I_4')
INSERT INTO Relationship VALUES('I_5','I_6')
INSERT INTO Relationship VALUES('I_5','I_7')

--I_6 Cây
INSERT INTO Relationship VALUES('I_6','I')
INSERT INTO Relationship VALUES('I_6','I_3')
INSERT INTO Relationship VALUES('I_6','I_4')
INSERT INTO Relationship VALUES('I_6','I_5')
INSERT INTO Relationship VALUES('I_6','I_2')
INSERT INTO Relationship VALUES('I_6','I_7')
INSERT INTO Relationship VALUES('I_6','I_6_4') --Cây nhị phân
INSERT INTO Relationship VALUES('I_6','I_6_5') --Cây Heap

--I_6_4 Cây nhị phân
INSERT INTO Relationship VALUES('I_6_4','I_6_5')
INSERT INTO Relationship VALUES('I_6_4','I_6')
INSERT INTO Relationship VALUES('I_6_4','I')
INSERT INTO Relationship VALUES('I_6_4','I_3')
INSERT INTO Relationship VALUES('I_6_4','I_4')
INSERT INTO Relationship VALUES('I_6_4','I_5')
INSERT INTO Relationship VALUES('I_6_4','I_2')
INSERT INTO Relationship VALUES('I_6_4','I_7')

--I_6_5 Cây heap
INSERT INTO Relationship VALUES('I_6_5','I_6_4') 
INSERT INTO Relationship VALUES('I_6_5','I_6')
INSERT INTO Relationship VALUES('I_6_5','I')
INSERT INTO Relationship VALUES('I_6_5','I_3')
INSERT INTO Relationship VALUES('I_6_5','I_4')
INSERT INTO Relationship VALUES('I_6_5','I_5')
INSERT INTO Relationship VALUES('I_6_5','I_2')
INSERT INTO Relationship VALUES('I_6_5','I_7')

--I_7
INSERT INTO Relationship VALUES('I_7','I')
INSERT INTO Relationship VALUES('I_7','I_3')
INSERT INTO Relationship VALUES('I_7','I_4')
INSERT INTO Relationship VALUES('I_7','I_2')
INSERT INTO Relationship VALUES('I_7','I_6')
INSERT INTO Relationship VALUES('I_7','I_2')
--I_7_3_1
INSERT INTO Relationship VALUES('I_7_3_1','I_7')
INSERT INTO Relationship VALUES('I_7_3_1','I_7_3_2')
--I_7_3_2
INSERT INTO Relationship VALUES('I_7_3_2','I_7')
INSERT INTO Relationship VALUES('I_7_3_2','I_7_3_1')

----ADD to table Concept 
INSERT INTO Concept VALUES('I#I_1',N'Khái niệm cấu trúc dữ liệu','I')
INSERT INTO Concept VALUES('I_2#I_2_1',N'Khái niệm cấu trúc dữ liệu mảng','I_2')
INSERT INTO Concept VALUES('I_2#I_2_2_1',N'Khái niệm cấu trúc dữ liệu mảng động','I_2#I_2_2')
INSERT INTO Concept VALUES('I_3#I_3_1',N'Khái niệm cấu trúc dữ liệu danh sách liên kết','I_3')
INSERT INTO Concept VALUES('I_4#I_4_1',N'Khái niệm cấu trúc dữ liệu ngăn xếp','I_4')
INSERT INTO Concept VALUES('I_5#I_5_1',N'Khái niệm cấu trúc dữ liệu hàng đợi','I_5')
INSERT INTO Concept VALUES('I_6#I_6_1',N'Khái niệm cấu trúc dữ liệu cây','I_6')
INSERT INTO Concept VALUES('I_6_4#I_6_4_1',N'Khái niệm cấu trúc dữ liệu cây nhị phân','I_6_4')
INSERT INTO Concept VALUES('I_6_5#I_6_5_1',N'Khái niệm cấu trúc dữ liệu cây Heap','I_6_5')
INSERT INTO Concept VALUES('I_7#I_7_1',N'Khái niệm cấu trúc dữ liệu đồ thị','I_7')
INSERT INTO Concept VALUES('I_7_3_1#I_7_3_1_a',N'Khái niệm tìm kiếm theo chiều sâu','I_7_3_1')
INSERT INTO Concept VALUES('I_7_3_1#I_7_3_2_a',N'Khái niệm tìm kiếm theo chiều rộng','I_7_3_2')


----ADD to table Construct
INSERT INTO Construct VALUES('I_2#I_2_3', N'Biểu diễn cấu trúc mảng', 'I_2')
INSERT INTO Construct VALUES('I_2#I_2_2_2', N'Biểu diễn cấu trúc mảng động', 'I_2#I_2_2')
INSERT INTO Construct VALUES('I_3#I_3_2_1', N'Biểu diễn danh sách liên kết đơn', 'I_3#I_3_2')
INSERT INTO Construct VALUES('I_3#I_3_3_1', N'Biểu diễn danh sách liên kết đôi', 'I_3#I_3_3')
INSERT INTO Construct VALUES('I_3#I_3_4_1', N'Biểu diễn danh sách liên kết vòng', 'I_3#I_3_4')
INSERT INTO Construct VALUES('I_4#I_4_2', N'Biểu diễn cấu trúc dữ liệu ngăn xếp', 'I_4')
INSERT INTO Construct VALUES('I_5#I_5_2', N'Biểu diễn cấu trúc dữ liệu hàng đợi', 'I_5')
INSERT INTO Construct VALUES('I_6#I_6_2', N'Biểu diễn cấu trúc dữ liệu cây', 'I_6')
INSERT INTO Construct VALUES('I_6_4#I_6_4_2', N'Biểu diễn cây Nhị phân', 'I_6_4')
INSERT INTO Construct VALUES('I_6_5#I_6_5_2', N'Biểu diễn cây Heap', 'I_6_5')
INSERT INTO Construct VALUES('I_7#I_7_2',N'Biểu diễn đồ thị','I_7')
INSERT INTO Construct VALUES('I_7_3_1#I_7_3_1_b', N'Các bước duyệt trong tìm kiếm theo chiều sâu', 'I_7_3_1')
INSERT INTO Construct VALUES('I_7_3_2#I_7_3_2_b', N'Các bước duyệt trong tìm kiếm theo chiều rộng', 'I_7_3_2')


---ADD Operator
INSERT INTO Operator VALUES('I_2#I_2_4',N'Phép toán thực hiện trên mảng','I_2')
INSERT INTO Operator VALUES('I_3#I_3_2_2',N'Hoạt động trên danh sách liên kết đơn','I_3#I_3_2')
INSERT INTO Operator VALUES('I_3#I_3_3_2',N'Hoạt động trên danh sách liên kết đôi','I_3#I_3_3')
INSERT INTO Operator VALUES('I_3#I_3_4_2',N'Hoạt động trên danh sách liên kết vòng','I_3#I_3_4')
INSERT INTO Operator VALUES('I_4#I_4_3',N'Hoạt động trên cấu trúc dữ liệu ngăn xếp','I_4')
INSERT INTO Operator VALUES('I_5#I_5_3',N'Hoạt động trên cấu trúc dữ liệu hàng đợi','I_5')
INSERT INTO Operator VALUES('I_6#I_6_2',N'Duyệt cây','I_6')
INSERT INTO Operator VALUES('I_6_4#I_6_4_3',N'Hoạt động trên cây nhị phân','I_6_4')
INSERT INTO Operator VALUES('I_6_5#I_6_5_3',N'Hoạt động trên cây Heap','I_6_5')

--Add Exercise
INSERT INTO Exercise VALUES('III_1',N'Bài tập về mảng','I_2')
INSERT INTO Exercise VALUES('III_2',N'Bài tập về mảng động','I_2#I_2_2')
INSERT INTO Exercise VALUES('III_3',N'Bài tập về danh sách liên kết','I_3')
INSERT INTO Exercise VALUES('III_4',N'Bài tập về ngăn xếp','I_4')
INSERT INTO Exercise VALUES('III_5',N'Bài tập về hàng đợi','I_5')
INSERT INTO Exercise VALUES('III_6',N'Bài tập về cây nhị phân','I_6_4')
INSERT INTO Exercise VALUES('III_8',N'Bài tập về cây heap','I_6_5')
INSERT INTO Exercise VALUES('III_9',N'Bài tập về đồ thị','I_7')


