CREATE TABLE [dbo].[TicketOrder] (
    [ID]       UNIQUEIDENTIFIER NOT NULL,
    [OrderID]  UNIQUEIDENTIFIER NOT NULL,
    [TicketID] UNIQUEIDENTIFIER NOT NULL,
    [Quantity] INT              NOT NULL,
    [EventID]  INT              NOT NULL,
    CONSTRAINT [PK_TicketOrder] PRIMARY KEY CLUSTERED ([ID] ASC),
    CONSTRAINT [FK_TicketOrder_Event] FOREIGN KEY ([EventID]) REFERENCES [dbo].[Event] ([ID]),
    CONSTRAINT [FK_TicketOrder_Order] FOREIGN KEY ([OrderID]) REFERENCES [dbo].[Order] ([ID]),
    CONSTRAINT [FK_TicketOrder_Ticket] FOREIGN KEY ([TicketID]) REFERENCES [dbo].[Ticket] ([ID])
);

