CREATE TABLE [dbo].[tbl_customer] (
    [customer_id] INT            IDENTITY (1, 1) NOT NULL,
    [name]        NVARCHAR (500) NULL,
    [address]     NVARCHAR (MAX) NULL,
    [mobile_no]   NVARCHAR (50)  NULL,
    CONSTRAINT [PK_tbl_customer] PRIMARY KEY CLUSTERED ([customer_id] ASC)
);

