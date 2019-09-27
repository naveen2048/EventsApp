CREATE TABLE [dbo].[Ticket] (
    [ID]          UNIQUEIDENTIFIER NOT NULL,
    [Price]       DECIMAL (18, 2)  NOT NULL,
    [Type]        INT              NOT NULL,
    [Description] NCHAR (500)      NOT NULL,
    [ValidFrom]   DATETIME         NOT NULL,
    [ValidTo]     DATETIME         NOT NULL,
    [EventID]     INT              NOT NULL,
    CONSTRAINT [PK_Ticket] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_Ticket_Event] FOREIGN KEY ([EventID]) REFERENCES [dbo].[Event] ([ID]),
    CONSTRAINT [FK_Ticket_TicketType] FOREIGN KEY ([Type]) REFERENCES [dbo].[TicketType] ([ID])
);

