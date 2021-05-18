--create database LessonKnowledge

--use LessonKnowledge

--drop table Concept
--drop table Construct
--drop table Property
--drop table Exercise
--drop table Operator
--drop table Relationship
--drop table Lesson

----------------------------------------------------------------------------------------------------------

--CREATE TABLE [dbo].[Lesson] (
--    [Id_Lesson]    NVARCHAR (450) NOT NULL,
--    [Name_Lesson]  NVARCHAR (MAX) NULL,
--    CONSTRAINT [PK_Lesson] PRIMARY KEY CLUSTERED ([Id_Lesson] ASC)
--);


----------------------------------------------------------------------------------------------------------------------------

--CREATE TABLE [dbo].[Relationship] (
--    [Id_Relationship] INT         IDENTITY (1, 1) NOT NULL,
--    [Id_Lesson_A]     NVARCHAR (450) NULL,
--    [Id_Lesson_B]     NVARCHAR (450) NULL,
--    CONSTRAINT [PK_Relationship] PRIMARY KEY CLUSTERED ([Id_Relationship] ASC),
--    CONSTRAINT [FK_Relationship_Lesson_Id_Lesson_A] FOREIGN KEY ([Id_Lesson_A]) REFERENCES [dbo].[Lesson] ([Id_Lesson]),
--    CONSTRAINT [FK_Relationship_Lesson_Id_Lesson_B] FOREIGN KEY ([Id_Lesson_B]) REFERENCES [dbo].[Lesson] ([Id_Lesson])
--);


--GO
--CREATE NONCLUSTERED INDEX [IX_Relationship_Id_Lesson_A]
--    ON [dbo].[Relationship]([Id_Lesson_A] ASC);


--GO
--CREATE NONCLUSTERED INDEX [IX_Relationship_Id_Lesson_B]
--    ON [dbo].[Relationship]([Id_Lesson_B] ASC);

-----------------------------------------------------------------------------------------------------------


--CREATE TABLE [dbo].[Exercise] (
--    [Id_Exercise]     INT            IDENTITY (1, 1) NOT NULL,
--    [Link_Exercise]   NVARCHAR (MAX) NULL,
--    [Name_Exercise]   NVARCHAR (MAX) NULL,
--    [LessonId_Lesson] NVARCHAR (450) NULL,
--    CONSTRAINT [PK_Exercise] PRIMARY KEY CLUSTERED ([Id_Exercise] ASC),
--    CONSTRAINT [FK_Exercise_Lesson_LessonId_Lesson] FOREIGN KEY ([LessonId_Lesson]) REFERENCES [dbo].[Lesson] ([Id_Lesson])
--);


--GO
--CREATE NONCLUSTERED INDEX [IX_Exercise_LessonId_Lesson]
--    ON [dbo].[Exercise]([LessonId_Lesson] ASC);

-----------------------------------------------------------------------------------------------------------
--CREATE TABLE [dbo].[Operator] (
--    [Id_Operator]     INT            IDENTITY (1, 1) NOT NULL,
--    [Link_Operator]   NVARCHAR (MAX) NULL,
--    [Name_Operator]   NVARCHAR (MAX) NULL,
--    [LessonId_Lesson] NVARCHAR (450) NULL,
--    CONSTRAINT [PK_Operator] PRIMARY KEY CLUSTERED ([Id_Operator] ASC),
--    CONSTRAINT [FK_Operator_Lesson_LessonId_Lesson] FOREIGN KEY ([LessonId_Lesson]) REFERENCES [dbo].[Lesson] ([Id_Lesson])
--);


--GO
--CREATE NONCLUSTERED INDEX [IX_Operator_LessonId_Lesson]
--    ON [dbo].[Operator]([LessonId_Lesson] ASC);


--------------------------------------------------------------------------------------------------------------

--CREATE TABLE [dbo].[Concept] ( --khai niem
--    [Id_Concept]     INT            IDENTITY (1, 1) NOT NULL,
--    [Link_Concept]   NVARCHAR (MAX) NULL,
--    [Name_Concept]   NVARCHAR (MAX) NULL,
--    [LessonId_Lesson] NVARCHAR (450) NULL,
--    CONSTRAINT [PK_Concept] PRIMARY KEY CLUSTERED ([Id_Concept] ASC),
--    CONSTRAINT [FK_Concept_Lesson_LessonId_Lesson] FOREIGN KEY ([LessonId_Lesson]) REFERENCES [dbo].[Lesson] ([Id_Lesson])
--);


--GO
--CREATE NONCLUSTERED INDEX [IX_Concept_LessonId_Lesson]
--    ON [dbo].[Concept]([LessonId_Lesson] ASC);


