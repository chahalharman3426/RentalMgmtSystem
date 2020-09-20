CREATE TABLE [dbo].[tbl_rentalVideo] (
    [rentalVideoId] INT  IDENTITY (1, 1) NOT NULL,
    [customerId]    INT  NULL,
    [videoId]       INT  NULL,
    [rentalDate]    DATE NULL,
    [returnDate]    DATE NULL,
    CONSTRAINT [PK_tbl_rentalVideo] PRIMARY KEY CLUSTERED ([rentalVideoId] ASC)
);

