IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200616012643_InitialCommit')
BEGIN
    CREATE TABLE [Project] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [OwnerName] nvarchar(max) NULL,
        CONSTRAINT [PK_Project] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200616012643_InitialCommit')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200616012643_InitialCommit', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200617035407_AddTeamMember')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Project]') AND [c].[name] = N'OwnerName');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Project] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Project] ALTER COLUMN [OwnerName] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200617035407_AddTeamMember')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Project]') AND [c].[name] = N'Name');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Project] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [Project] ALTER COLUMN [Name] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200617035407_AddTeamMember')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Project]') AND [c].[name] = N'Description');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Project] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [Project] ALTER COLUMN [Description] nvarchar(max) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200617035407_AddTeamMember')
BEGIN
    CREATE TABLE [TeamMember] (
        [Id] int NOT NULL IDENTITY,
        [FirstName] nvarchar(max) NOT NULL,
        [LastName] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_TeamMember] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200617035407_AddTeamMember')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200617035407_AddTeamMember', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200619234909_Project_TeamMember-Mapping-Table')
BEGIN
    ALTER TABLE [TeamMember] ADD [ProjectId] int NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200619234909_Project_TeamMember-Mapping-Table')
BEGIN
    CREATE INDEX [IX_TeamMember_ProjectId] ON [TeamMember] ([ProjectId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200619234909_Project_TeamMember-Mapping-Table')
BEGIN
    ALTER TABLE [TeamMember] ADD CONSTRAINT [FK_TeamMember_Project_ProjectId] FOREIGN KEY ([ProjectId]) REFERENCES [Project] ([Id]) ON DELETE NO ACTION;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200619234909_Project_TeamMember-Mapping-Table')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200619234909_Project_TeamMember-Mapping-Table', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200620001841_FixMistake')
BEGIN
    ALTER TABLE [TeamMember] DROP CONSTRAINT [FK_TeamMember_Project_ProjectId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200620001841_FixMistake')
BEGIN
    DROP INDEX [IX_TeamMember_ProjectId] ON [TeamMember];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200620001841_FixMistake')
BEGIN
    DECLARE @var3 sysname;
    SELECT @var3 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[TeamMember]') AND [c].[name] = N'ProjectId');
    IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [TeamMember] DROP CONSTRAINT [' + @var3 + '];');
    ALTER TABLE [TeamMember] DROP COLUMN [ProjectId];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200620001841_FixMistake')
BEGIN
    CREATE TABLE [ProjectTeamMembers] (
        [Id] int NOT NULL IDENTITY,
        [IdProject] int NOT NULL,
        [IdTeamMember] int NOT NULL,
        CONSTRAINT [PK_ProjectTeamMembers] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200620001841_FixMistake')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200620001841_FixMistake', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200620182315_AddRisks')
BEGIN
    CREATE TABLE [ProjectRisks] (
        [Id] int NOT NULL IDENTITY,
        [IdProject] int NOT NULL,
        [IdRisk] int NOT NULL,
        CONSTRAINT [PK_ProjectRisks] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200620182315_AddRisks')
BEGIN
    CREATE TABLE [Risk] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        [RiskStatus] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_Risk] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200620182315_AddRisks')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200620182315_AddRisks', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200620202519_ChangeRiskNameColumn')
BEGIN
    DECLARE @var4 sysname;
    SELECT @var4 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Risk]') AND [c].[name] = N'Name');
    IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Risk] DROP CONSTRAINT [' + @var4 + '];');
    ALTER TABLE [Risk] DROP COLUMN [Name];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200620202519_ChangeRiskNameColumn')
BEGIN
    ALTER TABLE [Risk] ADD [RiskName] nvarchar(max) NOT NULL DEFAULT N'';
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200620202519_ChangeRiskNameColumn')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200620202519_ChangeRiskNameColumn', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200620235812_AddRequirements')
BEGIN
    CREATE TABLE [Requirement] (
        [Id] int NOT NULL IDENTITY,
        [IdProject] int NOT NULL,
        [RequirementName] nvarchar(max) NOT NULL,
        [Description] nvarchar(max) NOT NULL,
        [IdRequirementType] int NOT NULL,
        CONSTRAINT [PK_Requirement] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200620235812_AddRequirements')
BEGIN
    CREATE TABLE [RequirementTypes] (
        [Id] int NOT NULL IDENTITY,
        [DisplayName] nvarchar(max) NULL,
        CONSTRAINT [PK_RequirementTypes] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200620235812_AddRequirements')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200620235812_AddRequirements', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200621023254_SeedRequirementTypeData')
BEGIN
    insert into RequirementTypes (DisplayName) values ('Functional'), ('Non-Functional')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200621023254_SeedRequirementTypeData')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200621023254_SeedRequirementTypeData', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200623020937_AddRequirementEffortSchema')
BEGIN
    CREATE TABLE [RequirementEffort] (
        [Id] int NOT NULL IDENTITY,
        [IdRequirement] int NOT NULL,
        [IdTeamMember] int NOT NULL,
        [IdRequirementEffortType] int NOT NULL,
        [IdTimeFrame] int NOT NULL,
        [DateFrom] datetime2 NOT NULL,
        [DateTo] datetime2 NULL,
        [TimeExpended] decimal(16,1) NOT NULL,
        CONSTRAINT [PK_RequirementEffort] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200623020937_AddRequirementEffortSchema')
BEGIN
    CREATE TABLE [RequirementEffortTypes] (
        [Id] int NOT NULL IDENTITY,
        [DisplayName] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_RequirementEffortTypes] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200623020937_AddRequirementEffortSchema')
BEGIN
    CREATE TABLE [TimeFrames] (
        [Id] int NOT NULL IDENTITY,
        [DisplayName] nvarchar(max) NOT NULL,
        CONSTRAINT [PK_TimeFrames] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200623020937_AddRequirementEffortSchema')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200623020937_AddRequirementEffortSchema', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200623021123_SeedRequirementEffortTypeData')
BEGIN
    insert into RequirementEffortTypes (DisplayName) values ('Requirements Analysis'), ('Designing'), ('Coding'), ('Testing'), ('Project Management')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200623021123_SeedRequirementEffortTypeData')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200623021123_SeedRequirementEffortTypeData', N'3.1.4');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200623021930_SeedTimeFrames')
BEGIN
    insert into TimeFrames (DisplayName) values ('Daily'), ('Weekly')
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20200623021930_SeedTimeFrames')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20200623021930_SeedTimeFrames', N'3.1.4');
END;

GO