-----------------------------------------------------------------------------------------------------
--CREATE TABLE [dbo].[Construct] (
--    [Id_Construct]     INT            IDENTITY (1, 1) NOT NULL,
--    [Link_Construct]   NVARCHAR (MAX) NULL,
--    [Name_Construct]   NVARCHAR (MAX) NULL,
--    [LessonId_Lesson] NVARCHAR (450) NULL,
--    CONSTRAINT [PK_Construct] PRIMARY KEY CLUSTERED ([Id_Construct] ASC),
--    CONSTRAINT [FK_Construct_Lesson_LessonId_Lesson] FOREIGN KEY ([LessonId_Lesson]) REFERENCES [dbo].[Lesson] ([Id_Lesson])
--);


--GO
--CREATE NONCLUSTERED INDEX [IX_Construct_LessonId_Lesson]
--    ON [dbo].[Construct]([LessonId_Lesson] ASC);


----------------------------------------------------------------------------------------------

--CREATE TABLE [dbo].[Property] (
--    [Id_Property]     INT            IDENTITY (1, 1) NOT NULL,
--    [Link_Property]   NVARCHAR (MAX) NULL,
--    [Name_Property]   NVARCHAR (MAX) NULL,
--    [LessonId_Lesson] NVARCHAR (450) NULL,
--    CONSTRAINT [PK_Property] PRIMARY KEY CLUSTERED ([Id_Property] ASC),
--    CONSTRAINT [FK_Property_Lesson_LessonId_Lesson] FOREIGN KEY ([LessonId_Lesson]) REFERENCES [dbo].[Lesson] ([Id_Lesson])
--);


--GO
--CREATE NONCLUSTERED INDEX [IX_Property_LessonId_Lesson]
--    ON [dbo].[Property]([LessonId_Lesson] ASC);
---------------------------------------------------------------------------
--delete from Concept
--delete from Construct
--delete from Exercise
--delete from Operator
--delete from Property
--delete from Relationship
--delete from Lesson
-------------------------------------------------------------------------------------
---ADD to table lesson---------------------------------------------------------------------
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
INSERT INTO Lesson VALUES('I_7_3_1', N'Tìm kiếm theo chiều sâu')
INSERT INTO Lesson VALUES('I_7_3_2', N'Tìm kiếm theo chiều rộng')

--INSERT INTO Lesson VALUES('II', N'Giải thuật')
--INSERT INTO Lesson VALUES('II_2', N'Độ phức tạp của thuật toán')
--INSERT INTO Lesson VALUES('II_3', N'Giải thuật tìm kiếm')
--INSERT INTO Lesson VALUES('II_3_1', N'Tìm kiếm nội suy')
--INSERT INTO Lesson VALUES('II_3_2', N'Tìm kiếm tuyến tính')
--INSERT INTO Lesson VALUES('II_3_3', N'Tìm kiếm nhị phân')
--INSERT INTO Lesson VALUES('II_3_4', N'Tìm kiếm bằng bảng băm')
--INSERT INTO Lesson VALUES('II_4', N'Giải thuật sắp xếp')
--INSERT INTO Lesson VALUES('II_4_1', N'Sắp xếp nghịch thể')
--INSERT INTO Lesson VALUES('II_4_2', N'Sắp xếp nổi bọt')
--INSERT INTO Lesson VALUES('II_4_3', N'Sắp xếp chèn')
--INSERT INTO Lesson VALUES('II_4_4', N'Sắp xếp chọn')
--INSERT INTO Lesson VALUES('II_4_5', N'Sắp xếp nhanh')
--INSERT INTO Lesson VALUES('II_4_6', N'Sắp xếp vun đống')
--INSERT INTO Lesson VALUES('II_5', N'Giải thuật tham lam')
--INSERT INTO Lesson VALUES('II_6', N'Giải thuật chia để trị')
--INSERT INTO Lesson VALUES('II_7', N'Giải thuật quy hoạch động')
--INSERT INTO Lesson VALUES('II_8', N'Giải thuật quay lui')
--INSERT INTO Lesson VALUES('II_9', N'Giải thuật đệ quy')


