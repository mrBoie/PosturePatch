
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/18/2016 22:25:18
-- Generated from EDMX file: C:\Users\Montret\documents\visual studio 2015\Projects\PosturePatch\PostureRepo\Repository and BO\dbContext\DatabaseContext.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [PosturePatch];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ExerciseExerciseTemplate]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ExerciseSet] DROP CONSTRAINT [FK_ExerciseExerciseTemplate];
GO
IF OBJECT_ID(N'[dbo].[FK_WorkoutExercise]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ExerciseSet] DROP CONSTRAINT [FK_WorkoutExercise];
GO
IF OBJECT_ID(N'[dbo].[FK_ClientWorkout]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[WorkoutSet] DROP CONSTRAINT [FK_ClientWorkout];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ExerciseTemplateSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ExerciseTemplateSet];
GO
IF OBJECT_ID(N'[dbo].[ExerciseSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ExerciseSet];
GO
IF OBJECT_ID(N'[dbo].[WorkoutSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[WorkoutSet];
GO
IF OBJECT_ID(N'[dbo].[ClientSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClientSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ExerciseTemplateSet'
CREATE TABLE [dbo].[ExerciseTemplateSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [DefaultSets] smallint  NOT NULL,
    [DefaultReps] smallint  NOT NULL
);
GO

-- Creating table 'ExerciseSet'
CREATE TABLE [dbo].[ExerciseSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [Sets] smallint  NOT NULL,
    [Reps] smallint  NOT NULL,
    [ExerciseTemplateId] int  NOT NULL,
    [WorkoutId] int  NOT NULL
);
GO

-- Creating table 'WorkoutSet'
CREATE TABLE [dbo].[WorkoutSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [DateCreated] datetime  NOT NULL,
    [Description] nvarchar(max)  NOT NULL,
    [ClientId] int  NOT NULL
);
GO

-- Creating table 'ClientSet'
CREATE TABLE [dbo].[ClientSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [DateOfBirth] datetime  NOT NULL,
    [Gender] smallint  NOT NULL,
    [Description] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ExerciseTemplateSet'
ALTER TABLE [dbo].[ExerciseTemplateSet]
ADD CONSTRAINT [PK_ExerciseTemplateSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ExerciseSet'
ALTER TABLE [dbo].[ExerciseSet]
ADD CONSTRAINT [PK_ExerciseSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'WorkoutSet'
ALTER TABLE [dbo].[WorkoutSet]
ADD CONSTRAINT [PK_WorkoutSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ClientSet'
ALTER TABLE [dbo].[ClientSet]
ADD CONSTRAINT [PK_ClientSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ExerciseTemplateId] in table 'ExerciseSet'
ALTER TABLE [dbo].[ExerciseSet]
ADD CONSTRAINT [FK_ExerciseExerciseTemplate]
    FOREIGN KEY ([ExerciseTemplateId])
    REFERENCES [dbo].[ExerciseTemplateSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ExerciseExerciseTemplate'
CREATE INDEX [IX_FK_ExerciseExerciseTemplate]
ON [dbo].[ExerciseSet]
    ([ExerciseTemplateId]);
GO

-- Creating foreign key on [WorkoutId] in table 'ExerciseSet'
ALTER TABLE [dbo].[ExerciseSet]
ADD CONSTRAINT [FK_WorkoutExercise]
    FOREIGN KEY ([WorkoutId])
    REFERENCES [dbo].[WorkoutSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_WorkoutExercise'
CREATE INDEX [IX_FK_WorkoutExercise]
ON [dbo].[ExerciseSet]
    ([WorkoutId]);
GO

-- Creating foreign key on [ClientId] in table 'WorkoutSet'
ALTER TABLE [dbo].[WorkoutSet]
ADD CONSTRAINT [FK_WorkoutClient]
    FOREIGN KEY ([ClientId])
    REFERENCES [dbo].[ClientSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_WorkoutClient'
CREATE INDEX [IX_FK_WorkoutClient]
ON [dbo].[WorkoutSet]
    ([ClientId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------