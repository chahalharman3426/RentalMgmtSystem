CREATE TABLE [dbo].[tbl_video] (
    [video_id]     INT             IDENTITY (1, 1) NOT NULL,
    [video_title]  NVARCHAR (50)   NULL,
    [release_date] DATE            NULL,
    [rental_cost]  DECIMAL (18, 2) NULL,
    [genre]        NVARCHAR (50)   NULL,
    [isAvailable]  NVARCHAR (50)   NULL,
    CONSTRAINT [PK_tbl_video] PRIMARY KEY CLUSTERED ([video_id] ASC)
);