----ADD to table Relationship---------------------------------------------------------------------------------
--I CẤU TRÚC DỮ LIỆU 
INSERT INTO Relationship VALUES('I','I_2')
INSERT INTO Relationship VALUES('I','I_3')
INSERT INTO Relationship VALUES('I','I_4')
INSERT INTO Relationship VALUES('I','I_5')
INSERT INTO Relationship VALUES('I','I_6')
INSERT INTO Relationship VALUES('I','I_7')
--INSERT INTO Relationship VALUES('I','II')
----II GIẢI THUẬT 
--INSERT INTO Relationship VALUES('II','II_2')
--INSERT INTO Relationship VALUES('II','II_3')
--INSERT INTO Relationship VALUES('II','II_4')
--INSERT INTO Relationship VALUES('II','II_5')
--INSERT INTO Relationship VALUES('II','II_6')
--INSERT INTO Relationship VALUES('II','II_7')
--INSERT INTO Relationship VALUES('II','II_8')
--INSERT INTO Relationship VALUES('II','II_9')
--INSERT INTO Relationship VALUES('II','I')
--I_2
INSERT INTO Relationship VALUES('I_2','I')
INSERT INTO Relationship VALUES('I_2','I_2#I_2_2')
INSERT INTO Relationship VALUES('I_2','I_3')
INSERT INTO Relationship VALUES('I_2','I_4')
INSERT INTO Relationship VALUES('I_2','I_5')
INSERT INTO Relationship VALUES('I_2','I_6')
INSERT INTO Relationship VALUES('I_2','I_7')
--I_2_4
INSERT INTO Relationship VALUES('I_2#I_2_2','I')
INSERT INTO Relationship VALUES('I_2#I_2_2','I_2')
INSERT INTO Relationship VALUES('I_2#I_2_2','I_3')
INSERT INTO Relationship VALUES('I_2#I_2_2','I_4')
INSERT INTO Relationship VALUES('I_2#I_2_2','I_5')
INSERT INTO Relationship VALUES('I_2#I_2_2','I_6')
INSERT INTO Relationship VALUES('I_2#I_2_2','I_7')
--I_3
INSERT INTO Relationship VALUES('I_3','I')
INSERT INTO Relationship VALUES('I_3','I_3#I_3_2')
INSERT INTO Relationship VALUES('I_3','I_3#I_3_3')
INSERT INTO Relationship VALUES('I_3','I_3#I_3_4')
INSERT INTO Relationship VALUES('I_3','I_4')
INSERT INTO Relationship VALUES('I_3','I_5')
INSERT INTO Relationship VALUES('I_3','I_6')
INSERT INTO Relationship VALUES('I_3','I_7')
--I_3_2
INSERT INTO Relationship VALUES('I_3#I_3_2','I')
INSERT INTO Relationship VALUES('I_3#I_3_2','I_3')
INSERT INTO Relationship VALUES('I_3#I_3_2','I_3#I_3_3')
INSERT INTO Relationship VALUES('I_3#I_3_2','I_3#I_3_4')
INSERT INTO Relationship VALUES('I_3#I_3_2','I_2')
INSERT INTO Relationship VALUES('I_3#I_3_2','I_4')
INSERT INTO Relationship VALUES('I_3#I_3_2','I_5')
INSERT INTO Relationship VALUES('I_3#I_3_2','I_6')
INSERT INTO Relationship VALUES('I_3#I_3_2','I_7')
--I_3_3
INSERT INTO Relationship VALUES('I_3#I_3_3','I')
INSERT INTO Relationship VALUES('I_3#I_3_3','I_3')
INSERT INTO Relationship VALUES('I_3#I_3_3','I_3#I_3_2')
INSERT INTO Relationship VALUES('I_3#I_3_3','I_3#I_3_4')
INSERT INTO Relationship VALUES('I_3#I_3_3','I_2')
INSERT INTO Relationship VALUES('I_3#I_3_3','I_4')
INSERT INTO Relationship VALUES('I_3#I_3_3','I_5')
INSERT INTO Relationship VALUES('I_3#I_3_3','I_6')
INSERT INTO Relationship VALUES('I_3#I_3_3','I_7')
--I_3_4
INSERT INTO Relationship VALUES('I_3#I_3_4','I')
INSERT INTO Relationship VALUES('I_3#I_3_4','I_3')
INSERT INTO Relationship VALUES('I_3#I_3_4','I_3#I_3_2')
INSERT INTO Relationship VALUES('I_3#I_3_4','I_3#I_3_3')
INSERT INTO Relationship VALUES('I_3#I_3_4','I_2')
INSERT INTO Relationship VALUES('I_3#I_3_4','I_4')
INSERT INTO Relationship VALUES('I_3#I_3_4','I_5')
INSERT INTO Relationship VALUES('I_3#I_3_4','I_6')
INSERT INTO Relationship VALUES('I_3#I_3_4','I_7')
--I_4
INSERT INTO Relationship VALUES('I_4','I')
INSERT INTO Relationship VALUES('I_4','I_2')
INSERT INTO Relationship VALUES('I_4','I_3')
INSERT INTO Relationship VALUES('I_4','I_5')
INSERT INTO Relationship VALUES('I_4','I_6')
INSERT INTO Relationship VALUES('I_4','I_7')
--I_5
INSERT INTO Relationship VALUES('I_5','I')
INSERT INTO Relationship VALUES('I_5','I_3')
INSERT INTO Relationship VALUES('I_5','I_4')
INSERT INTO Relationship VALUES('I_5','I_2')
INSERT INTO Relationship VALUES('I_5','I_6')
INSERT INTO Relationship VALUES('I_5','I_7')
--I_6
INSERT INTO Relationship VALUES('I_6','I')
INSERT INTO Relationship VALUES('I_6','I_3')
INSERT INTO Relationship VALUES('I_6','I_4')
INSERT INTO Relationship VALUES('I_6','I_5')
INSERT INTO Relationship VALUES('I_6','I_2')
INSERT INTO Relationship VALUES('I_6','I_7')
INSERT INTO Relationship VALUES('I_6','I_6_4')
INSERT INTO Relationship VALUES('I_6','I_6_5')

