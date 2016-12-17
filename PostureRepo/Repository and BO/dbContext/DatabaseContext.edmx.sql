
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/17/2016 14:06:09
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


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


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
    [ExerciseTemplateId] int  NOT NULL
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

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------