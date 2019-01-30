
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 06/12/2017 19:02:40
-- Generated from EDMX file: D:\C#\SisBase\SisBase\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Computers];
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

-- Creating table 'CategroiesSet'
CREATE TABLE [dbo].[CategroiesSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [CategoriesName] nvarchar(max)  NOT NULL,
    [CategoriesID] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ProductsSet'
CREATE TABLE [dbo].[ProductsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ProductsName] nvarchar(max)  NOT NULL,
    [ProductsID] nvarchar(max)  NOT NULL,
    [CategroiesId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'CategroiesSet'
ALTER TABLE [dbo].[CategroiesSet]
ADD CONSTRAINT [PK_CategroiesSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ProductsSet'
ALTER TABLE [dbo].[ProductsSet]
ADD CONSTRAINT [PK_ProductsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [CategroiesId] in table 'ProductsSet'
ALTER TABLE [dbo].[ProductsSet]
ADD CONSTRAINT [FK_CategroiesProducts]
    FOREIGN KEY ([CategroiesId])
    REFERENCES [dbo].[CategroiesSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_CategroiesProducts'
CREATE INDEX [IX_FK_CategroiesProducts]
ON [dbo].[ProductsSet]
    ([CategroiesId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------