--I_6_4
INSERT INTO Relationship VALUES('I_6_4','I_6_5')
INSERT INTO Relationship VALUES('I_6_4','I_6')
INSERT INTO Relationship VALUES('I_6_4','I')
INSERT INTO Relationship VALUES('I_6_4','I_3')
INSERT INTO Relationship VALUES('I_6_4','I_4')
INSERT INTO Relationship VALUES('I_6_4','I_5')
INSERT INTO Relationship VALUES('I_6_4','I_2')
INSERT INTO Relationship VALUES('I_6_4','I_7')
--INSERT INTO Relationship VALUES('I_6_4','II_3_3')
--I_6_5
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
--II_2
--INSERT INTO Relationship VALUES('II_2','II')
----II_3
--INSERT INTO Relationship VALUES('II_3','II_3_1')
--INSERT INTO Relationship VALUES('II_3','II_3_2')
--INSERT INTO Relationship VALUES('II_3','II_3_3')
--INSERT INTO Relationship VALUES('II_3','II_3_4')
--INSERT INTO Relationship VALUES('II_3','II')
--INSERT INTO Relationship VALUES('II_3','II_2')
--INSERT INTO Relationship VALUES('II_3','II_4')
--INSERT INTO Relationship VALUES('II_3','II_5')
--INSERT INTO Relationship VALUES('II_3','II_6')
--INSERT INTO Relationship VALUES('II_3','II_7')
--INSERT INTO Relationship VALUES('II_3','II_8')
--INSERT INTO Relationship VALUES('II_3','II_9')
----II_3_1
--INSERT INTO Relationship VALUES('II_3_1','II')
--INSERT INTO Relationship VALUES('II_3_1','II_2')
--INSERT INTO Relationship VALUES('II_3_1','II_3')
--INSERT INTO Relationship VALUES('II_3_1','II_3_2')
--INSERT INTO Relationship VALUES('II_3_1','II_3_3')
--INSERT INTO Relationship VALUES('II_3_1','II_3_4')
--INSERT INTO Relationship VALUES('II_3_1','II_4')
--INSERT INTO Relationship VALUES('II_3_1','II_5')
--INSERT INTO Relationship VALUES('II_3_1','II_6')
--INSERT INTO Relationship VALUES('II_3_1','II_7')
--INSERT INTO Relationship VALUES('II_3_1','II_8')
--INSERT INTO Relationship VALUES('II_3_1','II_9')
----II_3_2
--INSERT INTO Relationship VALUES('II_3_2','II')
--INSERT INTO Relationship VALUES('II_3_2','II_2')
--INSERT INTO Relationship VALUES('II_3_2','II_3')
--INSERT INTO Relationship VALUES('II_3_2','II_3_1')
--INSERT INTO Relationship VALUES('II_3_2','II_3_3')
--INSERT INTO Relationship VALUES('II_3_2','II_3_4')
--INSERT INTO Relationship VALUES('II_3_2','II_4')
--INSERT INTO Relationship VALUES('II_3_2','II_5')
--INSERT INTO Relationship VALUES('II_3_2','II_6')
--INSERT INTO Relationship VALUES('II_3_2','II_7')
--INSERT INTO Relationship VALUES('II_3_2','II_8')
--INSERT INTO Relationship VALUES('II_3_2','II_9')
----II_3_3
--INSERT INTO Relationship VALUES('II_3_3','II')
--INSERT INTO Relationship VALUES('II_3_3','II_2')
--INSERT INTO Relationship VALUES('II_3_3','II_3')
--INSERT INTO Relationship VALUES('II_3_3','II_3_1')
--INSERT INTO Relationship VALUES('II_3_3','II_3_2')
--INSERT INTO Relationship VALUES('II_3_3','II_3_4')
--INSERT INTO Relationship VALUES('II_3_3','II_4')
--INSERT INTO Relationship VALUES('II_3_3','II_5')
--INSERT INTO Relationship VALUES('II_3_3','II_6')
--INSERT INTO Relationship VALUES('II_3_3','II_7')
--INSERT INTO Relationship VALUES('II_3_3','II_8')
--INSERT INTO Relationship VALUES('II_3_3','II_9')
----II_3_4
--INSERT INTO Relationship VALUES('II_3_4','II')
--INSERT INTO Relationship VALUES('II_3_4','II_2')
--INSERT INTO Relationship VALUES('II_3_4','II_3')
--INSERT INTO Relationship VALUES('II_3_4','II_3_1')
--INSERT INTO Relationship VALUES('II_3_4','II_3_2')
--INSERT INTO Relationship VALUES('II_3_4','II_3_3')
--INSERT INTO Relationship VALUES('II_3_4','II_4')
--INSERT INTO Relationship VALUES('II_3_4','II_5')
--INSERT INTO Relationship VALUES('II_3_4','II_6')
--INSERT INTO Relationship VALUES('II_3_4','II_7')
--INSERT INTO Relationship VALUES('II_3_4','II_8')
--INSERT INTO Relationship VALUES('II_3_4','II_9')
----II_4
--INSERT INTO Relationship VALUES('II_4','II')
--INSERT INTO Relationship VALUES('II_4','II_2')
--INSERT INTO Relationship VALUES('II_4','II_3')
--INSERT INTO Relationship VALUES('II_4','II_4_1')
--INSERT INTO Relationship VALUES('II_4','II_4_2')
--INSERT INTO Relationship VALUES('II_4','II_4_3')
--INSERT INTO Relationship VALUES('II_4','II_4_4')
--INSERT INTO Relationship VALUES('II_4','II_4_5')
--INSERT INTO Relationship VALUES('II_4','II_4_6')
--INSERT INTO Relationship VALUES('II_4','II_5')
--INSERT INTO Relationship VALUES('II_4','II_6')
--INSERT INTO Relationship VALUES('II_4','II_7')
--INSERT INTO Relationship VALUES('II_4','II_8')
--INSERT INTO Relationship VALUES('II_4','II_9')
----II_4_1
--INSERT INTO Relationship VALUES('II_4_1','II')
--INSERT INTO Relationship VALUES('II_4_1','II_2')
--INSERT INTO Relationship VALUES('II_4_1','II_3')
--INSERT INTO Relationship VALUES('II_4_1','II_4_2')
--INSERT INTO Relationship VALUES('II_4_1','II_4_3')
--INSERT INTO Relationship VALUES('II_4_1','II_4_4')
--INSERT INTO Relationship VALUES('II_4_1','II_4_5')
--INSERT INTO Relationship VALUES('II_4_1','II_4_6')
--INSERT INTO Relationship VALUES('II_4_1','II_5')
--INSERT INTO Relationship VALUES('II_4_1','II_6')
--INSERT INTO Relationship VALUES('II_4_1','II_7')
--INSERT INTO Relationship VALUES('II_4_1','II_8')
--INSERT INTO Relationship VALUES('II_4_1','II_9')
----II_4_2
--INSERT INTO Relationship VALUES('II_4_2','II')
--INSERT INTO Relationship VALUES('II_4_2','II_2')
--INSERT INTO Relationship VALUES('II_4_2','II_3')
--INSERT INTO Relationship VALUES('II_4_2','II_4_1')
--INSERT INTO Relationship VALUES('II_4_2','II_4_3')
--INSERT INTO Relationship VALUES('II_4_2','II_4_4')
--INSERT INTO Relationship VALUES('II_4_2','II_4_5')
--INSERT INTO Relationship VALUES('II_4_2','II_4_6')
--INSERT INTO Relationship VALUES('II_4_2','II_5')
--INSERT INTO Relationship VALUES('II_4_2','II_6')
--INSERT INTO Relationship VALUES('II_4_2','II_7')
--INSERT INTO Relationship VALUES('II_4_2','II_8')
--INSERT INTO Relationship VALUES('II_4_2','II_9')
----II_4_3
--INSERT INTO Relationship VALUES('II_4_3','II')
--INSERT INTO Relationship VALUES('II_4_3','II_2')
--INSERT INTO Relationship VALUES('II_4_3','II_3')
--INSERT INTO Relationship VALUES('II_4_3','II_4_1')
--INSERT INTO Relationship VALUES('II_4_3','II_4_2')
--INSERT INTO Relationship VALUES('II_4_3','II_4_4')
--INSERT INTO Relationship VALUES('II_4_3','II_4_5')
--INSERT INTO Relationship VALUES('II_4_3','II_4_6')
--INSERT INTO Relationship VALUES('II_4_3','II_5')
--INSERT INTO Relationship VALUES('II_4_3','II_6')
--INSERT INTO Relationship VALUES('II_4_3','II_7')
--INSERT INTO Relationship VALUES('II_4_3','II_8')
--INSERT INTO Relationship VALUES('II_4_3','II_9')
----II_4_4
--INSERT INTO Relationship VALUES('II_4_4','II')
--INSERT INTO Relationship VALUES('II_4_4','II_2')
--INSERT INTO Relationship VALUES('II_4_4','II_3')
--INSERT INTO Relationship VALUES('II_4_4','II_4_1')
--INSERT INTO Relationship VALUES('II_4_4','II_4_2')
--INSERT INTO Relationship VALUES('II_4_4','II_4_3')
--INSERT INTO Relationship VALUES('II_4_4','II_4_5')
--INSERT INTO Relationship VALUES('II_4_4','II_4_6')
--INSERT INTO Relationship VALUES('II_4_4','II_5')
--INSERT INTO Relationship VALUES('II_4_4','II_6')
--INSERT INTO Relationship VALUES('II_4_4','II_7')
--INSERT INTO Relationship VALUES('II_4_4','II_8')
--INSERT INTO Relationship VALUES('II_4_4','II_9')
----II_4_5
--INSERT INTO Relationship VALUES('II_4_5','II')
--INSERT INTO Relationship VALUES('II_4_5','II_2')
--INSERT INTO Relationship VALUES('II_4_5','II_3')
--INSERT INTO Relationship VALUES('II_4_5','II_4_1')
--INSERT INTO Relationship VALUES('II_4_5','II_4_2')
--INSERT INTO Relationship VALUES('II_4_5','II_4_3')
--INSERT INTO Relationship VALUES('II_4_5','II_4_4')
--INSERT INTO Relationship VALUES('II_4_5','II_4_6')
--INSERT INTO Relationship VALUES('II_4_5','II_5')
--INSERT INTO Relationship VALUES('II_4_5','II_6')
--INSERT INTO Relationship VALUES('II_4_5','II_7')
--INSERT INTO Relationship VALUES('II_4_5','II_8')
--INSERT INTO Relationship VALUES('II_4_5','II_9')
----II_4_6
--INSERT INTO Relationship VALUES('II_4_6','II')
--INSERT INTO Relationship VALUES('II_4_6','II_2')
--INSERT INTO Relationship VALUES('II_4_6','II_3')
--INSERT INTO Relationship VALUES('II_4_6','II_4_1')
--INSERT INTO Relationship VALUES('II_4_6','II_4_2')
--INSERT INTO Relationship VALUES('II_4_6','II_4_3')
--INSERT INTO Relationship VALUES('II_4_6','II_4_4')
--INSERT INTO Relationship VALUES('II_4_6','II_4_5')
--INSERT INTO Relationship VALUES('II_4_6','II_5')
--INSERT INTO Relationship VALUES('II_4_6','II_6')
--INSERT INTO Relationship VALUES('II_4_6','II_7')
--INSERT INTO Relationship VALUES('II_4_6','II_8')
--INSERT INTO Relationship VALUES('II_4_6','II_9')
----II_5
--INSERT INTO Relationship VALUES('II_5','II')
--INSERT INTO Relationship VALUES('II_5','II_2')
--INSERT INTO Relationship VALUES('II_5','II_3')
--INSERT INTO Relationship VALUES('II_5','II_4')
--INSERT INTO Relationship VALUES('II_5','II_6')
--INSERT INTO Relationship VALUES('II_5','II_7')
--INSERT INTO Relationship VALUES('II_5','II_8')
--INSERT INTO Relationship VALUES('II_5','II_9')
----II_6
--INSERT INTO Relationship VALUES('II_6','II')
--INSERT INTO Relationship VALUES('II_6','II_2')
--INSERT INTO Relationship VALUES('II_6','II_3')
--INSERT INTO Relationship VALUES('II_6','II_4')
--INSERT INTO Relationship VALUES('II_6','II_5')
--INSERT INTO Relationship VALUES('II_6','II_7')
--INSERT INTO Relationship VALUES('II_6','II_8')
--INSERT INTO Relationship VALUES('II_6','II_9')
----II_7
--INSERT INTO Relationship VALUES('II_7','II')
--INSERT INTO Relationship VALUES('II_7','II_2')
--INSERT INTO Relationship VALUES('II_7','II_3')
--INSERT INTO Relationship VALUES('II_7','II_4')
--INSERT INTO Relationship VALUES('II_7','II_6')
--INSERT INTO Relationship VALUES('II_7','II_5')
--INSERT INTO Relationship VALUES('II_7','II_8')
--INSERT INTO Relationship VALUES('II_7','II_9')
----II_8
--INSERT INTO Relationship VALUES('II_8','II')
--INSERT INTO Relationship VALUES('II_8','II_2')
--INSERT INTO Relationship VALUES('II_8','II_3')
--INSERT INTO Relationship VALUES('II_8','II_4')
--INSERT INTO Relationship VALUES('II_8','II_6')
--INSERT INTO Relationship VALUES('II_8','II_7')
--INSERT INTO Relationship VALUES('II_8','II_5')
--INSERT INTO Relationship VALUES('II_8','II_9')
----II_9
--INSERT INTO Relationship VALUES('II_9','II')
--INSERT INTO Relationship VALUES('II_9','II_2')
--INSERT INTO Relationship VALUES('II_9','II_3')
--INSERT INTO Relationship VALUES('II_9','II_4')
--INSERT INTO Relationship VALUES('II_9','II_6')
--INSERT INTO Relationship VALUES('II_9','II_7')
--INSERT INTO Relationship VALUES('II_9','II_8')
--INSERT INTO Relationship VALUES('II_9','II_5')

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

