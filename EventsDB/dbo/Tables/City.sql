CREATE TABLE [dbo].[City] (
    [ID]      INT        NOT NULL,
    [Name]    NCHAR (10) NOT NULL,
    [Country] INT        NOT NULL,
    CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_City_Country] FOREIGN KEY ([ID]) REFERENCES [dbo].[Country] ([ID])
);

