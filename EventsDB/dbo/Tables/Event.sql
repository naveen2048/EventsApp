CREATE TABLE [dbo].[Event] (
    [ID]            INT            IDENTITY (1, 1) NOT NULL,
    [Name]          NVARCHAR (100) NOT NULL,
    [Type]          INT            NOT NULL,
    [Venue]         NVARCHAR (150) NOT NULL,
    [City]          INT            NOT NULL,
    [Country]       INT            NOT NULL,
    [StartDateTime] DATETIME       NOT NULL,
    [EndDateTime]   DATETIME       NOT NULL,
    CONSTRAINT [PK_Event] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Event_City] FOREIGN KEY ([City]) REFERENCES [dbo].[City] ([ID]),
    CONSTRAINT [FK_Event_Country] FOREIGN KEY ([Country]) REFERENCES [dbo].[Country] ([ID]),
    CONSTRAINT [FK_Event_EventType] FOREIGN KEY ([Type]) REFERENCES [dbo].[EventType] ([ID])
);