--INSERT INTO Concept VALUES('II#II_1',N'Giải thuật là gì','II')
--INSERT INTO Concept VALUES('II_2#II_2_1',N'Độ phức tạp của giải thuật là gì','II_2')
--INSERT INTO Concept VALUES('II_3_1#II_3_1_1',N'Tìm kiếm nội suy là gì','II_3_1')
--INSERT INTO Concept VALUES('II_3_2#II_3_2_1',N'Tìm kiếm tuyến tính là gì','II_3_2')
--INSERT INTO Concept VALUES('II_3_3#II_3_3_1',N'Tìm kiếm nhị phân là gì','II_3_3')
--INSERT INTO Concept VALUES('II_3_3#II_3_4_1',N'Tìm kiếm bằng bảng băm là gì','II_3_4')
--INSERT INTO Concept VALUES('II_4_1#II_4_1_1',N'Sắp xếp nghịch thể là gì','II_4_1')
--INSERT INTO Concept VALUES('II_4_2#II_4_2_1',N'Sắp xếp nổi bọt là gì','II_4_2')
--INSERT INTO Concept VALUES('II_4_3#II_4_3_1',N'Sắp xếp chèn là gì','II_4_3')
--INSERT INTO Concept VALUES('II_4_4#II_4_4_1',N'Sắp xếp chọn là gì','II_4_4')
--INSERT INTO Concept VALUES('II_4_5#II_4_5_1',N'Sắp xếp nhanh là gì','II_4_5')
--INSERT INTO Concept VALUES('II_4_6#II_4_6_1',N'Sắp xếp vun đống là gì','II_4_6')
--INSERT INTO Concept VALUES('II_5#II_5_1',N'Giải thuật tham lam là gì','II_5')
--INSERT INTO Concept VALUES('II_6#II_6_1',N'Giải thuật chia để trị là gì','II_6')
--INSERT INTO Concept VALUES('II_7#II_7_1',N'Giải thuật quy hoạch động là gì','II_7')
--INSERT INTO Concept VALUES('II_8#II_8_1',N'Giải thuật quay lui là gì','II_8')
--INSERT INTO Concept VALUES('II_9#II_9_1',N'Giải thuật đệ quy là gì','II_9')

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

