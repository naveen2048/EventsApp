CREATE TABLE [dbo].[Order] (
    [ID]          UNIQUEIDENTIFIER NOT NULL,
    [Description] NVARCHAR (50)    NOT NULL,
    [UserID]      UNIQUEIDENTIFIER NOT NULL,
    [EventID] INT NOT NULL, 
    CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Order_User] FOREIGN KEY ([UserID]) REFERENCES [dbo].[User] ([ID]), 
    CONSTRAINT [FK_Order_Event] FOREIGN KEY ([EventID]) REFERENCES [dbo].[Event]([ID])
);

