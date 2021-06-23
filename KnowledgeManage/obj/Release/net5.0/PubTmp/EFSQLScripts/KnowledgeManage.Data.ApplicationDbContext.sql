IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210618162045_addToDB')
BEGIN
    CREATE TABLE [Lesson] (
        [Id_Lesson] nvarchar(450) NOT NULL,
        [Name_Lesson] nvarchar(max) NULL,
        [Key_Lesson] nvarchar(max) NULL,
        CONSTRAINT [PK_Lesson] PRIMARY KEY ([Id_Lesson])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210618162045_addToDB')
BEGIN
    CREATE TABLE [Concept] (
        [Id_Concept] int NOT NULL IDENTITY,
        [Link_Concept] nvarchar(max) NULL,
        [Name_Concept] nvarchar(max) NULL,
        [LessonId_Lesson] nvarchar(450) NULL,
        CONSTRAINT [PK_Concept] PRIMARY KEY ([Id_Concept]),
        CONSTRAINT [FK_Concept_Lesson_LessonId_Lesson] FOREIGN KEY ([LessonId_Lesson]) REFERENCES [Lesson] ([Id_Lesson]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210618162045_addToDB')
BEGIN
    CREATE TABLE [Construct] (
        [Id_Construct] int NOT NULL IDENTITY,
        [Link_Construct] nvarchar(max) NULL,
        [Name_Construct] nvarchar(max) NULL,
        [LessonId_Lesson] nvarchar(450) NULL,
        CONSTRAINT [PK_Construct] PRIMARY KEY ([Id_Construct]),
        CONSTRAINT [FK_Construct_Lesson_LessonId_Lesson] FOREIGN KEY ([LessonId_Lesson]) REFERENCES [Lesson] ([Id_Lesson]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210618162045_addToDB')
BEGIN
    CREATE TABLE [Exercise] (
        [Id_Exercise] int NOT NULL IDENTITY,
        [Link_Exercise] nvarchar(max) NULL,
        [Name_Exercise] nvarchar(max) NULL,
        [LessonId_Lesson] nvarchar(450) NULL,
        CONSTRAINT [PK_Exercise] PRIMARY KEY ([Id_Exercise]),
        CONSTRAINT [FK_Exercise_Lesson_LessonId_Lesson] FOREIGN KEY ([LessonId_Lesson]) REFERENCES [Lesson] ([Id_Lesson]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210618162045_addToDB')
BEGIN
    CREATE TABLE [Operator] (
        [Id_Operator] int NOT NULL IDENTITY,
        [Link_Operator] nvarchar(max) NULL,
        [Name_Operator] nvarchar(max) NULL,
        [LessonId_Lesson] nvarchar(450) NULL,
        CONSTRAINT [PK_Operator] PRIMARY KEY ([Id_Operator]),
        CONSTRAINT [FK_Operator_Lesson_LessonId_Lesson] FOREIGN KEY ([LessonId_Lesson]) REFERENCES [Lesson] ([Id_Lesson]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210618162045_addToDB')
BEGIN
    CREATE TABLE [Relationship] (
        [Id_Relationship] int NOT NULL IDENTITY,
        [Id_Lesson_A] nvarchar(450) NULL,
        [Id_Lesson_B] nvarchar(450) NULL,
        CONSTRAINT [PK_Relationship] PRIMARY KEY ([Id_Relationship]),
        CONSTRAINT [FK_Relationship_Lesson_Id_Lesson_A] FOREIGN KEY ([Id_Lesson_A]) REFERENCES [Lesson] ([Id_Lesson]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Relationship_Lesson_Id_Lesson_B] FOREIGN KEY ([Id_Lesson_B]) REFERENCES [Lesson] ([Id_Lesson]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210618162045_addToDB')
BEGIN
    CREATE INDEX [IX_Concept_LessonId_Lesson] ON [Concept] ([LessonId_Lesson]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210618162045_addToDB')
BEGIN
    CREATE INDEX [IX_Construct_LessonId_Lesson] ON [Construct] ([LessonId_Lesson]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210618162045_addToDB')
BEGIN
    CREATE INDEX [IX_Exercise_LessonId_Lesson] ON [Exercise] ([LessonId_Lesson]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210618162045_addToDB')
BEGIN
    CREATE INDEX [IX_Operator_LessonId_Lesson] ON [Operator] ([LessonId_Lesson]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210618162045_addToDB')
BEGIN
    CREATE INDEX [IX_Relationship_Id_Lesson_A] ON [Relationship] ([Id_Lesson_A]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210618162045_addToDB')
BEGIN
    CREATE INDEX [IX_Relationship_Id_Lesson_B] ON [Relationship] ([Id_Lesson_B]);
END;
GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210618162045_addToDB')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210618162045_addToDB', N'5.0.7');
END;
GO

COMMIT;
GO