--INSERT INTO Construct VALUES('II_3_1#II_3_1_2', N'Xây dựng giải thuật tìm kiếm nội suy', 'II_3_1')
--INSERT INTO Construct VALUES('II_3_2#II_3_2_2', N'Xây dựng giải thuật tìm kiếm tuyến tính', 'II_3_2')
--INSERT INTO Construct VALUES('II_3_3#II_3_3_2', N'Xây dựng giải thuật tìm kiếm nhị phân', 'II_3_3')
--INSERT INTO Construct VALUES('II_3_4#II_3_4_2', N'Xây dựng giải thuật tìm kiếm bằng bảng băm', 'II_3_4')
--INSERT INTO Construct VALUES('II_4_1#II_4_1_2', N'Xây dựng giải thuật sắp xếp nghịch thể', 'II_4_1')
--INSERT INTO Construct VALUES('II_4_2#II_4_2_2', N'Xây dựng giải thuật sắp xếp nổi bọt', 'II_4_2')
--INSERT INTO Construct VALUES('II_4_3#II_4_3_2', N'Xây dựng giải thuật sắp xếp chèn', 'II_4_3')
--INSERT INTO Construct VALUES('II_4_4#II_4_4_2', N'Xây dựng giải thuật sắp xếp chọn', 'II_4_4')
--INSERT INTO Construct VALUES('II_4_5#II_4_5_2', N'Xây dựng giải thuật sắp xếp nhanh', 'II_4_5')
--INSERT INTO Construct VALUES('II_4_6#II_4_6_2', N'Xây dựng giải thuật sắp xếp vun đống', 'II_4_6')
--INSERT INTO Construct VALUES('II_5#II_5_2', N'Xây dựng giải thuật tham lam', 'II_5')
--INSERT INTO Construct VALUES('II_6#II_6_2', N'Xây dựng giải thuật chia để trị', 'II_6')
--INSERT INTO Construct VALUES('II_7#II_7_2', N'Xây dựng giải thuật quy hoạch động', 'II_7')
--INSERT INTO Construct VALUES('II_8#II_8_2', N'Xây dựng giải thuật quay lui', 'II_8')
--INSERT INTO Construct VALUES('II_9#II_9_2', N'Xây dựng giải thuật đệ quy', 'II_9')

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


---ADD Property
--INSERT INTO Property VALUES('II_2#II_2_2',N'Quy tắc xác định độ phức tạp của thuật toán','II_2')
--INSERT INTO Property VALUES('II_2#II_2_3',N'Các bước xác định độ phức tạp của thuật toán','II_2')
--INSERT INTO Property VALUES('II_3_1#II_3_1_3',N'Độ phức tạp giải thuật tìm kiếm nội suy','II_3_1')
--INSERT INTO Property VALUES('II_3_2#II_3_2_3',N'Độ phức tạp giải thuật tìm kiếm tuyến tính','II_3_2')
--INSERT INTO Property VALUES('II_3_3#II_3_3_3',N'Độ phức tạp giải thuật tìm kiếm nhị phân','II_3_3')
--INSERT INTO Property VALUES('II_3_4#II_3_4_3',N'Độ phức tạp giải thuật tìm kiếm bằng bảng băm','II_3_4')
--INSERT INTO Property VALUES('II_4_1#II_4_1_3',N'Độ phức tạp giải thuật sắp xếp nghịch thể','II_4_1')
--INSERT INTO Property VALUES('II_4_2#II_4_2_3',N'Độ phức tạp giải thuật sắp xếp nổi bọt','II_4_2')
--INSERT INTO Property VALUES('II_4_3#II_4_3_3',N'Độ phức tạp giải thuật sắp xếp chèn','II_4_3')
--INSERT INTO Property VALUES('II_4_4#II_4_4_3',N'Độ phức tạp giải thuật sắp xếp chọn','II_4_4')
--INSERT INTO Property VALUES('II_4_5#II_4_5_3',N'Độ phức tạp giải thuật sắp xếp nhanh','II_4_5')
--INSERT INTO Property VALUES('II_4_6#II_4_6_3',N'Độ phức tạp giải thuật sắp xếp vun đống','II_4_6')
--INSERT INTO Property VALUES('II_5#II_5_3',N'Độ phức tạp giải thuật tham lam','II_5')
--INSERT INTO Property VALUES('II_6#II_6_3',N'Độ phức tạp giải thuật chia để trị','II_6')
--INSERT INTO Property VALUES('II_7#II_7_3',N'Độ phức tạp giải thuật quy hoạch động','II_7')
--INSERT INTO Property VALUES('II_8#II_8_3',N'Độ phức tạp giải thuật quay lui','II_8')
--INSERT INTO Property VALUES('II_9#II_9_3',N'Độ phức tạp giải thuật đệ quy','II_9')


--Add Exercise
INSERT INTO Exercise VALUES('III_1',N'Bài tập về mảng','I_2')
INSERT INTO Exercise VALUES('III_2',N'Bài tập về mảng động','I_2#I_2_2')
INSERT INTO Exercise VALUES('III_3',N'Bài tập về danh sách liên kết','I_3')
INSERT INTO Exercise VALUES('III_4',N'Bài tập về ngăn xếp','I_4')
INSERT INTO Exercise VALUES('III_5',N'Bài tập về hàng đợi','I_5')
INSERT INTO Exercise VALUES('III_6',N'Bài tập về cây nhị phân','I_6_4')
INSERT INTO Exercise VALUES('III_8',N'Bài tập về cây heap','I_6_5')
INSERT INTO Exercise VALUES('III_10',N'Bài tập tìm kiếm theo chiều sâu','I_7_3_1')
INSERT INTO Exercise VALUES('III_11',N'Bài tập tìm kiếm theo chiều rộng','I_7_3_2')

--INSERT INTO Exercise VALUES('III_12',N'Bài tập xác định độ phức tạp của thuật toán','II_2')
--INSERT INTO Exercise VALUES('III_13',N'Bài tập giải thuật tìm kiếm nội suy','II_3_1')
--INSERT INTO Exercise VALUES('III_14',N'Bài tập giải thuật tìm kiếm tuyến tính','II_3_2')
--INSERT INTO Exercise VALUES('III_15',N'Bài tập giải thuật tìm kiếm nhị phân','II_3_3')
--INSERT INTO Exercise VALUES('III_16',N'Bài tập giải thuật tìm kiếm bằng bảng băm','II_3_4')
--INSERT INTO Exercise VALUES('III_17',N'Bài tập giải thuật sắp xếp nghịch thể','II_4_1')
--INSERT INTO Exercise VALUES('III_18',N'Bài tập giải thuật sắp xếp nổi bọt','II_4_2')
--INSERT INTO Exercise VALUES('III_19',N'Bài tập giải thuật sắp xếp chèn','II_4_3')
--INSERT INTO Exercise VALUES('III_20',N'Bài tập giải thuật sắp xếp chọn','II_4_4')
--INSERT INTO Exercise VALUES('III_21',N'Bài tập về giải thuật sắp xếp nhanh','II_4_5')
--INSERT INTO Exercise VALUES('III_22',N'Bài tập về giải thuật sắp xếp vun đống','II_4_6')
--INSERT INTO Exercise VALUES('III_23',N'Bài tập về giải thuật tham lam','II_5')
--INSERT INTO Exercise VALUES('III_24',N'Bài tập về giải thuật chia để trị','II_6')
--INSERT INTO Exercise VALUES('III_25',N'Bài tập về giải thuật quy hoạch động','II_7')
--INSERT INTO Exercise VALUES('III_26',N'Bài tập của giải thuật quay lui','II_8')
--INSERT INTO Exercise VALUES('III_27',N'Bài tập về giải thuật đệ quy','II_9')

